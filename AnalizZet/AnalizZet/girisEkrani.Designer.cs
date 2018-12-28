namespace AnalizZet
{
    partial class girisEkrani
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
            this.veriSecBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.veriYoluTxt = new System.Windows.Forms.TextBox();
            this.videoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.videoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // veriSecBtn
            // 
            this.veriSecBtn.Location = new System.Drawing.Point(215, 96);
            this.veriSecBtn.Name = "veriSecBtn";
            this.veriSecBtn.Size = new System.Drawing.Size(75, 23);
            this.veriSecBtn.TabIndex = 0;
            this.veriSecBtn.Text = "Veri Seç";
            this.veriSecBtn.UseVisualStyleBackColor = true;
            this.veriSecBtn.Click += new System.EventHandler(this.veriSecBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensör Verilerini Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seçilen Veri Yolu:";
            // 
            // veriYoluTxt
            // 
            this.veriYoluTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriYoluTxt.Location = new System.Drawing.Point(190, 125);
            this.veriYoluTxt.Name = "veriYoluTxt";
            this.veriYoluTxt.Size = new System.Drawing.Size(100, 23);
            this.veriYoluTxt.TabIndex = 3;
            // 
            // videoTxt
            // 
            this.videoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videoTxt.Location = new System.Drawing.Point(190, 260);
            this.videoTxt.Name = "videoTxt";
            this.videoTxt.Size = new System.Drawing.Size(100, 23);
            this.videoTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seçilen Video Yolu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Video Kaydı Seçiniz:";
            // 
            // videoBtn
            // 
            this.videoBtn.Location = new System.Drawing.Point(215, 231);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(75, 23);
            this.videoBtn.TabIndex = 4;
            this.videoBtn.Text = "Video Seç";
            this.videoBtn.UseVisualStyleBackColor = true;
            // 
            // girisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 413);
            this.Controls.Add(this.videoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.videoBtn);
            this.Controls.Add(this.veriYoluTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veriSecBtn);
            this.Name = "girisEkrani";
            this.Text = "girisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button veriSecBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox veriYoluTxt;
        private System.Windows.Forms.TextBox videoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button videoBtn;
    }
}