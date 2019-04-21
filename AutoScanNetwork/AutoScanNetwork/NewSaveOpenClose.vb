Imports System.Data.SQLite
Module NewSaveOpenClose
    '//////////////////////////////////////////////////////////////////////////////////////
    '                                    CODE MODULES
    '//////////////////////////////////////////////////////////////////////////////////////
    Public Function CreateEmptyFile(ByVal flnm As String) As String
        Dim NewConnectionString As String
        Dim SQL1 As String 'Create SsNames
        Dim SQL2 As String 'Create ScanSchedule
        Dim SQL3 As String 'Create ConnectionParameters
        Dim SQL4 As String 'Create ScheduledLog
        Dim SQL5 As String 'Create AllLog
        'Create DB file at desired location
        Try
            SQLiteConnection.CreateFile(flnm)
        Catch ex As Exception
            MsgBox(ex.Message)
            CreateEmptyFile = ""
            Exit Function
        End Try

        'Establish connection with created file and Create table in DB file
        NewConnectionString = "Data Source=" & flnm & ";Version=3;"

        'Create SsNames
        SQL1 = "CREATE TABLE SsNames ("
        SQL1 &= "SS_ID text PRIMARY KEY NOT NULL,"
        SQL1 &= "SsName text NOT NULL,"
        SQL1 &= "RouterIp text NOT NULL,"
        SQL1 &= "GatewayIp text NOT NULL"
        SQL1 &= ");"

        'Create ScanSchedule
        SQL2 = "CREATE TABLE ScanSchedule ("
        SQL2 &= "ID Integer PRIMARY KEY NOT NULL,"
        SQL2 &= "RepeatTime INTEGER NOT NULL,"
        SQL2 &= "StartTime INTEGER NOT NULL"
        SQL2 &= ");"

        'Create ConnectionParameters
        SQL3 = "CREATE TABLE ConnectionParameters ("
        SQL3 &= "ID Integer PRIMARY KEY NOT NULL,"
        SQL3 &= "ConnectionMode text NOT NULL,"
        SQL3 &= "DefaultGateway text NOT NULL,"
        SQL3 &= "SubnetMask text NOT NULL,"
        SQL3 &= "ComputerIp text NOT NULL,"
        SQL3 &= "MacAddress text NOT NULL,"
        SQL3 &= "EthernetPortDescription text NOT NULL"
        SQL3 &= ");"

        'Create ScheduledLog
        SQL4 = "CREATE TABLE ScheduledLog ("
        SQL4 &= "ID Integer PRIMARY KEY NOT NULL,"
        SQL4 &= "SS_ID text NOT NULL,"
        SQL4 &= "SsName text NOT NULL,"
        SQL4 &= "TimeStamp text NOT NULL,"
        SQL4 &= "RouterIp text NOT NULL,"
        SQL4 &= "RouterAvailability Real NOT NULL,"
        SQL4 &= "RouterResponseTime Real NOT NULL,"
        SQL4 &= "GatewayIp text NOT NULL,"
        SQL4 &= "GatewayAvailability Real NOT NULL,"
        SQL4 &= "GatewayResponseTime Real NOT NULL"
        SQL4 &= ");"

        'Create AllLog
        SQL5 = "CREATE TABLE AllLog ("
        SQL5 &= "ID Integer PRIMARY KEY NOT NULL,"
        SQL5 &= "SS_ID text NOT NULL,"
        SQL5 &= "SsName text NOT NULL,"
        SQL5 &= "TimeStamp text NOT NULL,"
        SQL5 &= "RouterIp text NOT NULL,"
        SQL5 &= "RouterAvailability Real NOT NULL,"
        SQL5 &= "RouterResponseTime Real NOT NULL,"
        SQL5 &= "GatewayIp text NOT NULL,"
        SQL5 &= "GatewayAvailability Real NOT NULL,"
        SQL5 &= "GatewayResponseTime Real NOT NULL"
        SQL5 &= ");"


        Try
            Using con As New SQLiteConnection(NewConnectionString)
                con.Open()
                Using cmd As New SQLiteCommand(SQL1, con)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New SQLiteCommand(SQL2, con)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New SQLiteCommand(SQL3, con)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New SQLiteCommand(SQL4, con)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New SQLiteCommand(SQL5, con)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("File and Table Structure Created Successfully", MsgBoxStyle.Information)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            CreateEmptyFile = ""
        End Try




        CreateEmptyFile = NewConnectionString
    End Function
    'Creates dataset of required structure and return it back 
    Public Function CreateEmptyDataSetInMemory() As DataSet
        Dim dx As DataSet
        dx = New DataSet

        dx.Tables.Add("SsNames")
        dx.Tables(0).Columns.Add("SS_ID")
        dx.Tables(0).Columns.Add("SsName")
        dx.Tables(0).Columns.Add("RouterIp")
        dx.Tables(0).Columns.Add("GatewayIp")
        dx.Tables(0).NewRow()

        Dim dr As DataRow

        dx.Tables.Add("ScanSchedule")
        dx.Tables(1).Columns.Add("ID")
        dx.Tables(1).Columns.Add("RepeatTime")
        dx.Tables(1).Columns.Add("StartTime")
        'dx.Tables(1).Columns("ID").DataType = System.Type.GetType("System.Integer")
        dr = dx.Tables(1).NewRow()
        dr("ID") = 1
        dr("RepeatTime") = 8
        dr("StartTime") = 7
        dx.Tables(1).Rows.Add(dr)

        dx.Tables.Add("ConnectionParameters")
        dx.Tables(2).Columns.Add("ID")
        dx.Tables(2).Columns.Add("ConnectionMode")
        dx.Tables(2).Columns.Add("DefaultGateway")
        dx.Tables(2).Columns.Add("SubnetMask")
        dx.Tables(2).Columns.Add("ComputerIp")
        dx.Tables(2).Columns.Add("MacAddress")
        dx.Tables(2).Columns.Add("EthernetPortDescription")
        dr = dx.Tables(2).NewRow()
        dr("ID") = 1
        dr("ConnectionMode") = "Manual"
        dr("DefaultGateway") = "168.92.13.4"
        dr("SubnetMask") = "255.255.255.0"
        dr("ComputerIp") = "168.92.13.125"
        dr("MacAddress") = "0123456789AB"
        dr("EthernetPortDescription") = "Some Description"
        dx.Tables(2).Rows.Add(dr)

        dx.Tables.Add("ScheduledLog")
        dx.Tables(3).Columns.Add("ID")
        dx.Tables(3).Columns.Add("SS_ID")
        dx.Tables(3).Columns.Add("SsName")
        dx.Tables(3).Columns.Add("TimeStamp")
        dx.Tables(3).Columns.Add("RouterIp")
        dx.Tables(3).Columns.Add("RouterAvailability")
        dx.Tables(3).Columns.Add("RouterResponseTime")
        dx.Tables(3).Columns.Add("GatewayIp")
        dx.Tables(3).Columns.Add("GatewayAvailability")
        dx.Tables(3).Columns.Add("GatewayResponseTime")
        dx.Tables(3).NewRow()

        dx.Tables.Add("AllLog")
        dx.Tables(4).Columns.Add("ID")
        dx.Tables(4).Columns.Add("SS_ID")
        dx.Tables(4).Columns.Add("SsName")
        dx.Tables(4).Columns.Add("TimeStamp")
        dx.Tables(4).Columns.Add("RouterIp")
        dx.Tables(4).Columns.Add("RouterAvailability")
        dx.Tables(4).Columns.Add("RouterResponseTime")
        dx.Tables(4).Columns.Add("GatewayIp")
        dx.Tables(4).Columns.Add("GatewayAvailability")
        dx.Tables(4).Columns.Add("GatewayResponseTime")
        dx.Tables(4).NewRow()


        CreateEmptyDataSetInMemory = dx
    End Function

    Public Function SaveTo(ByVal constr As String, ByRef ds As DataSet) As Boolean
        Try
            Using con As New SQLiteConnection(constr)
                SaveTable(con, ds, "SsNames")
                SaveTable(con, ds, "ScanSchedule")
                SaveTable(con, ds, "ConnectionParameters")
                SaveTable(con, ds, "ScheduledLog")
                SaveTable(con, ds, "AllLog")
            End Using
        Catch ex As System.Data.SQLite.SQLiteException
            MsgBox("An error occured while writting to *.mncx file" & vbCrLf & _
                   "Error Code: " & ex.ErrorCode.ToString & vbCrLf & _
                   "Error: " & ex.Message, _
                   MsgBoxStyle.Exclamation)
            SaveTo = False
            Exit Function
        Catch ex As Exception
            MsgBox("An unknown error occured", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            SaveTo = False
            Exit Function
        End Try
        SaveTo = True
    End Function

    'This time it returns dataset having saved data
    Public Function MyOpenFile(ByVal ConnectionString As String) As DataSet
        Dim dx As DataSet


        '3) Generate a fresh data set of rquired structure
        dx = New DataSet
        dx.Tables.Add("SsNames")
        dx.Tables(0).Columns.Add("SS_ID")
        dx.Tables(0).Columns.Add("SsName")
        dx.Tables(0).Columns.Add("RouterIp")
        dx.Tables(0).Columns.Add("GatewayIp")

        dx.Tables.Add("ScanSchedule")
        dx.Tables(1).Columns.Add("ID")
        dx.Tables(1).Columns.Add("RepeatTime")
        dx.Tables(1).Columns.Add("StartTime")

        dx.Tables.Add("ConnectionParameters")
        dx.Tables(2).Columns.Add("ID")
        dx.Tables(2).Columns.Add("ConnectionMode")
        dx.Tables(2).Columns.Add("DefaultGateway")
        dx.Tables(2).Columns.Add("SubnetMask")
        dx.Tables(2).Columns.Add("ComputerIp")
        dx.Tables(2).Columns.Add("MacAddress")
        dx.Tables(2).Columns.Add("EthernetPortDescription")

        dx.Tables.Add("ScheduledLog")
        dx.Tables(3).Columns.Add("ID")
        dx.Tables(3).Columns.Add("SS_ID")
        dx.Tables(3).Columns.Add("SsName")
        dx.Tables(3).Columns.Add("TimeStamp")
        dx.Tables(3).Columns.Add("RouterIp")
        dx.Tables(3).Columns.Add("RouterAvailability")
        dx.Tables(3).Columns.Add("RouterResponseTime")
        dx.Tables(3).Columns.Add("GatewayIp")
        dx.Tables(3).Columns.Add("GatewayAvailability")
        dx.Tables(3).Columns.Add("GatewayResponseTime")

        dx.Tables.Add("AllLog")
        dx.Tables(4).Columns.Add("ID")
        dx.Tables(4).Columns.Add("SS_ID")
        dx.Tables(4).Columns.Add("SsName")
        dx.Tables(4).Columns.Add("TimeStamp")
        dx.Tables(4).Columns.Add("RouterIp")
        dx.Tables(4).Columns.Add("RouterAvailability")
        dx.Tables(4).Columns.Add("RouterResponseTime")
        dx.Tables(4).Columns.Add("GatewayIp")
        dx.Tables(4).Columns.Add("GatewayAvailability")
        dx.Tables(4).Columns.Add("GatewayResponseTime")

        Try
            Using con As New SQLiteConnection(ConnectionString)
                con.Open()
                ReadTable(con, dx, "SsNames")
                ReadTable(con, dx, "ScanSchedule")
                ReadTable(con, dx, "ConnectionParameters")
                ReadTable(con, dx, "ScheduledLog")
                ReadTable(con, dx, "AllLog")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MyOpenFile = dx


    End Function


    Public Function SaveTable(ByRef Conxn As SQLiteConnection, ByRef thisDataSet As DataSet, ByVal TableName As String) As Boolean
        Dim SQL As String
        Dim da As SQLiteDataAdapter
        SQL = "Select * From " & TableName
        da = New SQLiteDataAdapter(SQL, Conxn)
        Dim updateCmd As New SQLiteCommandBuilder(da)
        Dim deleteCmd As New SQLiteCommandBuilder(da)
        Dim insertCmd As New SQLiteCommandBuilder(da)
        da.UpdateCommand = updateCmd.GetUpdateCommand()
        da.InsertCommand = insertCmd.GetInsertCommand()
        da.DeleteCommand = deleteCmd.GetDeleteCommand()
        da.Update(thisDataSet, TableName)
        SaveTable = True
    End Function


    Public Function ReadTable(ByRef Conxn As SQLiteConnection, ByRef thisDataSet As DataSet, ByVal TableName As String) As Boolean
        Dim SQL As String
        Dim da As SQLiteDataAdapter
        SQL = "Select * From " & TableName
        da = New SQLiteDataAdapter(SQL, Conxn)
        da.Fill(thisDataSet, TableName)
        ReadTable = True
    End Function

    Public Function GetFileNameToSave(ByRef FlSave As SaveFileDialog) As String
        Dim userResponse As New MsgBoxResult
        userResponse = MsgBox("The file has not been saved." & vbCrLf & "Do you want to save it now?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel)
        If userResponse = MsgBoxResult.Yes Then
            FlSave.ShowDialog()
            GetFileNameToSave = FlSave.FileName
            Exit Function
        End If
        If userResponse = MsgBoxResult.No Then
            GetFileNameToSave = ""
            Exit Function
        End If
        If userResponse = MsgBoxResult.Cancel Then
            GetFileNameToSave = "Canceled"
            Exit Function
        End If
        GetFileNameToSave = Nothing
    End Function

    Public Function OpenFile(ByVal ConnectionString As String) As DataSet
        Dim SQL As String
        Dim dx As DataSet
        Dim da As SQLiteDataAdapter


        '3) Generate a fresh data set of rquired structure
        dx = New DataSet
        dx.Tables.Add("Squares")
        dx.Tables(0).Columns.Add("number")
        dx.Tables(0).Columns.Add("square")

        '4.a) Generate data adapter
        SQL = "SELECT * FROM Squares"
        Try
            Using con As New SQLiteConnection(ConnectionString)
                con.Open()
                da = New SQLiteDataAdapter(SQL, con)

                '4.b) Fill record set using data adapter
                da.Fill(dx, "Squares")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        OpenFile = dx


    End Function

    Public Function SettingsControlVisibility(ByVal x As Boolean) As Boolean
        For Each tab As TabPage In Form1.TabControl1.TabPages
            If tab.Name = "TabPage2" Then
                For Each ctr As Control In tab.Controls
                    ctr.Visible = x
                Next ctr
            End If
        Next tab
        SettingsControlVisibility = True
    End Function


End Module


'Tables and It’s columns in *.mcnx database

'1)	SsNames
'       a.	SS_ID    				Text 	Primary Key
'       b.	SsName  				Text	Not Null
'       c.	RouterIp				Text	Not Null
'       d.	GatewayIp				Text 	Not Null
'2)	ScanSchedule
'       a.	ID                      Integer Primary Key
'       a.  RepeatTime				Integer Not Null
'       b.	StartTime				Integer Not Null
'3)	ConnectionParameters
'       a.	ID                      Integer Primary Key
'       a.	ConnectionMode			Text Not Null
'       a.	DefaultGateway			Text Not Null
'       b.	SubnetMask				Text Not Null
'       c.	ComputerIp				Text Not Null
'       d.	MacAddress				Text Not Null
'       e.	EthernetPortDescription	Text Not Null
'4)	ScheduledLog
'       a.	ID                      Integer Primary Key
'       a.	SS_ID					Text Not Null
'       b.	SsName  				Text Not Null
'       c.	TimeStamp				Text Not Null
'       d.	RouterIp				Text Not Null
'       e.	RouterAvailability		Real Not Null
'       f.	RouterResponseTime		Real Not Null 
'       g.	GatewayIp				Text Not Null
'       h.	GatewayAvailability		Real Not Null
'       i.	GatewayResponseTime		Real Not Null

'5)	AllLog
'       a.	ID                      Integer Primary Key
'       a.	SS_ID					Text Not Null
'       b.	SsName				    Text Not Null
'       c.	TimeStamp				Text Not Null
'       d.	RouterIp				Text Not Null
'       e.	RouterAvailability		Real Not Null
'       f.	RouterResponseTime		Real Not Null 
'       g.	GatewayIp				Text Not Null
'       h.	GatewayAvailability		Real Not Null
'       i.	GatewayResponseTime		Real Not Null
