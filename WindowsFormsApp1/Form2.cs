using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;
using SautinSoft;
using SautinSoft.Document;


namespace WindowsFormsApp1
{
    public partial class AppForm : System.Windows.Forms.Form
    {
        public AppForm()

        {
            InitializeComponent();
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Word to PDF")
            {


                System.Windows.Forms.OpenFileDialog fdlg = new System.Windows.Forms.OpenFileDialog();
                fdlg.Title = "Browse";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = fdlg.FileName;
                }
            }

            else if (comboBox1.Text == "PDF to Excel")
            {
                System.Windows.Forms.OpenFileDialog fdlg = new System.Windows.Forms.OpenFileDialog();
                fdlg.Title = "Browse";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = fdlg.FileName;
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Word to PDF")
            {
                this.Hide();
                PleaseWait pw = new PleaseWait();
                pw.Show();


                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();



                object oMissing = System.Reflection.Missing.Value;

                string path = textBox1.Text;
                FileInfo fileInfo = new FileInfo(@path);



                word.Visible = false;
                word.ScreenUpdating = false;



                Document doc = word.Documents.Open(path);
                doc.Activate();


                object outputFileName = path.Replace(".docx", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;


                doc.SaveAs(outputFileName, WdSaveFormat.wdFormatPDF);


                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;


                ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
                word = null;

                pw.Close();
                EndForm ef = new EndForm();
                ef.Show();

            }

            else if (comboBox1.Text == "PDF to Excel")
            {

                this.Hide();
                PleaseWait pw = new PleaseWait();
                pw.Show();

                string path = comboBox1.Text;

                SautinSoft.PdfFocus f = new PdfFocus();

                f.OpenPdf(path);

                if (f.PageCount > 0)

                    f.ToExcel(path.Replace(".pdf", ".xls"));


                pw.Close();
                EndForm ef = new EndForm();
                ef.Show();
            }
        }
            
            

        private void AppForm_Load(object sender, EventArgs e)
        {
            //show in center of the screen
            Size screenSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);

        }

       /* private void button3_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.OpenFileDialog fdlg = new System.Windows.Forms.OpenFileDialog();
            fdlg.Title = "Browse";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = fdlg.FileName;
            }

            
        }*/
        
        
    }


}
