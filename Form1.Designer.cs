namespace EreflectTrainer
{
    partial class Form1
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
            this.wbTypeRacer = new System.Windows.Forms.WebBrowser();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbTypeRacer
            // 
            this.wbTypeRacer.Location = new System.Drawing.Point(-7, 12);
            this.wbTypeRacer.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTypeRacer.Name = "wbTypeRacer";
            this.wbTypeRacer.Size = new System.Drawing.Size(985, 634);
            this.wbTypeRacer.TabIndex = 0;
            this.wbTypeRacer.Url = new System.Uri("http://play.typeracer.com/", System.UriKind.Absolute);
            this.wbTypeRacer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbTypeRacer_DocumentCompleted);
            this.wbTypeRacer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.wbTypeRacer_PreviewKeyDown);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(993, 57);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(283, 458);
            this.txtData.TabIndex = 1;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(993, 597);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(283, 23);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Read Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(993, 31);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(283, 20);
            this.txtUrl.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(993, 521);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1099, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(1125, 518);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(20, 23);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(993, 548);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1151, 518);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset To Default";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 658);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.wbTypeRacer);
            this.Name = "Form1";
            this.Text = "Type Racer Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbTypeRacer;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnReset;
    }
}

