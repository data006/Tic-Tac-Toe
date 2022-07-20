<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGatoVB
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.pnlJuego = New System.Windows.Forms.Panel()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnNueve = New System.Windows.Forms.Button()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnOcho = New System.Windows.Forms.Button()
        Me.btnSiete = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.pnlJuego.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(357, 390)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(53, 13)
        Me.lblPlayer2.TabIndex = 11
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(132, 390)
        Me.lblPlayer1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(53, 13)
        Me.lblPlayer1.TabIndex = 10
        Me.lblPlayer1.Text = "Player 1"
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(344, 360)
        Me.txtPlayer2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(76, 20)
        Me.txtPlayer2.TabIndex = 9
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(120, 360)
        Me.txtPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(76, 20)
        Me.txtPlayer1.TabIndex = 8
        '
        'pnlJuego
        '
        Me.pnlJuego.BackColor = System.Drawing.SystemColors.Control
        Me.pnlJuego.Controls.Add(Me.lbl9)
        Me.pnlJuego.Controls.Add(Me.lbl8)
        Me.pnlJuego.Controls.Add(Me.lbl7)
        Me.pnlJuego.Controls.Add(Me.lbl4)
        Me.pnlJuego.Controls.Add(Me.lbl3)
        Me.pnlJuego.Controls.Add(Me.lbl2)
        Me.pnlJuego.Controls.Add(Me.lbl6)
        Me.pnlJuego.Controls.Add(Me.lbl5)
        Me.pnlJuego.Controls.Add(Me.lbl1)
        Me.pnlJuego.Controls.Add(Me.btnNueve)
        Me.pnlJuego.Controls.Add(Me.btnUno)
        Me.pnlJuego.Controls.Add(Me.btnOcho)
        Me.pnlJuego.Controls.Add(Me.btnSiete)
        Me.pnlJuego.Controls.Add(Me.btnSeis)
        Me.pnlJuego.Controls.Add(Me.btnCinco)
        Me.pnlJuego.Controls.Add(Me.btnCuatro)
        Me.pnlJuego.Controls.Add(Me.btnTres)
        Me.pnlJuego.Controls.Add(Me.btnDos)
        Me.pnlJuego.Location = New System.Drawing.Point(120, 29)
        Me.pnlJuego.Name = "pnlJuego"
        Me.pnlJuego.Size = New System.Drawing.Size(300, 300)
        Me.pnlJuego.TabIndex = 7
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.BackColor = System.Drawing.SystemColors.Window
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(228, 230)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(0, 46)
        Me.lbl9.TabIndex = 21
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.BackColor = System.Drawing.SystemColors.Window
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.Location = New System.Drawing.Point(125, 230)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(0, 46)
        Me.lbl8.TabIndex = 20
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.SystemColors.Window
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(29, 230)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(0, 46)
        Me.lbl7.TabIndex = 19
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.Window
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(29, 130)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 46)
        Me.lbl4.TabIndex = 18
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.Window
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(228, 30)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 46)
        Me.lbl3.TabIndex = 17
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Window
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(125, 30)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 46)
        Me.lbl2.TabIndex = 16
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.SystemColors.Window
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(228, 130)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(0, 46)
        Me.lbl6.TabIndex = 15
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.SystemColors.Window
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(125, 130)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(0, 46)
        Me.lbl5.TabIndex = 14
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Window
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(29, 30)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 46)
        Me.lbl1.TabIndex = 13
        '
        'btnNueve
        '
        Me.btnNueve.BackColor = System.Drawing.Color.White
        Me.btnNueve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNueve.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNueve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueve.Location = New System.Drawing.Point(200, 200)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(100, 100)
        Me.btnNueve.TabIndex = 8
        Me.btnNueve.UseVisualStyleBackColor = False
        '
        'btnUno
        '
        Me.btnUno.BackColor = System.Drawing.Color.White
        Me.btnUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUno.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUno.Location = New System.Drawing.Point(0, 0)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(100, 100)
        Me.btnUno.TabIndex = 0
        Me.btnUno.UseVisualStyleBackColor = False
        '
        'btnOcho
        '
        Me.btnOcho.BackColor = System.Drawing.Color.White
        Me.btnOcho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcho.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOcho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnOcho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcho.Location = New System.Drawing.Point(100, 200)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(100, 100)
        Me.btnOcho.TabIndex = 7
        Me.btnOcho.UseVisualStyleBackColor = False
        '
        'btnSiete
        '
        Me.btnSiete.BackColor = System.Drawing.Color.White
        Me.btnSiete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSiete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSiete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiete.Location = New System.Drawing.Point(0, 200)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(100, 100)
        Me.btnSiete.TabIndex = 6
        Me.btnSiete.UseVisualStyleBackColor = False
        '
        'btnSeis
        '
        Me.btnSeis.BackColor = System.Drawing.Color.White
        Me.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeis.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(200, 100)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(100, 100)
        Me.btnSeis.TabIndex = 5
        Me.btnSeis.UseVisualStyleBackColor = False
        '
        'btnCinco
        '
        Me.btnCinco.BackColor = System.Drawing.Color.White
        Me.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCinco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(100, 100)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(100, 100)
        Me.btnCinco.TabIndex = 4
        Me.btnCinco.UseVisualStyleBackColor = False
        '
        'btnCuatro
        '
        Me.btnCuatro.BackColor = System.Drawing.Color.White
        Me.btnCuatro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuatro.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuatro.Location = New System.Drawing.Point(0, 100)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(100, 100)
        Me.btnCuatro.TabIndex = 3
        Me.btnCuatro.UseVisualStyleBackColor = False
        '
        'btnTres
        '
        Me.btnTres.BackColor = System.Drawing.Color.White
        Me.btnTres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTres.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(200, 0)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(100, 100)
        Me.btnTres.TabIndex = 2
        Me.btnTres.UseVisualStyleBackColor = False
        '
        'btnDos
        '
        Me.btnDos.BackColor = System.Drawing.Color.White
        Me.btnDos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(100, 0)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(100, 100)
        Me.btnDos.TabIndex = 1
        Me.btnDos.UseVisualStyleBackColor = False
        '
        'tmrTiempo
        '
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(253, 360)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(37, 27)
        Me.btnGo.TabIndex = 12
        Me.btnGo.Text = "GO!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmGatoVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 418)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.pnlJuego)
        Me.Name = "frmGatoVB"
        Me.Text = "Gato"
        Me.pnlJuego.ResumeLayout(False)
        Me.pnlJuego.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents txtPlayer1 As TextBox
    Private WithEvents pnlJuego As Panel
    Private WithEvents btnNueve As Button
    Private WithEvents btnUno As Button
    Private WithEvents btnOcho As Button
    Private WithEvents btnSiete As Button
    Private WithEvents btnSeis As Button
    Private WithEvents btnCinco As Button
    Private WithEvents btnCuatro As Button
    Private WithEvents btnTres As Button
    Private WithEvents btnDos As Button
    Friend WithEvents tmrTiempo As Timer
    Friend WithEvents btnGo As Button
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl1 As Label
End Class
