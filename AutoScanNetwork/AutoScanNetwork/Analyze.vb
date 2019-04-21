Imports System.Data.SQLite
Module Analyze
    Public Function GetLimitedData(ByVal NumOfDays As Integer) As DataTable
        Dim SQL As String
        Dim da As SQLiteDataAdapter
        Dim beforeTimeStamp As String
        Dim nowTimeStamp As String = Now().ToString("yyyy.MM.dd HH:mm")
        Dim dx As New DataSet() 'To use without disturbing original one i.e. MyDataSet
        dx.Tables.Add("ScheduledLog")
        dx.Tables(0).Columns.Add("ID")
        dx.Tables(0).Columns.Add("SS_ID")
        dx.Tables(0).Columns.Add("SsName")
        dx.Tables(0).Columns.Add("TimeStamp")
        dx.Tables(0).Columns.Add("RouterIp")
        dx.Tables(0).Columns.Add("RouterAvailability")
        dx.Tables(0).Columns.Add("RouterResponseTime")
        dx.Tables(0).Columns.Add("GatewayIp")
        dx.Tables(0).Columns.Add("GatewayAvailability")
        dx.Tables(0).Columns.Add("GatewayResponseTime")

        beforeTimeStamp = GetSomeDaysBeforeTimeStampString(NumOfDays)

        MsgBox("Loading data from : " & beforeTimeStamp & vbCrLf & _
               "(Get displayed under Scheduled Log tab)", MsgBoxStyle.Information)

        SQL = "SELECT * FROM ScheduledLog WHERE TimeStamp BETWEEN '" & beforeTimeStamp & "' AND '" & nowTimeStamp & "'"
        Try
            Using con As New SQLiteConnection(Form1.MyConnectionString)
                con.Open()
                da = New SQLiteDataAdapter(SQL, con)
                da.Fill(dx, "ScheduledLog")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        GetLimitedData = dx.Tables(0)
    End Function

    Public Function GetAvgData(ByVal NumOfDays As Integer) As DataTable
        'SELECT pub_id,avg(no_page) FROM book_mast GROUP BY pub_id;
        Dim SQL As String
        Dim da As SQLiteDataAdapter
        Dim dx As New DataSet() 'To use without disturbing original one i.e. MyDataSet
        Dim beforeTimeStamp As String
        Dim nowTimeStamp As String = Now().ToString("yyyy.MM.dd HH:mm")
        dx.Tables.Add("ConsolidateLog")
        dx.Tables(0).Columns.Add("SS_ID")
        dx.Tables(0).Columns.Add("SsName")
        dx.Tables(0).Columns.Add("RouterIp")
        dx.Tables(0).Columns.Add("AVG(RouterAvailability)")
        dx.Tables(0).Columns.Add("AVG(RouterResponseTime)")
        dx.Tables(0).Columns.Add("GatewayIp")
        dx.Tables(0).Columns.Add("AVG(GatewayAvailability)")
        dx.Tables(0).Columns.Add("AVG(GatewayResponseTime)")

        beforeTimeStamp = GetSomeDaysBeforeTimeStampString(NumOfDays)

        MsgBox("Consolidating data from : " & beforeTimeStamp & vbCrLf & _
               "(Get displayed under Scheduled Log tab)", MsgBoxStyle.Information)


        SQL = "SELECT SS_ID, SsName, RouterIp, AVG(RouterAvailability), AVG(RouterResponseTime), GatewayIp, AVG(GatewayAvailability), AVG(GatewayResponseTime) FROM ScheduledLog" & " WHERE TimeStamp BETWEEN '" & beforeTimeStamp & "' AND '" & nowTimeStamp & "' GROUP BY SS_ID"
        MsgBox(SQL)
        Try
            Using con As New SQLiteConnection(Form1.MyConnectionString)
                con.Open()
                da = New SQLiteDataAdapter(SQL, con)
                da.Fill(dx, "ConsolidateLog")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        GetAvgData = dx.Tables(0)
    End Function

    Private Function GetSomeDaysBeforeTimeStampString(ByVal days As Integer) As String
        Dim someDaysBeforeValue As DateTime
        Dim beforeTimeSpan As TimeSpan = New TimeSpan(days, 0, 0, 0)
        someDaysBeforeValue = Now().Subtract(beforeTimeSpan)
        GetSomeDaysBeforeTimeStampString = someDaysBeforeValue.ToString("yyyy.MM.dd HH:mm")
    End Function

End Module
