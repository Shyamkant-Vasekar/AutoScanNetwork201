Imports System.Net.NetworkInformation
Imports System.Globalization.DateTimeFormatInfo
Module ScheduleScan

    Public Function ScheduleTime(ByRef McnxDataSet As DataSet) As Boolean
        Dim ThisRecTime As DateTime
        Dim ValidationTime As Double
        Dim StartTime As Double
        Dim RepeatTime As Double
        Dim TimeDeviation As Double
        ThisRecTime = Now()
        ValidationTime = ThisRecTime.Hour + ThisRecTime.Minute / 60.0
        RepeatTime = CDbl(McnxDataSet.Tables("ScanSchedule").Rows(0).Item("RepeatTime"))
        StartTime = CDbl(McnxDataSet.Tables("ScanSchedule").Rows(0).Item("StartTime"))
        TimeDeviation = Math.Abs(((ValidationTime - StartTime) / RepeatTime) - CInt(Math.Abs((ValidationTime - StartTime) / RepeatTime)))
        If TimeDeviation < 0.15 Or TimeDeviation > 0.85 Then
            ScheduleTime = True
        Else
            ScheduleTime = False
        End If
    End Function

    Public Function McnxScheduledPing(ByRef mcnxDataSet As DataSet) As Boolean
        Dim RouterIp As String
        Dim GatewayIp As String
        Dim RouterPingResult As PingResult
        Dim GatewayPingResult As PingResult
        Dim TtlRecCount As Integer
        Dim thisSS_ID As String
        Dim TmDev As Double
        Dim RptTm As Integer
        If (MsgBox("Scanning more than once in same scheduled time window" & vbCrLf & _
               "To happen it correctly ensure recent records has got the ID" & vbCrLf & _
               "(We get ID to records in Scheduled Log table by re-opening after fresh scan)" & vbCrLf & _
               "Do you want to re-scan now", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            TtlRecCount = mcnxDataSet.Tables("SsNames").Rows.Count
            FrmPingStatus.LblTtlRec.Text = TtlRecCount.ToString()
            RptTm = CInt(mcnxDataSet.Tables("ScanSchedule").Rows(0).Item("RepeatTime"))

            FrmPingStatus.Show()
            Try
                For I = 0 To TtlRecCount - 1 'ZERO BASED INDEX
                    RouterIp = mcnxDataSet.Tables("SsNames").Rows(I).Item("RouterIp")
                    GatewayIp = mcnxDataSet.Tables("SsNames").Rows(I).Item("GatewayIp")
                    thisSS_ID = mcnxDataSet.Tables("SsNames").Rows(I).Item("SS_ID")
                    FrmPingStatus.LblCurrentRec.Text = (I + 1).ToString()
                    FrmPingStatus.LblSsName.Text = mcnxDataSet.Tables("SsNames").Rows(I).Item("SsName")
                    Application.DoEvents()
                    RouterPingResult = MyPingTrial(RouterIp)
                    GatewayPingResult = MyPingTrial(GatewayIp)

                    'Decide whether to update or append
                    'If for selected SS_ID last time scan is in current block of schedule
                    'i.e. deviting by LESS THAN 30% of RepeatTime from current time then update
                    TmDev = PrcntDevBtwnLastAndThisPingTmWrtRptTime(mcnxDataSet, thisSS_ID, RptTm)
                    'MsgBox("Time Deviation from last Ping " & TmDev.ToString("0.0000"))
                    If TmDev < 0.27 Then 'Slightly less than expected +/- 15%
                        'Update previous record and refresh data grid view
                        UpdateScheduledLog(mcnxDataSet, RouterPingResult, GatewayPingResult, thisSS_ID)
                    Else
                        'Create new record and write respective results into it
                        AppendScheduledLog(mcnxDataSet, RouterPingResult, GatewayPingResult, I)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            FrmPingStatus.FormBorderStyle = FormBorderStyle.Fixed3D
            FrmPingStatus.ControlBox = True
            FrmPingStatus.LblError.ForeColor = Color.Green
            FrmPingStatus.LblError.Text = "Scanning Completed...."
            McnxScheduledPing = True
        Else
            McnxScheduledPing = False
        End If
    End Function

    Private Function MyPingTrial(ByVal hostName As String) As PingResult
        Dim TmOut As Integer = 1000
        Dim Availability As Double
        Dim PingTrial As Integer
        Dim PingTrialSuccess As Integer
        Dim TotalResponseTime As Long
        Dim AverageResponseTime As Double
        Dim MyPingResult As New PingResult
        Dim pingreq As Ping = New Ping()

        Try
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
        Catch ex As Exception
            FrmPingStatus.LblError.Text = "Error while pinging :" & hostName
            MyPingResult.Availability = 0
            MyPingResult.AvgResponseTime = 10000.0
        End Try

        MyPingTrial = MyPingResult
    End Function

    Private Function PrcntDevBtwnLastAndThisPingTmWrtRptTime(ByRef dx As DataSet, ByVal ssid As String, ByVal RptTm As Integer) As Double
        Dim lastTmPrcntDeviationFromCurrentTm As Double
        Dim dblTimeDiff As Double
        Dim lastDtTm As DateTime
        Dim thisDtTm As DateTime
        Dim timeDiff As TimeSpan
        Dim lastDtTmStr As String
        Dim searchExpression As String
        searchExpression = "SS_ID = '" & ssid & "'"

        If dx.Tables("ScheduledLog").Select(searchExpression).Count > 0 Then 'IF FOUND TO DECIDE WHETHER UPDATE NECESSARY
            lastDtTmStr = dx.Tables("ScheduledLog").Select(searchExpression, "TimeStamp DESC").ElementAt(0).Item("TimeStamp")
            lastDtTm = DateTime.ParseExact(lastDtTmStr, "yyyy.MM.dd HH:mm", Nothing)
            'MsgBox("Last time scanning for - " & ssid & " carried out at - " & lastDtTmStr)
            thisDtTm = Now()
            'MsgBox("Now time is - " & thisDtTm.ToString("yyyy.MM.dd HH:mm"))
            timeDiff = thisDtTm.Subtract(lastDtTm)
            'MsgBox("Time Difference is - " & timeDiff.ToString() & " Repeat time is " & RptTm.ToString() & "Hours")
            dblTimeDiff = timeDiff.Hours * 60 + timeDiff.Minutes
            lastTmPrcntDeviationFromCurrentTm = dblTimeDiff / (RptTm * 60.0)
            'MsgBox("Percentage time deviation wrt repeat time is - " & lastTmPrcntDeviationFromCurrentTm.ToString("0.0000"))
            PrcntDevBtwnLastAndThisPingTmWrtRptTime = lastTmPrcntDeviationFromCurrentTm
        Else
            PrcntDevBtwnLastAndThisPingTmWrtRptTime = 3.0 '300% indicating not found case GO FOR APPEND
        End If
    End Function


    Private Function UpdateScheduledLog(ByRef dx As DataSet, ByVal routurpng As PingResult, ByVal gtwpng As PingResult, ByVal ssid As String) As Boolean
        Dim UpdtRowNdx As Integer
        UpdtRowNdx = GetLastRowIndex(dx, ssid)
        'Need to add logic for update only if results better
        dx.Tables("ScheduledLog").Rows(UpdtRowNdx).Item("RouterAvailability") = routurpng.Availability
        dx.Tables("ScheduledLog").Rows(UpdtRowNdx).Item("RouterResponseTime") = routurpng.AvgResponseTime
        dx.Tables("ScheduledLog").Rows(UpdtRowNdx).Item("GatewayAvailability") = gtwpng.Availability
        dx.Tables("ScheduledLog").Rows(UpdtRowNdx).Item("GatewayResponseTime") = gtwpng.AvgResponseTime
        UpdateScheduledLog = True
    End Function

    Private Function AppendScheduledLog(ByRef dx As DataSet, ByVal routurpng As PingResult, ByVal gtwpng As PingResult, ByVal usingSsNmRow As Integer) As Boolean
        Dim dr As DataRow
        dr = dx.Tables("ScheduledLog").NewRow()
        dr("SS_ID") = dx.Tables("SsNames").Rows(usingSsNmRow).Item("SS_ID")
        dr("SsName") = dx.Tables("SsNames").Rows(usingSsNmRow).Item("SsName")
        dr("TimeStamp") = Now().ToString("yyyy.MM.dd HH:mm")
        dr("RouterIp") = dx.Tables("SsNames").Rows(usingSsNmRow).Item("RouterIp")
        dr("RouterAvailability") = routurpng.Availability
        dr("RouterResponseTime") = routurpng.AvgResponseTime
        dr("GatewayIp") = dx.Tables("SsNames").Rows(usingSsNmRow).Item("GatewayIp")
        dr("GatewayAvailability") = gtwpng.Availability
        dr("GatewayResponseTime") = gtwpng.AvgResponseTime
        dx.Tables("ScheduledLog").Rows.Add(dr)
        AppendScheduledLog = True
    End Function

    Private Function GetLastRowIndex(ByRef dx As DataSet, ByVal ssid As String) As Integer
        Dim RecNdx As Integer
        RecNdx = dx.Tables("ScheduledLog").Rows.Count - 1

        For I = RecNdx To 0 Step -1
            If dx.Tables("ScheduledLog").Rows(I).Item("SS_ID") = ssid Then
                GetLastRowIndex = I
                Exit Function
            End If
        Next
        GetLastRowIndex = -1 'SOMTHING TO CREATE ERROR
    End Function



    'REWRITTEN IN MODULE GeneralScan MAY REQUIRE CORRECTION
    Public Class PingResult
        Public Property Availability As Double
        Public Property AvgResponseTime As Double
    End Class



End Module
