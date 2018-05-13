namespace QuanLyThuVien.GUI.UCs
{
    partial class ucFrmHuongDanSuDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.DocumentFilePath = "QuanLyThuVien\\Resources\\HDSD.pdf";
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(836, 519);
            this.pdfViewer1.TabIndex = 0;
            // 
            // ucFrmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdfViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucFrmHuongDanSuDung";
            this.Size = new System.Drawing.Size(836, 519);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
    }
}
