using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubLib.Bll;
using SubLib.Facade;

namespace WinSub
{
    public partial class WinSub : Form
    {

        private SubEngine engine = new SubEngine();

        private List<SubInfo> fileContent;
        public WinSub()
        {
            InitializeComponent();

        }


        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                tbSource.Text = openFileDialog1.FileName;
                tbTarget.Text = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.Length - 4) + "_1.srt";
            }
            try
            {
                fileContent = engine.LoadSrtFile(tbSource.Text);
                BindGrid();
            }
            catch (Exception ex)
            {

                lblErrmsg.Text = $"Loading error for {tbSource.Text}"
                                + ex.Message;
            }


        }

        private void btRemoveHtmTag_Click(object sender, EventArgs e)
        {
            try
            {
                engine.StripHtml(fileContent);
                lblErrmsg.Text = $"HTML tags were removed for { tbSource.Text} .";
            }
            catch (Exception ex)
            {
                lblErrmsg.Text = $"Convert error for {tbSource.Text}"
                                 + ex.Message;
            }
            BindGrid();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files.Length == 0) return;

            tbSource.Text = files[0];
            tbTarget.Text = files[0].Substring(0, files[0].Length - 4) + "_1.srt";

        }


        private void btnDelay_Click(object sender, EventArgs e)
        {
            try
            {
                engine.DelayMiliSeconds(fileContent, int.Parse(txtDelayMilliSeconds.Text));
                lblErrmsg.Text = $"Src was delayed for { txtDelayMilliSeconds.Text} milliseconds.";
            }
            catch (Exception ex)
            {
                lblErrmsg.Text = $"Convert error:"
                                 + ex.Message;
            }
            BindGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            engine.SaveFile(fileContent, tbTarget.Text);
            lblErrmsg.Text = "Saved";
        }

        private void BindGrid()
        {

            dataGridView1.DataSource = fileContent;
            dataGridView1.Columns[3].Width = 450;
            dataGridView1.Refresh();
        }
    }
}
