Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates

Public Class formKujundid
    Public abi1 As Int32

    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tuubi valjastamine
        lblTyyp.Text = kujund.annaTyyp
        'Pindala ja umbermoodu arvutamine ja valjastamine
        txtPindala.Text = Math.Round(kujund.leiaPindala, abi1)
        txtYmbermoot.Text = Math.Round(kujund.leiaYmberMoot, abi1)
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnKolmnurk.Click
        'Objekt kolmnurga klassist
        Try
            Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
            tootleKujund(objektKolmnurk)
            lblViga.Text = ""
        Catch ex As Exception
            'MsgBox("Viga!")
            lblViga.Text = "Viga sisendis!"
        End Try

    End Sub

    Private Sub btnRuut_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRuut.Click
        'Objekt ruudu klassist
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRistkylik.Click
        'Objekt ristkyliku klassist
        Dim objektRistkylik As New Ristkylik(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektRistkylik)
    End Sub

    Private Sub combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox.SelectedIndexChanged

        abi1 = combobox.SelectedItem

    End Sub

    Private Sub btnRomb_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRomb.Click
        Dim objektRomb As New Romb(txtKylgA.Text, txtKorgus.Text)
        tootleKujund(objektRomb)
    End Sub

    Private Sub btnRoopkylik_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRoopkylik.Click
        Dim objektRoopkylik As New Roopkylik(txtKylgA.Text, txtKorgus.Text)
        tootleKujund(objektRoopkylik)
    End Sub
End Class
