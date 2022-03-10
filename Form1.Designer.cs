
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
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(5, 5);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Padding = new System.Windows.Forms.Padding(10);
            this.pdfViewer1.Size = new System.Drawing.Size(649, 506);
            this.pdfViewer1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.pdfViewer1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(725, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(659, 662);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.printAll);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDeleteFile);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 146);
            this.panel2.TabIndex = 12;
            // 
            // printAll
            // 
            this.printAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printAll.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printAll.Location = new System.Drawing.Point(225, 42);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(219, 46);
            this.printAll.TabIndex = 11;
            this.printAll.Text = "Imprimir Todo";
            this.printAll.UseVisualStyleBackColor = false;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(21, 58);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(21, 6);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(81, 29);
            this.btnDeleteFile.TabIndex = 8;
            this.btnDeleteFile.Text = "Eliminar";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(21, 88);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // documentsListBox
            // 
            this.documentsListBox.AllowDrop = true;
            this.documentsListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.documentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsListBox.FormattingEnabled = true;
            this.documentsListBox.ItemHeight = 15;
            this.documentsListBox.Location = new System.Drawing.Point(10, 62);
            this.documentsListBox.Name = "documentsListBox";
            this.documentsListBox.Size = new System.Drawing.Size(705, 590);
            this.documentsListBox.TabIndex = 10;
            this.documentsListBox.SelectedIndexChanged += new System.EventHandler(this.documentsListBox_SelectedIndexChanged);
            this.documentsListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.documentsListBox_DragDrop);
            this.documentsListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.documentsListBox_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.documentsListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(725, 662);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(228, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suelte sus PDF ▼";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1384, 662);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDF Massive Printer - By JDevelops";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
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

