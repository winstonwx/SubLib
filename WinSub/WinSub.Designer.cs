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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelay = new System.Windows.Forms.Button();
            this.txtDelayMilliSeconds = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblErrmsg = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "srt File (*.srt)|*.srt";
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(1, 9);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(63, 13);
            this.lblSourceFile.TabIndex = 0;
            this.lblSourceFile.Text = "Source File:";
            // 
            // tbSource
            // 
            this.tbSource.Enabled = false;
            this.tbSource.Location = new System.Drawing.Point(67, 6);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(237, 20);
            this.tbSource.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(310, 3);
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
            this.lblTarget.Location = new System.Drawing.Point(-1, 7);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(60, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target File:";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(62, 3);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(330, 20);
            this.tbTarget.TabIndex = 4;
            // 
            // btRemoveHtmTag
            // 
            this.btRemoveHtmTag.Location = new System.Drawing.Point(408, 3);
            this.btRemoveHtmTag.Name = "btRemoveHtmTag";
            this.btRemoveHtmTag.Size = new System.Drawing.Size(116, 23);
            this.btRemoveHtmTag.TabIndex = 5;
            this.btRemoveHtmTag.Text = "Remove HTML Tags";
            this.btRemoveHtmTag.UseVisualStyleBackColor = true;
            this.btRemoveHtmTag.Click += new System.EventHandler(this.btRemoveHtmTag_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(530, 3);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(133, 23);
            this.btnDelay.TabIndex = 8;
            this.btnDelay.Text = "Delay Miliseconds";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // txtDelayMilliSeconds
            // 
            this.txtDelayMilliSeconds.Location = new System.Drawing.Point(669, 5);
            this.txtDelayMilliSeconds.Name = "txtDelayMilliSeconds";
            this.txtDelayMilliSeconds.Size = new System.Drawing.Size(111, 20);
            this.txtDelayMilliSeconds.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblErrmsg);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblTarget);
            this.panel2.Controls.Add(this.tbTarget);
            this.panel2.Location = new System.Drawing.Point(4, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 49);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 400);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblErrmsg
            // 
            this.lblErrmsg.AutoSize = true;
            this.lblErrmsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrmsg.Location = new System.Drawing.Point(489, 7);
            this.lblErrmsg.Name = "lblErrmsg";
            this.lblErrmsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrmsg.TabIndex = 9;
            // 
            // WinSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDelayMilliSeconds);
            this.Controls.Add(this.btRemoveHtmTag);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.lblSourceFile);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.panel2);
            this.Name = "WinSub";
            this.Text = "Sub Cleaner ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Button btRemoveHtmTag;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.TextBox txtDelayMilliSeconds;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblErrmsg;
    }
}

