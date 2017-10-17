namespace Teste_Mod7
{
    partial class Form1
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
            this.abrirFicheiroBtn = new System.Windows.Forms.Button();
            this.guardarFicheiroBtn = new System.Windows.Forms.Button();
            this.EncriptarBtn = new System.Windows.Forms.Button();
            this.DesencriptarBtn = new System.Windows.Forms.Button();
            this.NovoBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // abrirFicheiroBtn
            // 
            this.abrirFicheiroBtn.Location = new System.Drawing.Point(12, 12);
            this.abrirFicheiroBtn.Name = "abrirFicheiroBtn";
            this.abrirFicheiroBtn.Size = new System.Drawing.Size(91, 42);
            this.abrirFicheiroBtn.TabIndex = 0;
            this.abrirFicheiroBtn.Text = "Abrir Ficheiro";
            this.abrirFicheiroBtn.UseVisualStyleBackColor = true;
            this.abrirFicheiroBtn.Click += new System.EventHandler(this.abrirFicheiroBtn_Click);
            // 
            // guardarFicheiroBtn
            // 
            this.guardarFicheiroBtn.Location = new System.Drawing.Point(12, 60);
            this.guardarFicheiroBtn.Name = "guardarFicheiroBtn";
            this.guardarFicheiroBtn.Size = new System.Drawing.Size(91, 42);
            this.guardarFicheiroBtn.TabIndex = 1;
            this.guardarFicheiroBtn.Text = "Guardar Ficheiro";
            this.guardarFicheiroBtn.UseVisualStyleBackColor = true;
            this.guardarFicheiroBtn.Click += new System.EventHandler(this.guardarFicheiroBtn_Click);
            // 
            // EncriptarBtn
            // 
            this.EncriptarBtn.Location = new System.Drawing.Point(12, 108);
            this.EncriptarBtn.Name = "EncriptarBtn";
            this.EncriptarBtn.Size = new System.Drawing.Size(91, 42);
            this.EncriptarBtn.TabIndex = 2;
            this.EncriptarBtn.Text = "Encriptar";
            this.EncriptarBtn.UseVisualStyleBackColor = true;
            this.EncriptarBtn.Click += new System.EventHandler(this.EncriptarBtn_Click);
            // 
            // DesencriptarBtn
            // 
            this.DesencriptarBtn.Location = new System.Drawing.Point(12, 156);
            this.DesencriptarBtn.Name = "DesencriptarBtn";
            this.DesencriptarBtn.Size = new System.Drawing.Size(91, 42);
            this.DesencriptarBtn.TabIndex = 3;
            this.DesencriptarBtn.Text = "Desencriptar";
            this.DesencriptarBtn.UseVisualStyleBackColor = true;
            this.DesencriptarBtn.Click += new System.EventHandler(this.DesencriptarBtn_Click);
            // 
            // NovoBtn
            // 
            this.NovoBtn.Location = new System.Drawing.Point(12, 204);
            this.NovoBtn.Name = "NovoBtn";
            this.NovoBtn.Size = new System.Drawing.Size(91, 42);
            this.NovoBtn.TabIndex = 4;
            this.NovoBtn.Text = "Novo";
            this.NovoBtn.UseVisualStyleBackColor = true;
            this.NovoBtn.Click += new System.EventHandler(this.NovoBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(563, 234);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 258);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.NovoBtn);
            this.Controls.Add(this.DesencriptarBtn);
            this.Controls.Add(this.EncriptarBtn);
            this.Controls.Add(this.guardarFicheiroBtn);
            this.Controls.Add(this.abrirFicheiroBtn);
            this.Name = "Form1";
            this.Text = "Encriptador 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abrirFicheiroBtn;
        private System.Windows.Forms.Button guardarFicheiroBtn;
        private System.Windows.Forms.Button EncriptarBtn;
        private System.Windows.Forms.Button DesencriptarBtn;
        private System.Windows.Forms.Button NovoBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

