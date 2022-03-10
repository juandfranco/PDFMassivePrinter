using PdfiumPrinter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFMassivePrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void documentsListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {

                string ext = Path.GetExtension(file);

                if (ext.Equals(".pdf"))
                {
                    documentsListBox.Items.Add(file);
                }
                

                //THEN DO WHATEVER YOU WANT TO EACH file in files
                //e.g.



            }
        }

        private void documentsListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }

        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            var currentSelectIndex = documentsListBox.SelectedIndex;

            if (documentsListBox.SelectedIndex >= 0)
            {
                documentsListBox.Items.RemoveAt(documentsListBox.SelectedIndex);

                this.pdfViewer1.Document.Dispose();
                this.pdfViewer1.Visible = false;


                if (documentsListBox.Items.Count >= 0)
                {
                    if (documentsListBox.Items.Count >= currentSelectIndex + 1)
                    {
                        documentsListBox.SelectedIndex = currentSelectIndex;
                    }
                    else
                    {
                        documentsListBox.SelectedIndex = currentSelectIndex-1;
                    }
                }
                

            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = documentsListBox.SelectedIndex;
            object item = documentsListBox.SelectedItem;
            documentsListBox.Items.RemoveAt(documentsListBox.SelectedIndex);
            documentsListBox.Items.Insert(index - 1, item);
            documentsListBox.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = documentsListBox.SelectedIndex;
            object item = documentsListBox.SelectedItem;
            documentsListBox.Items.RemoveAt(documentsListBox.SelectedIndex);
            documentsListBox.Items.Insert(index + 1, item);
            documentsListBox.SelectedIndex = index + 1;
        }

        private void documentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnUp.Enabled = (documentsListBox.SelectedIndex > 0);
            btnDown.Enabled =(documentsListBox.SelectedIndex < documentsListBox.Items.Count - 1);

            if (documentsListBox.SelectedIndex >= 0)
            {
                this.pdfViewer1.Visible = true;
                string patch = documentsListBox.GetItemText(documentsListBox.SelectedItem);
                var doc = PdfiumViewer.PdfDocument.Load(patch);
                this.pdfViewer1.Document = doc;
            }

        }

        private void printAll_Click(object sender, EventArgs e)
        {
            
            

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                var printerSettings = printDialog1.PrinterSettings;

                pageSetupDialog1.PageSettings = GetPrinterPageInfo(printerSettings.PrinterName);

                if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                {
                    var pageSettings = pageSetupDialog1.PageSettings;

                    foreach (var patch in documentsListBox.Items)
                    {
                        
                        var printer = new PdfPrinter();

                        //printer.PageSettings.PaperSize = cbSelectPaperSize.Text

                        printer.Settings.PrinterName = printerSettings.PrinterName;
                        printer.Settings.Copies = printerSettings.Copies;
                        printer.Settings.Duplex = printerSettings.Duplex;


                        printer.PageSettings.PaperSize = pageSettings.PaperSize;
                        printer.PageSettings.Landscape = pageSettings.Landscape;
                        printer.PageSettings.Margins = pageSettings.Margins;
                        printer.PageSettings.Color = pageSettings.Color;
                        printer.PageSettings.PaperSource = pageSettings.PaperSource;
                        printer.PageSettings.PrinterResolution = pageSettings.PrinterResolution;
                        
                        



                        var printFile = patch.ToString(); //The path to the pdf which needs to be printed;


                        printer.Print(printFile);
                    }
                }
            }
                        
        }



        public static PageSettings GetPrinterPageInfo(string printerName)
        {
            PrinterSettings settings;

            // If printer name is not set, look for default printer
            if (string.IsNullOrEmpty(printerName))
            {
                foreach (var printer in PrinterSettings.InstalledPrinters)
                {
                    settings = new PrinterSettings();

                    settings.PrinterName = printer.ToString();

                    if (settings.IsDefaultPrinter)
                        return settings.DefaultPageSettings;
                }

                return null; // <- No default printer  
            }

            // printer by its name 
            settings = new PrinterSettings();

            settings.PrinterName = printerName;

            return settings.DefaultPageSettings;
        }
    }
}
