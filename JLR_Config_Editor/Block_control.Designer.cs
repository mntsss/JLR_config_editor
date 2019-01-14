namespace JLR_Config_Editor
{
    partial class Block_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Block_control));
            this.tableLayoutPanelBlock = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxBlock = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tableLayoutPanelBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBlock
            // 
            this.tableLayoutPanelBlock.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanelBlock.ColumnCount = 2;
            this.tableLayoutPanelBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            this.tableLayoutPanelBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
            this.tableLayoutPanelBlock.Controls.Add(this.pictureBoxBlock, 0, 0);
            this.tableLayoutPanelBlock.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanelBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBlock.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBlock.Name = "tableLayoutPanelBlock";
            this.tableLayoutPanelBlock.RowCount = 1;
            this.tableLayoutPanelBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBlock.Size = new System.Drawing.Size(225, 59);
            this.tableLayoutPanelBlock.TabIndex = 0;
            this.tableLayoutPanelBlock.Click += new System.EventHandler(this.tableLayoutPanelBlock_Click);
            this.tableLayoutPanelBlock.MouseEnter += new System.EventHandler(this.tableLayoutPanelBlock_MouseEnter);
            this.tableLayoutPanelBlock.MouseLeave += new System.EventHandler(this.tableLayoutPanelBlock_MouseLeave);
            // 
            // pictureBoxBlock
            // 
            this.pictureBoxBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBlock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlock.Image")));
            this.pictureBoxBlock.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBlock.Name = "pictureBoxBlock";
            this.pictureBoxBlock.Size = new System.Drawing.Size(59, 53);
            this.pictureBoxBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlock.TabIndex = 0;
            this.pictureBoxBlock.TabStop = false;
            this.pictureBoxBlock.Click += new System.EventHandler(this.pictureBoxBlock_Click);
            this.pictureBoxBlock.MouseEnter += new System.EventHandler(this.pictureBoxBlock_MouseEnter);
            this.pictureBoxBlock.MouseLeave += new System.EventHandler(this.pictureBoxBlock_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(68, 22);
            this.labelName.MaximumSize = new System.Drawing.Size(155, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.pictureBoxBlock_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.labelName_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.labelName_MouseLeave);
            // 
            // Block_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelBlock);
            this.Name = "Block_control";
            this.Size = new System.Drawing.Size(225, 59);
            this.tableLayoutPanelBlock.ResumeLayout(false);
            this.tableLayoutPanelBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBlock;
        private System.Windows.Forms.PictureBox pictureBoxBlock;
        private System.Windows.Forms.Label labelName;
    }
}
