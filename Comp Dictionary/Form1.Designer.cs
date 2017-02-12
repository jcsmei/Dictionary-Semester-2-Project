namespace Comp_Dictionary
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutComputerDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboHeadWord = new System.Windows.Forms.ComboBox();
            this.fOLDOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCDataSet = new Comp_Dictionary.FOLDOCDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDefinition = new System.Windows.Forms.RichTextBox();
            this.fOLDOCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCTableAdapter = new Comp_Dictionary.FOLDOCDataSetTableAdapters.FOLDOCTableAdapter();
            this.tableAdapterManager = new Comp_Dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.advancedSearchToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // advancedSearchToolStripMenuItem
            // 
            this.advancedSearchToolStripMenuItem.Name = "advancedSearchToolStripMenuItem";
            this.advancedSearchToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.advancedSearchToolStripMenuItem.Text = "&Advance Search";
            this.advancedSearchToolStripMenuItem.Click += new System.EventHandler(this.advancedSearchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutComputerDictionaryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutComputerDictionaryToolStripMenuItem
            // 
            this.aboutComputerDictionaryToolStripMenuItem.Name = "aboutComputerDictionaryToolStripMenuItem";
            this.aboutComputerDictionaryToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutComputerDictionaryToolStripMenuItem.Text = "&About Computer Dictionary";
            this.aboutComputerDictionaryToolStripMenuItem.Click += new System.EventHandler(this.aboutComputerDictionaryToolStripMenuItem_Click);
            // 
            // cboHeadWord
            // 
            this.cboHeadWord.AllowDrop = true;
            this.cboHeadWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboHeadWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboHeadWord.DataSource = this.fOLDOCBindingSource;
            this.cboHeadWord.DisplayMember = "Headword";
            this.cboHeadWord.FormattingEnabled = true;
            this.cboHeadWord.Location = new System.Drawing.Point(12, 69);
            this.cboHeadWord.Name = "cboHeadWord";
            this.cboHeadWord.Size = new System.Drawing.Size(559, 21);
            this.cboHeadWord.TabIndex = 12;
            this.cboHeadWord.ValueMember = "key";
            // 
            // fOLDOCBindingSource
            // 
            this.fOLDOCBindingSource.DataMember = "FOLDOC";
            this.fOLDOCBindingSource.DataSource = this.fOLDOCDataSet;
            // 
            // fOLDOCDataSet
            // 
            this.fOLDOCDataSet.DataSetName = "FOLDOCDataSet";
            this.fOLDOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Head&word Incremental Search";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 27);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(455, 442);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(116, 27);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "De&finition";
            // 
            // rtbDefinition
            // 
            this.rtbDefinition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Definition", true));
            this.rtbDefinition.Location = new System.Drawing.Point(12, 123);
            this.rtbDefinition.Name = "rtbDefinition";
            this.rtbDefinition.Size = new System.Drawing.Size(559, 313);
            this.rtbDefinition.TabIndex = 7;
            this.rtbDefinition.Text = "";
            // 
            // fOLDOCDataSetBindingSource
            // 
            this.fOLDOCDataSetBindingSource.DataSource = this.fOLDOCDataSet;
            this.fOLDOCDataSetBindingSource.Position = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 476);
            this.Controls.Add(this.cboHeadWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDefinition);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutComputerDictionaryToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboHeadWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDefinition;
        private System.Windows.Forms.BindingSource fOLDOCDataSetBindingSource;
        private FOLDOCDataSet fOLDOCDataSet;
        private System.Windows.Forms.BindingSource fOLDOCBindingSource;
        private FOLDOCDataSetTableAdapters.FOLDOCTableAdapter fOLDOCTableAdapter;
        private FOLDOCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

