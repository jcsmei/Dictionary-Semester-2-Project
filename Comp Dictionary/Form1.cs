using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReadyToChange()
        {
            cboHeadWord.DataBindings.Clear();
            cboHeadWord.DataBindings.Add("Text", fOLDOCBindingSource, "Headword");
            cboHeadWord.AutoCompleteMode = AutoCompleteMode.None;
            cboHeadWord.AllowDrop = false;
            btnDone.Visible = true;
            btnCancel.Visible = true;
            rtbDefinition.ReadOnly = false;
        }
        private void ResumeSearch()
        {
            cboHeadWord.DataBindings.Clear();
            cboHeadWord.DataSource = fOLDOCBindingSource;
            cboHeadWord.DisplayMember = "Headword";
            cboHeadWord.ValueMember = "key";
            cboHeadWord.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHeadWord.AllowDrop = true;
            btnCancel.Visible = false;
            btnDone.Visible = false;
            rtbDefinition.ReadOnly = true;
            cboHeadWord.Focus();
        }
        public static string currentHeadWord = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOLDOCDataSet.FOLDOC' table. You can move, or remove it, as needed.
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadyToChange();
            fOLDOCBindingSource.AddNew();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentPosition = fOLDOCBindingSource.Position;
            ReadyToChange();
            fOLDOCBindingSource.Position = currentPosition;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fOLDOCBindingSource.CancelEdit();
            ResumeSearch();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            fOLDOCBindingSource.EndEdit();
            fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
            fOLDOCTableAdapter.Fill(fOLDOCDataSet.FOLDOC);
            ResumeSearch();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fOLDOCBindingSource.RemoveCurrent();
                fOLDOCBindingSource.Position = 1;
                fOLDOCBindingSource.EndEdit();
                fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
                fOLDOCTableAdapter.Fill(fOLDOCDataSet.FOLDOC);
                cboHeadWord.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error removing a word");
            }
        }
        

        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvanceSearch frmAdvance = new AdvanceSearch();
            DialogResult dr = frmAdvance.ShowDialog(); 
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                frmAdvance.Dispose();
                cboHeadWord.Text = currentHeadWord;
                ResumeSearch();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutComputerDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Copyright @ Mei, Changshi 
ASA College CIT150 Term Project");
        }
    }
}
