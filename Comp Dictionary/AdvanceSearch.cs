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
    public partial class AdvanceSearch : Form
    {
        public AdvanceSearch()
        {
            InitializeComponent();
        }

        private void AdvanceSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOLDOCDataSet.FOLDOC' table. You can move, or remove it, as needed.
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);

        }

        private void btnPartial_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().Contains(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().StartsWith(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().EndsWith(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().Contains
                        (txtSearch.Text.ToUpper()) ||
                        word.Definition.ToUpper().Contains
                        (txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void AdvanceSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fOLDOCBindingSource.Current != null)
            {
                Form1.currentHeadWord = lstHeadWord.SelectedValue.ToString();
            }
            else
            {
                Form1.currentHeadWord = "";
            }
        }
    }
}
