Imports System.Net.NetworkInformation
Module GeneralScanNetwork
    Public Function McnxPing(ByRef mcnxDataSet As DataSet) As Boolean
        Dim RouterIp As String
        Dim GatewayIp As String
        Dim RouterPingResult As PingResult
        Dim GatewayPingResult As PingResult
        Dim dr As DataRow
        Dim TtlRecCount As Integer



        TtlRecCount = mcnxDataSet.Tables("SsNames").Rows.Count

        FrmPingStatus.Show()
        Try
            For I = 0 To TtlRecCount - 1 'ZERO BASED INDEX
                RouterIp = mcnxDataSet.Tables("SsNames").Rows(I).Item("RouterIp")
                GatewayIp = mcnxDataSet.Tables("SsNames").Rows(I).Item("GatewayIp")
                FrmPingStatus.LblCurrentRec.Text = (I + 1).ToString()
                FrmPingStatus.LblSsName.Text = mcnxDataSet.Tables("SsNames").Rows(I).Item("SsName")
                FrmPingStatus.LblTtlRec.Text = TtlRecCount.ToString()
                Application.DoEvents()
                RouterPingResult = MyPingTrial(RouterIp)
                GatewayPingResult = MyPingTrial(GatewayIp)
                'FrmPingStatus.LblError.Text = ""

                'Create new record and write respective results into it
                dr = mcnxDataSet.Tables("AllLog").NewRow()
                dr("SS_ID") = mcnxDataSet.Tables("SsNames").Rows(I).Item("SS_ID")
                dr("SsName") = mcnxDataSet.Tables("SsNames").Rows(I).Item("SsName")
                dr("TimeStamp") = Now().ToString("yyyy.MM.dd HH:mm")
                dr("RouterIp") = mcnxDataSet.Tables("SsNames").Rows(I).Item("RouterIp")
                dr("RouterAvailability") = RouterPingResult.Availability
                dr("RouterResponseTime") = RouterPingResult.AvgResponseTime
                dr("GatewayIp") = mcnxDataSet.Tables("SsNames").Rows(I).Item("GatewayIp")
                dr("GatewayAvailability") = GatewayPingResult.Availability
                dr("GatewayResponseTime") = GatewayPingResult.AvgResponseTime
                mcnxDataSet.Tables("AllLog").Rows.Add(dr)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FrmPingStatus.FormBorderStyle = FormBorderStyle.Fixed3D
        FrmPingStatus.ControlBox = True
        FrmPingStatus.LblError.ForeColor = Color.Green
        FrmPingStatus.LblError.Text = "Scanning Completed...."
        McnxPing = True

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

    'REWRITTEN IN MODULE ScheduleScan MAY REQUIRE CORRECTION
    Private Class PingResult
        Public Property Availability As Double
        Public Property AvgResponseTime As Double
    End Class

End Module
