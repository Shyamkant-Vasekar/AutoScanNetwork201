Imports System.Management
Imports System.Text.RegularExpressions
Public Class FrmGetMacAddress

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim dt As New DataTable("xyz")
        Dim dr As DataRow
        dt.Columns.Add("Col1")
        dt.Columns.Add("Col2")
        dt.Columns("Col1").DataType = System.Type.GetType("System.String")
        dt.Columns("Col2").DataType = System.Type.GetType("System.String")
        For i = 0 To 10
            dr = dt.NewRow()
            dr("Col1") = "abc"
            dr("Col2") = "pqr"
            dt.Rows.Add(dr)
        Next
        dgv.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim k(10, 5) As String
        AcceptTwoDimentionalArrayAndFillIt(k)
        For R = 0 To 9
            For C = 0 To 5
                If Not IsNothing(k(R, C)) Then
                    MsgBox(k(R, C).ToString())
                End If
            Next
        Next
    End Sub

    Function AcceptTwoDimentionalArrayAndFillIt(ByRef x As String(,)) As Boolean
        Dim result As Boolean = False
        For I = 1 To 3
            For J = 1 To 2
                x(I, J) = (10 * J + I).ToString()
            Next
        Next
        result = True
        AcceptTwoDimentionalArrayAndFillIt = result
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyNetworkData(100, 2) As String
        Dim dt As New DataTable("xyz")
        Dim dr As DataRow
        dt.Columns.Add("Col1")
        dt.Columns.Add("Col2")
        dt.Columns("Col1").DataType = System.Type.GetType("System.String")
        dt.Columns("Col2").DataType = System.Type.GetType("System.String")

        GetNetworkData(MyNetworkData)

        For R = 0 To 99
            If Not IsNothing(MyNetworkData(R, 1)) Then 'MyNetworkData(R,1) is MAC Address
                dr = dt.NewRow()
                dr("Col1") = MyNetworkData(R, 0)
                dr("Col2") = MyNetworkData(R, 1)
                dt.Rows.Add(dr)
            End If
        Next

        dgv.DataSource = dt
        dgv.Columns(0).Width = 450
        dgv.Columns(1).Width = 230
        dgv.Columns(0).HeaderText = "Netwok Interface Card Description"
        dgv.Columns(1).HeaderText = "MAC Address (Separator Removed)"
    End Sub



    Function GetNetworkData(ByRef ntwd As String(,)) As Boolean
        Dim thisDescription As String
        Dim origMAC As String
        Dim repMAC As String
        Dim pattern As String = ":"
        Dim rgx As New Regex(pattern)
        Dim replacement As String = ""
        Dim ThisRecord As Integer = 0

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        For Each objMO As ManagementObject In objMOC
            Try
                thisDescription = objMO("Description")

                ' remove colons from mac address so that it could match the provided mac address
                origMAC = objMO("MacAddress")

                If Not IsNothing(origMAC) Then
                    ' the mac address with colons removed from it
                    repMAC = rgx.Replace(origMAC, replacement)
                    ntwd(ThisRecord, 0) = thisDescription
                    ntwd(ThisRecord, 1) = repMAC
                End If
                ThisRecord = ThisRecord + 1
            Catch ex As Exception
                MsgBox("ERROR :" & ex.Message, MsgBoxStyle.Critical)
            End Try

        Next

        GetNetworkData = True

    End Function


End Class
