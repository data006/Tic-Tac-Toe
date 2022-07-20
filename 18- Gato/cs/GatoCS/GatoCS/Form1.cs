using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoCS
{
	public partial class frmGatoCS : Form
	{



		private bool botonUno, botonDos, botonTres, botonCuatro, botonCinco, botonSeis, botonSiete, botonOcho, botonNueve, nadieGana;

		

		private int turno, numeroRandom;

		

		public frmGatoCS()
		{
			InitializeComponent();
		}


		//Inicio del form
		private void frmGatoCS_Load(object sender, EventArgs e)
		{
			btnSeis.Enabled = false;
			btnSiete.Enabled = false;
			btnOcho.Enabled = false;
			btnNueve.Enabled = false;
			btnUno.Enabled = false;
			btnDos.Enabled = false;
			btnTres.Enabled = false;
			btnCuatro.Enabled = false;
			btnCinco.Enabled = false;
		}


		//Timer
		private void tmrTiempo_Tick(object sender, EventArgs e)
		{
			if ((lbl1.Text ?? "") == "X" & (lbl2.Text ?? "") == "X" & (lbl3.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				Application.Restart();
			}
			else if ((lbl4.Text ?? "") == "X" & (lbl5.Text ?? "") == "X" & (lbl6.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl7.Text ?? "") == "X" & (lbl8.Text ?? "") == "X" & (lbl9.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl1.Text ?? "") == "X" & (lbl4.Text ?? "") == "X" & (lbl7.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl2.Text ?? "") == "X" & (lbl5.Text ?? "") == "X" & (lbl8.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl3.Text ?? "") == "X" & (lbl6.Text ?? "") == "X" & (lbl9.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl1.Text ?? "") == "X" & (lbl5.Text ?? "") == "X" & (lbl9.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl3.Text ?? "") == "X" & (lbl5.Text ?? "") == "X" & (lbl7.Text ?? "") == "X")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer1.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}

			if ((lbl1.Text ?? "") == "O" & (lbl2.Text ?? "") == "O" & (lbl3.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				Application.Restart();
			}
			else if ((lbl4.Text ?? "") == "O" & (lbl5.Text ?? "") == "O" & (lbl6.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl7.Text ?? "") == "O" & (lbl8.Text ?? "") == "O" & (lbl9.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl1.Text ?? "") == "O" & (lbl4.Text ?? "") == "O" & (lbl7.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl2.Text ?? "") == "O" & (lbl5.Text ?? "") == "O" & (lbl8.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl3.Text ?? "") == "O" & (lbl6.Text ?? "") == "O" & (lbl9.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl1.Text ?? "") == "O" & (lbl5.Text ?? "") == "O" & (lbl9.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}
			else if ((lbl3.Text ?? "") == "O" & (lbl5.Text ?? "") == "O" & (lbl7.Text ?? "") == "O")
			{
				tmrTiempo.Enabled = false;
				MessageBox.Show("gano " + txtPlayer2.Text);
				tmrTiempo.Enabled = false;
				Application.Restart();
			}

			if (!string.IsNullOrEmpty(lbl1.Text) & !string.IsNullOrEmpty(lbl2.Text) & !string.IsNullOrEmpty(lbl3.Text) & !string.IsNullOrEmpty(lbl4.Text) & !string.IsNullOrEmpty(lbl5.Text) & !string.IsNullOrEmpty(lbl6.Text) & !string.IsNullOrEmpty(lbl7.Text) & !string.IsNullOrEmpty(lbl8.Text) & !string.IsNullOrEmpty(lbl9.Text))
			{
				if (nadieGana == true)
				{
					tmrTiempo.Enabled = false;
					MessageBox.Show("Nadie gana");
					Application.Restart();
				}

				nadieGana = true;
			}

			if (turno == 1)
			{
				lblPlayer1.BackColor = Color.Red;
				lblPlayer2.BackColor = Color.White;
			}
			else
			{
				lblPlayer1.BackColor = Color.White;
				lblPlayer2.BackColor = Color.Red;
			}
		}


		//Botones del gato
		private void btnUno_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonUno = true;
				btnUno.Enabled = false;
				lbl1.Text = "X";
				turno = 2;
			}
			else
			{
				botonUno = true;
				btnUno.Enabled = false;
				lbl1.Text = "O";
				turno = 1;
			}
		}

		private void btnDos_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonDos = true;
				btnDos.Enabled = false;
				lbl2.Text = "X";
				turno = 2;
			}
			else
			{
				botonDos = true;
				btnDos.Enabled = false;
				lbl2.Text = "O";
				turno = 1;
			}
		}

		private void btnTres_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonTres = true;
				btnTres.Enabled = false;
				lbl3.Text = "X";
				turno = 2;
			}
			else
			{
				botonTres = true;
				btnTres.Enabled = false;
				lbl3.Text = "O";
				turno = 1;
			}
		}

		private void btnCuatro_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonCuatro = true;
				btnCuatro.Enabled = false;
				lbl4.Text = "X";
				turno = 2;
			}
			else
			{
				botonCuatro = true;
				btnCuatro.Enabled = false;
				lbl4.Text = "O";
				turno = 1;
			}
		}

		private void btnCinco_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonCinco = true;
				btnCinco.Enabled = false;
				lbl5.Text = "X";
				turno = 2;
			}
			else
			{
				botonCinco = true;
				btnCinco.Enabled = false;
				lbl5.Text = "O";
				turno = 1;
			}
		}

		private void btnSeis_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonSeis = true;
				btnSeis.Enabled = false;
				lbl6.Text = "X";
				turno = 2;
			}
			else
			{
				botonSeis = true;
				btnSeis.Enabled = false;
				lbl6.Text = "O";
				turno = 1;
			}
		}

		private void btnSiete_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonSiete = true;
				btnSiete.Enabled = false;
				lbl7.Text = "X";
				turno = 2;
			}
			else
			{
				botonSiete = true;
				btnSiete.Enabled = false;
				lbl7.Text = "O";
				turno = 1;
			}
		}

		private void btnOcho_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonOcho = true;
				btnOcho.Enabled = false;
				lbl8.Text = "X";
				turno = 2;
			}
			else
			{
				botonOcho = true;
				btnOcho.Enabled = false;
				lbl8.Text = "O";
				turno = 1;
			}
		}

		private void btnNueve_Click(object sender, EventArgs e)
		{
			if (turno == 1)
			{
				botonNueve = true;
				btnNueve.Enabled = false;
				lbl9.Text = "X";
				turno = 2;
			}
			else
			{
				botonNueve = true;
				btnNueve.Enabled = false;
				lbl9.Text = "O";
				turno = 1;
			}
		}





		//Boton Go!
		private void btnGo_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtPlayer1.Text) & !string.IsNullOrEmpty(txtPlayer2.Text))
			{
				VBMath.Randomize();
				numeroRandom = Convert.ToInt32(VBMath.Rnd() * 100);
				if (numeroRandom <= 50)
				{
					turno = 1;
					MessageBox.Show("Turno de " + txtPlayer1.Text);
				}
				else
				{
					turno = 2;
					MessageBox.Show("Turno de " + txtPlayer2.Text);
				}

				txtPlayer1.Enabled = false;
				txtPlayer2.Enabled = false;
				btnSeis.Enabled = true;
				btnSiete.Enabled = true;
				btnOcho.Enabled = true;
				btnNueve.Enabled = true;
				btnUno.Enabled = true;
				btnDos.Enabled = true;
				btnTres.Enabled = true;
				btnCuatro.Enabled = true;
				btnCinco.Enabled = true;
				btnGo.Enabled = false;
				tmrTiempo.Enabled = true;
			}
		}


	}
}
