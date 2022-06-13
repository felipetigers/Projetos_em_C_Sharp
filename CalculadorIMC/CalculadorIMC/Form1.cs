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

            //Operador ternário
            txtResultado.Text =
                vlrIMC < 18.5 ? "Magreza" :
                vlrIMC >= 18.5 && vlrIMC < 25.0 ? "Normal" :
                vlrIMC >= 25.0 && vlrIMC < 30.0 ? "Sobrepeso" :
                vlrIMC >= 30.0 && vlrIMC < 40.0 ? "Obesidade" : "Obeside grave";

        }
    }
}
