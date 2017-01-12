Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Public Class fPrioritas
    Dim comm As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Private Sub fPrioritas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        autoArt()
        autoCust()

    End Sub

    Private Sub txtNamaCust_TextChanged(sender As Object, e As EventArgs) Handles txtNamaCust.TextChanged
        Dim rd As SqlDataReader
        comm = New SqlCommand("select kdCust from customer where nama ='" & txtNamaCust.Text & "'", mwa)
        rd = comm.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtKodeCust.Text = rd.Item("kdCust")

        End If
        rd.Close()
    End Sub

    Private Sub txtArt_TextChanged(sender As Object, e As EventArgs) Handles txtArt.TextChanged
        Dim rd As SqlDataReader
        comm = New SqlCommand("select kdArt,hargaArt,mataUang from art where namaArt ='" & txtArt.Text & "'", mwa)
        rd = comm.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtkodeArt.Text = rd.Item("kdArt")
            txtHarga.Text = rd.Item("hargaArt")
        End If
        rd.Close()
    End Sub

    Private Sub autoCust()
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim dt As DataTable

        cmd = New SqlCommand("select nama from customer", mwa)
        adapter = New SqlDataAdapter(cmd)
        dt = New DataTable
        adapter.Fill(dt)

        Dim col As New AutoCompleteStringCollection
        'Melakukan perulangan untuk mengisi col sebanyak data dari datatable
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("nama"))
        Next

        txtNamaCust.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNamaCust.AutoCompleteCustomSource = col
        txtNamaCust.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub autoArt()
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim dt As DataTable

        cmd = New SqlCommand("select namaArt from art", mwa)
        adapter = New SqlDataAdapter(cmd)
        dt = New DataTable
        adapter.Fill(dt)

        Dim col As New AutoCompleteStringCollection
        'Melakukan perulangan untuk mengisi col sebanyak data dari datatable
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("namaArt"))
        Next

        txtArt.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtArt.AutoCompleteCustomSource = col
        txtArt.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t() As TextBox = {txtKodeCust, txtkodeArt, txtHarga}
   
        If validasi(t) Then
            Try
                comm = New SqlCommand("exec sp_prioritas'" & txtKodeCust.Text & "', '" & txtkodeArt.Text & "', '" & txtHarga.Text & "'", mwa)
                comm.ExecuteNonQuery()
                Label1.Visible = True
                Label1.Text = "Data Has Been Saved "
            Catch ex As Exception
                MsgBox("Gagal karena, " & ex.Message)
            End Try

        End If

    End Sub
End Class