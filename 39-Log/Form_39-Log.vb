Imports System.ComponentModel
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Configuration
Public Class Form_39_Log
    Enum SlaveIndex As Integer      ' 設備索引
        S31 = 0
        S32 = 1
        S33 = 2
        C34 = 3
    End Enum
    '-----------------------------------------
    Enum HeadingCommand As Byte    ' 加熱命令
        None = &H2A
        Active = &HAA
    End Enum
    '-----------------------------------------
    Enum PacketCheckStep As UInt16    ' 封包檢查步驟
        Start = &HFFFF
        Finish = &HEEEE
        DataError = &HDDDD
    End Enum
    '-----------------------------------------
    Dim ComPortThread As Thread                 ' ComPort 執行緒
    Dim ComPortReceiving As Boolean = False     ' 是否正在進行接收資料中
    Dim Event_DataReceiving As Boolean = False  ' 是否發生資料接收：用於閃爍接收燈號用
    '-----------------------------------------
    Dim PacketErrorCount As Integer = 0         ' 封包錯誤計數
    '-----------------------------------------
    Dim PollingCommand As New List(Of Byte) From {&H88, &H77, &H66, &H55}    ' 輪詢指令
    Dim PollingIndex As Integer = -1    ' 輪詢索引
    '-----------------------------------------
    Dim SlaveID() As Byte = {&H31, &H32, &H33, &H34}                ' 設備ID
    Dim SlaveName() As String = {"S31", "S32", "S33", "C34"}        ' 設備名稱
    Dim SlaveSimMode() As Boolean = {False, False, False, False}    ' 模擬設備模式
    '-----------------------------------------
    Dim Now_PacketCheckStep As UInt16 = PacketCheckStep.Start       ' 目前封包檢查步驟
    '-----------------------------------------
    ' ComPort 接收的資料
    Dim ReceivedData As New List(Of Byte)
    ' 接收完資料後經比對資料需更新時【置換】此處資料
    Dim TempData As New List(Of Byte()) From {New Byte() {}, New Byte() {}, New Byte() {}, New Byte() {}}
    ' 接收完資料後經比對資料需更新時【增加】至此準備分析 & 輸出用
    Dim LogData As New List(Of Byte())
    '-----------------------------------------
    ' UI 群組：模擬：設備模擬
    Dim UI_Sim_GroupBox() As GroupBox = New GroupBox(4 - 1) {}
    ' UI 群組：模擬：強制加熱按鈕
    Dim UI_Sim_ForcedHeatingButton() As Button = New Button(3 - 1) {}
    ' UI 群組：模擬：更改水溫設定按鈕
    Dim UI_Sim_SetTemperatureButton() As Button = New Button(3 - 1) {}
    ' UI 群組：模擬：更改水溫設定
    Dim UI_Sim_NUD_SetTemperature() As NumericUpDown = New NumericUpDown(3 - 1) {}
    '-----------------------------------------
    ' UI 群組：系統：設備狀態值 
    Dim UI_Sys_NUD_StatusCode() As NumericUpDown = New NumericUpDown(4 - 1) {}
    ' UI 群組：系統：目前水溫
    Dim UI_Sys_S3X_LB_NowTemperature() As Label = New Label(3 - 1) {}
    ' UI 群組：系統：水溫設定
    Dim UI_Sys_S3X_LB_SetTemperature() As Label = New Label(3 - 1) {}
    '-----------------------------------------
    ' S3X 模擬：強制加熱
    Dim S3X_Sim_ForcedHeating() As Byte = {HeadingCommand.None, HeadingCommand.None, HeadingCommand.None}
    ' S3X 模擬：水溫設定
    Dim S3X_Sim_SetTemperature() As Byte = {0, 0, 0}
    '-----------------------------------------
    ' C34 模擬：控制箱狀態
    Dim C34_Sim_Status As Byte = &H7
    ' C34 模擬：目前水溫
    Dim C34_Sim_Temperature As Byte = 45
    '-----------------------------------------
    'Dim AppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.StartupPath & "\39-Log.exe")
    ' App.Config
    Dim AppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
    Dim AppConfigSettings As AppSettingsSection = AppConfig.AppSettings
    '-----------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-----------------------------
        Me.Text &= String.Format(" ({0})", Application.ProductVersion)
        '-----------------------------
        SearchSystemComport()   ' 搜尋系統 ComPort
        DataGridView_Init()     ' 顯示S3X與C34資料的 DataGridView 元件初始化設定
        SimMode_UI_Init()       ' 模擬模式 UI 介面初始化設定
        SysInfo_UI_Init()       ' 系統資訊 UI 介面初始化設定
        Notifyicon_DrawText(NotifyIcon_39, "--")
        '-----------------------------
    End Sub

    Private Sub DataGridView_Init()  ' 顯示S3X與C34資料的 DataGridView 元件初始化設定
        Dim DR As DataRow
        Dim CS As DataGridViewCellStyle
        Const WS As Integer = 35
        Const WD As Integer = 70
        Const WT As Integer = 55
        Const W2 As Integer = 40
        Const W3 As Integer = 65
        Dim CX As Integer

        '-----------------------------------------
        With DataGridView_S3X               ' S3X 部分
            .AutoGenerateColumns = False    ' 禁止 DataGridView 自動建立資料行
            .DataMember = "Table_S3X"
            ' 新增三筆空白資料至 Table_S3X
            For CX = 0 To (3 - 1)
                DR = DataSet_Polling.Tables("Table_S3X").NewRow()
                DR("設備") = SlaveName(CX)    ' 設備名稱
                DataSet_Polling.Tables("Table_S3X").Rows.Add(DR)
            Next

            .RowHeadersVisible = False
            .ReadOnly = True
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            For CX = 0 To .ColumnCount - 1  ' 停用排序模式
                .Columns(CX).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            .Columns("S3X_設備").Width = WS
            CS = New DataGridViewCellStyle
            CS.Format = "yyyy-MM-dd"
            .Columns("S3X_日期").DefaultCellStyle = CS
            .Columns("S3X_日期").Width = WD

            CS = New DataGridViewCellStyle
            CS.Format = "HH:mm:ss"
            .Columns("S3X_時間").DefaultCellStyle = CS
            .Columns("S3X_時間").Width = WT
            .Columns("S3X_輪詢").Width = W2
            .Columns("S3X_設備ID").Width = W3
            .Columns("S3X_加熱命令").Width = W3
            .Columns("S3X_更改水溫").Width = W3
            .Columns("S3X_目前水溫").Width = W3
            .Columns("S3X_水溫設定").Width = W3
            .Columns("S3X_主機狀態").Width = W3
            .ScrollBars = ScrollBars.None
            ' 設定選取項目的顏色與預設相同
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
        End With
        '-----------------------------------------
        With DataGridView_C34               ' C34 部分
            .AutoGenerateColumns = False    ' 禁止 DataGridView 自動建立資料行
            .DataMember = "Table_C34"
            ' 新增一筆空白資料至 Table_C34
            DR = DataSet_Polling.Tables("Table_C34").NewRow()
            DR("設備") = SlaveName(SlaveIndex.C34)    ' 設備名稱
            DataSet_Polling.Tables("Table_C34").Rows.Add(DR)

            .RowHeadersVisible = False
            .ReadOnly = True
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            For CX = 0 To .ColumnCount - 1  ' 停用排序模式
                .Columns(CX).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            .Columns("C34_設備").Width = WS
            CS = New DataGridViewCellStyle
            CS.Format = "yyyy-MM-dd"
            .Columns("C34_日期").DefaultCellStyle = CS
            .Columns("C34_日期").Width = WD

            CS = New DataGridViewCellStyle
            CS.Format = "HH:mm:ss"
            .Columns("C34_時間").DefaultCellStyle = CS
            .Columns("C34_時間").Width = WT
            .Columns("C34_輪詢").Width = W2
            .Columns("C34_設備ID").Width = W3
            .Columns("C34_目前水溫").Width = W3
            .Columns("C34_控制箱狀態").Width = W3 + 15
            .Columns("C34_功能44").Width = W2
            .Columns("C34_功能55").Width = W2
            .Columns("C34_功能56").Width = W2
            .Columns("C34_功能57").Width = W2
            .Columns("C34_功能58").Width = W2
            .Columns("C34_功能59").Width = W2
            .Columns("C34_功能5A").Width = W2
            .Columns("C34_加熱命令").Width = W3
            .ScrollBars = ScrollBars.None
            ' 設定選取項目的顏色與預設相同
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
        End With
    End Sub

    Private Sub SimMode_UI_Init()    ' 模擬模式 UI 介面初始化設定
        ' -----------------------------------------
        BT_Sim_S31_HeatingButton.Tag = SlaveIndex.S31
        BT_Sim_S31_SetTemperature.Tag = SlaveIndex.S31
        NUD_Sim_S31_Temperature.Tag = SlaveIndex.S31
        UI_Sim_ForcedHeatingButton(SlaveIndex.S31) = BT_Sim_S31_HeatingButton
        UI_Sim_SetTemperatureButton(SlaveIndex.S31) = BT_Sim_S31_SetTemperature
        UI_Sim_NUD_SetTemperature(SlaveIndex.S31) = NUD_Sim_S31_Temperature
        AddHandler BT_Sim_S31_HeatingButton.Click, AddressOf Sim_S3X_ForcedHeatingButton_Click
        AddHandler BT_Sim_S31_SetTemperature.Click, AddressOf Sim_S3X_SetTemperatureButton_Click
        GB_S31.Enabled = False
        UI_Sim_GroupBox(SlaveIndex.S31) = GB_S31
        ' -----------------------------------------
        BT_Sim_S32_HeatingButton.Tag = SlaveIndex.S32
        BT_Sim_S32_SetTemperature.Tag = SlaveIndex.S32
        NUD_Sim_S32_Temperature.Tag = SlaveIndex.S32
        UI_Sim_ForcedHeatingButton(SlaveIndex.S32) = BT_Sim_S32_HeatingButton
        UI_Sim_SetTemperatureButton(SlaveIndex.S32) = BT_Sim_S32_SetTemperature
        UI_Sim_NUD_SetTemperature(SlaveIndex.S32) = NUD_Sim_S32_Temperature
        AddHandler BT_Sim_S32_HeatingButton.Click, AddressOf Sim_S3X_ForcedHeatingButton_Click
        AddHandler BT_Sim_S32_SetTemperature.Click, AddressOf Sim_S3X_SetTemperatureButton_Click
        GB_S32.Enabled = False
        UI_Sim_GroupBox(SlaveIndex.S32) = GB_S32
        ' -----------------------------------------
        BT_Sim_S33_HeatingButton.Tag = SlaveIndex.S33
        BT_Sim_S33_SetTemperature.Tag = SlaveIndex.S33
        NUD_Sim_S33_Temperature.Tag = SlaveIndex.S33
        UI_Sim_ForcedHeatingButton(SlaveIndex.S33) = BT_Sim_S33_HeatingButton
        UI_Sim_SetTemperatureButton(SlaveIndex.S33) = BT_Sim_S33_SetTemperature
        UI_Sim_NUD_SetTemperature(SlaveIndex.S33) = NUD_Sim_S33_Temperature
        AddHandler BT_Sim_S33_HeatingButton.Click, AddressOf Sim_S3X_ForcedHeatingButton_Click
        AddHandler BT_Sim_S33_SetTemperature.Click, AddressOf Sim_S3X_SetTemperatureButton_Click
        GB_S33.Enabled = False
        UI_Sim_GroupBox(SlaveIndex.S33) = GB_S33
        ' -----------------------------------------
        CLB_Sim_C34_StatusCode.Tag = SlaveIndex.C34
        NUD_Sim_C34_StatusCode.Tag = SlaveIndex.C34
        GB_C34.Enabled = False
        UI_Sim_GroupBox(SlaveIndex.C34) = GB_C34
        NUD_Sim_C34_StatusCode.Value = C34_Sim_Status
        NUD_Sim_C34_Temperature.Value = C34_Sim_Temperature
        ' -----------------------------------------

    End Sub
    Private Sub SysInfo_UI_Init()   ' 系統資訊 UI 介面初始化設定
        ' -----------------------------------------
        NUD_Sys_S31_StatusCode.Tag = LV_Sys_S31_StatusCode
        UI_Sys_NUD_StatusCode(SlaveIndex.S31) = NUD_Sys_S31_StatusCode
        UI_Sys_S3X_LB_NowTemperature(SlaveIndex.S31) = LB_Sys_S31_NowTemperature
        UI_Sys_S3X_LB_SetTemperature(SlaveIndex.S31) = LB_Sys_S31_SetTemperature
        AddHandler NUD_Sys_S31_StatusCode.ValueChanged, AddressOf Info_NUD_StatusCode_ValueChanged
        AddHandler LV_Sys_S31_StatusCode.DrawItem, AddressOf ListView_Sys_StatusCode_DrawItem
        LV_Sys_S31_StatusCode.View = View.List
        LV_Sys_S31_StatusCode.CheckBoxes = False
        LV_Sys_S31_StatusCode.OwnerDraw = True
        ' -----------------------------------------
        NUD_Sys_S32_StatusCode.Tag = LV_Sys_S32_StatusCode
        UI_Sys_NUD_StatusCode(SlaveIndex.S32) = NUD_Sys_S32_StatusCode
        AddHandler NUD_Sys_S32_StatusCode.ValueChanged, AddressOf Info_NUD_StatusCode_ValueChanged
        AddHandler LV_Sys_S32_StatusCode.DrawItem, AddressOf ListView_Sys_StatusCode_DrawItem
        UI_Sys_S3X_LB_NowTemperature(SlaveIndex.S32) = LB_Sys_S32_NowTemperature
        UI_Sys_S3X_LB_SetTemperature(SlaveIndex.S32) = LB_Sys_S32_SetTemperature
        LV_Sys_S32_StatusCode.View = View.List
        LV_Sys_S32_StatusCode.CheckBoxes = False
        LV_Sys_S32_StatusCode.OwnerDraw = True
        ' -----------------------------------------
        NUD_Sys_S33_StatusCode.Tag = LV_Sys_S33_StatusCode
        UI_Sys_NUD_StatusCode(SlaveIndex.S33) = NUD_Sys_S33_StatusCode
        UI_Sys_S3X_LB_NowTemperature(SlaveIndex.S33) = LB_Sys_S33_NowTemperature
        UI_Sys_S3X_LB_SetTemperature(SlaveIndex.S33) = LB_Sys_S33_SetTemperature
        AddHandler NUD_Sys_S33_StatusCode.ValueChanged, AddressOf Info_NUD_StatusCode_ValueChanged
        AddHandler LV_Sys_S33_StatusCode.DrawItem, AddressOf ListView_Sys_StatusCode_DrawItem
        LV_Sys_S33_StatusCode.View = View.List
        LV_Sys_S33_StatusCode.CheckBoxes = False
        LV_Sys_S33_StatusCode.OwnerDraw = True
        ' -----------------------------------------
        NUD_Sys_C34_StatusCode.Tag = LV_Sys_C34_StatusCode
        UI_Sys_NUD_StatusCode(SlaveIndex.C34) = NUD_Sys_C34_StatusCode
        AddHandler NUD_Sys_C34_StatusCode.ValueChanged, AddressOf Info_NUD_StatusCode_ValueChanged
        AddHandler LV_Sys_C34_StatusCode.DrawItem, AddressOf ListView_Sys_StatusCode_DrawItem
        LV_Sys_C34_StatusCode.View = View.List
        LV_Sys_C34_StatusCode.CheckBoxes = False
        LV_Sys_C34_StatusCode.OwnerDraw = True
        ' -----------------------------------------
    End Sub

    ' 設定資料：讀取項目字串值
    Private Function AppConfig_ItemString(ByVal ItemName As String) As String
        If IsNothing(AppConfigSettings.Settings(ItemName)) Then
            Return ("")
        Else
            Return (AppConfigSettings.Settings(ItemName).Value)
        End If
    End Function

    ' 設定資料：讀取項目布林值
    Private Function AppConfig_ItemBoolean(ByVal ItemName As String) As Boolean
        If IsNothing(AppConfigSettings.Settings(ItemName)) Then
            Return (False)
        Else
            Return (CBool(AppConfigSettings.Settings(ItemName).Value))
        End If
    End Function

    ' 設定資料：更新項目值
    Private Sub AppConfig_ItemUpdate(ByVal ItemName As String, ByVal ItemData As String)
        If IsNothing(AppConfigSettings.Settings(ItemName)) Then
            AppConfigSettings.Settings.Add(ItemName, ItemData)
        Else
            AppConfigSettings.Settings(ItemName).Value = ItemData
        End If
    End Sub

    ' 設定資訊寫入
    Private Sub AppConfig_Save()
        '------------------------------------------
        AppConfig_ItemUpdate("PortName", ComboBox_ComPortName.Text)
        '------------------------------------------
        AppConfig_ItemUpdate("PortConfig", ComboBox_ComPortConfig.Text)
        '------------------------------------------
        AppConfig_ItemUpdate("PortThreadMode", CheckBox_ComPortThread.Checked.ToString())
        '------------------------------------------
        AppConfig.Save(ConfigurationSaveMode.Modified)  ' 儲存更新資料 
    End Sub

    ' 搜尋系統 ComPort
    Private Sub SearchSystemComport()
        Dim PortName As String

        '---------------------------------------
        ComboBox_ComPortConfig.SelectedIndex = 0
        ComboBox_ComPortConfig.Text = AppConfig_ItemString("PortConfig")
        '---------------------------------------
        CheckBox_ComPortThread.Checked = AppConfig_ItemBoolean("PortThreadMode")
        '---------------------------------------
        For Each PortName In My.Computer.Ports.SerialPortNames
            ComboBox_ComPortName.Items.Add(PortName)
        Next
        If ComboBox_ComPortName.Items.Count > 0 Then
            ComboBox_ComPortName.SelectedIndex = 0
            ComboBox_ComPortName.Text = AppConfig_ItemString("PortName")
            GB_ComPort.Enabled = True
            BT_ComPort.Enabled = True
        Else
            GB_ComPort.Enabled = False
            BT_ComPort.Enabled = False
        End If
        '---------------------------------------
    End Sub

    ' 事件：ComPort 連線(離線) 按鈕按下
    Private Sub ComPort_BT_Click(sender As Object, e As EventArgs) Handles BT_ComPort.Click
        If ComPort.IsOpen Then
            Comport_Close()
            GB_SimSlave.Enabled = True
            BT_Exit.Enabled = True
        Else
            PollingCommand_ReScanMode()
            BT_Exit.Enabled = False
            GB_SimSlave.Enabled = False
            Comport_Open()
        End If
    End Sub

    ' 開啟 ComPort
    Private Sub Comport_Open()
        If ComPort.IsOpen = False Then
            GB_ComPort.Enabled = False
            BT_ComPort.Text = "離線"
            ComPort.PortName = ComboBox_ComPortName.Text
            ComPort.BaudRate = 9600
            ComPort.DataBits = 8
            ComPort.StopBits = StopBits.One
            Select Case ComboBox_ComPortConfig.SelectedIndex
                Case 0
                    ComPort.Parity = Parity.None
                Case 1
                    ComPort.Parity = Parity.Even
                Case 2
                    ComPort.Parity = Parity.Odd
                Case Else
                    MsgBox("ComPort 組態設定發生錯誤")
            End Select

            If CheckBox_ComPortThread.Checked = True Then
                ComPortReceiving = True
                ComPort.Open()
                ComPortThread = New Thread(AddressOf ComPort_DataReceived_ThreadMode)
                ComPortThread.IsBackground = True
                ComPortThread.Start()
            Else
                AddHandler ComPort.DataReceived, AddressOf ComPort_DataReceived_EventMode
                ComPortReceiving = False
                ComPort.Open()
            End If
        End If
    End Sub

    ' 關閉 ComPort
    Private Sub Comport_Close()
        If ComPort.IsOpen = True Then
            If CheckBox_ComPortThread.Checked = True Then
                ComPortReceiving = False
            Else
                RemoveHandler ComPort.DataReceived, AddressOf ComPort_DataReceived_EventMode
                ComPort.Close()
            End If
            GB_ComPort.Enabled = True
            BT_ComPort.Text = "連線"
        End If
    End Sub

    ' 顯示 Log 資料
    Private Sub DisplayLogData(ByVal Data As Byte())
        Dim Index As Integer = PollingCommand.IndexOf(Data(0))
        Dim DR As DataRow
        Dim DT As DateTime = Now()
        Dim CX As Integer

        If (Index >= 0 And Index <= 3) Or Data.Count = 3 Or Data.Count = 20 Or Data.Count = 28 Then
        Else
            MsgBox("發生錯誤：" & System.Reflection.MethodBase.GetCurrentMethod.Name & vbCrLf & '
                                         "PollingIndex：" & Index & vbCrLf & '
                      "PollingDataTempLength：" & Data.Count & vbCrLf & '
                      "")
        End If

        If (Index = SlaveIndex.C34) Then    ' C34 部分
            DR = DataSet_Polling.Tables("Table_C34").Rows(0)
            DR("日期") = DT
            DR("時間") = DT
            DR("輪詢") = String.Format("{0:X2} {1:X2}", Data(0), Data(1))
            If (Data.Count > 3) Then
                DR("設備ID") = String.Format("{0:X2} {1:X2} {1:X2}", Data(2), Data(3), Data(4))
                DR("目前水溫") = String.Format("{0:X2} {1:X2} {1:X2}", Data(5), Data(6), Data(7))
                LB_Sys_C34_NowTemperature.Text = TemperatureToString(Data(6))
                ' ---------------------------------------------------
                ' 系統列提示目前水溫
                Notifyicon_DrawText(NotifyIcon_39, TemperatureToString(Data(6)))
                ' ---------------------------------------------------
                DR("控制箱狀態") = String.Format("{0:X2} {1:X2} {1:X2}", Data(8), Data(9), Data(10))
                UI_Sys_NUD_StatusCode(Index).Value = Data(9)
                DR("功能44") = String.Format("{0:X2} {1:X2}", Data(11), Data(12))
                DR("功能55") = String.Format("{0:X2} {1:X2}", Data(13), Data(14))
                DR("功能56") = String.Format("{0:X2} {1:X2}", Data(15), Data(16))
                DR("功能57") = String.Format("{0:X2} {1:X2}", Data(17), Data(18))
                DR("功能58") = String.Format("{0:X2} {1:X2}", Data(19), Data(20))
                DR("功能59") = String.Format("{0:X2} {1:X2}", Data(21), Data(22))
                DR("功能5A") = String.Format("{0:X2} {1:X2}", Data(23), Data(24))
                DR("加熱命令") = String.Format("{0:X2} {1:X2} {1:X2}", Data(25), Data(26), Data(27))
                NUD_Sim_C34_StatusCode.Value = C34_Sim_Status
            Else
                DR("設備ID") = String.Format("{0:X2}", Data(2))
                DR("目前水溫") = ""
                LB_Sys_C34_NowTemperature.Text = "--"
                DR("控制箱狀態") = ""
                DR("功能44") = ""
                DR("功能55") = ""
                DR("功能56") = ""
                DR("功能57") = ""
                DR("功能58") = ""
                DR("功能59") = ""
                DR("功能5A") = ""
                DR("加熱命令") = ""
            End If

        Else    ' S3X 部分
            DR = DataSet_Polling.Tables("Table_S3X").Rows(Index)
            DR("日期") = DT
            DR("時間") = DT
            DR("輪詢") = String.Format("{0:X2} {1:X2}", Data(0), Data(1))
            If (Data.Count > 3) Then
                DR("設備ID") = String.Format("{0:X2} {1:X2} {1:X2}", Data(2), Data(3), Data(4))
                DR("加熱命令") = String.Format("{0:X2} {1:X2} {1:X2}", Data(5), Data(6), Data(7))
                If Data(6) = HeadingCommand.Active Then ' 檢查是否強制加熱動作
                    UI_Sim_ForcedHeatingButton(Index).ForeColor = Color.Black
                End If
                DR("更改水溫") = String.Format("{0:X2} {1:X2} {1:X2}", Data(8), Data(9), Data(10))
                If Data(9) <> 0 Then ' 有設定水溫時：30~75
                    UI_Sim_SetTemperatureButton(Index).ForeColor = Color.Black
                End If
                DR("目前水溫") = String.Format("{0:X2} {1:X2} {1:X2}", Data(11), Data(12), Data(13))
                UI_Sys_S3X_LB_NowTemperature(Index).Text = TemperatureToString(Data(12))
                DR("水溫設定") = String.Format("{0:X2} {1:X2} {1:X2}", Data(14), Data(15), Data(16))
                UI_Sys_S3X_LB_SetTemperature(Index).Text = TemperatureToString(Data(15))
                For CX = 0 To UI_Sim_NUD_SetTemperature.Count - 1
                    UI_Sim_NUD_SetTemperature(CX).Value = Data(15)
                Next
                DR("主機狀態") = String.Format("{0:X2} {1:X2} {1:X2}", Data(17), Data(18), Data(19))
                UI_Sys_NUD_StatusCode(Index).Value = Data(18)
            Else
                DR("設備ID") = String.Format("{0:X2}", Data(2))
                DR("加熱命令") = ""
                DR("更改水溫") = ""
                DR("目前水溫") = ""
                UI_Sys_S3X_LB_NowTemperature(Index).Text = "--"
                DR("水溫設定") = ""
                UI_Sys_S3X_LB_SetTemperature(Index).Text = "--"
                DR("主機狀態") = ""
            End If
        End If
    End Sub

    ' 溫度值轉換為字串
    Private Function TemperatureToString(ByVal TempValue As Byte) As String
        Select Case TempValue
            Case &HFF
                Return ("--")
            Case Is < 100
                Return (TempValue.ToString())
            Case Else
                Return ("99")
        End Select
    End Function

    ' 事件：畫面大小變更時，可用來攔截最小化視窗被按下時
    Private Sub Form_39Log_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            'Me.Hide()
        End If
    End Sub

    ' 事件：視窗關閉中
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        'Me.Visible = False
        Me.Hide()
        NotifyIcon_ShowBalloonTip("縮小至系統列提示", "滑鼠連點系統列圖示可復原程式畫面!")
    End Sub

    ' 事件：關閉程式按鈕被按下
    Private Sub Exit_BT_Click(sender As Object, e As EventArgs) Handles BT_Exit.Click
        AppConfig_Save()
        Comport_Close()
        Application.Exit()
    End Sub

    ' 協定檢查
    Private Sub ProtocolCheck(ByVal BD As Byte)
        Dim FPC As Integer

        If PollingIndex < 0 Then
            FPC = PollingCommand.IndexOf(BD) ' 比對是否 88,77,66,55 輪詢命令
            If FPC >= 0 Then
                ReceivedData_Start(FPC) ' 開始接收資料至 ReceivedData
            End If
        Else
            If PollingIndex = SlaveIndex.C34 Then
                Now_PacketCheckStep = C34_Slave(BD, Now_PacketCheckStep)
            Else
                Now_PacketCheckStep = S3X_Slave(BD, Now_PacketCheckStep)
            End If

            If Now_PacketCheckStep = PacketCheckStep.DataError Then  ' 當封包資料分析結果是錯誤時
                FPC = PollingCommand.IndexOf(BD) ' 比對此時時資料是否 88,77,66,55 輪詢命令
                ' 當確定是新的輪詢命令而且之前收到的資料剛好符合最短輪詢結構=3
                If FPC >= 0 And ReceivedData.Count = 3 Then
                    ReceivedData_UpdateTo_LogData() ' 將之前收到的資料加至 LogData 佇列
                    ReceivedData_Start(FPC) ' 開始接收資料至 ReceivedData
                Else
                    PollingCommand_ReScanMode()
                    PacketErrorCount += 1   ' 錯誤封包次數+1
                End If
            Else
                If Now_PacketCheckStep = PacketCheckStep.Finish Then
                    ReceivedData_UpdateTo_LogData()
                    PollingCommand_ReScanMode()
                End If
            End If
        End If

    End Sub

    ' Received 資料 Update 至 Log 資料
    Private Sub ReceivedData_UpdateTo_LogData()
        If ReceivedData_CMP_TempData() < 0 Then             ' 比對 Received 資料與 Log 資料是否相同
            TempData(PollingIndex) = ReceivedData.ToArray() ' 當資料不同時更新至 Temp 資料
            LogData.Add(ReceivedData.ToArray())             ' 當資料不同時增加至 Log 資料
        End If
    End Sub

    ' 比對 Received 資料與 Log 資料是否相同：-1表示不同
    Private Function ReceivedData_CMP_TempData() As Integer
        If TempData(PollingIndex).Count <> ReceivedData.Count Then
            Return (-1)
        Else
            Return (ByteArrayCMP(TempData(PollingIndex).ToArray(), ReceivedData.ToArray(), ReceivedData.Count))
        End If
    End Function

    ' Byte 陣列資料比對：-1表示不同
    Private Function ByteArrayCMP(ByVal AR1 As Byte(), ByVal AR2 As Byte(), ByVal CmpLen As Integer) As Integer
        Dim CX As Integer

        If CmpLen > AR1.Count Or CmpLen > AR2.Count Or CmpLen <= 0 Then
            Return (-1)
        End If
        For CX = 0 To CmpLen - 1
            If AR1(CX) <> AR2(CX) Then
                Return (-1)
            End If
        Next
        Return (CmpLen)
    End Function

    ' 重新掃描輪詢命令模式
    Private Sub PollingCommand_ReScanMode()
        ReceivedData.Clear()
        PollingIndex = -1
        Now_PacketCheckStep = PacketCheckStep.Start
    End Sub

    ' ReceivedData 開始接收資料
    Private Sub ReceivedData_Start(ByVal PollingCommandIndex As Integer)
        ReceivedData.Clear()
        PollingIndex = PollingCommandIndex
        ReceivedData.Add(PollingCommand(PollingCommandIndex))
        Now_PacketCheckStep = PacketCheckStep.Start
    End Sub

    ' C34 設備功能
    Private Function C34_Slave(ByVal Data As Byte, ByVal CheckStep As UInt16) As UInt16

        If SlaveSimMode(PollingIndex) = True Then ' 是否為要模擬設備功能
            Return (C34_Slave_SimMode(Data, CheckStep))
        Else
            Return (C34_Slave_InfoMode(Data, CheckStep))
        End If

    End Function

    ' S3X 設備功能
    Private Function S3X_Slave(ByVal Data As Byte, ByVal CheckStep As UInt16) As UInt16

        If SlaveSimMode(PollingIndex) = True Then ' 是否為要模擬設備功能
            Return (S3X_Slave_SimMode(Data, CheckStep))
        Else
            Return (S3X_Slave_InfoMode(Data, CheckStep))
        End If

    End Function

    ' 功能碼資料回應
    Private Sub FunctionCode_ResponseData(ByVal Data As Byte, ByVal Count As Integer)
        Dim TX_Buffer() As Byte = {&H0}
        Dim CX As Integer

        For CX = 0 To (Count - 1)
            TX_Buffer(0) = Data
            ReceivedData.Add(Data)    ' 存入回應資料
            ' 避免在傳統 ComPort轉 RS-485 的介面送出資料後引起後續接收的資料錯誤
            ' USB介面的 RS-485 則無上述狀況
            ' Sleep值視情況調整，另外送出資料採用一次一個 Byte
            ' https://forum.arduino.cc/index.php?topic=134980.0
            Thread.Sleep(1)
            ComPort.Write(TX_Buffer, 0, 1)  ' 功能代碼回應資料
        Next
    End Sub

    ' C34 設備：模擬模式
    Private Function C34_Slave_SimMode(ByVal BD As Byte, ByVal CheckStep As UInt16) As UInt16
        Dim NextStep As UInt16 = PacketCheckStep.DataError

        Select Case CheckStep
            Case PacketCheckStep.Start
                If BD = PollingCommand(PollingIndex) Then ' 檢查 PollingCommand 內容是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H0
                End If
            Case &H0
                If BD = &H0 Then ' 功能【00】：查詢子機代碼
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(SlaveID(PollingIndex), 2) ' 回應子機代碼
                    NextStep = &H1100
                End If
            Case &H1100
                If BD = &H11 Then   ' 功能【11】：查詢控制箱現在水溫
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(C34_Sim_Temperature, 2) ' 回應現在水溫
                    NextStep = &H2200
                End If
            Case &H2200
                If BD = &H22 Then   ' 功能【22】：查詢控制箱狀態值
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(C34_Sim_Status, 2) ' 回應控制箱狀態值
                    NextStep = &H4400
                End If
            Case &H4400
                If BD = &H44 Then   ' 功能【44】：
                    ReceivedData.Add(BD)
                    NextStep = &H4401
                End If
            Case &H4401
                ReceivedData.Add(BD)
                NextStep = &H5500
            Case &H5500
                If BD = &H55 Then   ' 功能【55】：
                    ReceivedData.Add(BD)
                    NextStep = &H5501
                End If
            Case &H5501
                ReceivedData.Add(BD)
                NextStep = &H5600
            Case &H5600
                If BD = &H56 Then   ' 功能【56】：
                    ReceivedData.Add(BD)
                    NextStep = &H5601
                End If
            Case &H5601
                ReceivedData.Add(BD)
                NextStep = &H5700
            Case &H5700
                If BD = &H57 Then   ' 功能【57】：
                    ReceivedData.Add(BD)
                    NextStep = &H5701
                End If
            Case &H5701
                ReceivedData.Add(BD)
                NextStep = &H5800
            Case &H5800
                If BD = &H58 Then   ' 功能【58】：
                    ReceivedData.Add(BD)
                    NextStep = &H5801
                End If
            Case &H5801
                ReceivedData.Add(BD)
                NextStep = &H5900
            Case &H5900
                If BD = &H59 Then   ' 功能【59】：
                    ReceivedData.Add(BD)
                    NextStep = &H5901
                End If
            Case &H5901
                ReceivedData.Add(BD)
                NextStep = &H5A00
            Case &H5A00
                If BD = &H5A Then   ' 功能【5A】：
                    ReceivedData.Add(BD)
                    NextStep = &H5A01
                End If
            Case &H5A01
                ReceivedData.Add(BD)
                NextStep = &H3300
            Case &H3300
                If BD = &H33 Then   ' 功能【33】：主機加熱命令
                    ReceivedData.Add(BD)
                    NextStep = &H3301
                End If
            Case &H3301
                ReceivedData.Add(BD)
                FunctionCode_ResponseData(BD, 1) ' 回應收到的加熱命令給主機
                If BD = HeadingCommand.Active Then ' 收到加熱命令 AA
                    If (C34_Sim_Status And &H10) = &H0 Then ' 檢查下次回應加熱中狀態是否為 OFF
                        C34_Sim_Status = C34_Sim_Status Or CByte(&H10)   ' 更改下次回應加熱中狀態為 ON
                    End If
                Else
                    If (C34_Sim_Status And &H10) <> &H0 Then ' 檢查下次回應加熱中狀態是否為 ON
                        C34_Sim_Status = C34_Sim_Status And CByte(&HEF) ' 更改下次回應加熱中狀態為 OFF
                    End If
                End If
                NextStep = PacketCheckStep.Finish      ' 接收完畢
            Case Else
                MsgBox("發生錯誤：" & System.Reflection.MethodBase.GetCurrentMethod.Name & vbCrLf & '
                       "BD：" & BD.ToString("X2") & vbCrLf & '
                       "PollingFunctionCode：" & Now_PacketCheckStep.ToString("X4") & vbCrLf & '
                       "PollingIndex：" & PollingIndex & vbCrLf & '
                       "PollingDataTempLength：" & ReceivedData.Count & vbCrLf & '
                       "")
        End Select
        Return (NextStep)
    End Function

    ' C34 設備：資訊模式
    Private Function C34_Slave_InfoMode(ByVal BD As Byte, ByVal CheckStep As UInt16) As UInt16
        Dim NextStep As UInt16 = PacketCheckStep.DataError

        Select Case CheckStep
            Case PacketCheckStep.Start
                If BD = PollingCommand(PollingIndex) Then ' 檢查 PollingCommand 內容是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H0
                End If
            Case &H0
                If BD = &H0 Then ' 功能【00】：查詢子機代碼
                    ReceivedData.Add(BD)
                    NextStep = &H1
                End If
            Case &H1
                If BD = SlaveID(PollingIndex) Then    ' 檢查子機代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H2
                End If
            Case &H2
                If BD = SlaveID(PollingIndex) Then    ' 檢查子機代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H1100
                End If
            Case &H1100
                If BD = &H11 Then   ' 功能【11】：查詢控制箱現在溫度
                    ReceivedData.Add(BD)
                    NextStep = &H1101
                End If
            Case &H1101
                ReceivedData.Add(BD)  ' 現在溫度
                NextStep = &H1102
            Case &H1102
                ReceivedData.Add(BD)  ' 現在溫度
                NextStep = &H2200
            Case &H2200
                If BD = &H22 Then   ' 功能【22】：查詢控制箱狀態值
                    ReceivedData.Add(BD)
                    NextStep = &H2201
                End If
            Case &H2201
                ReceivedData.Add(BD)  ' 控制箱狀態值
                NextStep = &H2202
            Case &H2202
                ReceivedData.Add(BD)  ' 控制箱狀態值
                NextStep = &H4400
            Case &H4400
                If BD = &H44 Then   ' 功能【44】：
                    ReceivedData.Add(BD)
                    NextStep = &H4401
                End If
            Case &H4401
                ReceivedData.Add(BD)
                NextStep = &H5500
            Case &H5500
                If BD = &H55 Then   ' 功能【55】：
                    ReceivedData.Add(BD)
                    NextStep = &H5501
                End If
            Case &H5501
                ReceivedData.Add(BD)
                NextStep = &H5600
            Case &H5600
                If BD = &H56 Then   ' 功能【56】：
                    ReceivedData.Add(BD)
                    NextStep = &H5601
                End If
            Case &H5601
                ReceivedData.Add(BD)
                NextStep = &H5700
            Case &H5700
                If BD = &H57 Then   ' 功能【57】：
                    ReceivedData.Add(BD)
                    NextStep = &H5701
                End If
            Case &H5701
                ReceivedData.Add(BD)
                NextStep = &H5800
            Case &H5800
                If BD = &H58 Then   ' 功能【58】：
                    ReceivedData.Add(BD)
                    NextStep = &H5801
                End If
            Case &H5801
                ReceivedData.Add(BD)
                NextStep = &H5900
            Case &H5900
                If BD = &H59 Then   ' 功能【59】：
                    ReceivedData.Add(BD)
                    NextStep = &H5901
                End If
            Case &H5901
                ReceivedData.Add(BD)
                NextStep = &H5A00
            Case &H5A00
                If BD = &H5A Then   ' 功能【5A】：
                    ReceivedData.Add(BD)
                    NextStep = &H5A01
                End If
            Case &H5A01
                ReceivedData.Add(BD)
                NextStep = &H3300
            Case &H3300
                If BD = &H33 Then   ' 功能【33】：主機加熱命令
                    ReceivedData.Add(BD)
                    NextStep = &H3301
                End If
            Case &H3301
                ReceivedData.Add(BD)
                NextStep = &H3302
            Case &H3302
                ReceivedData.Add(BD)
                NextStep = PacketCheckStep.Finish
            Case Else
                MsgBox("發生錯誤：" & System.Reflection.MethodBase.GetCurrentMethod.Name & vbCrLf & '
                       "BD：" & BD.ToString("X2") & vbCrLf & '
                       "PollingFunctionCode：" & Now_PacketCheckStep.ToString("X4") & vbCrLf & '
                       "PollingIndex：" & PollingIndex & vbCrLf & '
                       "PollingDataTempLength：" & ReceivedData.Count & vbCrLf & '
                       "")
        End Select
        Return (NextStep)
    End Function

    ' S3X 設備：模擬模式
    Private Function S3X_Slave_SimMode(ByVal BD As Byte, ByVal CheckStep As UInt16) As UInt16
        Dim NextStep As UInt16 = PacketCheckStep.DataError

        Select Case CheckStep
            Case PacketCheckStep.Start
                If BD = PollingCommand(PollingIndex) Then ' 檢查 PollingCommand 內容是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H0
                End If
            Case &H0
                If BD = &H0 Then ' 功能【00】：查詢子機代碼
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(SlaveID(PollingIndex), 2) ' 回應子機代碼
                    NextStep = &H1100
                End If
            Case &H1100
                If BD = &H11 Then   ' 功能【11】：查詢子機強制加熱按鈕狀態
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(S3X_Sim_ForcedHeating(PollingIndex), 2) ' 回應加熱按鈕狀態
                    If S3X_Sim_ForcedHeating(PollingIndex) = HeadingCommand.Active Then ' 檢查是否強制加熱動作
                        S3X_Sim_ForcedHeating(PollingIndex) = HeadingCommand.None
                    End If
                    NextStep = &H1500
                End If
            Case &H1500
                If BD = &H15 Then   ' 功能【15】：查詢子機更改水溫
                    ReceivedData.Add(BD)
                    FunctionCode_ResponseData(S3X_Sim_SetTemperature(PollingIndex), 2) ' 回應 00：不變 30~75：更改
                    If S3X_Sim_SetTemperature(PollingIndex) <> 0 Then ' 檢查是否更改設定溫度
                        S3X_Sim_SetTemperature(PollingIndex) = 0 ' 將值歸零免得一直在送出要更改主機的設定水溫
                    End If
                    NextStep = &H2200
                End If
            Case &H2200
                If BD = &H22 Then   ' 功能【22】：主機(P31)現在水溫值
                    ReceivedData.Add(BD)
                    NextStep = &H2201
                End If
            Case &H2201
                ReceivedData.Add(BD)
                FunctionCode_ResponseData(BD, 1) ' 回應收到的現在水溫值給主機(P31)
                NextStep = &H2500
            Case &H2500
                If BD = &H25 Then   ' 功能【25】：主機(P31)設定水溫值
                    ReceivedData.Add(BD)
                    NextStep = &H2501
                End If
            Case &H2501
                ReceivedData.Add(BD)
                FunctionCode_ResponseData(BD, 1)  ' 回應收到的設定水溫值給主機(P31)
                NextStep = &H3300
            Case &H3300
                If BD = &H33 Then   ' 功能【33】：主機(P31)系統狀態值
                    ReceivedData.Add(BD)
                    NextStep = &H3301
                End If
            Case &H3301
                ReceivedData.Add(BD)
                FunctionCode_ResponseData(BD, 1) ' 回應收到的系統狀態值給主機(P31)
                NextStep = PacketCheckStep.Finish      ' 接收完畢
            Case Else
                MsgBox("發生錯誤：" & System.Reflection.MethodBase.GetCurrentMethod.Name & vbCrLf & '
                       "BD：" & BD.ToString("X2") & vbCrLf & '
                       "PollingFunctionCode：" & Now_PacketCheckStep.ToString("X4") & vbCrLf & '
                       "PollingIndex：" & PollingIndex & vbCrLf & '
                       "PollingDataTempLength：" & ReceivedData.Count & vbCrLf & '
                       "")
        End Select
        Return (NextStep)
    End Function

    ' S3X 設備：資訊模式
    Private Function S3X_Slave_InfoMode(ByVal BD As Byte, ByVal CheckStep As UInt16) As UInt16
        Dim NextStep As UInt16 = PacketCheckStep.DataError

        Select Case CheckStep
            Case PacketCheckStep.Start
                If BD = PollingCommand(PollingIndex) Then ' 檢查 PollingCommand 內容是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H0
                End If
            Case &H0
                If BD = &H0 Then ' 功能【00】：查詢子機代碼
                    ReceivedData.Add(BD)
                    NextStep = &H1
                End If
            Case &H1
                If BD = SlaveID(PollingIndex) Then    ' 檢查子機代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H2
                End If
            Case &H2
                If BD = SlaveID(PollingIndex) Then    ' 檢查子機代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H1100
                End If
            Case &H1100
                If BD = &H11 Then   ' 功能【11】：查詢子機強制加熱按鈕狀態
                    ReceivedData.Add(BD)
                    NextStep = &H1101
                End If
            Case &H1101
                If System.Enum.IsDefined(GetType(HeadingCommand), BD) Then  ' 檢查強制加熱按鈕代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H1102
                End If
            Case &H1102
                If System.Enum.IsDefined(GetType(HeadingCommand), BD) Then  ' 檢查強制加熱按鈕代碼是否相符
                    ReceivedData.Add(BD)
                    NextStep = &H1500
                End If
            Case &H1500
                If BD = &H15 Then   ' 功能【15】：更改水溫
                    ReceivedData.Add(BD)
                    NextStep = &H1501
                End If
            Case &H1501
                ReceivedData.Add(BD)
                NextStep = &H1502
            Case &H1502
                ReceivedData.Add(BD)
                NextStep = &H2200
            Case &H2200
                If BD = &H22 Then   ' 功能【22】：主機回應現在溫度
                    ReceivedData.Add(BD)
                    NextStep = &H2201
                End If
            Case &H2201
                ReceivedData.Add(BD)  ' 現在溫度
                NextStep = &H2202
            Case &H2202
                ReceivedData.Add(BD)  ' 現在溫度
                NextStep = &H2500
            Case &H2500
                If BD = &H25 Then   ' 功能【25】：主機回應設定溫度
                    ReceivedData.Add(BD)
                    NextStep = &H2501
                End If
            Case &H2501
                ReceivedData.Add(BD)  ' 設定溫度
                NextStep = &H2502
            Case &H2502
                ReceivedData.Add(BD)  ' 設定溫度
                NextStep = &H3300
            Case &H3300
                If BD = &H33 Then   ' 功能【33】：主機回應系統狀態
                    ReceivedData.Add(BD)
                    NextStep = &H3301
                End If
            Case &H3301
                ReceivedData.Add(BD)  ' 設定溫度
                NextStep = &H3302
            Case &H3302
                ReceivedData.Add(BD)  ' 設定溫度
                NextStep = PacketCheckStep.Finish      ' 接收完畢
            Case Else
                MsgBox("發生錯誤：" & System.Reflection.MethodBase.GetCurrentMethod.Name & vbCrLf & '
                       "BD：" & BD.ToString("X2") & vbCrLf & '
                       "PollingFunctionCode：" & Now_PacketCheckStep.ToString("X4") & vbCrLf & '
                       "PollingIndex：" & PollingIndex & vbCrLf & '
                       "PollingDataTempLength：" & ReceivedData.Count & vbCrLf & '
                       "")
        End Select
        Return (NextStep)
    End Function

    ' 事件：所要模擬的設備項目被滑鼠點下
    Private Sub CLB_SimSlave_MouseDown(sender As Object, e As MouseEventArgs) Handles CLB_SimSlave.MouseDown
        Dim CLB As CheckedListBox = DirectCast(sender, CheckedListBox)
        Dim index As Integer = CLB.IndexFromPoint(e.Location)

        CLB.SetItemChecked(index, Not CLB.GetItemChecked(index))
        SlaveSimMode(index) = CLB.GetItemChecked(index)
        UI_Sim_GroupBox(index).Enabled = CLB.GetItemChecked(index)
    End Sub

    ' 事件：C34模擬：狀態碼【位元】被點選變更
    Private Sub Sim_CLB_C34_StatusCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CLB_Sim_C34_StatusCode.SelectedIndexChanged
        Dim CLB As CheckedListBox = DirectCast(sender, CheckedListBox)
        Dim NUD As NumericUpDown = NUD_Sim_C34_StatusCode
        NUD.Value = CByte(NUD.Value) Xor CByte(2 ^ (7 - CLB.SelectedIndex))
    End Sub

    ' 事件：C34模擬：狀態碼【數值】被變更
    Private Sub Sim_NUD_C34_StatusCode_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Sim_C34_StatusCode.ValueChanged
        Dim NUD As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim CLB As CheckedListBox = CLB_Sim_C34_StatusCode
        Dim CX As Integer

        C34_Sim_Status = CByte(NUD.Value)
        For CX = 0 To CLB.Items.Count - 1
            If (CByte(2 ^ (7 - CX)) And CByte(NUD.Value)) <> 0 Then
                CLB.SetItemChecked(CX, True)
            Else
                CLB.SetItemChecked(CX, False)
            End If
        Next
    End Sub

    ' 事件：資訊：狀態碼數值被改變
    Private Sub Info_NUD_StatusCode_ValueChanged(sender As Object, e As EventArgs)
        Dim NUD As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim LV As ListView = DirectCast(NUD.Tag, ListView)
        Dim CX As Integer

        For CX = 0 To LV.Items.Count - 1
            If (CByte(2 ^ (7 - CX)) And CByte(NUD.Value)) <> 0 Then
                LV.Items(CX).ForeColor = Color.Red
                LV.Items(CX).Text = "●" & LV.Items(CX).Text.Substring(1)
            Else
                LV.Items(CX).ForeColor = Color.Black
                LV.Items(CX).Text = "○" & LV.Items(CX).Text.Substring(1)
            End If
        Next
    End Sub

    ' 事件：C34模擬：目前水溫【數值】被變更
    Private Sub Sim_NUD_C34_Temperature_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Sim_C34_Temperature.ValueChanged
        C34_Sim_Temperature = CByte(NUD_Sim_C34_Temperature.Value)
    End Sub

    ' 事件：S3X模擬：更改水溫【按鈕】被按下
    Private Sub Sim_S3X_SetTemperatureButton_Click(sender As Object, e As EventArgs)
        Dim BT As Button = DirectCast(sender, Button)

        If S3X_Sim_SetTemperature(CInt(BT.Tag)) = 0 Then
            BT.ForeColor = Color.Red
            S3X_Sim_SetTemperature(CInt(BT.Tag)) = CByte(UI_Sim_NUD_SetTemperature(CInt(BT.Tag)).Value)
        Else
            BT.ForeColor = Color.Black
            S3X_Sim_SetTemperature(CInt(BT.Tag)) = 0
        End If
    End Sub

    ' 事件：S3X模擬：強制加熱【按鈕】被按下
    Private Sub Sim_S3X_ForcedHeatingButton_Click(sender As Object, e As EventArgs)
        Dim BT As Button = DirectCast(sender, Button)

        If S3X_Sim_ForcedHeating(CInt(BT.Tag)) = HeadingCommand.None Then
            BT.ForeColor = Color.Red
            S3X_Sim_ForcedHeating(CInt(BT.Tag)) = HeadingCommand.Active
        Else
            BT.ForeColor = Color.Black
            S3X_Sim_ForcedHeating(CInt(BT.Tag)) = HeadingCommand.None
        End If
    End Sub

    ' 顯示 Log 訊息
    Private Sub DisplayLogMessage(ByVal Data As Byte())
        Dim Index As Integer = PollingCommand.IndexOf(Data(0))
        Dim Str As String = ""
        Dim CX As Integer
        Dim DT As DateTime = Now()

        Str = String.Format("[{0:HH:mm:ss}] ", DT)
        Str &= String.Format("{0:X2} {1:X2} ,", Data(0), Data(1))
        If Data.Count > 3 Then
            Str &= String.Format("{0:X2} {1:X2} {2:X2} ,", Data(2), Data(3), Data(4))
            For CX = 5 To Data.Count - 1
                Str &= String.Format("{0:X2} ", Data(CX))
            Next
        Else
            Str &= String.Format("{0:X2}", Data(2))
        End If

        ListBox_LogMessage.Items.Add(Str)
        If ListBox_LogMessage.Items.Count > 100 Then    ' 最多只保留 100 筆 Log 訊息
            ListBox_LogMessage.Items.RemoveAt(0)
        End If
        ListBox_LogMessage.SelectedIndex = ListBox_LogMessage.Items.Count - 1

    End Sub

    ' Log 檔案輸出
    Private Sub LogFileOutput(ByVal Data As Byte())
        Dim Index As Integer = PollingCommand.IndexOf(Data(0))
        Dim sw As StreamWriter
        Dim fn As String = Application.StartupPath & "\39-Log.csv"
        Dim Str As String = ""
        Dim CX As Integer
        Dim DT As DateTime = Now()

        Str = String.Format("=""{0:yyyy-MM-dd}"",=""{1:HH:mm:ss}"",", DT, DT)
        Str &= String.Format("{0},", SlaveName(Index))
        If Data.Count > 3 And Index = SlaveIndex.C34 Then
            Str &= String.Format("{0},{1},", Data(6), IIf((Data(9) And &H10) > 0, "●", ""))
        Else
            Str &= ",,"
        End If
        Str &= String.Format("{0:X2} {1:X2},", Data(0), Data(1))
        If Data.Count > 3 Then
            Str &= String.Format("{0:X2} {1:X2} {2:X2},", Data(2), Data(3), Data(4))
            For CX = 5 To Data.Count - 1
                Str &= String.Format("{0:X2} ", Data(CX))
            Next
        Else
            Str &= String.Format("=""{0:X2}"",", Data(2))
        End If

        If File.Exists(fn) Then
            Try
                sw = My.Computer.FileSystem.OpenTextFileWriter(fn, True)
                sw.WriteLine(Str)
                sw.Close()
            Catch ex As Exception
                MsgBox("寫入 39-Log.csv 發生錯誤")
            End Try
        Else
            sw = My.Computer.FileSystem.OpenTextFileWriter(fn, True)
            sw.WriteLine("日期,時間,設備,目前水溫,加熱中,輪詢,設備ID,資料")
            sw.WriteLine(Str)
            sw.Close()
        End If

    End Sub

    ' UI：避免 ListView 顯示選取的反白項目
    Private Sub ListView_Sys_StatusCode_DrawItem(sender As Object, e As DrawListViewItemEventArgs)
        e.DrawBackground()
        e.DrawText()
    End Sub

    ' 事件：計時器：接收資料閃燈
    Private Sub Timer_RX_Blink_Tick(sender As Object, e As EventArgs) Handles Timer_RX_Blink.Tick

        If Event_DataReceiving = True And CInt(TSSL_RX_Blink.Tag) = 0 Then
            TSSL_RX_Blink.Tag = 2
        End If

        With TSSL_RX_Blink
            Select Case CInt(.Tag)
                Case 2
                    .Text = "●"
                    .ForeColor = Color.GreenYellow
                    .Tag = 1
                Case 1
                    .Text = "○"
                    .ForeColor = Color.Black
                    .Tag = 0
                    Event_DataReceiving = False
                Case 0
            End Select
        End With


        If PacketErrorCount <> CInt(TSSL_ErrorCount.Tag) Then
            TSSL_ErrorCount.Text = PacketErrorCount.ToString()
            TSSL_ErrorCount.Tag = PacketErrorCount
        End If

    End Sub

    ' 事件：計時器：處理 Log 資料
    Private Sub Timer_ProcessLogData_Tick(sender As Object, e As EventArgs) Handles Timer_ProcessLogData.Tick
        If LogData.Count > 0 Then
            DisplayLogData(LogData(0))
            LogFileOutput(LogData(0))
            DisplayLogMessage(LogData(0))
            TSSL_WF_Count.Text = (CInt(TSSL_WF_Count.Text) + 1).ToString()
            If CInt(TSSL_WF_Blink.Tag) = 0 Then
                TSSL_WF_Blink.Tag = 2
            End If
            LogData.RemoveAt(0)
        End If

        With TSSL_WF_Blink
            Select Case CInt(.Tag)
                Case 2
                    .Text = "●"
                    .ForeColor = Color.Red
                    .Tag = 1
                Case 1
                    .Text = "○"
                    .ForeColor = Color.Black
                    .Tag = 0
                Case 0
            End Select
        End With


    End Sub

    ' 事件：計時器：顯示日期時間
    Private Sub Timer_DateTime_Tick(sender As Object, e As EventArgs) Handles Timer_DateTime.Tick
        LB_NowDate.Text = Now().ToString("yyyy-MM-dd")
        LB_NowTime.Text = Now().ToString("HH:mm:ss")
    End Sub

    ' Comport：ReceivedData 資料讀取
    Private Sub ReceivedData_Read()
        Dim RX_Count As Integer
        Dim RX_Buff(64) As Byte
        Dim CX As Integer

        RX_Count = ComPort.BytesToRead
        If RX_Count > 0 Then
            If Event_DataReceiving = False Then
                Event_DataReceiving = True
            End If

            If RX_Count > RX_Buff.Length Then
                Array.Resize(RX_Buff, RX_Count)
            End If
            ComPort.Read(RX_Buff, 0, RX_Count)
            For CX = 0 To RX_Count - 1
                ProtocolCheck(RX_Buff(CX))
            Next
        End If
    End Sub

    ' ComPort：資料接收：事件模式
    Private Sub ComPort_DataReceived_EventMode(sender As Object, e As SerialDataReceivedEventArgs)

        If ComPortReceiving = True Then
            MsgBox("ComPort_DataReceived 事件重複!")
            Exit Sub
        End If

        ComPortReceiving = True
        ReceivedData_Read()
        ComPortReceiving = False
    End Sub

    ' ComPort：資料接收：執行緒模式
    Private Sub ComPort_DataReceived_ThreadMode()
        While (ComPortReceiving = True)
            ReceivedData_Read()
            Thread.Sleep(20)
        End While
        ComPort.Close()
    End Sub

    ' 工作列圖示內顯示文字
    Private Sub Notifyicon_DrawText(ByVal NI As NotifyIcon, ByVal text As String)
        Const IconSize As Integer = 32
        'Dim Bitmap As Bitmap = New Bitmap(16, 16, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim myBitmap As Bitmap = New Bitmap(IconSize, IconSize, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim myGraphics As Graphics = Graphics.FromImage(myBitmap)
        'Dim drawFont As System.Drawing.Font = New System.Drawing.Font("Consolas", 9, FontStyle.Bold)
        Dim drawFont As System.Drawing.Font = New System.Drawing.Font("Consolas", IconSize / 2, System.Drawing.FontStyle.Regular)
        Dim drawBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Color.Red)
        Dim drawStringSize As SizeF = New SizeF()
        '------------------------------------------
        'Measure the Copyright string in this Font
        drawStringSize = myGraphics.MeasureString(text, drawFont)
        '------------------------------------------
        myGraphics.Clear(Color.Yellow)
        '------------------------------------------
        'Graphics.DrawString(text, drawFont, drawBrush, 16 / 2 - drawStringSize.Width / 2, 16 / 2 - drawStringSize.Height / 2)
        myGraphics.DrawString(text, drawFont, drawBrush, CInt(IconSize / 2 - drawStringSize.Width / 2), CInt(IconSize / 2 - drawStringSize.Height / 2))
        '------------------------------------------
        If (NI.Icon IsNot Nothing) Then
            NI.Icon.Dispose()
        End If
        '------------------------------------------
        Dim HIcon As System.IntPtr = myBitmap.GetHicon()
        Dim newIcon As Icon = System.Drawing.Icon.FromHandle(HIcon)
        NI.Icon = newIcon
        DestroyIcon(newIcon.Handle)
        '------------------------------------------
    End Sub

    ' 使用處置原始圖示的 DestroyIcon Win32 API，以確保會釋放資源中的方法
    ' https://msdn.microsoft.com/zh-tw/library/system.drawing.icon.fromhandle(v=vs.110).aspx

    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    ' 工作列中顯示氣球提示
    Private Sub NotifyIcon_ShowBalloonTip(ByVal Title As String, ByVal Text As String)
        NotifyIcon_39.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon_39.BalloonTipTitle = Title
        NotifyIcon_39.BalloonTipText = Text
        NotifyIcon_39.ShowBalloonTip(1000)
        'NotifyIcon_39.Visible = False   ' 先 Visible = False
        'NotifyIcon_39.Visible = True    ' 再 Visible = True 避免疊一堆訊息沒消掉
    End Sub

    ' 事件：通知區域圖示被滑鼠連點
    Private Sub NotifyIcon_39_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_39.MouseDoubleClick
        'Me.Visible = True
        Me.Show()
        WindowState = FormWindowState.Normal
    End Sub

End Class