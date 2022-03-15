
namespace PDFMassivePrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printAll = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.documentsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            resources.ApplyResources(this.pdfViewer1, "pdfViewer1");
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pdfViewer1.Name = "pdfViewer1";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.pdfViewer1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Name = "panel4";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.printAll);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDeleteFile);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Name = "panel2";
            // 
            // printAll
            // 
            resources.ApplyResources(this.printAll, "printAll");
            this.printAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printAll.Name = "printAll";
            this.printAll.UseVisualStyleBackColor = false;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // btnUp
            // 
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDeleteFile
            // 
            resources.ApplyResources(this.btnDeleteFile, "btnDeleteFile");
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDown
            // 
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // documentsListBox
            // 
            resources.ApplyResources(this.documentsListBox, "documentsListBox");
            this.documentsListBox.AllowDrop = true;
            this.documentsListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.documentsListBox.FormattingEnabled = true;
            this.documentsListBox.Name = "documentsListBox";
            this.documentsListBox.SelectedIndexChanged += new System.EventHandler(this.documentsListBox_SelectedIndexChanged);
            this.documentsListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.documentsListBox_DragDrop);
            this.documentsListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.documentsListBox_DragEnter);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.documentsListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox documentsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

