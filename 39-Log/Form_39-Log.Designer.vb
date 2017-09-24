<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_39_Log
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_39_Log))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewItem97 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.8：感溫棒異常")
        Dim ListViewItem98 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.7：加熱管失效")
        Dim ListViewItem99 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.6：未知 #6")
        Dim ListViewItem100 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.5：加熱中")
        Dim ListViewItem101 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.4：繼電器開路")
        Dim ListViewItem102 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.3：水位")
        Dim ListViewItem103 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.2：水位")
        Dim ListViewItem104 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.1：水位")
        Dim ListViewItem105 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.8：控制箱未連線")
        Dim ListViewItem106 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.7：溫度異常")
        Dim ListViewItem107 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.6：無法加熱")
        Dim ListViewItem108 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.5：未知 #5")
        Dim ListViewItem109 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.4：加熱中")
        Dim ListViewItem110 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.3：強制加熱模式")
        Dim ListViewItem111 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.2：水位過低")
        Dim ListViewItem112 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.1：未知 #1")
        Dim ListViewItem113 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.8：控制箱未連線")
        Dim ListViewItem114 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.7：溫度異常")
        Dim ListViewItem115 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.6：無法加熱")
        Dim ListViewItem116 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.5：未知 #5")
        Dim ListViewItem117 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.4：加熱中")
        Dim ListViewItem118 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.3：強制加熱模式")
        Dim ListViewItem119 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.2：水位過低")
        Dim ListViewItem120 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.1：未知 #1")
        Dim ListViewItem121 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.8：控制箱未連線")
        Dim ListViewItem122 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.7：溫度異常")
        Dim ListViewItem123 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.6：無法加熱")
        Dim ListViewItem124 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.5：未知 #5")
        Dim ListViewItem125 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.4：加熱中")
        Dim ListViewItem126 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.3：強制加熱模式")
        Dim ListViewItem127 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.2：水位過低")
        Dim ListViewItem128 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("○.1：未知 #1")
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComPort = New System.IO.Ports.SerialPort(Me.components)
        Me.NotifyIcon_39 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DataSet_Polling = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.StatusStrip_39 = New System.Windows.Forms.StatusStrip()
        Me.TSSL_RX_Blink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_WF_Blink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_WF_Count = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_ErrorCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_RX_Blink = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ProcessLogData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox_LogMessage = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LB_NowDate = New System.Windows.Forms.Label()
        Me.LB_NowTime = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GB_S33 = New System.Windows.Forms.GroupBox()
        Me.BT_Sim_S33_SetTemperature = New System.Windows.Forms.Button()
        Me.NUD_Sim_S33_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.BT_Sim_S33_HeatingButton = New System.Windows.Forms.Button()
        Me.GB_S31 = New System.Windows.Forms.GroupBox()
        Me.BT_Sim_S31_SetTemperature = New System.Windows.Forms.Button()
        Me.NUD_Sim_S31_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.BT_Sim_S31_HeatingButton = New System.Windows.Forms.Button()
        Me.GB_S32 = New System.Windows.Forms.GroupBox()
        Me.BT_Sim_S32_SetTemperature = New System.Windows.Forms.Button()
        Me.NUD_Sim_S32_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.BT_Sim_S32_HeatingButton = New System.Windows.Forms.Button()
        Me.BT_Exit = New System.Windows.Forms.Button()
        Me.GB_SimSlave = New System.Windows.Forms.GroupBox()
        Me.CLB_SimSlave = New System.Windows.Forms.CheckedListBox()
        Me.GB_C34 = New System.Windows.Forms.GroupBox()
        Me.NUD_Sim_C34_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.CLB_Sim_C34_StatusCode = New System.Windows.Forms.CheckedListBox()
        Me.NUD_Sim_C34_StatusCode = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BT_ComPort = New System.Windows.Forms.Button()
        Me.DataGridView_S3X = New System.Windows.Forms.DataGridView()
        Me.S3X_設備 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_日期 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_輪詢 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_設備ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_加熱命令 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_更改水溫 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_目前水溫 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_水溫設定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3X_主機狀態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LV_Sys_C34_StatusCode = New System.Windows.Forms.ListView()
        Me.NUD_Sys_C34_StatusCode = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_Sys_C34_NowTemperature = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LV_Sys_S33_StatusCode = New System.Windows.Forms.ListView()
        Me.NUD_Sys_S33_StatusCode = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB_Sys_S33_SetTemperature = New System.Windows.Forms.Label()
        Me.LB_Sys_S33_NowTemperature = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_Sys_S31_StatusCode = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LV_Sys_S31_StatusCode = New System.Windows.Forms.ListView()
        Me.LB_Sys_S31_NowTemperature = New System.Windows.Forms.Label()
        Me.LB_Sys_S31_SetTemperature = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LV_Sys_S32_StatusCode = New System.Windows.Forms.ListView()
        Me.NUD_Sys_S32_StatusCode = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LB_Sys_S32_SetTemperature = New System.Windows.Forms.Label()
        Me.LB_Sys_S32_NowTemperature = New System.Windows.Forms.Label()
        Me.GB_ComPort = New System.Windows.Forms.GroupBox()
        Me.CheckBox_ComPortThread = New System.Windows.Forms.CheckBox()
        Me.ComboBox_ComPortConfig = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ComPortName = New System.Windows.Forms.ComboBox()
        Me.DataGridView_C34 = New System.Windows.Forms.DataGridView()
        Me.C34_設備 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_日期 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_輪詢 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_設備ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_目前水溫 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_控制箱狀態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_功能5A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C34_加熱命令 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet_Polling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip_39.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GB_S33.SuspendLayout()
        CType(Me.NUD_Sim_S33_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_S31.SuspendLayout()
        CType(Me.NUD_Sim_S31_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_S32.SuspendLayout()
        CType(Me.NUD_Sim_S32_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_SimSlave.SuspendLayout()
        Me.GB_C34.SuspendLayout()
        CType(Me.NUD_Sim_C34_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Sim_C34_StatusCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_S3X, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_Sys_C34_StatusCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_Sys_S33_StatusCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NUD_Sys_S31_StatusCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUD_Sys_S32_StatusCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ComPort.SuspendLayout()
        CType(Me.DataGridView_C34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComPort
        '
        Me.ComPort.Parity = System.IO.Ports.Parity.Even
        Me.ComPort.PortName = "COM2"
        '
        'NotifyIcon_39
        '
        Me.NotifyIcon_39.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_39.Icon = CType(resources.GetObject("NotifyIcon_39.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_39.Text = "滑鼠連點開啟"
        Me.NotifyIcon_39.Visible = True
        '
        'DataSet_Polling
        '
        Me.DataSet_Polling.DataSetName = "NewDataSet"
        Me.DataSet_Polling.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn21, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn22, Me.DataColumn24})
        Me.DataTable1.TableName = "Table_C34"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "日期"
        Me.DataColumn1.DataType = GetType(Date)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "時間"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "輪詢"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "設備ID"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "目前水溫"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "控制箱狀態"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "功能44"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "功能55"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "功能56"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "功能57"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "功能58"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "功能59"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "功能5A"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "加熱命令"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "設備"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn23, Me.DataColumn25})
        Me.DataTable2.TableName = "Table_S3X"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "日期"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "時間"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "輪詢"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "設備ID"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "加熱命令"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "更改水溫"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "目前水溫"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "水溫設定"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "主機狀態"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "設備"
        '
        'StatusStrip_39
        '
        Me.StatusStrip_39.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StatusStrip_39.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_RX_Blink, Me.ToolStripStatusLabel1, Me.TSSL_WF_Blink, Me.ToolStripStatusLabel2, Me.TSSL_WF_Count, Me.ToolStripStatusLabel3, Me.TSSL_ErrorCount})
        Me.StatusStrip_39.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip_39.Name = "StatusStrip_39"
        Me.StatusStrip_39.Size = New System.Drawing.Size(781, 22)
        Me.StatusStrip_39.TabIndex = 27
        Me.StatusStrip_39.Text = "StatusStrip1"
        '
        'TSSL_RX_Blink
        '
        Me.TSSL_RX_Blink.Name = "TSSL_RX_Blink"
        Me.TSSL_RX_Blink.Size = New System.Drawing.Size(24, 17)
        Me.TSSL_RX_Blink.Text = "○"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel1.Text = "接收資料     "
        '
        'TSSL_WF_Blink
        '
        Me.TSSL_WF_Blink.Name = "TSSL_WF_Blink"
        Me.TSSL_WF_Blink.Size = New System.Drawing.Size(24, 17)
        Me.TSSL_WF_Blink.Text = "○"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel2.Text = "寫LOG檔："
        '
        'TSSL_WF_Count
        '
        Me.TSSL_WF_Count.Name = "TSSL_WF_Count"
        Me.TSSL_WF_Count.Size = New System.Drawing.Size(16, 17)
        Me.TSSL_WF_Count.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(108, 17)
        Me.ToolStripStatusLabel3.Text = "     錯誤封包："
        '
        'TSSL_ErrorCount
        '
        Me.TSSL_ErrorCount.Name = "TSSL_ErrorCount"
        Me.TSSL_ErrorCount.Size = New System.Drawing.Size(16, 17)
        Me.TSSL_ErrorCount.Text = "0"
        '
        'Timer_RX_Blink
        '
        Me.Timer_RX_Blink.Enabled = True
        Me.Timer_RX_Blink.Interval = 500
        Me.Timer_RX_Blink.Tag = "0"
        '
        'Timer_ProcessLogData
        '
        Me.Timer_ProcessLogData.Enabled = True
        '
        'Timer_DateTime
        '
        Me.Timer_DateTime.Enabled = True
        Me.Timer_DateTime.Interval = 1000
        '
        'ListBox_LogMessage
        '
        Me.ListBox_LogMessage.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_LogMessage.FormattingEnabled = True
        Me.ListBox_LogMessage.Location = New System.Drawing.Point(12, 514)
        Me.ListBox_LogMessage.Name = "ListBox_LogMessage"
        Me.ListBox_LogMessage.Size = New System.Drawing.Size(607, 108)
        Me.ListBox_LogMessage.TabIndex = 51
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LB_NowDate)
        Me.GroupBox5.Controls.Add(Me.LB_NowTime)
        Me.GroupBox5.Location = New System.Drawing.Point(604, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 92)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "【現在時間】"
        '
        'LB_NowDate
        '
        Me.LB_NowDate.AutoSize = True
        Me.LB_NowDate.Font = New System.Drawing.Font("新細明體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_NowDate.ForeColor = System.Drawing.Color.Blue
        Me.LB_NowDate.Location = New System.Drawing.Point(6, 18)
        Me.LB_NowDate.Name = "LB_NowDate"
        Me.LB_NowDate.Size = New System.Drawing.Size(153, 29)
        Me.LB_NowDate.TabIndex = 43
        Me.LB_NowDate.Text = "0000-00-00"
        '
        'LB_NowTime
        '
        Me.LB_NowTime.AutoSize = True
        Me.LB_NowTime.Font = New System.Drawing.Font("新細明體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_NowTime.ForeColor = System.Drawing.Color.Red
        Me.LB_NowTime.Location = New System.Drawing.Point(25, 60)
        Me.LB_NowTime.Name = "LB_NowTime"
        Me.LB_NowTime.Size = New System.Drawing.Size(121, 29)
        Me.LB_NowTime.TabIndex = 1
        Me.LB_NowTime.Text = "00:00:00"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GB_S33)
        Me.GroupBox8.Controls.Add(Me.GB_S31)
        Me.GroupBox8.Controls.Add(Me.GB_S32)
        Me.GroupBox8.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(147, 411)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(461, 97)
        Me.GroupBox8.TabIndex = 49
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "【模擬】"
        '
        'GB_S33
        '
        Me.GB_S33.Controls.Add(Me.BT_Sim_S33_SetTemperature)
        Me.GB_S33.Controls.Add(Me.NUD_Sim_S33_Temperature)
        Me.GB_S33.Controls.Add(Me.BT_Sim_S33_HeatingButton)
        Me.GB_S33.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_S33.Location = New System.Drawing.Point(308, 21)
        Me.GB_S33.Name = "GB_S33"
        Me.GB_S33.Size = New System.Drawing.Size(145, 70)
        Me.GB_S33.TabIndex = 6
        Me.GB_S33.TabStop = False
        Me.GB_S33.Text = "【S33：子機-3】"
        '
        'BT_Sim_S33_SetTemperature
        '
        Me.BT_Sim_S33_SetTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.BT_Sim_S33_SetTemperature.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S33_SetTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_Sim_S33_SetTemperature.Location = New System.Drawing.Point(9, 17)
        Me.BT_Sim_S33_SetTemperature.Name = "BT_Sim_S33_SetTemperature"
        Me.BT_Sim_S33_SetTemperature.Size = New System.Drawing.Size(75, 19)
        Me.BT_Sim_S33_SetTemperature.TabIndex = 5
        Me.BT_Sim_S33_SetTemperature.Text = "更改水溫℃"
        Me.BT_Sim_S33_SetTemperature.UseVisualStyleBackColor = True
        '
        'NUD_Sim_S33_Temperature
        '
        Me.NUD_Sim_S33_Temperature.Location = New System.Drawing.Point(90, 17)
        Me.NUD_Sim_S33_Temperature.Maximum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.NUD_Sim_S33_Temperature.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_Sim_S33_Temperature.Name = "NUD_Sim_S33_Temperature"
        Me.NUD_Sim_S33_Temperature.Size = New System.Drawing.Size(43, 22)
        Me.NUD_Sim_S33_Temperature.TabIndex = 3
        Me.NUD_Sim_S33_Temperature.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'BT_Sim_S33_HeatingButton
        '
        Me.BT_Sim_S33_HeatingButton.BackColor = System.Drawing.SystemColors.Control
        Me.BT_Sim_S33_HeatingButton.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S33_HeatingButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_Sim_S33_HeatingButton.Location = New System.Drawing.Point(9, 42)
        Me.BT_Sim_S33_HeatingButton.Name = "BT_Sim_S33_HeatingButton"
        Me.BT_Sim_S33_HeatingButton.Size = New System.Drawing.Size(124, 19)
        Me.BT_Sim_S33_HeatingButton.TabIndex = 0
        Me.BT_Sim_S33_HeatingButton.Text = "強制加熱"
        Me.BT_Sim_S33_HeatingButton.UseVisualStyleBackColor = True
        '
        'GB_S31
        '
        Me.GB_S31.Controls.Add(Me.BT_Sim_S31_SetTemperature)
        Me.GB_S31.Controls.Add(Me.NUD_Sim_S31_Temperature)
        Me.GB_S31.Controls.Add(Me.BT_Sim_S31_HeatingButton)
        Me.GB_S31.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_S31.Location = New System.Drawing.Point(6, 21)
        Me.GB_S31.Name = "GB_S31"
        Me.GB_S31.Size = New System.Drawing.Size(145, 70)
        Me.GB_S31.TabIndex = 1
        Me.GB_S31.TabStop = False
        Me.GB_S31.Text = "【S31：子機-1】"
        '
        'BT_Sim_S31_SetTemperature
        '
        Me.BT_Sim_S31_SetTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.BT_Sim_S31_SetTemperature.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S31_SetTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_Sim_S31_SetTemperature.Location = New System.Drawing.Point(9, 17)
        Me.BT_Sim_S31_SetTemperature.Name = "BT_Sim_S31_SetTemperature"
        Me.BT_Sim_S31_SetTemperature.Size = New System.Drawing.Size(75, 19)
        Me.BT_Sim_S31_SetTemperature.TabIndex = 7
        Me.BT_Sim_S31_SetTemperature.Text = "更改水溫℃"
        Me.BT_Sim_S31_SetTemperature.UseVisualStyleBackColor = True
        '
        'NUD_Sim_S31_Temperature
        '
        Me.NUD_Sim_S31_Temperature.Location = New System.Drawing.Point(90, 17)
        Me.NUD_Sim_S31_Temperature.Maximum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.NUD_Sim_S31_Temperature.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_Sim_S31_Temperature.Name = "NUD_Sim_S31_Temperature"
        Me.NUD_Sim_S31_Temperature.Size = New System.Drawing.Size(43, 22)
        Me.NUD_Sim_S31_Temperature.TabIndex = 3
        Me.NUD_Sim_S31_Temperature.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'BT_Sim_S31_HeatingButton
        '
        Me.BT_Sim_S31_HeatingButton.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S31_HeatingButton.Location = New System.Drawing.Point(9, 42)
        Me.BT_Sim_S31_HeatingButton.Name = "BT_Sim_S31_HeatingButton"
        Me.BT_Sim_S31_HeatingButton.Size = New System.Drawing.Size(124, 19)
        Me.BT_Sim_S31_HeatingButton.TabIndex = 0
        Me.BT_Sim_S31_HeatingButton.Text = "強制加熱"
        Me.BT_Sim_S31_HeatingButton.UseVisualStyleBackColor = True
        '
        'GB_S32
        '
        Me.GB_S32.Controls.Add(Me.BT_Sim_S32_SetTemperature)
        Me.GB_S32.Controls.Add(Me.NUD_Sim_S32_Temperature)
        Me.GB_S32.Controls.Add(Me.BT_Sim_S32_HeatingButton)
        Me.GB_S32.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_S32.Location = New System.Drawing.Point(157, 21)
        Me.GB_S32.Name = "GB_S32"
        Me.GB_S32.Size = New System.Drawing.Size(145, 70)
        Me.GB_S32.TabIndex = 5
        Me.GB_S32.TabStop = False
        Me.GB_S32.Text = "【S32：子機-2】"
        '
        'BT_Sim_S32_SetTemperature
        '
        Me.BT_Sim_S32_SetTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.BT_Sim_S32_SetTemperature.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S32_SetTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_Sim_S32_SetTemperature.Location = New System.Drawing.Point(9, 17)
        Me.BT_Sim_S32_SetTemperature.Name = "BT_Sim_S32_SetTemperature"
        Me.BT_Sim_S32_SetTemperature.Size = New System.Drawing.Size(75, 19)
        Me.BT_Sim_S32_SetTemperature.TabIndex = 6
        Me.BT_Sim_S32_SetTemperature.Text = "更改水溫℃"
        Me.BT_Sim_S32_SetTemperature.UseVisualStyleBackColor = True
        '
        'NUD_Sim_S32_Temperature
        '
        Me.NUD_Sim_S32_Temperature.Location = New System.Drawing.Point(90, 17)
        Me.NUD_Sim_S32_Temperature.Maximum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.NUD_Sim_S32_Temperature.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_Sim_S32_Temperature.Name = "NUD_Sim_S32_Temperature"
        Me.NUD_Sim_S32_Temperature.Size = New System.Drawing.Size(43, 22)
        Me.NUD_Sim_S32_Temperature.TabIndex = 3
        Me.NUD_Sim_S32_Temperature.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'BT_Sim_S32_HeatingButton
        '
        Me.BT_Sim_S32_HeatingButton.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sim_S32_HeatingButton.Location = New System.Drawing.Point(9, 42)
        Me.BT_Sim_S32_HeatingButton.Name = "BT_Sim_S32_HeatingButton"
        Me.BT_Sim_S32_HeatingButton.Size = New System.Drawing.Size(124, 19)
        Me.BT_Sim_S32_HeatingButton.TabIndex = 0
        Me.BT_Sim_S32_HeatingButton.Text = "強制加熱"
        Me.BT_Sim_S32_HeatingButton.UseVisualStyleBackColor = True
        '
        'BT_Exit
        '
        Me.BT_Exit.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Exit.Location = New System.Drawing.Point(18, 378)
        Me.BT_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_Exit.Name = "BT_Exit"
        Me.BT_Exit.Size = New System.Drawing.Size(118, 20)
        Me.BT_Exit.TabIndex = 44
        Me.BT_Exit.Text = "離開"
        Me.BT_Exit.UseVisualStyleBackColor = True
        '
        'GB_SimSlave
        '
        Me.GB_SimSlave.BackColor = System.Drawing.SystemColors.Control
        Me.GB_SimSlave.Controls.Add(Me.CLB_SimSlave)
        Me.GB_SimSlave.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_SimSlave.Location = New System.Drawing.Point(12, 411)
        Me.GB_SimSlave.Name = "GB_SimSlave"
        Me.GB_SimSlave.Size = New System.Drawing.Size(129, 97)
        Me.GB_SimSlave.TabIndex = 41
        Me.GB_SimSlave.TabStop = False
        Me.GB_SimSlave.Text = "【模擬設備】"
        '
        'CLB_SimSlave
        '
        Me.CLB_SimSlave.BackColor = System.Drawing.SystemColors.Control
        Me.CLB_SimSlave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CLB_SimSlave.CheckOnClick = True
        Me.CLB_SimSlave.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CLB_SimSlave.FormattingEnabled = True
        Me.CLB_SimSlave.Items.AddRange(New Object() {"S31：子機【1】", "S32：子機【2】", "S33：子機【3】", "C34：控制箱"})
        Me.CLB_SimSlave.Location = New System.Drawing.Point(6, 21)
        Me.CLB_SimSlave.Name = "CLB_SimSlave"
        Me.CLB_SimSlave.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.CLB_SimSlave.Size = New System.Drawing.Size(117, 68)
        Me.CLB_SimSlave.TabIndex = 25
        '
        'GB_C34
        '
        Me.GB_C34.Controls.Add(Me.NUD_Sim_C34_Temperature)
        Me.GB_C34.Controls.Add(Me.CLB_Sim_C34_StatusCode)
        Me.GB_C34.Controls.Add(Me.NUD_Sim_C34_StatusCode)
        Me.GB_C34.Controls.Add(Me.Label6)
        Me.GB_C34.Controls.Add(Me.Label12)
        Me.GB_C34.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_C34.Location = New System.Drawing.Point(625, 411)
        Me.GB_C34.Name = "GB_C34"
        Me.GB_C34.Size = New System.Drawing.Size(145, 219)
        Me.GB_C34.TabIndex = 42
        Me.GB_C34.TabStop = False
        Me.GB_C34.Text = "【C34：控制箱】"
        '
        'NUD_Sim_C34_Temperature
        '
        Me.NUD_Sim_C34_Temperature.Location = New System.Drawing.Point(80, 189)
        Me.NUD_Sim_C34_Temperature.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sim_C34_Temperature.Name = "NUD_Sim_C34_Temperature"
        Me.NUD_Sim_C34_Temperature.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sim_C34_Temperature.TabIndex = 5
        Me.NUD_Sim_C34_Temperature.Tag = "50"
        Me.NUD_Sim_C34_Temperature.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'CLB_Sim_C34_StatusCode
        '
        Me.CLB_Sim_C34_StatusCode.CheckOnClick = True
        Me.CLB_Sim_C34_StatusCode.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.CLB_Sim_C34_StatusCode.FormattingEnabled = True
        Me.CLB_Sim_C34_StatusCode.Items.AddRange(New Object() {"8：感溫棒異常", "7：加熱管失效", "6：未知 #6", "5：加熱中", "4：繼電器開路", "3：水位", "2：水位", "1：水位"})
        Me.CLB_Sim_C34_StatusCode.Location = New System.Drawing.Point(5, 42)
        Me.CLB_Sim_C34_StatusCode.Name = "CLB_Sim_C34_StatusCode"
        Me.CLB_Sim_C34_StatusCode.Size = New System.Drawing.Size(134, 140)
        Me.CLB_Sim_C34_StatusCode.TabIndex = 1
        Me.CLB_Sim_C34_StatusCode.Tag = ""
        '
        'NUD_Sim_C34_StatusCode
        '
        Me.NUD_Sim_C34_StatusCode.Hexadecimal = True
        Me.NUD_Sim_C34_StatusCode.Location = New System.Drawing.Point(6, 14)
        Me.NUD_Sim_C34_StatusCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sim_C34_StatusCode.Name = "NUD_Sim_C34_StatusCode"
        Me.NUD_Sim_C34_StatusCode.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sim_C34_StatusCode.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "模擬狀態"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 12)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "模擬水溫 ℃"
        '
        'BT_ComPort
        '
        Me.BT_ComPort.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ComPort.Location = New System.Drawing.Point(18, 286)
        Me.BT_ComPort.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_ComPort.Name = "BT_ComPort"
        Me.BT_ComPort.Size = New System.Drawing.Size(118, 68)
        Me.BT_ComPort.TabIndex = 43
        Me.BT_ComPort.Text = "連線"
        Me.BT_ComPort.UseVisualStyleBackColor = True
        '
        'DataGridView_S3X
        '
        Me.DataGridView_S3X.AllowUserToAddRows = False
        Me.DataGridView_S3X.AllowUserToResizeRows = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.DataGridView_S3X.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView_S3X.AutoGenerateColumns = False
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_S3X.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView_S3X.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_S3X.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S3X_設備, Me.S3X_日期, Me.S3X_時間, Me.S3X_輪詢, Me.S3X_設備ID, Me.S3X_加熱命令, Me.S3X_更改水溫, Me.S3X_目前水溫, Me.S3X_水溫設定, Me.S3X_主機狀態})
        Me.DataGridView_S3X.DataSource = Me.DataSet_Polling
        Me.DataGridView_S3X.EnableHeadersVisualStyles = False
        Me.DataGridView_S3X.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView_S3X.MultiSelect = False
        Me.DataGridView_S3X.Name = "DataGridView_S3X"
        Me.DataGridView_S3X.ReadOnly = True
        Me.DataGridView_S3X.RowHeadersVisible = False
        Me.DataGridView_S3X.RowTemplate.Height = 24
        Me.DataGridView_S3X.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView_S3X.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_S3X.Size = New System.Drawing.Size(586, 92)
        Me.DataGridView_S3X.TabIndex = 46
        '
        'S3X_設備
        '
        Me.S3X_設備.DataPropertyName = "設備"
        Me.S3X_設備.HeaderText = "設備"
        Me.S3X_設備.Name = "S3X_設備"
        Me.S3X_設備.ReadOnly = True
        '
        'S3X_日期
        '
        Me.S3X_日期.DataPropertyName = "日期"
        Me.S3X_日期.HeaderText = "日期"
        Me.S3X_日期.Name = "S3X_日期"
        Me.S3X_日期.ReadOnly = True
        '
        'S3X_時間
        '
        Me.S3X_時間.DataPropertyName = "時間"
        Me.S3X_時間.HeaderText = "時間"
        Me.S3X_時間.Name = "S3X_時間"
        Me.S3X_時間.ReadOnly = True
        '
        'S3X_輪詢
        '
        Me.S3X_輪詢.DataPropertyName = "輪詢"
        Me.S3X_輪詢.HeaderText = "輪詢"
        Me.S3X_輪詢.Name = "S3X_輪詢"
        Me.S3X_輪詢.ReadOnly = True
        '
        'S3X_設備ID
        '
        Me.S3X_設備ID.DataPropertyName = "設備ID"
        Me.S3X_設備ID.HeaderText = "設備ID"
        Me.S3X_設備ID.Name = "S3X_設備ID"
        Me.S3X_設備ID.ReadOnly = True
        '
        'S3X_加熱命令
        '
        Me.S3X_加熱命令.DataPropertyName = "加熱命令"
        Me.S3X_加熱命令.HeaderText = "加熱命令"
        Me.S3X_加熱命令.Name = "S3X_加熱命令"
        Me.S3X_加熱命令.ReadOnly = True
        '
        'S3X_更改水溫
        '
        Me.S3X_更改水溫.DataPropertyName = "更改水溫"
        Me.S3X_更改水溫.HeaderText = "更改水溫"
        Me.S3X_更改水溫.Name = "S3X_更改水溫"
        Me.S3X_更改水溫.ReadOnly = True
        '
        'S3X_目前水溫
        '
        Me.S3X_目前水溫.DataPropertyName = "目前水溫"
        Me.S3X_目前水溫.HeaderText = "目前水溫"
        Me.S3X_目前水溫.Name = "S3X_目前水溫"
        Me.S3X_目前水溫.ReadOnly = True
        '
        'S3X_水溫設定
        '
        Me.S3X_水溫設定.DataPropertyName = "水溫設定"
        Me.S3X_水溫設定.HeaderText = "水溫設定"
        Me.S3X_水溫設定.Name = "S3X_水溫設定"
        Me.S3X_水溫設定.ReadOnly = True
        '
        'S3X_主機狀態
        '
        Me.S3X_主機狀態.DataPropertyName = "主機狀態"
        Me.S3X_主機狀態.HeaderText = "主機狀態"
        Me.S3X_主機狀態.Name = "S3X_主機狀態"
        Me.S3X_主機狀態.ReadOnly = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Location = New System.Drawing.Point(147, 157)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(623, 248)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "【系統狀態】"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LV_Sys_C34_StatusCode)
        Me.GroupBox1.Controls.Add(Me.NUD_Sys_C34_StatusCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LB_Sys_C34_NowTemperature)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 220)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "【C34：控制箱】"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "目前水溫"
        '
        'LV_Sys_C34_StatusCode
        '
        ListViewItem97.StateImageIndex = 0
        ListViewItem98.StateImageIndex = 0
        ListViewItem99.StateImageIndex = 0
        ListViewItem100.StateImageIndex = 0
        ListViewItem101.StateImageIndex = 0
        ListViewItem102.StateImageIndex = 0
        ListViewItem103.StateImageIndex = 0
        ListViewItem104.StateImageIndex = 0
        Me.LV_Sys_C34_StatusCode.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem97, ListViewItem98, ListViewItem99, ListViewItem100, ListViewItem101, ListViewItem102, ListViewItem103, ListViewItem104})
        Me.LV_Sys_C34_StatusCode.Location = New System.Drawing.Point(5, 46)
        Me.LV_Sys_C34_StatusCode.Name = "LV_Sys_C34_StatusCode"
        Me.LV_Sys_C34_StatusCode.OwnerDraw = True
        Me.LV_Sys_C34_StatusCode.Size = New System.Drawing.Size(134, 133)
        Me.LV_Sys_C34_StatusCode.TabIndex = 37
        Me.LV_Sys_C34_StatusCode.UseCompatibleStateImageBehavior = False
        Me.LV_Sys_C34_StatusCode.View = System.Windows.Forms.View.List
        '
        'NUD_Sys_C34_StatusCode
        '
        Me.NUD_Sys_C34_StatusCode.Hexadecimal = True
        Me.NUD_Sys_C34_StatusCode.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NUD_Sys_C34_StatusCode.Location = New System.Drawing.Point(5, 18)
        Me.NUD_Sys_C34_StatusCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sys_C34_StatusCode.Name = "NUD_Sys_C34_StatusCode"
        Me.NUD_Sys_C34_StatusCode.ReadOnly = True
        Me.NUD_Sys_C34_StatusCode.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sys_C34_StatusCode.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(53, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "控制箱狀態"
        '
        'LB_Sys_C34_NowTemperature
        '
        Me.LB_Sys_C34_NowTemperature.AutoSize = True
        Me.LB_Sys_C34_NowTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_C34_NowTemperature.ForeColor = System.Drawing.Color.Red
        Me.LB_Sys_C34_NowTemperature.Location = New System.Drawing.Point(20, 177)
        Me.LB_Sys_C34_NowTemperature.Name = "LB_Sys_C34_NowTemperature"
        Me.LB_Sys_C34_NowTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_C34_NowTemperature.TabIndex = 42
        Me.LB_Sys_C34_NowTemperature.Text = "--"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LV_Sys_S33_StatusCode)
        Me.GroupBox2.Controls.Add(Me.NUD_Sys_S33_StatusCode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LB_Sys_S33_SetTemperature)
        Me.GroupBox2.Controls.Add(Me.LB_Sys_S33_NowTemperature)
        Me.GroupBox2.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 220)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "【S33：子機-3】"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "目前水溫 水溫設定"
        '
        'LV_Sys_S33_StatusCode
        '
        ListViewItem105.StateImageIndex = 0
        ListViewItem106.StateImageIndex = 0
        ListViewItem107.StateImageIndex = 0
        ListViewItem108.StateImageIndex = 0
        ListViewItem109.StateImageIndex = 0
        ListViewItem110.StateImageIndex = 0
        ListViewItem111.StateImageIndex = 0
        ListViewItem112.StateImageIndex = 0
        Me.LV_Sys_S33_StatusCode.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem105, ListViewItem106, ListViewItem107, ListViewItem108, ListViewItem109, ListViewItem110, ListViewItem111, ListViewItem112})
        Me.LV_Sys_S33_StatusCode.Location = New System.Drawing.Point(5, 46)
        Me.LV_Sys_S33_StatusCode.Name = "LV_Sys_S33_StatusCode"
        Me.LV_Sys_S33_StatusCode.OwnerDraw = True
        Me.LV_Sys_S33_StatusCode.Size = New System.Drawing.Size(134, 133)
        Me.LV_Sys_S33_StatusCode.TabIndex = 40
        Me.LV_Sys_S33_StatusCode.UseCompatibleStateImageBehavior = False
        Me.LV_Sys_S33_StatusCode.View = System.Windows.Forms.View.List
        '
        'NUD_Sys_S33_StatusCode
        '
        Me.NUD_Sys_S33_StatusCode.Hexadecimal = True
        Me.NUD_Sys_S33_StatusCode.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NUD_Sys_S33_StatusCode.Location = New System.Drawing.Point(5, 18)
        Me.NUD_Sys_S33_StatusCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sys_S33_StatusCode.Name = "NUD_Sys_S33_StatusCode"
        Me.NUD_Sys_S33_StatusCode.ReadOnly = True
        Me.NUD_Sys_S33_StatusCode.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sys_S33_StatusCode.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(53, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 12)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "主機(P31)狀態"
        '
        'LB_Sys_S33_SetTemperature
        '
        Me.LB_Sys_S33_SetTemperature.AutoSize = True
        Me.LB_Sys_S33_SetTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S33_SetTemperature.ForeColor = System.Drawing.Color.Blue
        Me.LB_Sys_S33_SetTemperature.Location = New System.Drawing.Point(80, 177)
        Me.LB_Sys_S33_SetTemperature.Name = "LB_Sys_S33_SetTemperature"
        Me.LB_Sys_S33_SetTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S33_SetTemperature.TabIndex = 42
        Me.LB_Sys_S33_SetTemperature.Text = "--"
        '
        'LB_Sys_S33_NowTemperature
        '
        Me.LB_Sys_S33_NowTemperature.AutoSize = True
        Me.LB_Sys_S33_NowTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S33_NowTemperature.ForeColor = System.Drawing.Color.Red
        Me.LB_Sys_S33_NowTemperature.Location = New System.Drawing.Point(20, 177)
        Me.LB_Sys_S33_NowTemperature.Name = "LB_Sys_S33_NowTemperature"
        Me.LB_Sys_S33_NowTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S33_NowTemperature.TabIndex = 41
        Me.LB_Sys_S33_NowTemperature.Text = "--"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.NUD_Sys_S31_StatusCode)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.LV_Sys_S31_StatusCode)
        Me.GroupBox4.Controls.Add(Me.LB_Sys_S31_NowTemperature)
        Me.GroupBox4.Controls.Add(Me.LB_Sys_S31_SetTemperature)
        Me.GroupBox4.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 220)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "【S31：子機-1】"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "目前水溫 水溫設定"
        '
        'NUD_Sys_S31_StatusCode
        '
        Me.NUD_Sys_S31_StatusCode.Hexadecimal = True
        Me.NUD_Sys_S31_StatusCode.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NUD_Sys_S31_StatusCode.Location = New System.Drawing.Point(5, 18)
        Me.NUD_Sys_S31_StatusCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sys_S31_StatusCode.Name = "NUD_Sys_S31_StatusCode"
        Me.NUD_Sys_S31_StatusCode.ReadOnly = True
        Me.NUD_Sys_S31_StatusCode.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sys_S31_StatusCode.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(53, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 12)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "主機(P31)狀態"
        '
        'LV_Sys_S31_StatusCode
        '
        Me.LV_Sys_S31_StatusCode.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        ListViewItem113.StateImageIndex = 0
        ListViewItem114.StateImageIndex = 0
        ListViewItem115.StateImageIndex = 0
        ListViewItem116.StateImageIndex = 0
        ListViewItem117.StateImageIndex = 0
        ListViewItem118.StateImageIndex = 0
        ListViewItem119.StateImageIndex = 0
        ListViewItem120.StateImageIndex = 0
        Me.LV_Sys_S31_StatusCode.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem113, ListViewItem114, ListViewItem115, ListViewItem116, ListViewItem117, ListViewItem118, ListViewItem119, ListViewItem120})
        Me.LV_Sys_S31_StatusCode.Location = New System.Drawing.Point(5, 46)
        Me.LV_Sys_S31_StatusCode.Name = "LV_Sys_S31_StatusCode"
        Me.LV_Sys_S31_StatusCode.OwnerDraw = True
        Me.LV_Sys_S31_StatusCode.Size = New System.Drawing.Size(134, 133)
        Me.LV_Sys_S31_StatusCode.TabIndex = 39
        Me.LV_Sys_S31_StatusCode.UseCompatibleStateImageBehavior = False
        Me.LV_Sys_S31_StatusCode.View = System.Windows.Forms.View.List
        '
        'LB_Sys_S31_NowTemperature
        '
        Me.LB_Sys_S31_NowTemperature.AutoSize = True
        Me.LB_Sys_S31_NowTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S31_NowTemperature.ForeColor = System.Drawing.Color.Red
        Me.LB_Sys_S31_NowTemperature.Location = New System.Drawing.Point(20, 177)
        Me.LB_Sys_S31_NowTemperature.Name = "LB_Sys_S31_NowTemperature"
        Me.LB_Sys_S31_NowTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S31_NowTemperature.TabIndex = 0
        Me.LB_Sys_S31_NowTemperature.Text = "--"
        '
        'LB_Sys_S31_SetTemperature
        '
        Me.LB_Sys_S31_SetTemperature.AutoSize = True
        Me.LB_Sys_S31_SetTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S31_SetTemperature.ForeColor = System.Drawing.Color.Blue
        Me.LB_Sys_S31_SetTemperature.Location = New System.Drawing.Point(80, 177)
        Me.LB_Sys_S31_SetTemperature.Name = "LB_Sys_S31_SetTemperature"
        Me.LB_Sys_S31_SetTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S31_SetTemperature.TabIndex = 31
        Me.LB_Sys_S31_SetTemperature.Text = "--"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LV_Sys_S32_StatusCode)
        Me.GroupBox3.Controls.Add(Me.NUD_Sys_S32_StatusCode)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.LB_Sys_S32_SetTemperature)
        Me.GroupBox3.Controls.Add(Me.LB_Sys_S32_NowTemperature)
        Me.GroupBox3.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(157, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(145, 220)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "【S32：子機-2】"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "目前水溫 水溫設定"
        '
        'LV_Sys_S32_StatusCode
        '
        ListViewItem121.StateImageIndex = 0
        ListViewItem122.StateImageIndex = 0
        ListViewItem123.StateImageIndex = 0
        ListViewItem124.StateImageIndex = 0
        ListViewItem125.StateImageIndex = 0
        ListViewItem126.StateImageIndex = 0
        ListViewItem127.StateImageIndex = 0
        ListViewItem128.StateImageIndex = 0
        Me.LV_Sys_S32_StatusCode.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem121, ListViewItem122, ListViewItem123, ListViewItem124, ListViewItem125, ListViewItem126, ListViewItem127, ListViewItem128})
        Me.LV_Sys_S32_StatusCode.Location = New System.Drawing.Point(5, 46)
        Me.LV_Sys_S32_StatusCode.Name = "LV_Sys_S32_StatusCode"
        Me.LV_Sys_S32_StatusCode.OwnerDraw = True
        Me.LV_Sys_S32_StatusCode.Size = New System.Drawing.Size(134, 133)
        Me.LV_Sys_S32_StatusCode.TabIndex = 41
        Me.LV_Sys_S32_StatusCode.UseCompatibleStateImageBehavior = False
        Me.LV_Sys_S32_StatusCode.View = System.Windows.Forms.View.List
        '
        'NUD_Sys_S32_StatusCode
        '
        Me.NUD_Sys_S32_StatusCode.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NUD_Sys_S32_StatusCode.Hexadecimal = True
        Me.NUD_Sys_S32_StatusCode.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NUD_Sys_S32_StatusCode.Location = New System.Drawing.Point(5, 18)
        Me.NUD_Sys_S32_StatusCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUD_Sys_S32_StatusCode.Name = "NUD_Sys_S32_StatusCode"
        Me.NUD_Sys_S32_StatusCode.ReadOnly = True
        Me.NUD_Sys_S32_StatusCode.Size = New System.Drawing.Size(48, 22)
        Me.NUD_Sys_S32_StatusCode.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(53, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 12)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "主機(P31)狀態"
        '
        'LB_Sys_S32_SetTemperature
        '
        Me.LB_Sys_S32_SetTemperature.AutoSize = True
        Me.LB_Sys_S32_SetTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S32_SetTemperature.ForeColor = System.Drawing.Color.Blue
        Me.LB_Sys_S32_SetTemperature.Location = New System.Drawing.Point(80, 177)
        Me.LB_Sys_S32_SetTemperature.Name = "LB_Sys_S32_SetTemperature"
        Me.LB_Sys_S32_SetTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S32_SetTemperature.TabIndex = 43
        Me.LB_Sys_S32_SetTemperature.Text = "--"
        '
        'LB_Sys_S32_NowTemperature
        '
        Me.LB_Sys_S32_NowTemperature.AutoSize = True
        Me.LB_Sys_S32_NowTemperature.Font = New System.Drawing.Font("新細明體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LB_Sys_S32_NowTemperature.ForeColor = System.Drawing.Color.Red
        Me.LB_Sys_S32_NowTemperature.Location = New System.Drawing.Point(20, 177)
        Me.LB_Sys_S32_NowTemperature.Name = "LB_Sys_S32_NowTemperature"
        Me.LB_Sys_S32_NowTemperature.Size = New System.Drawing.Size(43, 37)
        Me.LB_Sys_S32_NowTemperature.TabIndex = 42
        Me.LB_Sys_S32_NowTemperature.Text = "--"
        '
        'GB_ComPort
        '
        Me.GB_ComPort.Controls.Add(Me.CheckBox_ComPortThread)
        Me.GB_ComPort.Controls.Add(Me.ComboBox_ComPortConfig)
        Me.GB_ComPort.Controls.Add(Me.ComboBox_ComPortName)
        Me.GB_ComPort.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ComPort.Location = New System.Drawing.Point(12, 157)
        Me.GB_ComPort.Name = "GB_ComPort"
        Me.GB_ComPort.Size = New System.Drawing.Size(129, 124)
        Me.GB_ComPort.TabIndex = 47
        Me.GB_ComPort.TabStop = False
        Me.GB_ComPort.Text = "【RS-485】"
        '
        'CheckBox_ComPortThread
        '
        Me.CheckBox_ComPortThread.AutoSize = True
        Me.CheckBox_ComPortThread.Location = New System.Drawing.Point(6, 95)
        Me.CheckBox_ComPortThread.Name = "CheckBox_ComPortThread"
        Me.CheckBox_ComPortThread.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox_ComPortThread.TabIndex = 17
        Me.CheckBox_ComPortThread.Text = "Thread 模式"
        Me.CheckBox_ComPortThread.UseVisualStyleBackColor = True
        '
        'ComboBox_ComPortConfig
        '
        Me.ComboBox_ComPortConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ComPortConfig.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_ComPortConfig.FormattingEnabled = True
        Me.ComboBox_ComPortConfig.Items.AddRange(New Object() {"9600, N-8-1", "9600, E-8-1", "9600, O-8-1"})
        Me.ComboBox_ComPortConfig.Location = New System.Drawing.Point(6, 57)
        Me.ComboBox_ComPortConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_ComPortConfig.Name = "ComboBox_ComPortConfig"
        Me.ComboBox_ComPortConfig.Size = New System.Drawing.Size(118, 20)
        Me.ComboBox_ComPortConfig.TabIndex = 16
        '
        'ComboBox_ComPortName
        '
        Me.ComboBox_ComPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ComPortName.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_ComPortName.FormattingEnabled = True
        Me.ComboBox_ComPortName.Location = New System.Drawing.Point(6, 20)
        Me.ComboBox_ComPortName.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_ComPortName.Name = "ComboBox_ComPortName"
        Me.ComboBox_ComPortName.Size = New System.Drawing.Size(118, 20)
        Me.ComboBox_ComPortName.Sorted = True
        Me.ComboBox_ComPortName.TabIndex = 7
        '
        'DataGridView_C34
        '
        Me.DataGridView_C34.AllowUserToAddRows = False
        Me.DataGridView_C34.AllowUserToResizeRows = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView_C34.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView_C34.AutoGenerateColumns = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle16.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_C34.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView_C34.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_C34.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C34_設備, Me.C34_日期, Me.C34_時間, Me.C34_輪詢, Me.C34_設備ID, Me.C34_目前水溫, Me.C34_控制箱狀態, Me.C34_功能44, Me.C34_功能55, Me.C34_功能56, Me.C34_功能57, Me.C34_功能58, Me.C34_功能59, Me.C34_功能5A, Me.C34_加熱命令})
        Me.DataGridView_C34.DataSource = Me.DataSet_Polling
        Me.DataGridView_C34.EnableHeadersVisualStyles = False
        Me.DataGridView_C34.Location = New System.Drawing.Point(12, 110)
        Me.DataGridView_C34.MultiSelect = False
        Me.DataGridView_C34.Name = "DataGridView_C34"
        Me.DataGridView_C34.ReadOnly = True
        Me.DataGridView_C34.RowHeadersVisible = False
        Me.DataGridView_C34.RowTemplate.Height = 24
        Me.DataGridView_C34.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView_C34.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_C34.Size = New System.Drawing.Size(758, 41)
        Me.DataGridView_C34.TabIndex = 45
        '
        'C34_設備
        '
        Me.C34_設備.DataPropertyName = "設備"
        Me.C34_設備.HeaderText = "設備"
        Me.C34_設備.Name = "C34_設備"
        Me.C34_設備.ReadOnly = True
        '
        'C34_日期
        '
        Me.C34_日期.DataPropertyName = "日期"
        Me.C34_日期.HeaderText = "日期"
        Me.C34_日期.Name = "C34_日期"
        Me.C34_日期.ReadOnly = True
        Me.C34_日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C34_時間
        '
        Me.C34_時間.DataPropertyName = "時間"
        Me.C34_時間.HeaderText = "時間"
        Me.C34_時間.Name = "C34_時間"
        Me.C34_時間.ReadOnly = True
        '
        'C34_輪詢
        '
        Me.C34_輪詢.DataPropertyName = "輪詢"
        Me.C34_輪詢.HeaderText = "輪詢"
        Me.C34_輪詢.Name = "C34_輪詢"
        Me.C34_輪詢.ReadOnly = True
        '
        'C34_設備ID
        '
        Me.C34_設備ID.DataPropertyName = "設備ID"
        Me.C34_設備ID.HeaderText = "設備ID"
        Me.C34_設備ID.Name = "C34_設備ID"
        Me.C34_設備ID.ReadOnly = True
        '
        'C34_目前水溫
        '
        Me.C34_目前水溫.DataPropertyName = "目前水溫"
        Me.C34_目前水溫.HeaderText = "目前水溫"
        Me.C34_目前水溫.Name = "C34_目前水溫"
        Me.C34_目前水溫.ReadOnly = True
        '
        'C34_控制箱狀態
        '
        Me.C34_控制箱狀態.DataPropertyName = "控制箱狀態"
        Me.C34_控制箱狀態.HeaderText = "控制箱狀態"
        Me.C34_控制箱狀態.Name = "C34_控制箱狀態"
        Me.C34_控制箱狀態.ReadOnly = True
        '
        'C34_功能44
        '
        Me.C34_功能44.DataPropertyName = "功能44"
        Me.C34_功能44.HeaderText = "# 44"
        Me.C34_功能44.Name = "C34_功能44"
        Me.C34_功能44.ReadOnly = True
        '
        'C34_功能55
        '
        Me.C34_功能55.DataPropertyName = "功能55"
        Me.C34_功能55.HeaderText = "# 55"
        Me.C34_功能55.Name = "C34_功能55"
        Me.C34_功能55.ReadOnly = True
        '
        'C34_功能56
        '
        Me.C34_功能56.DataPropertyName = "功能56"
        Me.C34_功能56.HeaderText = "# 56"
        Me.C34_功能56.Name = "C34_功能56"
        Me.C34_功能56.ReadOnly = True
        '
        'C34_功能57
        '
        Me.C34_功能57.DataPropertyName = "功能57"
        Me.C34_功能57.HeaderText = "# 57"
        Me.C34_功能57.Name = "C34_功能57"
        Me.C34_功能57.ReadOnly = True
        '
        'C34_功能58
        '
        Me.C34_功能58.DataPropertyName = "功能58"
        Me.C34_功能58.HeaderText = "# 58"
        Me.C34_功能58.Name = "C34_功能58"
        Me.C34_功能58.ReadOnly = True
        '
        'C34_功能59
        '
        Me.C34_功能59.DataPropertyName = "功能59"
        Me.C34_功能59.HeaderText = "# 59"
        Me.C34_功能59.Name = "C34_功能59"
        Me.C34_功能59.ReadOnly = True
        '
        'C34_功能5A
        '
        Me.C34_功能5A.DataPropertyName = "功能5A"
        Me.C34_功能5A.HeaderText = "# 5A"
        Me.C34_功能5A.Name = "C34_功能5A"
        Me.C34_功能5A.ReadOnly = True
        '
        'C34_加熱命令
        '
        Me.C34_加熱命令.DataPropertyName = "加熱命令"
        Me.C34_加熱命令.HeaderText = "加熱命令"
        Me.C34_加熱命令.Name = "C34_加熱命令"
        Me.C34_加熱命令.ReadOnly = True
        '
        'Form_39_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 654)
        Me.Controls.Add(Me.ListBox_LogMessage)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.BT_Exit)
        Me.Controls.Add(Me.GB_SimSlave)
        Me.Controls.Add(Me.GB_C34)
        Me.Controls.Add(Me.BT_ComPort)
        Me.Controls.Add(Me.DataGridView_S3X)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GB_ComPort)
        Me.Controls.Add(Me.DataGridView_C34)
        Me.Controls.Add(Me.StatusStrip_39)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_39_Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "39-Log"
        CType(Me.DataSet_Polling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip_39.ResumeLayout(False)
        Me.StatusStrip_39.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GB_S33.ResumeLayout(False)
        CType(Me.NUD_Sim_S33_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_S31.ResumeLayout(False)
        CType(Me.NUD_Sim_S31_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_S32.ResumeLayout(False)
        CType(Me.NUD_Sim_S32_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_SimSlave.ResumeLayout(False)
        Me.GB_C34.ResumeLayout(False)
        Me.GB_C34.PerformLayout()
        CType(Me.NUD_Sim_C34_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Sim_C34_StatusCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_S3X, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_Sys_C34_StatusCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_Sys_S33_StatusCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NUD_Sys_S31_StatusCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUD_Sys_S32_StatusCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ComPort.ResumeLayout(False)
        Me.GB_ComPort.PerformLayout()
        CType(Me.DataGridView_C34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComPort As IO.Ports.SerialPort
    Friend WithEvents NotifyIcon_39 As NotifyIcon
    Friend WithEvents DataSet_Polling As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn21 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents DataColumn22 As DataColumn
    Friend WithEvents DataColumn24 As DataColumn
    Friend WithEvents DataTable2 As DataTable
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents DataColumn14 As DataColumn
    Friend WithEvents DataColumn15 As DataColumn
    Friend WithEvents DataColumn16 As DataColumn
    Friend WithEvents DataColumn17 As DataColumn
    Friend WithEvents DataColumn18 As DataColumn
    Friend WithEvents DataColumn19 As DataColumn
    Friend WithEvents DataColumn20 As DataColumn
    Friend WithEvents DataColumn23 As DataColumn
    Friend WithEvents DataColumn25 As DataColumn
    Friend WithEvents StatusStrip_39 As StatusStrip
    Friend WithEvents TSSL_RX_Blink As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSSL_WF_Blink As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TSSL_WF_Count As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents TSSL_ErrorCount As ToolStripStatusLabel
    Friend WithEvents Timer_RX_Blink As Timer
    Friend WithEvents Timer_ProcessLogData As Timer
    Friend WithEvents Timer_DateTime As Timer
    Friend WithEvents ListBox_LogMessage As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LB_NowDate As Label
    Friend WithEvents LB_NowTime As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GB_S33 As GroupBox
    Friend WithEvents BT_Sim_S33_SetTemperature As Button
    Friend WithEvents NUD_Sim_S33_Temperature As NumericUpDown
    Friend WithEvents BT_Sim_S33_HeatingButton As Button
    Friend WithEvents GB_S31 As GroupBox
    Friend WithEvents BT_Sim_S31_SetTemperature As Button
    Friend WithEvents NUD_Sim_S31_Temperature As NumericUpDown
    Friend WithEvents BT_Sim_S31_HeatingButton As Button
    Friend WithEvents GB_S32 As GroupBox
    Friend WithEvents BT_Sim_S32_SetTemperature As Button
    Friend WithEvents NUD_Sim_S32_Temperature As NumericUpDown
    Friend WithEvents BT_Sim_S32_HeatingButton As Button
    Friend WithEvents BT_Exit As Button
    Friend WithEvents GB_SimSlave As GroupBox
    Friend WithEvents CLB_SimSlave As CheckedListBox
    Friend WithEvents GB_C34 As GroupBox
    Friend WithEvents NUD_Sim_C34_Temperature As NumericUpDown
    Friend WithEvents CLB_Sim_C34_StatusCode As CheckedListBox
    Friend WithEvents NUD_Sim_C34_StatusCode As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BT_ComPort As Button
    Friend WithEvents DataGridView_S3X As DataGridView
    Friend WithEvents S3X_設備 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_日期 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_時間 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_輪詢 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_設備ID As DataGridViewTextBoxColumn
    Friend WithEvents S3X_加熱命令 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_更改水溫 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_目前水溫 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_水溫設定 As DataGridViewTextBoxColumn
    Friend WithEvents S3X_主機狀態 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LV_Sys_C34_StatusCode As ListView
    Friend WithEvents NUD_Sys_C34_StatusCode As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_Sys_C34_NowTemperature As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LV_Sys_S33_StatusCode As ListView
    Friend WithEvents NUD_Sys_S33_StatusCode As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents LB_Sys_S33_SetTemperature As Label
    Friend WithEvents LB_Sys_S33_NowTemperature As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NUD_Sys_S31_StatusCode As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents LV_Sys_S31_StatusCode As ListView
    Friend WithEvents LB_Sys_S31_NowTemperature As Label
    Friend WithEvents LB_Sys_S31_SetTemperature As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LV_Sys_S32_StatusCode As ListView
    Friend WithEvents NUD_Sys_S32_StatusCode As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents LB_Sys_S32_SetTemperature As Label
    Friend WithEvents LB_Sys_S32_NowTemperature As Label
    Friend WithEvents GB_ComPort As GroupBox
    Friend WithEvents CheckBox_ComPortThread As CheckBox
    Friend WithEvents ComboBox_ComPortConfig As ComboBox
    Friend WithEvents ComboBox_ComPortName As ComboBox
    Friend WithEvents DataGridView_C34 As DataGridView
    Friend WithEvents C34_設備 As DataGridViewTextBoxColumn
    Friend WithEvents C34_日期 As DataGridViewTextBoxColumn
    Friend WithEvents C34_時間 As DataGridViewTextBoxColumn
    Friend WithEvents C34_輪詢 As DataGridViewTextBoxColumn
    Friend WithEvents C34_設備ID As DataGridViewTextBoxColumn
    Friend WithEvents C34_目前水溫 As DataGridViewTextBoxColumn
    Friend WithEvents C34_控制箱狀態 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能44 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能55 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能56 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能57 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能58 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能59 As DataGridViewTextBoxColumn
    Friend WithEvents C34_功能5A As DataGridViewTextBoxColumn
    Friend WithEvents C34_加熱命令 As DataGridViewTextBoxColumn
End Class
