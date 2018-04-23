namespace os2_projekt
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
            this.orgTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cryptoTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSazetak = new System.Windows.Forms.RichTextBox();
            this.radioSim = new System.Windows.Forms.RadioButton();
            this.radioAntisim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.btnSazetak = new System.Windows.Forms.Button();
            this.btnPotpis = new System.Windows.Forms.Button();
            this.btnProvjera = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orgTxt
            // 
            this.orgTxt.Location = new System.Drawing.Point(20, 71);
            this.orgTxt.Name = "orgTxt";
            this.orgTxt.Size = new System.Drawing.Size(279, 253);
            this.orgTxt.TabIndex = 0;
            this.orgTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Originalni tekst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(365, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kriptirani tekst:";
            // 
            // cryptoTxt
            // 
            this.cryptoTxt.Location = new System.Drawing.Point(368, 71);
            this.cryptoTxt.Name = "cryptoTxt";
            this.cryptoTxt.Size = new System.Drawing.Size(279, 253);
            this.cryptoTxt.TabIndex = 3;
            this.cryptoTxt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSazetak);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cryptoTxt);
            this.groupBox1.Controls.Add(this.orgTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(198, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 474);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sažetak:";
            // 
            // txtSazetak
            // 
            this.txtSazetak.Location = new System.Drawing.Point(20, 363);
            this.txtSazetak.Name = "txtSazetak";
            this.txtSazetak.Size = new System.Drawing.Size(627, 96);
            this.txtSazetak.TabIndex = 4;
            this.txtSazetak.Text = "";
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioSim.Location = new System.Drawing.Point(29, 31);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(74, 17);
            this.radioSim.TabIndex = 5;
            this.radioSim.TabStop = true;
            this.radioSim.Text = "Simetrično";
            this.radioSim.UseVisualStyleBackColor = true;
            // 
            // radioAntisim
            // 
            this.radioAntisim.AutoSize = true;
            this.radioAntisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioAntisim.Location = new System.Drawing.Point(29, 54);
            this.radioAntisim.Name = "radioAntisim";
            this.radioAntisim.Size = new System.Drawing.Size(90, 17);
            this.radioAntisim.TabIndex = 6;
            this.radioAntisim.TabStop = true;
            this.radioAntisim.Text = "Antisimetrično";
            this.radioAntisim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSim);
            this.groupBox2.Controls.Add(this.radioAntisim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(11, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odaberi način:";
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.BackColor = System.Drawing.Color.Azure;
            this.btnKriptiraj.Location = new System.Drawing.Point(12, 228);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(146, 31);
            this.btnKriptiraj.TabIndex = 8;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = false;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.BackColor = System.Drawing.Color.Azure;
            this.btnDekriptiraj.Location = new System.Drawing.Point(11, 265);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(147, 31);
            this.btnDekriptiraj.TabIndex = 9;
            this.btnDekriptiraj.Text = "Dekriptiraj";
            this.btnDekriptiraj.UseVisualStyleBackColor = false;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // btnSazetak
            // 
            this.btnSazetak.BackColor = System.Drawing.Color.Azure;
            this.btnSazetak.Location = new System.Drawing.Point(12, 340);
            this.btnSazetak.Name = "btnSazetak";
            this.btnSazetak.Size = new System.Drawing.Size(146, 41);
            this.btnSazetak.TabIndex = 10;
            this.btnSazetak.Text = "Napravi sažetak";
            this.btnSazetak.UseVisualStyleBackColor = false;
            this.btnSazetak.Click += new System.EventHandler(this.btnSazetak_Click);
            // 
            // btnPotpis
            // 
            this.btnPotpis.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPotpis.Location = new System.Drawing.Point(890, 431);
            this.btnPotpis.Name = "btnPotpis";
            this.btnPotpis.Size = new System.Drawing.Size(135, 49);
            this.btnPotpis.TabIndex = 11;
            this.btnPotpis.Text = "Digitalni potpis";
            this.btnPotpis.UseVisualStyleBackColor = false;
            this.btnPotpis.Click += new System.EventHandler(this.btnPotpis_Click);
            // 
            // btnProvjera
            // 
            this.btnProvjera.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProvjera.Location = new System.Drawing.Point(890, 486);
            this.btnProvjera.Name = "btnProvjera";
            this.btnProvjera.Size = new System.Drawing.Size(135, 30);
            this.btnProvjera.TabIndex = 12;
            this.btnProvjera.Text = "Provjera";
            this.btnProvjera.UseVisualStyleBackColor = false;
            this.btnProvjera.Click += new System.EventHandler(this.btnProvjera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.btnProvjera);
            this.Controls.Add(this.btnPotpis);
            this.Controls.Add(this.btnSazetak);
            this.Controls.Add(this.btnDekriptiraj);
            this.Controls.Add(this.btnKriptiraj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Moj projekt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox orgTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox cryptoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtSazetak;
        private System.Windows.Forms.RadioButton radioSim;
        private System.Windows.Forms.RadioButton radioAntisim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.Button btnDekriptiraj;
        private System.Windows.Forms.Button btnSazetak;
        private System.Windows.Forms.Button btnPotpis;
        private System.Windows.Forms.Button btnProvjera;
    }
}

