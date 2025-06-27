namespace GeradorDeFrase
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGerarFrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(53, 317);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 17);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "...";
            // 
            // btnGerarFrase
            // 
            this.btnGerarFrase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarFrase.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGerarFrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarFrase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerarFrase.Location = new System.Drawing.Point(236, 369);
            this.btnGerarFrase.Name = "btnGerarFrase";
            this.btnGerarFrase.Size = new System.Drawing.Size(121, 43);
            this.btnGerarFrase.TabIndex = 2;
            this.btnGerarFrase.Text = "Gerar Frase";
            this.btnGerarFrase.UseVisualStyleBackColor = false;
            this.btnGerarFrase.Click += new System.EventHandler(this.btnGerarFrase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeradorDeFrase.Properties.Resources.Racionis_atvd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btnGerarFrase);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnGerarFrase_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnGerarFrase;
    }
}

