namespace GatoCS
{
	partial class frmGatoCS
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnGo = new System.Windows.Forms.Button();
			this.lblPlayer2 = new System.Windows.Forms.Label();
			this.lblPlayer1 = new System.Windows.Forms.Label();
			this.txtPlayer2 = new System.Windows.Forms.TextBox();
			this.txtPlayer1 = new System.Windows.Forms.TextBox();
			this.pnlJuego = new System.Windows.Forms.Panel();
			this.lbl9 = new System.Windows.Forms.Label();
			this.lbl8 = new System.Windows.Forms.Label();
			this.lbl7 = new System.Windows.Forms.Label();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl6 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.btnNueve = new System.Windows.Forms.Button();
			this.btnUno = new System.Windows.Forms.Button();
			this.btnOcho = new System.Windows.Forms.Button();
			this.btnSiete = new System.Windows.Forms.Button();
			this.btnSeis = new System.Windows.Forms.Button();
			this.btnCinco = new System.Windows.Forms.Button();
			this.btnCuatro = new System.Windows.Forms.Button();
			this.btnTres = new System.Windows.Forms.Button();
			this.btnDos = new System.Windows.Forms.Button();
			this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
			this.pnlJuego.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.Location = new System.Drawing.Point(253, 353);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(37, 27);
			this.btnGo.TabIndex = 18;
			this.btnGo.Text = "GO!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// lblPlayer2
			// 
			this.lblPlayer2.AutoSize = true;
			this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayer2.Location = new System.Drawing.Point(357, 383);
			this.lblPlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPlayer2.Name = "lblPlayer2";
			this.lblPlayer2.Size = new System.Drawing.Size(53, 13);
			this.lblPlayer2.TabIndex = 17;
			this.lblPlayer2.Text = "Player 2";
			// 
			// lblPlayer1
			// 
			this.lblPlayer1.AutoSize = true;
			this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayer1.Location = new System.Drawing.Point(132, 383);
			this.lblPlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPlayer1.Name = "lblPlayer1";
			this.lblPlayer1.Size = new System.Drawing.Size(53, 13);
			this.lblPlayer1.TabIndex = 16;
			this.lblPlayer1.Text = "Player 1";
			// 
			// txtPlayer2
			// 
			this.txtPlayer2.Location = new System.Drawing.Point(344, 353);
			this.txtPlayer2.Margin = new System.Windows.Forms.Padding(2);
			this.txtPlayer2.Name = "txtPlayer2";
			this.txtPlayer2.Size = new System.Drawing.Size(76, 20);
			this.txtPlayer2.TabIndex = 15;
			// 
			// txtPlayer1
			// 
			this.txtPlayer1.Location = new System.Drawing.Point(120, 353);
			this.txtPlayer1.Margin = new System.Windows.Forms.Padding(2);
			this.txtPlayer1.Name = "txtPlayer1";
			this.txtPlayer1.Size = new System.Drawing.Size(76, 20);
			this.txtPlayer1.TabIndex = 14;
			// 
			// pnlJuego
			// 
			this.pnlJuego.BackColor = System.Drawing.SystemColors.Control;
			this.pnlJuego.Controls.Add(this.lbl9);
			this.pnlJuego.Controls.Add(this.lbl8);
			this.pnlJuego.Controls.Add(this.lbl7);
			this.pnlJuego.Controls.Add(this.lbl4);
			this.pnlJuego.Controls.Add(this.lbl3);
			this.pnlJuego.Controls.Add(this.lbl2);
			this.pnlJuego.Controls.Add(this.lbl6);
			this.pnlJuego.Controls.Add(this.lbl5);
			this.pnlJuego.Controls.Add(this.lbl1);
			this.pnlJuego.Controls.Add(this.btnNueve);
			this.pnlJuego.Controls.Add(this.btnUno);
			this.pnlJuego.Controls.Add(this.btnOcho);
			this.pnlJuego.Controls.Add(this.btnSiete);
			this.pnlJuego.Controls.Add(this.btnSeis);
			this.pnlJuego.Controls.Add(this.btnCinco);
			this.pnlJuego.Controls.Add(this.btnCuatro);
			this.pnlJuego.Controls.Add(this.btnTres);
			this.pnlJuego.Controls.Add(this.btnDos);
			this.pnlJuego.Location = new System.Drawing.Point(120, 22);
			this.pnlJuego.Name = "pnlJuego";
			this.pnlJuego.Size = new System.Drawing.Size(300, 300);
			this.pnlJuego.TabIndex = 13;
			// 
			// lbl9
			// 
			this.lbl9.AutoSize = true;
			this.lbl9.BackColor = System.Drawing.SystemColors.Window;
			this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl9.Location = new System.Drawing.Point(228, 230);
			this.lbl9.Name = "lbl9";
			this.lbl9.Size = new System.Drawing.Size(0, 46);
			this.lbl9.TabIndex = 21;
			// 
			// lbl8
			// 
			this.lbl8.AutoSize = true;
			this.lbl8.BackColor = System.Drawing.SystemColors.Window;
			this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl8.Location = new System.Drawing.Point(125, 230);
			this.lbl8.Name = "lbl8";
			this.lbl8.Size = new System.Drawing.Size(0, 46);
			this.lbl8.TabIndex = 20;
			// 
			// lbl7
			// 
			this.lbl7.AutoSize = true;
			this.lbl7.BackColor = System.Drawing.SystemColors.Window;
			this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl7.Location = new System.Drawing.Point(29, 230);
			this.lbl7.Name = "lbl7";
			this.lbl7.Size = new System.Drawing.Size(0, 46);
			this.lbl7.TabIndex = 19;
			// 
			// lbl4
			// 
			this.lbl4.AutoSize = true;
			this.lbl4.BackColor = System.Drawing.SystemColors.Window;
			this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl4.Location = new System.Drawing.Point(29, 130);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(0, 46);
			this.lbl4.TabIndex = 18;
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.BackColor = System.Drawing.SystemColors.Window;
			this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.Location = new System.Drawing.Point(228, 30);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(0, 46);
			this.lbl3.TabIndex = 17;
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(125, 30);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(0, 46);
			this.lbl2.TabIndex = 16;
			// 
			// lbl6
			// 
			this.lbl6.AutoSize = true;
			this.lbl6.BackColor = System.Drawing.SystemColors.Window;
			this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl6.Location = new System.Drawing.Point(228, 130);
			this.lbl6.Name = "lbl6";
			this.lbl6.Size = new System.Drawing.Size(0, 46);
			this.lbl6.TabIndex = 15;
			// 
			// lbl5
			// 
			this.lbl5.AutoSize = true;
			this.lbl5.BackColor = System.Drawing.SystemColors.Window;
			this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5.Location = new System.Drawing.Point(125, 130);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(0, 46);
			this.lbl5.TabIndex = 14;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(29, 30);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(0, 46);
			this.lbl1.TabIndex = 13;
			// 
			// btnNueve
			// 
			this.btnNueve.BackColor = System.Drawing.Color.White;
			this.btnNueve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNueve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnNueve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnNueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNueve.Location = new System.Drawing.Point(200, 200);
			this.btnNueve.Name = "btnNueve";
			this.btnNueve.Size = new System.Drawing.Size(100, 100);
			this.btnNueve.TabIndex = 8;
			this.btnNueve.UseVisualStyleBackColor = false;
			this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
			// 
			// btnUno
			// 
			this.btnUno.BackColor = System.Drawing.Color.White;
			this.btnUno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUno.Location = new System.Drawing.Point(0, 0);
			this.btnUno.Name = "btnUno";
			this.btnUno.Size = new System.Drawing.Size(100, 100);
			this.btnUno.TabIndex = 0;
			this.btnUno.UseVisualStyleBackColor = false;
			this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
			// 
			// btnOcho
			// 
			this.btnOcho.BackColor = System.Drawing.Color.White;
			this.btnOcho.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOcho.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnOcho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnOcho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOcho.Location = new System.Drawing.Point(100, 200);
			this.btnOcho.Name = "btnOcho";
			this.btnOcho.Size = new System.Drawing.Size(100, 100);
			this.btnOcho.TabIndex = 7;
			this.btnOcho.UseVisualStyleBackColor = false;
			this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
			// 
			// btnSiete
			// 
			this.btnSiete.BackColor = System.Drawing.Color.White;
			this.btnSiete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSiete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSiete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnSiete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiete.Location = new System.Drawing.Point(0, 200);
			this.btnSiete.Name = "btnSiete";
			this.btnSiete.Size = new System.Drawing.Size(100, 100);
			this.btnSiete.TabIndex = 6;
			this.btnSiete.UseVisualStyleBackColor = false;
			this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
			// 
			// btnSeis
			// 
			this.btnSeis.BackColor = System.Drawing.Color.White;
			this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeis.Location = new System.Drawing.Point(200, 100);
			this.btnSeis.Name = "btnSeis";
			this.btnSeis.Size = new System.Drawing.Size(100, 100);
			this.btnSeis.TabIndex = 5;
			this.btnSeis.UseVisualStyleBackColor = false;
			this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
			// 
			// btnCinco
			// 
			this.btnCinco.BackColor = System.Drawing.Color.White;
			this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCinco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCinco.Location = new System.Drawing.Point(100, 100);
			this.btnCinco.Name = "btnCinco";
			this.btnCinco.Size = new System.Drawing.Size(100, 100);
			this.btnCinco.TabIndex = 4;
			this.btnCinco.UseVisualStyleBackColor = false;
			this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
			// 
			// btnCuatro
			// 
			this.btnCuatro.BackColor = System.Drawing.Color.White;
			this.btnCuatro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCuatro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnCuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnCuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCuatro.Location = new System.Drawing.Point(0, 100);
			this.btnCuatro.Name = "btnCuatro";
			this.btnCuatro.Size = new System.Drawing.Size(100, 100);
			this.btnCuatro.TabIndex = 3;
			this.btnCuatro.UseVisualStyleBackColor = false;
			this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
			// 
			// btnTres
			// 
			this.btnTres.BackColor = System.Drawing.Color.White;
			this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTres.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTres.Location = new System.Drawing.Point(200, 0);
			this.btnTres.Name = "btnTres";
			this.btnTres.Size = new System.Drawing.Size(100, 100);
			this.btnTres.TabIndex = 2;
			this.btnTres.UseVisualStyleBackColor = false;
			this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
			// 
			// btnDos
			// 
			this.btnDos.BackColor = System.Drawing.Color.White;
			this.btnDos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnDos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDos.Location = new System.Drawing.Point(100, 0);
			this.btnDos.Name = "btnDos";
			this.btnDos.Size = new System.Drawing.Size(100, 100);
			this.btnDos.TabIndex = 1;
			this.btnDos.UseVisualStyleBackColor = false;
			this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
			// 
			// tmrTiempo
			// 
			this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
			// 
			// frmGatoCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(540, 418);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.lblPlayer2);
			this.Controls.Add(this.lblPlayer1);
			this.Controls.Add(this.txtPlayer2);
			this.Controls.Add(this.txtPlayer1);
			this.Controls.Add(this.pnlJuego);
			this.Name = "frmGatoCS";
			this.Text = "Gato";
			this.Load += new System.EventHandler(this.frmGatoCS_Load);
			this.pnlJuego.ResumeLayout(false);
			this.pnlJuego.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnGo;
		internal System.Windows.Forms.Label lblPlayer2;
		internal System.Windows.Forms.Label lblPlayer1;
		internal System.Windows.Forms.TextBox txtPlayer2;
		internal System.Windows.Forms.TextBox txtPlayer1;
		private System.Windows.Forms.Panel pnlJuego;
		internal System.Windows.Forms.Label lbl9;
		internal System.Windows.Forms.Label lbl8;
		internal System.Windows.Forms.Label lbl7;
		internal System.Windows.Forms.Label lbl4;
		internal System.Windows.Forms.Label lbl3;
		internal System.Windows.Forms.Label lbl2;
		internal System.Windows.Forms.Label lbl6;
		internal System.Windows.Forms.Label lbl5;
		internal System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnNueve;
		private System.Windows.Forms.Button btnUno;
		private System.Windows.Forms.Button btnOcho;
		private System.Windows.Forms.Button btnSiete;
		private System.Windows.Forms.Button btnSeis;
		private System.Windows.Forms.Button btnCinco;
		private System.Windows.Forms.Button btnCuatro;
		private System.Windows.Forms.Button btnTres;
		private System.Windows.Forms.Button btnDos;
		private System.Windows.Forms.Timer tmrTiempo;
	}
}

