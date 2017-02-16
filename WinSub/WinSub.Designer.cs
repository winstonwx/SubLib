namespace WinSub
{
    partial class WinSub
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.btRemoveHtmTag = new System.Windows.Forms.Button();
            this.lblErrmsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(12, 19);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(63, 13);
            this.lblSourceFile.TabIndex = 0;
            this.lblSourceFile.Text = "Source File:";
            // 
            // tbSource
            // 
            this.tbSource.Enabled = false;
            this.tbSource.Location = new System.Drawing.Point(84, 16);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(330, 20);
            this.tbSource.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(430, 14);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(12, 53);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(60, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target File:";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(84, 50);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(330, 20);
            this.tbTarget.TabIndex = 4;
            // 
            // btRemoveHtmTag
            // 
            this.btRemoveHtmTag.Location = new System.Drawing.Point(75, 89);
            this.btRemoveHtmTag.Name = "btRemoveHtmTag";
            this.btRemoveHtmTag.Size = new System.Drawing.Size(133, 23);
            this.btRemoveHtmTag.TabIndex = 5;
            this.btRemoveHtmTag.Text = "Remove HTML Tags";
            this.btRemoveHtmTag.UseVisualStyleBackColor = true;
            this.btRemoveHtmTag.Click += new System.EventHandler(this.btRemoveHtmTag_Click);
            // 
            // lblErrmsg
            // 
            this.lblErrmsg.AutoSize = true;
            this.lblErrmsg.Location = new System.Drawing.Point(12, 144);
            this.lblErrmsg.Name = "lblErrmsg";
            this.lblErrmsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrmsg.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.lblSourceFile);
            this.panel1.Controls.Add(this.BtnBrowse);
            this.panel1.Controls.Add(this.tbTarget);
            this.panel1.Controls.Add(this.lblErrmsg);
            this.panel1.Controls.Add(this.lblTarget);
            this.panel1.Controls.Add(this.tbSource);
            this.panel1.Controls.Add(this.btRemoveHtmTag);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 313);
            this.panel1.TabIndex = 7;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // WinSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 313);
            this.Controls.Add(this.panel1);
            this.Name = "WinSub";
            this.Text = "Sub Cleaner ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Button btRemoveHtmTag;
        private System.Windows.Forms.Label lblErrmsg;
        private System.Windows.Forms.Panel panel1;
    }
}

