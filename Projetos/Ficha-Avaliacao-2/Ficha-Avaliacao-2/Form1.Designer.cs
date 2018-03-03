namespace Ficha_Avaliacao_2
{
    partial class FormEncriptador9999
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
            this.btnAbrirFicheiro = new System.Windows.Forms.Button();
            this.btnGuardarFicheiro = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAbrirFicheiro
            // 
            this.btnAbrirFicheiro.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirFicheiro.Name = "btnAbrirFicheiro";
            this.btnAbrirFicheiro.Size = new System.Drawing.Size(100, 75);
            this.btnAbrirFicheiro.TabIndex = 0;
            this.btnAbrirFicheiro.Text = "Abrir Ficheiro";
            this.btnAbrirFicheiro.UseVisualStyleBackColor = true;
            this.btnAbrirFicheiro.Click += new System.EventHandler(this.btnAbrirFicheiro_Click);
            // 
            // btnGuardarFicheiro
            // 
            this.btnGuardarFicheiro.Location = new System.Drawing.Point(12, 93);
            this.btnGuardarFicheiro.Name = "btnGuardarFicheiro";
            this.btnGuardarFicheiro.Size = new System.Drawing.Size(100, 75);
            this.btnGuardarFicheiro.TabIndex = 1;
            this.btnGuardarFicheiro.Text = "Guardar Ficheiro";
            this.btnGuardarFicheiro.UseVisualStyleBackColor = true;
            this.btnGuardarFicheiro.Click += new System.EventHandler(this.btnGuardarFicheiro_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(12, 181);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(100, 75);
            this.btnEncriptar.TabIndex = 2;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(12, 262);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(100, 75);
            this.btnDesencriptar.TabIndex = 3;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 343);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 75);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(118, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 425);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // FormEncriptador9999
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.btnGuardarFicheiro);
            this.Controls.Add(this.btnAbrirFicheiro);
            this.Name = "FormEncriptador9999";
            this.Text = "Encriptador 9999";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFicheiro;
        private System.Windows.Forms.Button btnGuardarFicheiro;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

