namespace WordToPDFConverter
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.btnconvert = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfilepreview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconvert.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnconvert.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnconvert.Location = new System.Drawing.Point(267, 221);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(104, 30);
            this.btnconvert.TabIndex = 0;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(124, 110);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(193, 20);
            this.txtfilename.TabIndex = 1;
            this.txtfilename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnbrowse.Location = new System.Drawing.Point(415, 104);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(70, 31);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmail
            // 
            this.btnmail.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmail.Image = global::WordToPDFConverter.mailIcon.Mail_icon;
            this.btnmail.Location = new System.Drawing.Point(477, 316);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(132, 66);
            this.btnmail.TabIndex = 7;
            this.btnmail.UseVisualStyleBackColor = true;
            this.btnmail.Click += new System.EventHandler(this.mail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(167, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a file you want to convert";
            // 
            // btnfilepreview
            // 
            this.btnfilepreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnfilepreview.Location = new System.Drawing.Point(85, 336);
            this.btnfilepreview.Name = "btnfilepreview";
            this.btnfilepreview.Size = new System.Drawing.Size(104, 27);
            this.btnfilepreview.TabIndex = 9;
            this.btnfilepreview.Text = "File preview";
            this.btnfilepreview.UseVisualStyleBackColor = true;
            this.btnfilepreview.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "File :";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(641, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfilepreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmail);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.btnconvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Word to PDF Converter";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfilepreview;
        private System.Windows.Forms.Label label2;
    }
}