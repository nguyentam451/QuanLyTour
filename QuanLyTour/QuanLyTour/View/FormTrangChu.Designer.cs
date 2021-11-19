
namespace QuanLyTour
{
    partial class Form3
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
            this.lbQuanLyTour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBangGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuanLyTour
            // 
            this.lbQuanLyTour.BackColor = System.Drawing.Color.SkyBlue;
            this.lbQuanLyTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyTour.ForeColor = System.Drawing.Color.White;
            this.lbQuanLyTour.Location = new System.Drawing.Point(18, 24);
            this.lbQuanLyTour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuanLyTour.Name = "lbQuanLyTour";
            this.lbQuanLyTour.Size = new System.Drawing.Size(179, 58);
            this.lbQuanLyTour.TabIndex = 1;
            this.lbQuanLyTour.Text = "Tour Du Lịch";
            this.lbQuanLyTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuanLyTour.Click += new System.EventHandler(this.lbQuanLyTour_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBangGia
            // 
            this.lbBangGia.BackColor = System.Drawing.Color.Teal;
            this.lbBangGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangGia.ForeColor = System.Drawing.Color.White;
            this.lbBangGia.Location = new System.Drawing.Point(18, 265);
            this.lbBangGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBangGia.Name = "lbBangGia";
            this.lbBangGia.Size = new System.Drawing.Size(179, 58);
            this.lbBangGia.TabIndex = 3;
            this.lbBangGia.Text = "Bảng Giá";
            this.lbBangGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 409);
            this.Controls.Add(this.lbBangGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbQuanLyTour);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLyTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBangGia;
    }
}