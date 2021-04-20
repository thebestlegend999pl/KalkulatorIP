
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdresIP = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Maska = new System.Windows.Forms.MaskedTextBox();
            this.AdresSieci = new System.Windows.Forms.MaskedTextBox();
            this.AdresR = new System.Windows.Forms.MaskedTextBox();
            this.Adres2 = new System.Windows.Forms.MaskedTextBox();
            this.Adres1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AdresIP
            // 
            this.AdresIP.Location = new System.Drawing.Point(101, 42);
            this.AdresIP.Mask = "###\\.###\\.###\\.###";
            this.AdresIP.Name = "AdresIP";
            this.AdresIP.Size = new System.Drawing.Size(150, 31);
            this.AdresIP.TabIndex = 0;
            this.AdresIP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(21, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adres IP ";
            // 
            // Maska
            // 
            this.Maska.Location = new System.Drawing.Point(101, 102);
            this.Maska.Mask = "###\\.###\\.###\\.###";
            this.Maska.Name = "Maska";
            this.Maska.Size = new System.Drawing.Size(150, 31);
            this.Maska.TabIndex = 7;
            this.Maska.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // AdresSieci
            // 
            this.AdresSieci.Location = new System.Drawing.Point(131, 154);
            this.AdresSieci.Mask = "###\\.###\\.###\\.###";
            this.AdresSieci.Name = "AdresSieci";
            this.AdresSieci.ReadOnly = true;
            this.AdresSieci.Size = new System.Drawing.Size(150, 31);
            this.AdresSieci.TabIndex = 8;
            this.AdresSieci.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // AdresR
            // 
            this.AdresR.Location = new System.Drawing.Point(220, 196);
            this.AdresR.Mask = "###\\.###\\.###\\.###";
            this.AdresR.Name = "AdresR";
            this.AdresR.ReadOnly = true;
            this.AdresR.Size = new System.Drawing.Size(150, 31);
            this.AdresR.TabIndex = 9;
            this.AdresR.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // Adres2
            // 
            this.Adres2.Location = new System.Drawing.Point(151, 295);
            this.Adres2.Mask = "###\\.###\\.###\\.###";
            this.Adres2.Name = "Adres2";
            this.Adres2.Size = new System.Drawing.Size(150, 31);
            this.Adres2.TabIndex = 11;
            this.Adres2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // Adres1
            // 
            this.Adres1.Location = new System.Drawing.Point(160, 247);
            this.Adres1.Mask = "###\\.###\\.###\\.###";
            this.Adres1.Name = "Adres1";
            this.Adres1.Size = new System.Drawing.Size(150, 31);
            this.Adres1.TabIndex = 10;
            this.Adres1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maska";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adres Sieci";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres Rozgłoszeniowy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pierwszy Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ostatni Adres";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(620, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 31);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Kamil Jaglarski 3GH";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adres2);
            this.Controls.Add(this.Adres1);
            this.Controls.Add(this.AdresR);
            this.Controls.Add(this.AdresSieci);
            this.Controls.Add(this.Maska);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdresIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox AdresIP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Maska;
        private System.Windows.Forms.MaskedTextBox AdresSieci;
        private System.Windows.Forms.MaskedTextBox AdresR;
        private System.Windows.Forms.MaskedTextBox Adres2;
        private System.Windows.Forms.MaskedTextBox Adres1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

