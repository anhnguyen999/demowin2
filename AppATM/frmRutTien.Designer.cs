namespace AppATM
{
    partial class frmRutTien
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.txtSoTienRut = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "So Tiền";
            // 
            // btnRutTien
            // 
            this.btnRutTien.Location = new System.Drawing.Point(129, 84);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(103, 47);
            this.btnRutTien.TabIndex = 4;
            this.btnRutTien.Text = "Rut Tien";
            this.btnRutTien.UseVisualStyleBackColor = true;
            this.btnRutTien.Click += new System.EventHandler(this.BtnRutTien_Click);
            // 
            // txtSoTienRut
            // 
            this.txtSoTienRut.Location = new System.Drawing.Point(129, 27);
            this.txtSoTienRut.Name = "txtSoTienRut";
            this.txtSoTienRut.Size = new System.Drawing.Size(272, 26);
            this.txtSoTienRut.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(298, 84);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(103, 47);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Rut Tien";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 159);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnRutTien);
            this.Controls.Add(this.txtSoTienRut);
            this.Name = "frmRutTien";
            this.Text = "frmRutTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.TextBox txtSoTienRut;
        private System.Windows.Forms.Button btnDong;
    }
}