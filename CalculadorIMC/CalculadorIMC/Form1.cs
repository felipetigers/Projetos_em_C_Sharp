using System;
using System.Windows.Forms;

namespace CalculadorIMC
{
    public partial class frmPrincipal : Form
    {
        float Peso, Altura;
        double vlrIMC;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Para cálculo do IMC, informe os dados abaixo:";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peso = float.Parse(txtPeso.Text);
            Altura = float.Parse(txtAltura.Text);

            vlrIMC = Peso / Math.Pow(Altura, 2);

            txtSeuIMC.Text = Convert.ToString(Math.Round(vlrIMC, 2)) + " kg/m2";

            if (vlrIMC < 18.5) {
                txtResultado.Text = "Magreza";
            } else if (vlrIMC >= 18.5 && vlrIMC < 25.0) {
                txtResultado.Text = "Normal";
            } else if (vlrIMC >= 25.0 && vlrIMC < 30.0) {
                txtResultado.Text = "Sobrepeso";
            } else if (vlrIMC >= 30.0 && vlrIMC < 40.0) {
                txtResultado.Text = "Obesidade";
            } else {
                txtResultado.Text = "Obesidade grave";
            }
        }
    }
}
