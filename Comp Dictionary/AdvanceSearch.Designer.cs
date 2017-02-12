namespace Comp_Dictionary
{
    partial class AdvanceSearch
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
            this.components = new System.ComponentModel.Container();
            this.btnPartial = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstHeadWord = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rtbDefinition = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fOLDOCDataSet = new Comp_Dictionary.FOLDOCDataSet();
            this.fOLDOCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCTableAdapter = new Comp_Dictionary.FOLDOCDataSetTableAdapters.FOLDOCTableAdapter();
            this.tableAdapterManager = new Comp_Dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPartial
            // 
            this.btnPartial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartial.Location = new System.Drawing.Point(12, 12);
            this.btnPartial.Name = "btnPartial";
            this.btnPartial.Size = new System.Drawing.Size(100, 55);
            this.btnPartial.TabIndex = 0;
            this.btnPartial.Text = "&Partial Word\r\nSearch";
            this.btnPartial.UseVisualStyleBackColor = true;
            this.btnPartial.Click += new System.EventHandler(this.btnPartial_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(118, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(100, 55);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "&Begins With\r\nSearch";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(224, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 55);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "&Ends With\r\nSearch";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(330, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 55);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "&All Fields\r\nSearch";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(467, 12);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 40);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // lstHeadWord
            // 
            this.lstHeadWord.DataSource = this.fOLDOCBindingSource;
            this.lstHeadWord.DisplayMember = "Headword";
            this.lstHeadWord.FormattingEnabled = true;
            this.lstHeadWord.Location = new System.Drawing.Point(12, 156);
            this.lstHeadWord.Name = "lstHeadWord";
            this.lstHeadWord.Size = new System.Drawing.Size(555, 95);
            this.lstHeadWord.TabIndex = 5;
            this.lstHeadWord.ValueMember = "key";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 104);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(555, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // rtbDefinition
            // 
            this.rtbDefinition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Definition", true));
            this.rtbDefinition.Location = new System.Drawing.Point(12, 298);
            this.rtbDefinition.Name = "rtbDefinition";
            this.rtbDefinition.Size = new System.Drawing.Size(555, 168);
            this.rtbDefinition.TabIndex = 7;
            this.rtbDefinition.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Definition";
            // 
            // fOLDOCDataSet
            // 
            this.fOLDOCDataSet.DataSetName = "FOLDOCDataSet";
            this.fOLDOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOLDOCDataSetBindingSource
            // 
            this.fOLDOCDataSetBindingSource.DataSource = this.fOLDOCDataSet;
            this.fOLDOCDataSetBindingSource.Position = 0;
            // 
            // fOLDOCBindingSource
            // 
            this.fOLDOCBindingSource.DataMember = "FOLDOC";
            this.fOLDOCBindingSource.DataSource = this.fOLDOCDataSet;
            // 
            // fOLDOCTableAdapter
            // 
            this.fOLDOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLDOCTableAdapter = this.fOLDOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = Comp_Dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AdvanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDefinition);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstHeadWord);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnPartial);
            this.Name = "AdvanceSearch";
            this.Text = "AdvanceSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvanceSearch_FormClosing);
            this.Load += new System.EventHandler(this.AdvanceSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartial;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstHeadWord;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RichTextBox rtbDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fOLDOCDataSetBindingSource;
        private FOLDOCDataSet fOLDOCDataSet;
        private System.Windows.Forms.BindingSource fOLDOCBindingSource;
        private FOLDOCDataSetTableAdapters.FOLDOCTableAdapter fOLDOCTableAdapter;
        private FOLDOCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}