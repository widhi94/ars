﻿Imports System.Data
Imports System.Data.SqlClient

Public Class fArt
    Dim comm As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As DataSet

    Private Sub fArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim t() As TextBox = {txtKode, txtNama, txtMataUang, txtHarga, txtKet}

        If validasi(t) Then
            Try
                comm = New SqlCommand("exec sp_art'" & txtKode.Text & "', '" & txtNama.Text & "','" & txtMatauang.Text & "','" & txtHarga.Text & "','" & txtKet.Text & "'", mwa)
                comm.ExecuteNonQuery()
                Label1.Visible = True
                Label1.Text = "Data Has Been Saved "
            Catch ex As Exception
                MsgBox("Gagal karena, " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        fFaktur.Show()

    End Sub
End Class