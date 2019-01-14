namespace JLR_Config_Editor
{
    partial class DataTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTree));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.tableLayoutActions = new System.Windows.Forms.TableLayoutPanel();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.labelParamTitle = new System.Windows.Forms.Label();
            this.textBoxBytes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.optionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutActions.SuspendLayout();
            this.panelParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBindingSource1)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // keisToolStripMenuItem
            // 
            this.keisToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.keisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keisToolStripMenuItem.Name = "keisToolStripMenuItem";
            this.keisToolStripMenuItem.Size = new System.Drawing.Size(168, 21);
            this.keisToolStripMenuItem.Text = "Keisti parametrus į TRUE";
            this.keisToolStripMenuItem.Click += new System.EventHandler(this.keisToolStripMenuItem_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Beige;
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 525F));
            this.tableLayoutPanelMain.Controls.Add(this.panelMain, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelGroups, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutActions, 3, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1065, 567);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.MaximumSize = new System.Drawing.Size(245, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(0, 0);
            this.panelMain.TabIndex = 0;
            // 
            // panelGroups
            // 
            this.panelGroups.AutoScroll = true;
            this.panelGroups.BackColor = System.Drawing.Color.Beige;
            this.panelGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(253, 3);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(284, 561);
            this.panelGroups.TabIndex = 1;
            // 
            // tableLayoutActions
            // 
            this.tableLayoutActions.ColumnCount = 1;
            this.tableLayoutActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutActions.Controls.Add(this.panelParameters, 0, 0);
            this.tableLayoutActions.Controls.Add(this.panelSearch, 0, 1);
            this.tableLayoutActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutActions.Location = new System.Drawing.Point(543, 3);
            this.tableLayoutActions.Name = "tableLayoutActions";
            this.tableLayoutActions.RowCount = 2;
            this.tableLayoutActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.28342F));
            this.tableLayoutActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.71658F));
            this.tableLayoutActions.Size = new System.Drawing.Size(519, 561);
            this.tableLayoutActions.TabIndex = 2;
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.SystemColors.Control;
            this.panelParameters.Controls.Add(this.buttonEdit);
            this.panelParameters.Controls.Add(this.dataGridViewValues);
            this.panelParameters.Controls.Add(this.label13);
            this.panelParameters.Controls.Add(this.labelParamTitle);
            this.panelParameters.Controls.Add(this.textBoxBytes);
            this.panelParameters.Controls.Add(this.label15);
            this.panelParameters.Controls.Add(this.button2);
            this.panelParameters.Location = new System.Drawing.Point(3, 3);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(513, 449);
            this.panelParameters.TabIndex = 16;
            this.panelParameters.Visible = false;
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.AutoGenerateColumns = false;
            this.dataGridViewValues.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewValues.DataSource = this.optionBindingSource1;
            this.dataGridViewValues.Location = new System.Drawing.Point(155, 176);
            this.dataGridViewValues.MultiSelect = false;
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.ReadOnly = true;
            this.dataGridViewValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValues.ShowEditingIcon = false;
            this.dataGridViewValues.Size = new System.Drawing.Size(286, 169);
            this.dataGridViewValues.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 59;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // optionBindingSource1
            // 
            this.optionBindingSource1.DataSource = typeof(JLR_Config_Editor.Classes.Option);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Reikšmės:";
            // 
            // labelParamTitle
            // 
            this.labelParamTitle.AutoSize = true;
            this.labelParamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParamTitle.Location = new System.Drawing.Point(33, 13);
            this.labelParamTitle.Name = "labelParamTitle";
            this.labelParamTitle.Size = new System.Drawing.Size(57, 20);
            this.labelParamTitle.TabIndex = 9;
            this.labelParamTitle.Text = "label3";
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.BackColor = System.Drawing.Color.Beige;
            this.textBoxBytes.Location = new System.Drawing.Point(155, 63);
            this.textBoxBytes.MaxLength = 20;
            this.textBoxBytes.Multiline = true;
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(286, 76);
            this.textBoxBytes.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Baitai:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Išsaugoti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 458);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(513, 100);
            this.panelSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(330, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 33);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Ieškoti";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Beige;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 11;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(48, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(77, 20);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Paieška:";
            // 
            // optionBindingSource
            // 
            this.optionBindingSource.DataSource = typeof(JLR_Config_Editor.Classes.Option);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(120, 389);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 33);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Parametrai";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // DataTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 592);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataTree";
            this.Text = "DataTree";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataTree_FormClosed);
            this.Load += new System.EventHandler(this.DataTree_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutActions.ResumeLayout(false);
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBindingSource1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutActions;
        private System.Windows.Forms.BindingSource optionBindingSource;
        private System.Windows.Forms.BindingSource optionBindingSource1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolStripMenuItem keisToolStripMenuItem;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelParamTitle;
        private System.Windows.Forms.TextBox textBoxBytes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEdit;
    }
}