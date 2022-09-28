namespace CheckBox_Kontrola
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
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.checkBoxSakrij = new System.Windows.Forms.CheckBox();
            this.textBoxNarudzba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(23, 26);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Dorucak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(23, 77);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Rucak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(23, 122);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Vecera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(23, 187);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(75, 23);
            this.buttonPosalji.TabIndex = 3;
            this.buttonPosalji.Text = "Posalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // checkBoxSakrij
            // 
            this.checkBoxSakrij.AutoSize = true;
            this.checkBoxSakrij.Location = new System.Drawing.Point(214, 187);
            this.checkBoxSakrij.Name = "checkBoxSakrij";
            this.checkBoxSakrij.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSakrij.TabIndex = 4;
            this.checkBoxSakrij.Text = "Sakrij Narudzbu";
            this.checkBoxSakrij.UseVisualStyleBackColor = true;
            this.checkBoxSakrij.CheckedChanged += new System.EventHandler(this.checkBoxSakrij_CheckedChanged);
            // 
            // textBoxNarudzba
            // 
            this.textBoxNarudzba.Location = new System.Drawing.Point(214, 26);
            this.textBoxNarudzba.Multiline = true;
            this.textBoxNarudzba.Name = "textBoxNarudzba";
            this.textBoxNarudzba.Size = new System.Drawing.Size(138, 136);
            this.textBoxNarudzba.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 268);
            this.Controls.Add(this.textBoxNarudzba);
            this.Controls.Add(this.checkBoxSakrij);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDorucak;
        private System.Windows.Forms.CheckBox checkRucak;
        private System.Windows.Forms.CheckBox checkVecera;
        private System.Windows.Forms.TextBox txtNarudzba;
        private System.Windows.Forms.CheckBox checkSakrij;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.CheckBox checkBoxSakrij;
        private System.Windows.Forms.TextBox textBoxNarudzba;
    }
}

