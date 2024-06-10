namespace Csharp_bangcuuchung
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsKQ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(54, 163);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(366, 62);
            this.txtso.TabIndex = 1;
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(476, 163);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(176, 60);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "XEM";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn muốn hiện thị bản cửu chương mấy? ";
            // 
            // lbsKQ
            // 
            this.lbsKQ.FormattingEnabled = true;
            this.lbsKQ.Location = new System.Drawing.Point(54, 257);
            this.lbsKQ.Name = "lbsKQ";
            this.lbsKQ.Size = new System.Drawing.Size(598, 225);
            this.lbsKQ.TabIndex = 5;
            this.lbsKQ.SelectedIndexChanged += new System.EventHandler(this.lbsKQ_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 508);
            this.Controls.Add(this.lbsKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbsKQ;
    }
}

