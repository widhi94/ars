Imports System.Data
Imports System.Data.SqlClient

Public Class fCust
    Dim comm As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim t() As TextBox = {txtKodeCust, txtNama, txtKota, txtAlamat, txtNotelp}

        If validasi(t) Then
            Try
                comm = New SqlCommand("exec sp_cust'" & txtKodeCust.Text & "', '" & txtNama.Text & "', '" & txtKota.Text & "', '" & txtAlamat.Text & "', '" & txtNotelp.Text & "'", mwa)
                comm.ExecuteNonQuery()
                Label1.Visible = True
                Label1.Text = "Data Has Been Saved "
            Catch ex As Exception
                MsgBox("Gagal karena, " & ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        fArt.Show()

    End Sub
End Class
