Public Class Pelajar
    Private strNoMatrik As String
    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik

    End Sub
    Public Function Politeknik() As String
        Dim strKodPoli As String = strNoMatrik.Substring(0, 2)
        If strKodPoli = "18" Then
            Return "PTSS"
        Else
            Return "Not PTSS"
        End If

    End Function

    Public Function Program()
        Dim strKodCourse As String = strNoMatrik.Substring(2, 3)
        If strKodCourse = "DDT" Then
            Return "Diploma Teknologi Maklumat"
        Else
            Return "Not Diploma Teknologi Maklumat"

        End If



    End Function

    Public Function Ambilan()
        Dim strKodAmbilan As String = strNoMatrik.Substring(5, 2)

        If strKodAmbilan = "19" Then
            Return "Sesi Jun 2019"
        Else
            Return "Not sesi Jun 2019"
        End If

    End Function
End Class