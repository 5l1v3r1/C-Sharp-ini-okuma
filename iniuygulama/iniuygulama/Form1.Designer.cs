namespace iniuygulama
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.portDIGERtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portTAHTAtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.portSEStext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portGORUNTUtext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.portSOHBETtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.portDIGERtext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.portTAHTAtext);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.portSEStext);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.portGORUNTUtext);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.portSOHBETtext);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ipText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 241);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Ayarları";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(171, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 96;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Web Sunucusu:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portDIGERtext
            // 
            this.portDIGERtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portDIGERtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portDIGERtext.Location = new System.Drawing.Point(171, 208);
            this.portDIGERtext.Name = "portDIGERtext";
            this.portDIGERtext.Size = new System.Drawing.Size(100, 24);
            this.portDIGERtext.TabIndex = 23;
            this.portDIGERtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Diğer İletişim Portu :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ses İletişim Portu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portTAHTAtext
            // 
            this.portTAHTAtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portTAHTAtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portTAHTAtext.Location = new System.Drawing.Point(171, 180);
            this.portTAHTAtext.Name = "portTAHTAtext";
            this.portTAHTAtext.Size = new System.Drawing.Size(100, 24);
            this.portTAHTAtext.TabIndex = 16;
            this.portTAHTAtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tahta İletişim Portu :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portSEStext
            // 
            this.portSEStext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portSEStext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portSEStext.Location = new System.Drawing.Point(171, 152);
            this.portSEStext.Name = "portSEStext";
            this.portSEStext.Size = new System.Drawing.Size(100, 24);
            this.portSEStext.TabIndex = 18;
            this.portSEStext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Görüntü İletişim Portu :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portGORUNTUtext
            // 
            this.portGORUNTUtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portGORUNTUtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portGORUNTUtext.Location = new System.Drawing.Point(171, 124);
            this.portGORUNTUtext.Name = "portGORUNTUtext";
            this.portGORUNTUtext.Size = new System.Drawing.Size(100, 24);
            this.portGORUNTUtext.TabIndex = 20;
            this.portGORUNTUtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sohbet Yazışma Portu :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portSOHBETtext
            // 
            this.portSOHBETtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portSOHBETtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portSOHBETtext.Location = new System.Drawing.Point(171, 96);
            this.portSOHBETtext.Name = "portSOHBETtext";
            this.portSOHBETtext.Size = new System.Drawing.Size(100, 24);
            this.portSOHBETtext.TabIndex = 22;
            this.portSOHBETtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Genel IP:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipText
            // 
            this.ipText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipText.Location = new System.Drawing.Point(171, 68);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(100, 24);
            this.ipText.TabIndex = 14;
            this.ipText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox portDIGERtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTAHTAtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox portSEStext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portGORUNTUtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox portSOHBETtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ipText;
    }
}

