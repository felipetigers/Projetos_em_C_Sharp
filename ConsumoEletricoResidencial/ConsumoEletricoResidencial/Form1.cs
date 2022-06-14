using System;
using System.Windows.Forms;

namespace ConsumoEletricoResidencial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int t = 30;     //tempo de 30 dias de consumo

            Aparelho ap = new Aparelho();
            ap.Nome = txtNomeAparelho.Text;
            ap.Potencia = float.Parse(txtPotencia.Text);//conversao de string p/ float, do campo "txtPotencia"
            ap.TempoUso = float.Parse(txtTempoUso.Text);
            ap.Qtde = int.Parse(txtQtde.Text);

            txtConsumoDiario.Text = "O aparelho " + ap.Nome + " consome " + 
                (ap.calculoConsumo()).ToString() + " kW/h." +
                "\r\n\r\n - Na bandeira verde, gasta-se R$ " + Math.Round(ap.solucao("verde") * ap.calculoConsumo(),2) + " reais." +
                "\r\n - Na bandeira amarela, gasta-se R$ " + Math.Round(ap.solucao("amarelo") * ap.calculoConsumo(), 2) + " reais." +
                "\r\n - Na bandeira vermelha, gasta-se R$ " + Math.Round(ap.solucao("vermelho") * ap.calculoConsumo(),2) + " reais.";
        }
    }
}
