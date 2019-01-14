namespace JLR_Config_Editor
{
    partial class Group_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group_control));
            this.tableLayoutPanelGroup = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tableLayoutPanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGroup
            // 
            this.tableLayoutPanelGroup.ColumnCount = 2;
            this.tableLayoutPanelGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.44444F));
            this.tableLayoutPanelGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.55556F));
            this.tableLayoutPanelGroup.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelGroup.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGroup.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGroup.Name = "tableLayoutPanelGroup";
            this.tableLayoutPanelGroup.RowCount = 1;
            this.tableLayoutPanelGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGroup.Size = new System.Drawing.Size(225, 59);
            this.tableLayoutPanelGroup.TabIndex = 0;
            this.tableLayoutPanelGroup.Click += new System.EventHandler(this.tableLayoutPanelGroup_Click);
            this.tableLayoutPanelGroup.MouseEnter += new System.EventHandler(this.tableLayoutPanelGroup_MouseEnter);
            this.tableLayoutPanelGroup.MouseLeave += new System.EventHandler(this.tableLayoutPanelGroup_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(66, 21);
            this.labelName.MaximumSize = new System.Drawing.Size(150, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.labelName_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.labelName_MouseLeave);
            // 
            // Group_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.tableLayoutPanelGroup);
            this.Name = "Group_control";
            this.Size = new System.Drawing.Size(225, 59);
            this.tableLayoutPanelGroup.ResumeLayout(false);
            this.tableLayoutPanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
    }
}
