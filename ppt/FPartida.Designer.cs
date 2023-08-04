namespace ppt
{
    partial class FPartida
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
            this.rbPiedra = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.rbTijera = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReportaje = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReportaje = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPiedra
            // 
            this.rbPiedra.AutoSize = true;
            this.rbPiedra.Location = new System.Drawing.Point(98, 26);
            this.rbPiedra.Name = "rbPiedra";
            this.rbPiedra.Size = new System.Drawing.Size(55, 17);
            this.rbPiedra.TabIndex = 0;
            this.rbPiedra.TabStop = true;
            this.rbPiedra.Text = "Piedra";
            this.rbPiedra.UseVisualStyleBackColor = true;
            // 
            // rbPapel
            // 
            this.rbPapel.AutoSize = true;
            this.rbPapel.Location = new System.Drawing.Point(159, 26);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(52, 17);
            this.rbPapel.TabIndex = 1;
            this.rbPapel.TabStop = true;
            this.rbPapel.Text = "Papel";
            this.rbPapel.UseVisualStyleBackColor = true;
            // 
            // rbTijera
            // 
            this.rbTijera.AutoSize = true;
            this.rbTijera.Location = new System.Drawing.Point(217, 26);
            this.rbTijera.Name = "rbTijera";
            this.rbTijera.Size = new System.Drawing.Size(51, 17);
            this.rbTijera.TabIndex = 2;
            this.rbTijera.TabStop = true;
            this.rbTijera.Text = "Tijera";
            this.rbTijera.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(6, 19);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(86, 31);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJugar);
            this.groupBox1.Controls.Add(this.rbPiedra);
            this.groupBox1.Controls.Add(this.rbTijera);
            this.groupBox1.Controls.Add(this.rbPapel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Humano";
            // 
            // lbReportaje
            // 
            this.lbReportaje.FormattingEnabled = true;
            this.lbReportaje.Location = new System.Drawing.Point(6, 19);
            this.lbReportaje.Name = "lbReportaje";
            this.lbReportaje.Size = new System.Drawing.Size(265, 95);
            this.lbReportaje.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbReportaje);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Máquina";
            // 
            // btnReportaje
            // 
            this.btnReportaje.Location = new System.Drawing.Point(18, 265);
            this.btnReportaje.Name = "btnReportaje";
            this.btnReportaje.Size = new System.Drawing.Size(130, 56);
            this.btnReportaje.TabIndex = 9;
            this.btnReportaje.Text = "Mostrar Reportaje";
            this.btnReportaje.UseVisualStyleBackColor = true;
            this.btnReportaje.Click += new System.EventHandler(this.btnReportaje_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(159, 264);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 56);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(301, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReportaje);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Partida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rbPiedra;
        public System.Windows.Forms.RadioButton rbPapel;
        public System.Windows.Forms.RadioButton rbTijera;
        public System.Windows.Forms.ListBox lbReportaje;
        public System.Windows.Forms.Button btnJugar;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnReportaje;
        public System.Windows.Forms.Button btnCerrar;
    }
}