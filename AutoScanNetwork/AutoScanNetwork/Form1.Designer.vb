<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.btnHelp = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnOpen = New System.Windows.Forms.RibbonButton()
        Me.btnClose = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.btnSchScan = New System.Windows.Forms.RibbonButton()
        Me.btnOthScan = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.btnFiveDaysLogShow = New System.Windows.Forms.RibbonButton()
        Me.btnTenDaysLogShow = New System.Windows.Forms.RibbonButton()
        Me.btnCustomLogShow = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.btnFiveDaysLogAnalyze = New System.Windows.Forms.RibbonButton()
        Me.btnTenDAysLogAnalyze = New System.Windows.Forms.RibbonButton()
        Me.btnCustomLogAnalyze = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab4 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.btnCheckConnectivity = New System.Windows.Forms.RibbonButton()
        Me.btnGetMacAddress = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel6 = New System.Windows.Forms.RibbonPanel()
        Me.btnExport = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab5 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel7 = New System.Windows.Forms.RibbonPanel()
        Me.btnHelpRbn = New System.Windows.Forms.RibbonButton()
        Me.btnAbout = New System.Windows.Forms.RibbonButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblNno1 = New System.Windows.Forms.Label()
        Me.LblInf1 = New System.Windows.Forms.Label()
        Me.DgvNtwd = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblNno2 = New System.Windows.Forms.Label()
        Me.LblInf2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEthernetDescription = New System.Windows.Forms.TextBox()
        Me.TxtMacAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCompIp = New System.Windows.Forms.TextBox()
        Me.TxtSubnetMask = New System.Windows.Forms.TextBox()
        Me.TxtDfltGateway = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtnCnxAutoMode = New System.Windows.Forms.RadioButton()
        Me.RbtnCnxMnualMode = New System.Windows.Forms.RadioButton()
        Me.LblConnectionParametersID = New System.Windows.Forms.Label()
        Me.LblScanScheduleID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumStartHr = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbRptHr = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LblNno3 = New System.Windows.Forms.Label()
        Me.LblInf3 = New System.Windows.Forms.Label()
        Me.DgvSchLog = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LblNno4 = New System.Windows.Forms.Label()
        Me.LblInf4 = New System.Windows.Forms.Label()
        Me.DgvAllLog = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvNtwd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumStartHr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvSchLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvAllLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbVisible = False
        '
        '
        '
        Me.Ribbon1.QuickAccessToolbar.Items.Add(Me.btnHelp)
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1000, 155)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab4)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab5)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        '
        'btnHelp
        '
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.LargeImage = CType(resources.GetObject("btnHelp.LargeImage"), System.Drawing.Image)
        Me.btnHelp.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.SmallImage = Global.AutoScanNetwork.My.Resources.Resources.Help
        Me.btnHelp.Text = "RibbonButton1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "Network"
        Me.RibbonTab1.ToolTip = "To manage the *mcnx file"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnNew)
        Me.RibbonPanel1.Items.Add(Me.btnSave)
        Me.RibbonPanel1.Items.Add(Me.btnOpen)
        Me.RibbonPanel1.Items.Add(Me.btnClose)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = "Network Database"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.LargeImage = CType(resources.GetObject("btnNew.LargeImage"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.SmallImage = CType(resources.GetObject("btnNew.SmallImage"), System.Drawing.Image)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.LargeImage = CType(resources.GetObject("btnSave.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.SmallImage = CType(resources.GetObject("btnSave.SmallImage"), System.Drawing.Image)
        Me.btnSave.Text = "Save"
        '
        'btnOpen
        '
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.LargeImage = CType(resources.GetObject("btnOpen.LargeImage"), System.Drawing.Image)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.SmallImage = CType(resources.GetObject("btnOpen.SmallImage"), System.Drawing.Image)
        Me.btnOpen.Text = "Open"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.LargeImage = CType(resources.GetObject("btnClose.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.SmallImage = CType(resources.GetObject("btnClose.SmallImage"), System.Drawing.Image)
        Me.btnClose.Text = "Close"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab2.Text = "Scan Network"
        Me.RibbonTab2.ToolTip = "Carryout ping trials using addresses in *.mcnx file."
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.btnSchScan)
        Me.RibbonPanel2.Items.Add(Me.btnOthScan)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = "Scan"
        '
        'btnSchScan
        '
        Me.btnSchScan.Image = CType(resources.GetObject("btnSchScan.Image"), System.Drawing.Image)
        Me.btnSchScan.LargeImage = CType(resources.GetObject("btnSchScan.LargeImage"), System.Drawing.Image)
        Me.btnSchScan.Name = "btnSchScan"
        Me.btnSchScan.SmallImage = CType(resources.GetObject("btnSchScan.SmallImage"), System.Drawing.Image)
        Me.btnSchScan.Text = "Schedule"
        '
        'btnOthScan
        '
        Me.btnOthScan.Image = CType(resources.GetObject("btnOthScan.Image"), System.Drawing.Image)
        Me.btnOthScan.LargeImage = CType(resources.GetObject("btnOthScan.LargeImage"), System.Drawing.Image)
        Me.btnOthScan.Name = "btnOthScan"
        Me.btnOthScan.SmallImage = CType(resources.GetObject("btnOthScan.SmallImage"), System.Drawing.Image)
        Me.btnOthScan.Text = "Other"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab3.Text = "Analyze Log"
        Me.RibbonTab3.ToolTip = "Displays/Consolidates ping result log for last few days"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.btnFiveDaysLogShow)
        Me.RibbonPanel3.Items.Add(Me.btnTenDaysLogShow)
        Me.RibbonPanel3.Items.Add(Me.btnCustomLogShow)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Text = "Show Log"
        '
        'btnFiveDaysLogShow
        '
        Me.btnFiveDaysLogShow.Image = CType(resources.GetObject("btnFiveDaysLogShow.Image"), System.Drawing.Image)
        Me.btnFiveDaysLogShow.LargeImage = CType(resources.GetObject("btnFiveDaysLogShow.LargeImage"), System.Drawing.Image)
        Me.btnFiveDaysLogShow.Name = "btnFiveDaysLogShow"
        Me.btnFiveDaysLogShow.SmallImage = CType(resources.GetObject("btnFiveDaysLogShow.SmallImage"), System.Drawing.Image)
        Me.btnFiveDaysLogShow.Text = "5 Days"
        '
        'btnTenDaysLogShow
        '
        Me.btnTenDaysLogShow.Image = CType(resources.GetObject("btnTenDaysLogShow.Image"), System.Drawing.Image)
        Me.btnTenDaysLogShow.LargeImage = CType(resources.GetObject("btnTenDaysLogShow.LargeImage"), System.Drawing.Image)
        Me.btnTenDaysLogShow.Name = "btnTenDaysLogShow"
        Me.btnTenDaysLogShow.SmallImage = CType(resources.GetObject("btnTenDaysLogShow.SmallImage"), System.Drawing.Image)
        Me.btnTenDaysLogShow.Text = "10 Days"
        '
        'btnCustomLogShow
        '
        Me.btnCustomLogShow.Image = CType(resources.GetObject("btnCustomLogShow.Image"), System.Drawing.Image)
        Me.btnCustomLogShow.LargeImage = CType(resources.GetObject("btnCustomLogShow.LargeImage"), System.Drawing.Image)
        Me.btnCustomLogShow.Name = "btnCustomLogShow"
        Me.btnCustomLogShow.SmallImage = CType(resources.GetObject("btnCustomLogShow.SmallImage"), System.Drawing.Image)
        Me.btnCustomLogShow.Text = "Custom"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.btnFiveDaysLogAnalyze)
        Me.RibbonPanel5.Items.Add(Me.btnTenDAysLogAnalyze)
        Me.RibbonPanel5.Items.Add(Me.btnCustomLogAnalyze)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Text = "Consolidate"
        '
        'btnFiveDaysLogAnalyze
        '
        Me.btnFiveDaysLogAnalyze.Image = CType(resources.GetObject("btnFiveDaysLogAnalyze.Image"), System.Drawing.Image)
        Me.btnFiveDaysLogAnalyze.LargeImage = CType(resources.GetObject("btnFiveDaysLogAnalyze.LargeImage"), System.Drawing.Image)
        Me.btnFiveDaysLogAnalyze.Name = "btnFiveDaysLogAnalyze"
        Me.btnFiveDaysLogAnalyze.SmallImage = CType(resources.GetObject("btnFiveDaysLogAnalyze.SmallImage"), System.Drawing.Image)
        Me.btnFiveDaysLogAnalyze.Text = "5 Days"
        '
        'btnTenDAysLogAnalyze
        '
        Me.btnTenDAysLogAnalyze.Image = CType(resources.GetObject("btnTenDAysLogAnalyze.Image"), System.Drawing.Image)
        Me.btnTenDAysLogAnalyze.LargeImage = CType(resources.GetObject("btnTenDAysLogAnalyze.LargeImage"), System.Drawing.Image)
        Me.btnTenDAysLogAnalyze.Name = "btnTenDAysLogAnalyze"
        Me.btnTenDAysLogAnalyze.SmallImage = CType(resources.GetObject("btnTenDAysLogAnalyze.SmallImage"), System.Drawing.Image)
        Me.btnTenDAysLogAnalyze.Text = "10 Days"
        '
        'btnCustomLogAnalyze
        '
        Me.btnCustomLogAnalyze.Image = CType(resources.GetObject("btnCustomLogAnalyze.Image"), System.Drawing.Image)
        Me.btnCustomLogAnalyze.LargeImage = CType(resources.GetObject("btnCustomLogAnalyze.LargeImage"), System.Drawing.Image)
        Me.btnCustomLogAnalyze.Name = "btnCustomLogAnalyze"
        Me.btnCustomLogAnalyze.SmallImage = CType(resources.GetObject("btnCustomLogAnalyze.SmallImage"), System.Drawing.Image)
        Me.btnCustomLogAnalyze.Text = "Custom"
        '
        'RibbonTab4
        '
        Me.RibbonTab4.Name = "RibbonTab4"
        Me.RibbonTab4.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab4.Panels.Add(Me.RibbonPanel6)
        Me.RibbonTab4.Text = "Tools"
        Me.RibbonTab4.ToolTip = "Check connectivity, get MAC, export scheduled ping log to Excel"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.btnCheckConnectivity)
        Me.RibbonPanel4.Items.Add(Me.btnGetMacAddress)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Text = "Connect to Local"
        '
        'btnCheckConnectivity
        '
        Me.btnCheckConnectivity.Image = CType(resources.GetObject("btnCheckConnectivity.Image"), System.Drawing.Image)
        Me.btnCheckConnectivity.LargeImage = CType(resources.GetObject("btnCheckConnectivity.LargeImage"), System.Drawing.Image)
        Me.btnCheckConnectivity.Name = "btnCheckConnectivity"
        Me.btnCheckConnectivity.SmallImage = CType(resources.GetObject("btnCheckConnectivity.SmallImage"), System.Drawing.Image)
        Me.btnCheckConnectivity.Text = "Check Connectivity"
        '
        'btnGetMacAddress
        '
        Me.btnGetMacAddress.Image = CType(resources.GetObject("btnGetMacAddress.Image"), System.Drawing.Image)
        Me.btnGetMacAddress.LargeImage = CType(resources.GetObject("btnGetMacAddress.LargeImage"), System.Drawing.Image)
        Me.btnGetMacAddress.Name = "btnGetMacAddress"
        Me.btnGetMacAddress.SmallImage = CType(resources.GetObject("btnGetMacAddress.SmallImage"), System.Drawing.Image)
        Me.btnGetMacAddress.Text = "Get MAC Address"
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.Items.Add(Me.btnExport)
        Me.RibbonPanel6.Name = "RibbonPanel6"
        Me.RibbonPanel6.Text = "Export"
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.LargeImage = CType(resources.GetObject("btnExport.LargeImage"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.SmallImage = CType(resources.GetObject("btnExport.SmallImage"), System.Drawing.Image)
        Me.btnExport.Text = "To Excel"
        '
        'RibbonTab5
        '
        Me.RibbonTab5.Name = "RibbonTab5"
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel7)
        Me.RibbonTab5.Text = "Help"
        '
        'RibbonPanel7
        '
        Me.RibbonPanel7.Items.Add(Me.btnHelpRbn)
        Me.RibbonPanel7.Items.Add(Me.btnAbout)
        Me.RibbonPanel7.Name = "RibbonPanel7"
        Me.RibbonPanel7.Text = "Information"
        '
        'btnHelpRbn
        '
        Me.btnHelpRbn.Image = CType(resources.GetObject("btnHelpRbn.Image"), System.Drawing.Image)
        Me.btnHelpRbn.LargeImage = CType(resources.GetObject("btnHelpRbn.LargeImage"), System.Drawing.Image)
        Me.btnHelpRbn.Name = "btnHelpRbn"
        Me.btnHelpRbn.SmallImage = CType(resources.GetObject("btnHelpRbn.SmallImage"), System.Drawing.Image)
        Me.btnHelpRbn.Text = "Help"
        '
        'btnAbout
        '
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.LargeImage = CType(resources.GetObject("btnAbout.LargeImage"), System.Drawing.Image)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.SmallImage = CType(resources.GetObject("btnAbout.SmallImage"), System.Drawing.Image)
        Me.btnAbout.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 181)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(980, 480)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblNno1)
        Me.TabPage1.Controls.Add(Me.LblInf1)
        Me.TabPage1.Controls.Add(Me.DgvNtwd)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(972, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Network Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LblNno1
        '
        Me.LblNno1.AutoSize = True
        Me.LblNno1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNno1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNno1.ForeColor = System.Drawing.Color.Aqua
        Me.LblNno1.Location = New System.Drawing.Point(179, 183)
        Me.LblNno1.Name = "LblNno1"
        Me.LblNno1.Size = New System.Drawing.Size(614, 27)
        Me.LblNno1.TabIndex = 2
        Me.LblNno1.Text = "No Network Open; Create or Open the Network (*.mcnx)"
        '
        'LblInf1
        '
        Me.LblInf1.AutoSize = True
        Me.LblInf1.BackColor = System.Drawing.SystemColors.Info
        Me.LblInf1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblInf1.Location = New System.Drawing.Point(275, 219)
        Me.LblInf1.Name = "LblInf1"
        Me.LblInf1.Size = New System.Drawing.Size(417, 48)
        Me.LblInf1.TabIndex = 1
        Me.LblInf1.Text = "MSETCL communication network file ( *.mcnx) is a data file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "having substation nam" & _
    "es, router and gateway ip addresses," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "scanning schedule, network entry point set" & _
    "tings, scanning results etc. "
        '
        'DgvNtwd
        '
        Me.DgvNtwd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNtwd.Location = New System.Drawing.Point(7, 4)
        Me.DgvNtwd.Name = "DgvNtwd"
        Me.DgvNtwd.Size = New System.Drawing.Size(960, 438)
        Me.DgvNtwd.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TabPage2.Controls.Add(Me.LblNno2)
        Me.TabPage2.Controls.Add(Me.LblInf2)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.LblConnectionParametersID)
        Me.TabPage2.Controls.Add(Me.LblScanScheduleID)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.NumStartHr)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.CmbRptHr)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(972, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        '
        'LblNno2
        '
        Me.LblNno2.AutoSize = True
        Me.LblNno2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNno2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNno2.ForeColor = System.Drawing.Color.Aqua
        Me.LblNno2.Location = New System.Drawing.Point(179, 183)
        Me.LblNno2.Name = "LblNno2"
        Me.LblNno2.Size = New System.Drawing.Size(614, 27)
        Me.LblNno2.TabIndex = 32
        Me.LblNno2.Text = "No Network Open; Create or Open the Network (*.mcnx)"
        '
        'LblInf2
        '
        Me.LblInf2.AutoSize = True
        Me.LblInf2.BackColor = System.Drawing.SystemColors.Info
        Me.LblInf2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblInf2.Location = New System.Drawing.Point(275, 219)
        Me.LblInf2.Name = "LblInf2"
        Me.LblInf2.Size = New System.Drawing.Size(417, 48)
        Me.LblInf2.TabIndex = 31
        Me.LblInf2.Text = "MSETCL communication network file ( *.mcnx) is a data file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "having substation nam" & _
    "es, router and gateway ip addresses," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "scanning schedule, network entry point set" & _
    "tings, scanning results etc. "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "ID :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "ID :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Network Entry :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEthernetDescription)
        Me.GroupBox2.Controls.Add(Me.TxtMacAddress)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtCompIp)
        Me.GroupBox2.Controls.Add(Me.TxtSubnetMask)
        Me.GroupBox2.Controls.Add(Me.TxtDfltGateway)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 219)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ethernet Port Settings"
        '
        'TxtEthernetDescription
        '
        Me.TxtEthernetDescription.Enabled = False
        Me.TxtEthernetDescription.Location = New System.Drawing.Point(208, 168)
        Me.TxtEthernetDescription.Name = "TxtEthernetDescription"
        Me.TxtEthernetDescription.Size = New System.Drawing.Size(292, 22)
        Me.TxtEthernetDescription.TabIndex = 23
        Me.TxtEthernetDescription.Text = "New Ethernet Port"
        '
        'TxtMacAddress
        '
        Me.TxtMacAddress.Enabled = False
        Me.TxtMacAddress.Location = New System.Drawing.Point(208, 134)
        Me.TxtMacAddress.Name = "TxtMacAddress"
        Me.TxtMacAddress.Size = New System.Drawing.Size(109, 22)
        Me.TxtMacAddress.TabIndex = 22
        Me.TxtMacAddress.Text = "000000000000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Ethernet Port Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "MAC Address Ethernet Port"
        '
        'TxtCompIp
        '
        Me.TxtCompIp.Enabled = False
        Me.TxtCompIp.Location = New System.Drawing.Point(208, 100)
        Me.TxtCompIp.Name = "TxtCompIp"
        Me.TxtCompIp.Size = New System.Drawing.Size(109, 22)
        Me.TxtCompIp.TabIndex = 19
        Me.TxtCompIp.Text = "..."
        '
        'TxtSubnetMask
        '
        Me.TxtSubnetMask.Enabled = False
        Me.TxtSubnetMask.Location = New System.Drawing.Point(208, 67)
        Me.TxtSubnetMask.Name = "TxtSubnetMask"
        Me.TxtSubnetMask.Size = New System.Drawing.Size(109, 22)
        Me.TxtSubnetMask.TabIndex = 18
        Me.TxtSubnetMask.Text = "..."
        '
        'TxtDfltGateway
        '
        Me.TxtDfltGateway.Enabled = False
        Me.TxtDfltGateway.Location = New System.Drawing.Point(208, 34)
        Me.TxtDfltGateway.Name = "TxtDfltGateway"
        Me.TxtDfltGateway.Size = New System.Drawing.Size(109, 22)
        Me.TxtDfltGateway.TabIndex = 17
        Me.TxtDfltGateway.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "This Computer IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Subnet Mask"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Default Gateway IP Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtnCnxAutoMode)
        Me.GroupBox1.Controls.Add(Me.RbtnCnxMnualMode)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 100)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Mode Selection"
        '
        'RbtnCnxAutoMode
        '
        Me.RbtnCnxAutoMode.AutoSize = True
        Me.RbtnCnxAutoMode.Location = New System.Drawing.Point(7, 59)
        Me.RbtnCnxAutoMode.Name = "RbtnCnxAutoMode"
        Me.RbtnCnxAutoMode.Size = New System.Drawing.Size(455, 20)
        Me.RbtnCnxAutoMode.TabIndex = 1
        Me.RbtnCnxAutoMode.Text = "Use Following Ethernet Port Settings Automatically for network Scanning  "
        Me.RbtnCnxAutoMode.UseVisualStyleBackColor = True
        '
        'RbtnCnxMnualMode
        '
        Me.RbtnCnxMnualMode.AutoSize = True
        Me.RbtnCnxMnualMode.Checked = True
        Me.RbtnCnxMnualMode.Location = New System.Drawing.Point(7, 22)
        Me.RbtnCnxMnualMode.Name = "RbtnCnxMnualMode"
        Me.RbtnCnxMnualMode.Size = New System.Drawing.Size(306, 20)
        Me.RbtnCnxMnualMode.TabIndex = 0
        Me.RbtnCnxMnualMode.TabStop = True
        Me.RbtnCnxMnualMode.Text = "Set Ethernet Port Manually for network scanning"
        Me.RbtnCnxMnualMode.UseVisualStyleBackColor = True
        '
        'LblConnectionParametersID
        '
        Me.LblConnectionParametersID.AutoSize = True
        Me.LblConnectionParametersID.Location = New System.Drawing.Point(42, 71)
        Me.LblConnectionParametersID.Name = "LblConnectionParametersID"
        Me.LblConnectionParametersID.Size = New System.Drawing.Size(15, 16)
        Me.LblConnectionParametersID.TabIndex = 25
        Me.LblConnectionParametersID.Text = "1"
        '
        'LblScanScheduleID
        '
        Me.LblScanScheduleID.AutoSize = True
        Me.LblScanScheduleID.Location = New System.Drawing.Point(42, 0)
        Me.LblScanScheduleID.Name = "LblScanScheduleID"
        Me.LblScanScheduleID.Size = New System.Drawing.Size(15, 16)
        Me.LblScanScheduleID.TabIndex = 24
        Me.LblScanScheduleID.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hrs."
        '
        'NumStartHr
        '
        Me.NumStartHr.Enabled = False
        Me.NumStartHr.Location = New System.Drawing.Point(463, 20)
        Me.NumStartHr.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumStartHr.Name = "NumStartHr"
        Me.NumStartHr.Size = New System.Drawing.Size(43, 22)
        Me.NumStartHr.TabIndex = 12
        Me.NumStartHr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hrs.     Starts from"
        '
        'CmbRptHr
        '
        Me.CmbRptHr.Enabled = False
        Me.CmbRptHr.FormattingEnabled = True
        Me.CmbRptHr.Items.AddRange(New Object() {"1", "2", "3", "4", "6", "8", "12"})
        Me.CmbRptHr.Location = New System.Drawing.Point(287, 19)
        Me.CmbRptHr.Name = "CmbRptHr"
        Me.CmbRptHr.Size = New System.Drawing.Size(48, 24)
        Me.CmbRptHr.TabIndex = 10
        Me.CmbRptHr.Text = "8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Repeat Scan After Every"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Scan Schedule :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LblNno3)
        Me.TabPage3.Controls.Add(Me.LblInf3)
        Me.TabPage3.Controls.Add(Me.DgvSchLog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(972, 451)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Scheduled Scan Log"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LblNno3
        '
        Me.LblNno3.AutoSize = True
        Me.LblNno3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNno3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNno3.ForeColor = System.Drawing.Color.Aqua
        Me.LblNno3.Location = New System.Drawing.Point(179, 183)
        Me.LblNno3.Name = "LblNno3"
        Me.LblNno3.Size = New System.Drawing.Size(614, 27)
        Me.LblNno3.TabIndex = 4
        Me.LblNno3.Text = "No Network Open; Create or Open the Network (*.mcnx)"
        '
        'LblInf3
        '
        Me.LblInf3.AutoSize = True
        Me.LblInf3.BackColor = System.Drawing.SystemColors.Info
        Me.LblInf3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblInf3.Location = New System.Drawing.Point(275, 219)
        Me.LblInf3.Name = "LblInf3"
        Me.LblInf3.Size = New System.Drawing.Size(417, 48)
        Me.LblInf3.TabIndex = 3
        Me.LblInf3.Text = "MSETCL communication network file ( *.mcnx) is a data file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "having substation nam" & _
    "es, router and gateway ip addresses," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "scanning schedule, network entry point set" & _
    "tings, scanning results etc. "
        '
        'DgvSchLog
        '
        Me.DgvSchLog.AllowUserToAddRows = False
        Me.DgvSchLog.AllowUserToDeleteRows = False
        Me.DgvSchLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSchLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvSchLog.Location = New System.Drawing.Point(7, 5)
        Me.DgvSchLog.Name = "DgvSchLog"
        Me.DgvSchLog.Size = New System.Drawing.Size(960, 438)
        Me.DgvSchLog.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LblNno4)
        Me.TabPage4.Controls.Add(Me.LblInf4)
        Me.TabPage4.Controls.Add(Me.DgvAllLog)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(972, 451)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other Scan Log"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LblNno4
        '
        Me.LblNno4.AutoSize = True
        Me.LblNno4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNno4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNno4.ForeColor = System.Drawing.Color.Aqua
        Me.LblNno4.Location = New System.Drawing.Point(179, 183)
        Me.LblNno4.Name = "LblNno4"
        Me.LblNno4.Size = New System.Drawing.Size(614, 27)
        Me.LblNno4.TabIndex = 4
        Me.LblNno4.Text = "No Network Open; Create or Open the Network (*.mcnx)"
        '
        'LblInf4
        '
        Me.LblInf4.AutoSize = True
        Me.LblInf4.BackColor = System.Drawing.SystemColors.Info
        Me.LblInf4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblInf4.Location = New System.Drawing.Point(275, 219)
        Me.LblInf4.Name = "LblInf4"
        Me.LblInf4.Size = New System.Drawing.Size(417, 48)
        Me.LblInf4.TabIndex = 3
        Me.LblInf4.Text = "MSETCL communication network file ( *.mcnx) is a data file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "having substation nam" & _
    "es, router and gateway ip addresses," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "scanning schedule, network entry point set" & _
    "tings, scanning results etc. "
        '
        'DgvAllLog
        '
        Me.DgvAllLog.AllowUserToAddRows = False
        Me.DgvAllLog.AllowUserToDeleteRows = False
        Me.DgvAllLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAllLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvAllLog.Location = New System.Drawing.Point(4, 5)
        Me.DgvAllLog.Name = "DgvAllLog"
        Me.DgvAllLog.Size = New System.Drawing.Size(960, 438)
        Me.DgvAllLog.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Connection"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblConnection.Location = New System.Drawing.Point(102, 162)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(86, 16)
        Me.lblConnection.TabIndex = 11
        Me.lblConnection.Text = "lblConnection"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(783, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(841, 162)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 16)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "lblStatus"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Msetcl Com. Network File| *.mcnx"
        Me.SaveFileDialog1.InitialDirectory = Global.AutoScanNetwork.My.MySettings.Default.SaveFileIniDir
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Msetcl Com. Network File| *.mcnx"
        Me.OpenFileDialog1.InitialDirectory = Global.AutoScanNetwork.My.MySettings.Default.OpenFileIniDir
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 661)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Ribbon1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "MyNetworkScan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvNtwd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumStartHr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DgvSchLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DgvAllLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonTab1 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOpen As System.Windows.Forms.RibbonButton
    Friend WithEvents btnClose As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab2 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel2 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnSchScan As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOthScan As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab3 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel3 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnFiveDaysLogShow As System.Windows.Forms.RibbonButton
    Friend WithEvents btnTenDaysLogShow As System.Windows.Forms.RibbonButton
    Friend WithEvents btnCustomLogShow As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel5 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnFiveDaysLogAnalyze As System.Windows.Forms.RibbonButton
    Friend WithEvents btnTenDAysLogAnalyze As System.Windows.Forms.RibbonButton
    Friend WithEvents btnCustomLogAnalyze As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab4 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel4 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnCheckConnectivity As System.Windows.Forms.RibbonButton
    Friend WithEvents btnGetMacAddress As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel6 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnExport As System.Windows.Forms.RibbonButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DgvNtwd As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumStartHr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbRptHr As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DgvSchLog As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DgvAllLog As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents TxtCompIp As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubnetMask As System.Windows.Forms.TextBox
    Friend WithEvents TxtDfltGateway As System.Windows.Forms.TextBox
    Friend WithEvents TxtEthernetDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtMacAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblConnectionParametersID As System.Windows.Forms.Label
    Friend WithEvents LblScanScheduleID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnCnxAutoMode As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCnxMnualMode As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblInf1 As System.Windows.Forms.Label
    Friend WithEvents LblNno1 As System.Windows.Forms.Label
    Friend WithEvents LblNno2 As System.Windows.Forms.Label
    Friend WithEvents LblInf2 As System.Windows.Forms.Label
    Friend WithEvents LblNno3 As System.Windows.Forms.Label
    Friend WithEvents LblInf3 As System.Windows.Forms.Label
    Friend WithEvents LblNno4 As System.Windows.Forms.Label
    Friend WithEvents LblInf4 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTab5 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel7 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnHelpRbn As System.Windows.Forms.RibbonButton
    Friend WithEvents btnAbout As System.Windows.Forms.RibbonButton

End Class
