Public Class Cuti
    Dim tipeCuti, nomorDarurat, tipeCutis, idCuti, remarksCuti As String
    Dim tglMulai, tglAkhir, tanggalInput As DateTime
    Dim totalHari As Integer

    Public Sub setCuti(ID, tipe, tipes, nomor, mulai, akhir, remarks)
        idCuti = ID
        tanggalInput = Now()
        tipeCuti = tipe
        tipeCutis = tipes
        nomorDarurat = nomor
        tglMulai = mulai
        tglAkhir = akhir
        totalHari = kalkulasiHari(tglMulai, tglAkhir)
        remarksCuti = remarks
    End Sub

    Private Function kalkulasiHari(mulai, akhir)
        Return akhir.Subtract(mulai).Days + 1
    End Function

    Public Function getID()
        Return idCuti
    End Function

    Public Function getTanggalInput()
        Return tanggalInput
    End Function

    Public Function getTipeCuti()
        Return tipeCuti
    End Function

    Public Function getTipeCutis()
        Return tipeCutis
    End Function

    Public Function getNomorDarurat()
        Return nomorDarurat
    End Function

    Public Function getTglMulai()
        Return tglMulai
    End Function

    Public Function getTglAkhir()
        Return tglAkhir
    End Function

    Public Function getTotalHari()
        Return totalHari
    End Function

    Public Function getRemarks()
        Return remarksCuti
    End Function
End Class
