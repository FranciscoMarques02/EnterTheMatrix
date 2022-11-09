namespace EnterTheMatrix
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxVerificador = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.txbAnoNasc = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.gbxVerificador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Lime;
            this.lblTitulo.Location = new System.Drawing.Point(217, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ENTER THE MATRIX";
            // 
            // gbxVerificador
            // 
            this.gbxVerificador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxVerificador.Controls.Add(this.lblResultado);
            this.gbxVerificador.Controls.Add(this.pibResultado);
            this.gbxVerificador.Controls.Add(this.btnSair);
            this.gbxVerificador.Controls.Add(this.btnLimpar);
            this.gbxVerificador.Controls.Add(this.btnVerificar);
            this.gbxVerificador.Controls.Add(this.txbAnoNasc);
            this.gbxVerificador.Controls.Add(this.lblAnoNasc);
            this.gbxVerificador.Controls.Add(this.txbSobrenome);
            this.gbxVerificador.Controls.Add(this.lblSobrenome);
            this.gbxVerificador.Controls.Add(this.txbNome);
            this.gbxVerificador.Controls.Add(this.lblNome);
            this.gbxVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxVerificador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVerificador.ForeColor = System.Drawing.Color.Lime;
            this.gbxVerificador.Location = new System.Drawing.Point(134, 88);
            this.gbxVerificador.Name = "gbxVerificador";
            this.gbxVerificador.Size = new System.Drawing.Size(472, 320);
            this.gbxVerificador.TabIndex = 1;
            this.gbxVerificador.TabStop = false;
            this.gbxVerificador.Text = "VERIFICADOR";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.Window;
            this.txbNome.Location = new System.Drawing.Point(16, 62);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(227, 29);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 109);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(143, 22);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "SOBRENOME:";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(16, 134);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(227, 29);
            this.txbSobrenome.TabIndex = 3;
            this.txbSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Location = new System.Drawing.Point(12, 198);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(119, 22);
            this.lblAnoNasc.TabIndex = 4;
            this.lblAnoNasc.Text = "ANO NASC:";
            // 
            // txbAnoNasc
            // 
            this.txbAnoNasc.Location = new System.Drawing.Point(143, 191);
            this.txbAnoNasc.Name = "txbAnoNasc";
            this.txbAnoNasc.Size = new System.Drawing.Size(100, 29);
            this.txbAnoNasc.TabIndex = 5;
            this.txbAnoNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Lime;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.Black;
            this.btnVerificar.Location = new System.Drawing.Point(16, 268);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(126, 36);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Lime;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(158, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 36);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lime;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(270, 268);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(268, 206);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 12);
            this.lblResultado.TabIndex = 10;
            // 
            // pibResultado
            // 
            this.pibResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibResultado.Location = new System.Drawing.Point(289, 37);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(143, 147);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 9;
            this.pibResultado.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(740, 519);
            this.Controls.Add(this.gbxVerificador);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTER THE MATRIX";
            this.gbxVerificador.ResumeLayout(false);
            this.gbxVerificador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxVerificador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbAnoNasc;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pibResultado;
    }
}