﻿using System;
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
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;

namespace WordToPDFConverter
{
    public partial class AppForm : System.Windows.Forms.Form
    {

        
        public AppForm() 

        {
            InitializeComponent();
            
        }


        private bool convertClicked = false;
        public static string SetValueForText1 = "";


        private void btnBrowse_Click(object sender, EventArgs e)
        {

            
                System.Windows.Forms.OpenFileDialog fdlg = new System.Windows.Forms.OpenFileDialog();
                fdlg.Title = "Browse";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtfilename.Text = fdlg.FileName;
                }

        }


        
        private void btnConvert_Click(object sender, EventArgs e)
        {
                convertClicked = true;

                this.Hide();
                PleaseWait pw = new PleaseWait();
                pw.Show();


                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            
                object oMissing = System.Reflection.Missing.Value;

                string path = txtfilename.Text;
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

            

            System.Windows.Forms.MessageBox.Show("Your file has been converted.\n You can view it by clicking \"File preview\" or send it via email by clicking \"Mail\" button");

            pw.Close();
                this.Show();
            
        }
            

        private void AppForm_Load(object sender, EventArgs e)
        {
            //show in center of the screen
            Size screenSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
            
        }

        private void btnMail_Click(object sender, EventArgs e)
        {

            //opens new form with btnmail authentication and send button

            SetValueForText1 = txtfilename.Text.Replace(".docx",".pdf");

            mailAuth ma = new mailAuth();
            this.Hide();
            ma.Show();
            
        }

        
    public void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }


        //file preview, if "Convert" was clicked
        private void btnFilePreview_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtfilename.Text) && convertClicked)
            {
                string filename = txtfilename.Text.Replace(".docx", ".pdf");

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(filename);
                System.Diagnostics.Process.Start(startInfo);

                
                convertClicked = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No file converted.");
            }

            convertClicked = false;
        }

    }

}
