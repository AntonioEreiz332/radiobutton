namespace radio_button
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.rbtnAvion = new System.Windows.Forms.RadioButton();
            this.rbtnAutobus = new System.Windows.Forms.RadioButton();
            this.rbtnPrijevoz = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPrijevoz);
            this.groupBox1.Controls.Add(this.rbtnAutobus);
            this.groupBox1.Controls.Add(this.rbtnAvion);
            this.groupBox1.Location = new System.Drawing.Point(286, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(335, 195);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(98, 23);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(286, 254);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(200, 72);
            this.txtBox1.TabIndex = 2;
            // 
            // rbtnAvion
            // 
            this.rbtnAvion.AutoSize = true;
            this.rbtnAvion.Location = new System.Drawing.Point(29, 20);
            this.rbtnAvion.Name = "rbtnAvion";
            this.rbtnAvion.Size = new System.Drawing.Size(52, 17);
            this.rbtnAvion.TabIndex = 0;
            this.rbtnAvion.TabStop = true;
            this.rbtnAvion.Text = "Avion";
            this.rbtnAvion.UseVisualStyleBackColor = true;
            // 
            // rbtnAutobus
            // 
            this.rbtnAutobus.AutoSize = true;
            this.rbtnAutobus.Location = new System.Drawing.Point(29, 44);
            this.rbtnAutobus.Name = "rbtnAutobus";
            this.rbtnAutobus.Size = new System.Drawing.Size(64, 17);
            this.rbtnAutobus.TabIndex = 1;
            this.rbtnAutobus.TabStop = true;
            this.rbtnAutobus.Text = "Autobus";
            this.rbtnAutobus.UseVisualStyleBackColor = true;
            // 
            // rbtnPrijevoz
            // 
            this.rbtnPrijevoz.AutoSize = true;
            this.rbtnPrijevoz.Location = new System.Drawing.Point(29, 68);
            this.rbtnPrijevoz.Name = "rbtnPrijevoz";
            this.rbtnPrijevoz.Size = new System.Drawing.Size(94, 17);
            this.rbtnPrijevoz.TabIndex = 2;
            this.rbtnPrijevoz.TabStop = true;
            this.rbtnPrijevoz.Text = "Vlastiti prijevoz";
            this.rbtnPrijevoz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Upotreba RadioButton kontrole";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPrijevoz;
        private System.Windows.Forms.RadioButton rbtnAutobus;
        private System.Windows.Forms.RadioButton rbtnAvion;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

