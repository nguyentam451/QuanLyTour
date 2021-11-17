
namespace QuanLyTour.View.FormBangGia
{
    partial class FormBangGia
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGia = new System.Windows.Forms.TabPage();
            this.dtgvGia = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGia);
            this.tabControl1.Location = new System.Drawing.Point(17, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 594);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageGia
            // 
            this.tabPageGia.Controls.Add(this.dtgvGia);
            this.tabPageGia.Location = new System.Drawing.Point(4, 25);
            this.tabPageGia.Name = "tabPageGia";
            this.tabPageGia.Size = new System.Drawing.Size(870, 565);
            this.tabPageGia.TabIndex = 3;
            this.tabPageGia.Text = "Bảng giá";
            this.tabPageGia.UseVisualStyleBackColor = true;
            // 
            // dtgvGia
            // 
            this.dtgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGia.Location = new System.Drawing.Point(26, 63);
            this.dtgvGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvGia.Name = "dtgvGia";
            this.dtgvGia.RowHeadersWidth = 51;
            this.dtgvGia.RowTemplate.Height = 24;
            this.dtgvGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGia.Size = new System.Drawing.Size(758, 450);
            this.dtgvGia.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBangGia";
            this.Text = "FormBangGia";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGia;
        private System.Windows.Forms.DataGridView dtgvGia;
        private System.Windows.Forms.Button button1;
    }
}