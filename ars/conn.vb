Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Module conn
    Public mwa As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Sub koneksi()
        mwa = New SqlConnection("Server=MWA\SQLEXPRESS;database=ars; integrated security=true")
        Try
            mwa.Open()
            ' MsgBox("Koneksi Terbuka...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function validasi(ByVal obj() As TextBox) As Boolean
        Dim i, j As Integer
        Dim cek As Boolean = True
        Dim objname As String = ""

        For j = 0 To obj.Length - 1
            If obj(j).Text.Length = 0 Then
                objname &= " " & obj(j).Name
            End If
        Next

        For i = 0 To obj.Length - 1
            If obj(i).Text.Length = 0 And cek Then
                cek = False
                Exit For
            End If
        Next

        If cek Then
            Return True
        Else
            MessageBox.Show(" please complete the data ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' obj(i).setfocus()

            Return False
        End If
    End Function







    'Martiyanti Widiastuti
End Module
