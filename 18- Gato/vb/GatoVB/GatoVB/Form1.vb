Public Class frmGatoVB

    Dim botonUno, botonDos, botonTres, botonCuatro, botonCinco, botonSeis, botonSiete, botonOcho, botonNueve, nadieGana As Boolean
    Dim turno, numeroRandom As Integer

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        If turno = 1 Then
            botonSiete = True
            btnSiete.Enabled = False
            lbl7.Text = "X"
            turno = 2
        Else
            botonSiete = True
            btnSiete.Enabled = False
            lbl7.Text = "O"
            turno = 1
        End If

    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        If turno = 1 Then
            botonOcho = True
            btnOcho.Enabled = False
            lbl8.Text = "X"
            turno = 2
        Else
            botonOcho = True
            btnOcho.Enabled = False
            lbl8.Text = "O"
            turno = 1
        End If

    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        If turno = 1 Then
            botonNueve = True
            btnNueve.Enabled = False
            lbl9.Text = "X"
            turno = 2
        Else
            botonNueve = True
            btnNueve.Enabled = False
            lbl9.Text = "O"
            turno = 1
        End If

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If Not txtPlayer1.Text = "" And Not txtPlayer2.Text = "" Then

            Randomize()
            numeroRandom = Convert.ToInt32(Rnd() * 100)
            If numeroRandom <= 50 Then
                turno = 1
                MsgBox("Turno de " & txtPlayer1.Text)
            Else
                turno = 2
                MsgBox("Turno de " & txtPlayer2.Text)
            End If

            txtPlayer1.Enabled = False
            txtPlayer2.Enabled = False
            btnSeis.Enabled = True
            btnSiete.Enabled = True
            btnOcho.Enabled = True
            btnNueve.Enabled = True
            btnUno.Enabled = True
            btnDos.Enabled = True
            btnTres.Enabled = True
            btnCuatro.Enabled = True
            btnCinco.Enabled = True
            btnGo.Enabled = False

            tmrTiempo.Enabled = True
        End If
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        If turno = 1 Then
            botonSeis = True
            btnSeis.Enabled = False
            lbl6.Text = "X"
            turno = 2

        Else
            botonSeis = True
            btnSeis.Enabled = False
            lbl6.Text = "O"
            turno = 1

        End If


    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        If turno = 1 Then
            botonCinco = True
            btnCinco.Enabled = False
            lbl5.Text = "X"
            turno = 2
        Else
            botonCinco = True
            btnCinco.Enabled = False
            lbl5.Text = "O"
            turno = 1
        End If


    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        If turno = 1 Then
            botonCuatro = True
            btnCuatro.Enabled = False
            lbl4.Text = "X"
            turno = 2

        Else
            botonCuatro = True
            btnCuatro.Enabled = False
            lbl4.Text = "O"
            turno = 1
        End If

    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        If turno = 1 Then
            botonTres = True
            btnTres.Enabled = False
            lbl3.Text = "X"
            turno = 2
        Else
            botonTres = True
            btnTres.Enabled = False
            lbl3.Text = "O"
            turno = 1

        End If

    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        If turno = 1 Then
            botonDos = True
            btnDos.Enabled = False
            lbl2.Text = "X"
            turno = 2
        Else
            botonDos = True
            btnDos.Enabled = False
            lbl2.Text = "O"
            turno = 1

        End If

    End Sub

    Private Sub frmGatoVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSeis.Enabled = False
        btnSiete.Enabled = False
        btnOcho.Enabled = False
        btnNueve.Enabled = False
        btnUno.Enabled = False
        btnDos.Enabled = False
        btnTres.Enabled = False
        btnCuatro.Enabled = False
        btnCinco.Enabled = False

    End Sub


    'Contador
    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick

        If lbl1.Text = "X" And lbl2.Text = "X" And lbl3.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            Application.Restart()
        ElseIf lbl4.Text = "X" And lbl5.Text = "X" And lbl6.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl7.Text = "X" And lbl8.Text = "X" And lbl9.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl1.Text = "X" And lbl4.Text = "X" And lbl7.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl2.Text = "X" And lbl5.Text = "X" And lbl8.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl3.Text = "X" And lbl6.Text = "X" And lbl9.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl1.Text = "X" And lbl5.Text = "X" And lbl9.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl3.Text = "X" And lbl5.Text = "X" And lbl7.Text = "X" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer1.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        End If



        If lbl1.Text = "O" And lbl2.Text = "O" And lbl3.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            Application.Restart()
        ElseIf lbl4.Text = "O" And lbl5.Text = "O" And lbl6.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl7.Text = "O" And lbl8.Text = "O" And lbl9.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl1.Text = "O" And lbl4.Text = "O" And lbl7.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl2.Text = "O" And lbl5.Text = "O" And lbl8.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl3.Text = "O" And lbl6.Text = "O" And lbl9.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl1.Text = "O" And lbl5.Text = "O" And lbl9.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        ElseIf lbl3.Text = "O" And lbl5.Text = "O" And lbl7.Text = "O" Then
            tmrTiempo.Enabled = False
            MsgBox("gano " & txtPlayer2.Text)
            tmrTiempo.Enabled = False
            Application.Restart()
        End If

        If Not lbl1.Text = "" And Not lbl2.Text = "" And Not lbl3.Text = "" And Not lbl4.Text = "" And Not lbl5.Text = "" And Not lbl6.Text = "" And Not lbl7.Text = "" And Not lbl8.Text = "" And Not lbl9.Text = "" Then

            If nadieGana = True Then
                tmrTiempo.Enabled = False
                MsgBox("Nadie gana")
                Application.Restart()
            End If
            nadieGana = True

        End If

        If turno = 1 Then
            lblPlayer1.BackColor = Color.Red
            lblPlayer2.BackColor = Color.White
        Else
            lblPlayer1.BackColor = Color.White
            lblPlayer2.BackColor = Color.Red
        End If


    End Sub



    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        If turno = 1 Then
            botonUno = True
            btnUno.Enabled = False
            lbl1.Text = "X"
            turno = 2

        Else
            botonUno = True
            btnUno.Enabled = False
            lbl1.Text = "O"
            turno = 1

        End If

    End Sub
End Class
