namespace ConsumoEletricoResidencial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeAparelho = new System.Windows.Forms.Label();
            this.txtNomeAparelho = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtTempoUso = new System.Windows.Forms.TextBox();
            this.lblTempoUso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIntroducao = new System.Windows.Forms.Label();
            this.lblConsumoDiario = new System.Windows.Forms.Label();
            this.txtConsumoDiario = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeAparelho
            // 
            this.lblNomeAparelho.AutoSize = true;
            this.lblNomeAparelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAparelho.Location = new System.Drawing.Point(37, 61);
            this.lblNomeAparelho.Name = "lblNomeAparelho";
            this.lblNomeAparelho.Size = new System.Drawing.Size(124, 16);
            this.lblNomeAparelho.TabIndex = 0;
            this.lblNomeAparelho.Text = "Nome do aparelho:";
            // 
            // txtNomeAparelho
            // 
            this.txtNomeAparelho.Location = new System.Drawing.Point(167, 61);
            this.txtNomeAparelho.Name = "txtNomeAparelho";
            this.txtNomeAparelho.Size = new System.Drawing.Size(121, 20);
            this.txtNomeAparelho.TabIndex = 1;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(167, 96);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(121, 20);
            this.txtPotencia.TabIndex = 2;
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.Location = new System.Drawing.Point(37, 96);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(95, 16);
            this.lblPotencia.TabIndex = 2;
            this.lblPotencia.Text = "Potência (kW):";
            // 
            // txtTempoUso
            // 
            this.txtTempoUso.Location = new System.Drawing.Point(167, 132);
            this.txtTempoUso.Name = "txtTempoUso";
            this.txtTempoUso.Size = new System.Drawing.Size(121, 20);
            this.txtTempoUso.TabIndex = 3;
            // 
            // lblTempoUso
            // 
            this.lblTempoUso.AutoSize = true;
            this.lblTempoUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoUso.Location = new System.Drawing.Point(37, 132);
            this.lblTempoUso.Name = "lblTempoUso";
            this.lblTempoUso.Size = new System.Drawing.Size(117, 16);
            this.lblTempoUso.TabIndex = 4;
            this.lblTempoUso.Text = "Tempo de uso (h):";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(307, 61);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 55);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIntroducao
            // 
            this.lblIntroducao.AutoSize = true;
            this.lblIntroducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroducao.Location = new System.Drawing.Point(12, 22);
            this.lblIntroducao.Name = "lblIntroducao";
            this.lblIntroducao.Size = new System.Drawing.Size(313, 15);
            this.lblIntroducao.TabIndex = 7;
            this.lblIntroducao.Text = "Para iniciar o cálculo, informe os dados abaixo:";
            // 
            // lblConsumoDiario
            // 
            this.lblConsumoDiario.AutoSize = true;
            this.lblConsumoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumoDiario.Location = new System.Drawing.Point(21, 224);
            this.lblConsumoDiario.Name = "lblConsumoDiario";
            this.lblConsumoDiario.Size = new System.Drawing.Size(119, 16);
            this.lblConsumoDiario.TabIndex = 8;
            this.lblConsumoDiario.Text = "Consumos diários:";
            // 
            // txtConsumoDiario
            // 
            this.txtConsumoDiario.BackColor = System.Drawing.SystemColors.Info;
            this.txtConsumoDiario.Enabled = false;
            this.txtConsumoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumoDiario.Location = new System.Drawing.Point(24, 243);
            this.txtConsumoDiario.Multiline = true;
            this.txtConsumoDiario.Name = "txtConsumoDiario";
            this.txtConsumoDiario.Size = new System.Drawing.Size(404, 87);
            this.txtConsumoDiario.TabIndex = 9;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(167, 169);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(121, 20);
            this.txtQtde.TabIndex = 4;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(37, 169);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(81, 16);
            this.lblQtde.TabIndex = 10;
            this.lblQtde.Text = "Quantidade:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 353);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtConsumoDiario);
            this.Controls.Add(this.lblConsumoDiario);
            this.Controls.Add(this.lblIntroducao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempoUso);
            this.Controls.Add(this.lblTempoUso);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.txtNomeAparelho);
            this.Controls.Add(this.lblNomeAparelho);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Calculadora de Consumo Elétrico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAparelho;
        private System.Windows.Forms.TextBox txtNomeAparelho;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtTempoUso;
        private System.Windows.Forms.Label lblTempoUso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIntroducao;
        private System.Windows.Forms.Label lblConsumoDiario;
        private System.Windows.Forms.TextBox txtConsumoDiario;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQtde;
    }
}

