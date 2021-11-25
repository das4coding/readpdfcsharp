
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;



namespace PdfRead
{
    public partial class Form1 : Form
    {

        string file = @"C:\Users\lal\Documents\Visual Studio 2017\file\Agile Teams.pdf";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            PdfReader pdfRead = new PdfReader(file);
            PdfDocument pdfdoc = new PdfDocument(pdfRead);

            for(int page = 1; page <= pdfdoc.GetNumberOfPages(); page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                string data = PdfTextExtractor.GetTextFromPage(pdfdoc.GetPage(page), strategy);
                Debug.WriteLine(data);
                MessageBox.Show("page number : "+page);

            }

        }
    }
}
