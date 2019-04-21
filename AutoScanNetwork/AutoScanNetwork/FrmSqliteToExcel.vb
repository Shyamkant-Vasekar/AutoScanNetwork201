Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SQLite

Public Class FrmSqliteToExcel
    Dim da As SQLiteDataAdapter
    Dim ds As DataSet
    Dim ConnectionString As String '= "Data Source=F:\MyWork\IpNetScan\AutoScanNetwork20\MCNX\Sample.mcnx;Version=3;"
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim RowNdx As Integer
        Dim ColNdx As Integer
        Dim rec As Integer



        Dim Sql As String = "SELECT * FROM ScheduledLog"

        ConnectionString = Form1.lblConnection.Text

        da = New SQLiteDataAdapter(Sql, ConnectionString)
        'MsgBox("Created DataAdapter", MsgBoxStyle.Information)
        ds = New DataSet()
        'MsgBox("Created DataSet", MsgBoxStyle.Information)
        da.Fill(ds)
        'MsgBox(ds.Tables(0).Rows.Count.ToString() & " Records copied to data table", MsgBoxStyle.Information)
        ProgressBar1.Maximum = ds.Tables(0).Rows.Count * 10

        Label1.Text = "Exporting " & ds.Tables(0).Rows.Count.ToString() & " Records"

        'Close all open excel applications without warning
        Dim xlp() As Process = Process.GetProcessesByName("EXCEL")
        For Each Process As Process In xlp
            Process.Kill()
        Next
        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = xlWorkBook.Worksheets("Sheet1")

        Try
            For ColNdx = 1 To 10
                xlWorkSheet.Cells(1, ColNdx) = ds.Tables(0).Columns(ColNdx - 1).ColumnName
            Next

            For RowNdx = 1 To ds.Tables(0).Rows.Count
                For ColNdx = 1 To 10   'We know that ScheduledLog table has 10 columns i.e 9 index
                    xlWorkSheet.Cells(RowNdx + 1, ColNdx) = ds.Tables(0).Rows(RowNdx - 1).Item(ColNdx - 1).ToString()
                    ProgressBar1.Value = (RowNdx - 1) * ColNdx + ColNdx
                Next
                rec = rec + 1
            Next

        Catch ex As Exception
            MsgBox("ERROR While writting: " & ex.Message, MsgBoxStyle.Exclamation)
            CloseXlBook()
            MsgBox(rec & " Records expoted")
            Exit Sub
        End Try
        'CloseXlBook()
        MsgBox(rec & " Records expoted", MsgBoxStyle.Information)
        xlApp.Visible = True
        Me.Close()
    End Sub

    'Not used for this project but a good code
    Private Sub CloseXlBook()
        xlWorkBook.Save()
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    'Not used for this project but a good code
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub FrmSqliteToExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
    End Sub
End Class


