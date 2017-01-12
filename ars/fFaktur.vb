Imports System.Data
Imports System.Data.SqlClient
Imports System.Math

Public Class fFaktur
      Dim comm As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbFormat.Text = "EURO" Then
            Dim t() As TextBox = {txtArt, txtHarga, txtQty}
            If validasi(t) Then
                ' If btSimpan.Text = "Simpan" Then
                Dim total As Decimal

                total = txtHarga.Text * txtQty.Text
                total = Round(total, 3)

                Try
                    With DataGridView1
                        .Rows.Insert(.NewRowIndex, txtkodeArt.Text, txtArt.Text, txtKet.Text, txtQty.Text, txtHarga.Text, total)
                    End With
                Catch ex As Exception
                    MsgBox("Gagal karena DETAIL, " & ex.Message)
                End Try



                Dim a As Decimal
                a = 0
                For i As Integer = a To DataGridView1.Rows.Count - 1
                    a = a + Val(DataGridView1.Rows(i).Cells(5).Value)
                Next i

                Dim b As Integer
                txtTotal.Text = a

                b = a * txtKurs.Text
                txtTotal1.Text = Format(b, "#,###,###,###.##")


            Else
                MsgBox("Data Gagal Tersimpan", 16)

            End If

        ElseIf cmbFormat.Text = "EURO - IDR" Then

            Dim t() As TextBox = {txtArt, txtHarga, txtQty}
            If validasi(t) Then
                ' If btSimpan.Text = "Simpan" Then
                Dim total As Decimal
                Dim jumlahIDR As Integer

                total = txtHarga.Text * txtQty.Text
                total = Round(total, 3)

                If txtMatauang.Text = "EURO" Then

                    jumlahIDR = total * txtKurs.Text
                Else
                    jumlahIDR = total
                End If

                Try
                    With DataGridView1
                        .Rows.Insert(.NewRowIndex, txtkodeArt.Text, txtArt.Text, txtKet.Text, txtQty.Text, txtHarga.Text, total, jumlahIDR)
                    End With
                Catch ex As Exception
                    MsgBox("Gagal karena DETAIL, " & ex.Message)
                End Try



                Dim a As Decimal
                a = 0
                For i As Integer = a To DataGridView1.Rows.Count - 1
                    a = a + Val(DataGridView1.Rows(i).Cells(6).Value)
                Next i

              
                txtTotal1.Text = Format(a, "#,###,###,###.##")


            Else
                MsgBox("Data Gagal Tersimpan", 16)

            End If



        Else
            Dim t() As TextBox = {txtArt, txtHarga, txtQty}
            If validasi(t) Then
                ' If btSimpan.Text = "Simpan" Then
                Dim total As Decimal

                total = txtHarga.Text * txtQty.Text
                total = Round(total, 3)

                Try
                    With DataGridView1
                        .Rows.Insert(.NewRowIndex, txtkodeArt.Text, txtArt.Text, txtKet.Text, txtQty.Text, txtHarga.Text, total)
                    End With
                Catch ex As Exception
                    MsgBox("Gagal karena DETAIL, " & ex.Message)
                End Try



                Dim a As Integer
                a = 0
                For i As Integer = a To DataGridView1.Rows.Count - 1
                    a = a + Val(DataGridView1.Rows(i).Cells(5).Value)
                Next i
                txtTotal.Text = Format(a, "#,###,###,###.##")
            Else
                MsgBox("Data Gagal Tersimpan", 16)

            End If


            
        End If
       


            
    End Sub

    Private Sub fFaktur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        autoCust()
        autoArt()

        cmbFormat.Items.Add("EURO")
        cmbFormat.Items.Add("EURO - IDR")
        cmbFormat.Items.Add("IDR")

        comm = New SqlCommand("select dbo.no_otomatis()", mwa)
        Label3.Text = comm.ExecuteScalar()


    End Sub

    Private Sub txtNamaCust_TextChanged(sender As Object, e As EventArgs) Handles txtNamaCust.TextChanged
        Dim rd As SqlDataReader
        comm = New SqlCommand("select kdCust,kota from customer where nama ='" & txtNamaCust.Text & "'", mwa)
        rd = comm.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtKodeCust.Text = rd.Item("kdCust")
            txtKota.Text = rd.Item("kota")
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
            txtMatauang.Text = rd.Item("mataUang")
        End If
        rd.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save_faktur()
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                comm = New SqlCommand("exec sp_DFaktur'" & Label3.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & txtKurs.Text & "'", mwa)
                comm.ExecuteNonQuery()
                Label1.Text = "Data Has Been Save"
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub save_faktur()
        Try
            comm = New SqlCommand("insert into HFaktur values ('" & Label3.Text & "','" & txtTanggal.Text & "','" & txtKodeCust.Text & "')", mwa)
            comm.ExecuteNonQuery()
            Label1.Visible = True
            ' Label1.Text = "Data Has Been Saved "
        Catch ex As Exception
            MsgBox("Gagal karena PO, " & ex.Message)
        End Try
    End Sub
End Class