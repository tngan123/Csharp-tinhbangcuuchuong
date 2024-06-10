namespace Csharp_tinhbangcuuchuong
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
            this.lbsKQ = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsKQ
            // 
            this.lbsKQ.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsKQ.FormattingEnabled = true;
            this.lbsKQ.ItemHeight = 25;
            this.lbsKQ.Location = new System.Drawing.Point(153, 248);
            this.lbsKQ.Name = "lbsKQ";
            this.lbsKQ.Size = new System.Drawing.Size(500, 154);
            this.lbsKQ.TabIndex = 9;
            this.lbsKQ.SelectedIndexChanged += new System.EventHandler(this.lbsKQ_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(151, 159);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(312, 36);
            this.txtso.TabIndex = 7;
            this.txtso.TextChanged += new System.EventHandler(this.txtso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bạn muốn hiển thị bảng cửu chương mấy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsKQ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsKQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

