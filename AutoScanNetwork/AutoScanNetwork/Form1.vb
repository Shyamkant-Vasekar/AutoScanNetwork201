Imports AutoScanNetwork.NewSaveOpenClose
Imports AutoScanNetwork.GeneralScanNetwork
Imports System.Data.SQLite
Imports System.Net.NetworkInformation
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices 'For extracting icons from Shell.dll
Public Class Form1

    'Win API to extract icon from Shell.dll
    <DllImport("shell32.dll", EntryPoint:="ExtractAssociatedIconW", CallingConvention:=CallingConvention.StdCall)> Public Shared Function MyIconExtractor(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lpIconPath As String, ByRef lpiIcon As UShort) As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="DestroyIcon")> Public Shared Function MyIconDestroyer(ByVal hIcon As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Public MyConnectionString As String = ""
    Dim MyDataSet As DataSet
    Dim tmpBindingDataSource As New BindingSource

    'Icons for button needed to be decleared here because at end we have to destroy it
    Dim btnOpenIcon As Icon = GetSystemIcon(45)
    Dim btnNewIcon As Icon = GetSystemIcon(43)
    Dim btnSaveIcon As Icon = GetSystemIcon(258)
    Dim btnCloseIcon As Icon = GetSystemIcon(27)
    Dim btnSchScanIcon As Icon = GetSystemIcon(167)
    Dim btnOthScanIcon As Icon = GetSystemIcon(135)
    Dim btnFiveDaysLogShowIcon As Icon = GetSystemIcon(55)
    Dim btnTenDaysLogShowIcon As Icon = GetSystemIcon(55)
    Dim btnCustomLogShowIcon As Icon = GetSystemIcon(218)
    Dim btnFiveDaysLogAnalyzeIcon As Icon = GetSystemIcon(39)
    Dim btnTenDAysLogAnalyzeIcon As Icon = GetSystemIcon(39)
    Dim btnCustomLogAnalyzeIcon As Icon = GetSystemIcon(110)
    Dim btnCheckConnectivityIcon As Icon = GetSystemIcon(92)
    Dim btnExportIcon As Icon = GetSystemIcon(68)
    Dim btnGetMacAddressIcon As Icon = GetSystemIcon(71)
    Dim btnHelpRbnIcon As Icon = GetSystemIcon(23)
    Dim btnAboutIcon As Icon = GetSystemIcon(75)




    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        MyConnectionString = ""
        'CREATE TABLE IN MEMORY (But not connection unless at least once saved)
        MyDataSet = CreateEmptyDataSetInMemory()
        'Connect to controls on form
        DgvNtwd.DataSource = MyDataSet.Tables(0) 'TO CHECK WHETHER REQUIRES ONLY ONCE
        DgvSchLog.DataSource = MyDataSet.Tables(3)
        DgvAllLog.DataSource = MyDataSet.Tables(4)
        MakeOtherControlsEnabled()
        SettingsControlVisibility(True)
        PutNewFlag()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim flnm As String
        'SAVE AT DESIRED LOCATION AS PER CONNECTION STRING
        If MyConnectionString = "" Then
            SaveFileDialog1.ShowDialog()                    '////////////////////////////
            flnm = SaveFileDialog1.FileName                 'VERY IMPORTENT CHANGE. Whether Correct (?)
            If Not flnm = "" Then                           '///////////////////////////
                MyConnectionString = CreateEmptyFile(flnm)
                SaveTo(MyConnectionString, MyDataSet)
            Else
                Exit Sub
            End If
        Else
            SaveTo(MyConnectionString, MyDataSet)
        End If
        PutSavedFlag()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim flnm As String
        MyConnectionString = ""
        OpenFileDialog1.ShowDialog()
        flnm = OpenFileDialog1.FileName
        If Not flnm = "" Then
            MyConnectionString = "Data Source=" & flnm & ";Version=3;"
            MyDataSet = MyOpenFile(MyConnectionString)
            lblStatus.Text = "Opening"  'To control RefreshOTherControl and RefreshDataSet cyclic beheviour
            'Connect to controls on form
            DgvNtwd.DataSource = MyDataSet.Tables(0) 'TO CHECK WHETHER REQUIRES ONLY ONCE
            DgvSchLog.DataSource = MyDataSet.Tables(3)
            DgvAllLog.DataSource = MyDataSet.Tables(4)
            DgvAllLog.Sort(DgvAllLog.Columns("TimeStamp"), System.ComponentModel.ListSortDirection.Descending)
            MakeOtherControlsEnabled()
            RefreshOtherControls()
            SettingsControlVisibility(True)
            PutJustOpenedFlag()
        End If
    End Sub
    Private Sub DgvNtwd_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DgvNtwd.CellBeginEdit
        PutEditingFlag()
        If Not btnSave.Enabled Then btnSave.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblStatus.Text = "Created In Memory" Or lblStatus.Text = "Editing Started" Then
            Dim userResponse As New MsgBoxResult
            userResponse = MsgBox("The file has not been saved." & vbCrLf & _
                                  "Do you want to abort clossing to save results?", _
                                  MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If userResponse = MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If


        DgvNtwd.DataSource = Nothing
        DgvSchLog.DataSource = Nothing
        DgvAllLog.DataSource = Nothing
        MyConnectionString = ""
        CloseOtherControls()
        SettingsControlVisibility(False)
        PutCloseFlag()
    End Sub

    Private Sub PutSavedFlag()
        Me.lblConnection.Text = MyConnectionString
        lblStatus.Text = "Just Saved"

        'No need to save further you can either create new or open an existing or close
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnOpen.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub PutNewFlag()
        lblConnection.Text = "New File"
        lblStatus.Text = "Created In Memory"
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""

        'No need to create further ONLY you have to save this first
        btnSave.Enabled = False 'unless untill not edited save not enable this avoides saving of blank file
        btnNew.Enabled = False
        btnOpen.Enabled = False
        btnClose.Enabled = True
        InitialInfVisibility(False)
    End Sub

    Private Sub PutEditingFlag()
        lblStatus.Text = "Editing Started"
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""

        'Once editing started further ONLY you have to save this first
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnOpen.Enabled = False
        btnClose.Enabled = True
    End Sub

    Private Sub PutCloseFlag()
        lblConnection.Text = "Undefined"
        lblStatus.Text = "Expected New or Open"
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""

        'Once closed either create new or open
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnOpen.Enabled = True
        btnClose.Enabled = False
        InitialInfVisibility(True)
    End Sub

    Private Sub PutJustOpenedFlag()
        lblConnection.Text = MyConnectionString
        lblStatus.Text = "Just Opened"
        btnClose.Enabled = True
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = ""

        'When file just opened and not editing started either you can close it open another or create new
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnOpen.Enabled = True
        btnClose.Enabled = True
        InitialInfVisibility(False)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(DgvNtwd.DataSource) Then
            If lblStatus.Text = "Created In Memory" Or lblStatus.Text = "Editing Started" Then
                Dim userResponse As New MsgBoxResult
                userResponse = MsgBox("The file has not been saved." & vbCrLf & _
                                      "Do you want abort clossing to save results?", _
                                      MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
                If userResponse = MsgBoxResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If
        DestroyAllIcons()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbRptHr.SelectedIndex = 5
        NumStartHr.Value = 7
        btnSave.Enabled = False
        btnClose.Enabled = False
        RbtnCnxMnualMode.Enabled = False
        RbtnCnxAutoMode.Enabled = False
        OpenFileDialog1.FileName = Nothing
        SaveFileDialog1.FileName = Nothing
        SettingsControlVisibility(False)
        InitialInfVisibility(True)
        AssignIcons()

    End Sub

    Private Sub RefreshDataset_TextChanged(sender As Object, e As EventArgs) Handles TxtEthernetDescription.TextChanged, _
        TxtDfltGateway.TextChanged, TxtSubnetMask.TextChanged, TxtCompIp.TextChanged, TxtMacAddress.TextChanged
        RefreshDataset()
    End Sub

    Private Sub CmbRptHr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRptHr.SelectedIndexChanged, NumStartHr.ValueChanged
        'If Not lblStatus.Text = "Opening" Then
        If Not CmbRptHr.Text = "" Then
            NumStartHr.Maximum = CInt(CmbRptHr.Text)
            'NumStartHr.Value = Int(NumStartHr.Maximum / 2)
        End If
        'End If
        RefreshDataset()
    End Sub

    Private Function RefreshOtherControls() As Boolean
        LblScanScheduleID.Text = MyDataSet.Tables("ScanSchedule").Rows(0).Item("ID")
        CmbRptHr.Text = MyDataSet.Tables("ScanSchedule").Rows(0).Item("RepeatTime")
        NumStartHr.Value = MyDataSet.Tables("ScanSchedule").Rows(0).Item("StartTime")
        LblConnectionParametersID.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ID")
        If MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ConnectionMode") = "Auto" Then
            RbtnCnxAutoMode.Checked = True
        End If
        TxtDfltGateway.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("DefaultGateway")
        TxtSubnetMask.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("SubnetMask")
        TxtCompIp.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ComputerIp")
        TxtMacAddress.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("MacAddress")
        TxtEthernetDescription.Text = MyDataSet.Tables("ConnectionParameters").Rows(0).Item("EthernetPortDescription")
        RefreshOtherControls = True
    End Function

    Private Function RefreshDataset()
        If Not IsNothing(MyDataSet) And Not lblStatus.Text = "Opening" Then
            MyDataSet.Tables("ScanSchedule").Rows(0).Item("ID") = LblScanScheduleID.Text
            MyDataSet.Tables("ScanSchedule").Rows(0).Item("RepeatTime") = CInt(CmbRptHr.Text)
            MyDataSet.Tables("ScanSchedule").Rows(0).Item("StartTime") = NumStartHr.Value
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ID") = LblConnectionParametersID.Text
            If RbtnCnxAutoMode.Checked Then
                MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ConnectionMode") = "Auto"
            Else
                MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ConnectionMode") = "Manual"
            End If
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("DefaultGateway") = TxtDfltGateway.Text
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("SubnetMask") = TxtSubnetMask.Text
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("ComputerIp") = TxtCompIp.Text
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("MacAddress") = TxtMacAddress.Text
            MyDataSet.Tables("ConnectionParameters").Rows(0).Item("EthernetPortDescription") = TxtEthernetDescription.Text
            PutEditingFlag()
            If Not btnSave.Enabled Then btnSave.Enabled = True
        End If
        RefreshDataset = True
    End Function
    Private Function CloseOtherControls() As Boolean
        TxtCompIp.Text = "..."
        TxtDfltGateway.Text = "..."
        TxtSubnetMask.Text = "..."
        TxtEthernetDescription.Text = "New Ethernet Port"
        TxtMacAddress.Text = "000000000000"
        NumStartHr.Enabled = False
        CmbRptHr.Enabled = False
        TxtDfltGateway.Enabled = False
        TxtSubnetMask.Enabled = False
        TxtCompIp.Enabled = False
        TxtMacAddress.Enabled = False
        TxtEthernetDescription.Enabled = False
        CloseOtherControls = True
        RbtnCnxMnualMode.Enabled = False
        RbtnCnxAutoMode.Enabled = False
    End Function

    Private Function MakeOtherControlsEnabled() As Boolean
        'Special Tratment
        RbtnCnxMnualMode.Enabled = True
        RbtnCnxAutoMode.Enabled = True
        CmbRptHr.Enabled = True
        NumStartHr.Enabled = True
        MakeOtherControlsEnabled = True
    End Function

    Private Sub RbtnCnxAutoMode_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCnxAutoMode.CheckedChanged
        If RbtnCnxAutoMode.Checked Then
            'NumStartHr.Enabled = True
            'CmbRptHr.Enabled = True
            TxtDfltGateway.Enabled = True
            TxtSubnetMask.Enabled = True
            TxtCompIp.Enabled = True
            TxtMacAddress.Enabled = True
            TxtEthernetDescription.Enabled = True
        End If
        RefreshDataset()
    End Sub

    Private Sub RbtnCnxMnualMode_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCnxMnualMode.CheckedChanged
        If RbtnCnxMnualMode.Checked Then
            'NumStartHr.Enabled = False
            'CmbRptHr.Enabled = False
            TxtDfltGateway.Enabled = False
            TxtSubnetMask.Enabled = False
            TxtCompIp.Enabled = False
            TxtMacAddress.Enabled = False
            TxtEthernetDescription.Enabled = False
        End If
        RefreshDataset()
    End Sub

    Private Sub btnOthScan_Click(sender As Object, e As EventArgs) Handles btnOthScan.Click

        If MyConnectionString = "" Then
            MsgBox("Open a *.mcnx file and then scan it", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        McnxPing(MyDataSet)
        Try
            Using con As New SQLiteConnection(MyConnectionString)
                SaveTable(con, MyDataSet, "AllLog")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        DgvAllLog.DataSource = MyDataSet.Tables("AllLog")
        DgvAllLog.Sort(DgvAllLog.Columns("TimeStamp"), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btnSchScan_Click(sender As Object, e As EventArgs) Handles btnSchScan.Click


        If MyConnectionString = "" Then
            MsgBox("Open a *.mcnx file and then scan it", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If ScheduleTime(MyDataSet) Then
            MsgBox("It's Schedule Time", MsgBoxStyle.Information)
            McnxScheduledPing(MyDataSet)
        Else
            MsgBox("Not a Schedule Time", MsgBoxStyle.Exclamation)
            'McnxScheduledPing(MyDataSet)
        End If
        Try
            Using con As New SQLiteConnection(MyConnectionString)
                SaveTable(con, MyDataSet, "ScheduledLog")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        DgvSchLog.DataSource = MyDataSet.Tables("ScheduledLog")
        DgvSchLog.Sort(DgvSchLog.Columns("TimeStamp"), System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Private Sub btnFiveDaysLogShow_Click(sender As Object, e As EventArgs) Handles btnFiveDaysLogShow.Click
        'DgvSchLog.DataSource = GetLimitedData()
        Form3.LblAnlzInf.Text = "Scheduled Scan Log Data for last 5 days"
        Form3.DgvAnalyze.DataSource = GetLimitedData(5)
        Form3.ShowDialog()
    End Sub

    Private Sub btnFiveDaysLogAnalyze_Click(sender As Object, e As EventArgs) Handles btnFiveDaysLogAnalyze.Click
        'DgvSchLog.DataSource = GetAvgData()
        'This changed to displaying data on separate analyssis form3
        Form3.LblAnlzInf.Text = "Average of Scheduled Scan Log Data for last 5 days"
        Form3.DgvAnalyze.DataSource = GetAvgData(5)
        Form3.ShowDialog()
    End Sub


    Private Sub InitialInfVisibility(ByVal vsbl As Boolean)
        LblInf1.Visible = vsbl
        LblInf2.Visible = vsbl
        LblInf3.Visible = vsbl
        LblInf4.Visible = vsbl
        LblNno1.Visible = vsbl
        LblNno2.Visible = vsbl
        LblNno3.Visible = vsbl
        LblNno4.Visible = vsbl
    End Sub

    Private Sub btnTenDAysLogAnalyze_Click(sender As Object, e As EventArgs) Handles btnTenDAysLogAnalyze.Click
        Form3.LblAnlzInf.Text = "Average of Scheduled Scan Log Data for last 10 days"
        Form3.DgvAnalyze.DataSource = GetAvgData(10)
        Form3.ShowDialog()
    End Sub

    Private Sub btnTenDaysLogShow_Click(sender As Object, e As EventArgs) Handles btnTenDaysLogShow.Click
        Form3.LblAnlzInf.Text = "Scheduled Scan Log Data for last 10 days"
        Form3.DgvAnalyze.DataSource = GetLimitedData(10)
        Form3.ShowDialog()
    End Sub

    Private Sub btnCustomLogAnalyze_Click(sender As Object, e As EventArgs) Handles btnCustomLogAnalyze.Click
        Dim Ndays As Integer
        Try
            Ndays = CInt(InputBox("Enter number of days (>0) to show/analyze"))
            If Ndays <= 0 Then
                MsgBox("Invalid input....", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
        Form3.LblAnlzInf.Text = "Average of Scheduled Scan Log Data for last " & Ndays.ToString & " days"
        Form3.DgvAnalyze.DataSource = GetAvgData(Ndays)
        Form3.ShowDialog()
    End Sub

    Private Sub btnCustomLogShow_Click(sender As Object, e As EventArgs) Handles btnCustomLogShow.Click
        Dim Ndays As Integer
        Try
            Ndays = CInt(InputBox("Enter number of days (>0) to show/analyze"))
            If Ndays <= 0 Then
                MsgBox("Invalid input....", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
        Form3.LblAnlzInf.Text = "Scheduled Scan Log Data for last" & Ndays.ToString & "days"
        Form3.DgvAnalyze.DataSource = GetLimitedData(Ndays)
        Form3.ShowDialog()
    End Sub

    Private Sub btnCheckConnectivity_Click(sender As Object, e As EventArgs) Handles btnCheckConnectivity.Click
        'Trial Ping No Time Results
        Dim TestIp As String
        Try
            TestIp = InputBox("IP Address for trial", "Ping Trial", My.Settings.IpAddressForPingTrial)
            My.Settings.IpAddressForPingTrial = TestIp
            My.Computer.Network.Ping(TestIp)
            MsgBox("Simple Ping Trial Successfull", MsgBoxStyle.Information)
            MsgBox("Availability for " & TestIp & " is " & (MyPingTrial(TestIp).Availability * 100).ToString() & "%", MsgBoxStyle.Information)
            MsgBox("Response Time for " & TestIp & " is " & MyPingTrial(TestIp).AvgResponseTime.ToString() & " ms", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub



    Private Function MyPingTrial(ByVal hostName As String) As PingResult
        Dim TmOut As Integer = 1000
        Dim Availability As Double
        Dim PingTrial As Integer
        Dim PingTrialSuccess As Integer
        Dim TotalResponseTime As Long
        Dim AverageResponseTime As Double
        Dim MyPingResult As New PingResult

        On Error GoTo ErrCd

        Dim pingreq As Ping = New Ping()
        TotalResponseTime = 0
        PingTrialSuccess = 0
        For PingTrial = 1 To 5
            Dim rep As PingReply = pingreq.Send(hostName, TmOut)
            If rep.Status = IPStatus.Success Then
                PingTrialSuccess = PingTrialSuccess + 1
                TotalResponseTime = TotalResponseTime + rep.RoundtripTime
            End If
        Next
        Availability = PingTrialSuccess / 5.0
        AverageResponseTime = TotalResponseTime / PingTrialSuccess
        If Double.IsNaN(AverageResponseTime) Then AverageResponseTime = 10000.0

        MyPingResult.Availability = Availability
        MyPingResult.AvgResponseTime = AverageResponseTime

        MyPingTrial = MyPingResult

ErrCd:
        If Err.Number > 0 Then
            MsgBox("Line: " & Str(Erl()) & vbCrLf & _
                   "Error: " & Err.Number & vbCrLf & _
                   Err.Description, vbCritical)
        End If

    End Function


    Private Class PingResult
        Public Property Availability As Double
        Public Property AvgResponseTime As Double
    End Class


    Private Sub btnGetMacAddress_Click(sender As Object, e As EventArgs) Handles btnGetMacAddress.Click
        FrmGetMacAddress.ShowDialog()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        FrmSqliteToExcel.ShowDialog()
    End Sub

    Private Sub RibbonTab4_ActiveChanged(sender As Object, e As EventArgs) Handles RibbonTab4.ActiveChanged
        If IsNothing(DgvSchLog.DataSource) Then
            btnExport.Enabled = False
        Else
            If MyDataSet.Tables("ScheduledLog").Rows.Count = 0 Then
                btnExport.Enabled = False
            Else
                btnExport.Enabled = True
            End If
        End If
    End Sub


    'Fxn to extract Shell.dll icon to be used in ribbon
    Private Function GetSystemIcon(ByVal indx As UShort) As Icon
        Dim Shell32dllPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "Shell32.dll")
        Return Icon.FromHandle(MyIconExtractor(IntPtr.Zero, Shell32dllPath, indx))
    End Function

    Private Sub AssignIcons()
        btnOpen.Image = btnOpenIcon.ToBitmap
        btnNew.Image = btnNewIcon.ToBitmap
        btnSave.Image = btnSaveIcon.ToBitmap
        btnClose.Image = btnCloseIcon.ToBitmap
        btnSchScan.Image = btnSchScanIcon.ToBitmap
        btnOthScan.Image = btnOthScanIcon.ToBitmap
        btnFiveDaysLogShow.Image = btnFiveDaysLogShowIcon.ToBitmap
        btnTenDaysLogShow.Image = btnTenDaysLogShowIcon.ToBitmap
        btnCustomLogShow.Image = btnCustomLogShowIcon.ToBitmap
        btnFiveDaysLogAnalyze.Image = btnFiveDaysLogAnalyzeIcon.ToBitmap
        btnTenDAysLogAnalyze.Image = btnTenDAysLogAnalyzeIcon.ToBitmap
        btnCustomLogAnalyze.Image = btnCustomLogAnalyzeIcon.ToBitmap
        btnCheckConnectivity.Image = btnCheckConnectivityIcon.ToBitmap
        btnExport.Image = btnExportIcon.ToBitmap
        btnGetMacAddress.Image = btnGetMacAddressIcon.ToBitmap
        btnHelpRbn.Image = btnHelpRbnIcon.ToBitmap
        btnAbout.Image = btnAboutIcon.ToBitmap

        'btnOpen.Image = GetSystemIcon(45).ToBitmap
        'btnNew.Image = GetSystemIcon(43).ToBitmap
        'btnSave.Image = GetSystemIcon(258).ToBitmap
        'btnClose.Image = GetSystemIcon(27).ToBitmap
        'btnSchScan.Image = GetSystemIcon(167).ToBitmap
        'btnOthScan.Image = GetSystemIcon(135).ToBitmap
        'btnFiveDaysLogShow.Image = GetSystemIcon(55).ToBitmap
        'btnTenDaysLogShow.Image = GetSystemIcon(55).ToBitmap
        'btnCustomLogShow.Image = GetSystemIcon(218).ToBitmap
        'btnFiveDaysLogAnalyze.Image = GetSystemIcon(39).ToBitmap
        'btnTenDAysLogAnalyze.Image = GetSystemIcon(39).ToBitmap
        'btnCustomLogAnalyze.Image = GetSystemIcon(110).ToBitmap
        'btnCheckConnectivity.Image = GetSystemIcon(92).ToBitmap
        'btnExport.Image = GetSystemIcon(68).ToBitmap
        'btnGetMacAddress.Image = GetSystemIcon(71).ToBitmap
        'btnHelpRbn.Image = GetSystemIcon(23).ToBitmap
        'btnAbout.Image = GetSystemIcon(75).ToBitmap
    End Sub

    Private Sub DestroyAllIcons()
        MyIconDestroyer(btnOpenIcon.Handle)
        MyIconDestroyer(btnNewIcon.Handle)
        MyIconDestroyer(btnSaveIcon.Handle)
        MyIconDestroyer(btnCloseIcon.Handle)
        MyIconDestroyer(btnSchScanIcon.Handle)
        MyIconDestroyer(btnOthScanIcon.Handle)
        MyIconDestroyer(btnFiveDaysLogShowIcon.Handle)
        MyIconDestroyer(btnTenDaysLogShowIcon.Handle)
        MyIconDestroyer(btnCustomLogShowIcon.Handle)
        MyIconDestroyer(btnFiveDaysLogAnalyzeIcon.Handle)
        MyIconDestroyer(btnTenDAysLogAnalyzeIcon.Handle)
        MyIconDestroyer(btnCustomLogAnalyzeIcon.Handle)
        MyIconDestroyer(btnCheckConnectivityIcon.Handle)
        MyIconDestroyer(btnExportIcon.Handle)
        MyIconDestroyer(btnGetMacAddressIcon.Handle)
        MyIconDestroyer(btnHelpRbnIcon.Handle)
        MyIconDestroyer(btnAboutIcon.Handle)
    End Sub

    Private Sub btnHelpRbn_Click(sender As Object, e As EventArgs) Handles btnHelpRbn.Click
        'MsgBox(System.IO.Directory.GetCurrentDirectory())
        Dim Hlp As String '= "F:\MyWork\IpNetScan\AutoScanNetwork20\AutoScanNetwork\AutoScanNetwork\bin\Debug\Help\AutoScanHelp.chm"
        Hlp = System.IO.Directory.GetCurrentDirectory() & "\AutoScanHelp.chm"
        Help.ShowHelp(Me, Hlp)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim Hlp As String '= "F:\MyWork\IpNetScan\AutoScanNetwork20\AutoScanNetwork\AutoScanNetwork\bin\Debug\Help\AutoScanHelp.chm"
        Hlp = System.IO.Directory.GetCurrentDirectory() & "\AutoScanHelp.chm"
        Help.ShowHelp(Me, Hlp)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutBox1.ShowDialog()
    End Sub
End Class



