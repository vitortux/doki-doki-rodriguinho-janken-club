Public Class Screen2

    Private Sub btnPedra_Click(sender As Object, e As EventArgs) Handles btnPedra.Click
        Dim PC As Integer

        PC = Int((3 * Rnd()) + 1)

        Select Case PC
            Case 1 'Tesoura
                scrnPedraWin.Show()
                Me.Close()
            Case 2 'Pedra
                scrnPedraDraw.Show()
                Me.Close()
            Case 3 'Papel
                scrnPedraLose.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnPapel_Click(sender As Object, e As EventArgs) Handles btnPapel.Click
        Dim PC As Integer

        PC = Int((3 * Rnd()) + 1)

        Select Case PC
            Case 1 'Pedra
                scrnPapelWin.Show()
                Me.Close()
            Case 2 'Papel
                scrnPapelDraw.Show()
                Me.Close()
            Case 3 'Tesoura
                scrnPapelLose.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnTesoura_Click(sender As Object, e As EventArgs) Handles btnTesoura.Click
        Dim PC As Integer

        PC = Int((3 * Rnd()) + 1)

        Select Case PC
            Case 1 'Papel
                scrnTesouraWin.Show()
                Me.Close()
            Case 2 'Tesoura
                scrnTesouraDraw.Show()
                Me.Close()
            Case 3 'Pedra
                scrnTesouraLose.Show()
                Me.Close()
        End Select
    End Sub
End Class