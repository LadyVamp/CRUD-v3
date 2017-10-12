namespace CRUD_v3
{
    partial class MainAP
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
            this.btnAdminSP = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnAdminSP
            // 
            this.btnAdminSP.Location = new System.Drawing.Point(62, 102);
            this.btnAdminSP.Name = "btnAdminSP";
            this.btnAdminSP.Size = new System.Drawing.Size(322, 23);
            this.btnAdminSP.TabIndex = 0;
            this.btnAdminSP.Text = "Управление таблицей \"Шаблоны поиска\"";
            this.btnAdminSP.UseSelectable = true;
            this.btnAdminSP.Click += new System.EventHandler(this.btnAdminSP_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Панель администратора";
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(483, 295);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAdminSP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAP";
            this.Resizable = false;
            this.Text = "MainAP";
            this.Load += new System.EventHandler(this.MainAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdminSP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}