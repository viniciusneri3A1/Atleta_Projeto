namespace Atleta_Projeto
{
    partial class Form1
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
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(125, 190);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 23;
            this.lblIMC.Text = "IMC";
            // 
            // txtIMC
            // 
            this.txtIMC.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(12, 206);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(241, 34);
            this.txtIMC.TabIndex = 22;
            this.txtIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 135);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(86, 21);
            this.btnEnviar.TabIndex = 21;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(167, 137);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(86, 19);
            this.btnCalculo.TabIndex = 20;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(186, 60);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(48, 60);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 18;
            this.lblAltura.Text = "Altura";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(183, 9);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 17;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(47, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(148, 86);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(105, 20);
            this.txtPeso.TabIndex = 15;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(12, 86);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(105, 20);
            this.txtAltura.TabIndex = 14;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(148, 25);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(105, 20);
            this.txtIdade.TabIndex = 13;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(105, 20);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
    }
}

