namespace JLR_Config_Editor
{
    partial class Parameters
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
            this.panelParam = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelParam
            // 
            this.panelParam.AutoScroll = true;
            this.panelParam.AutoSize = true;
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParam.Location = new System.Drawing.Point(0, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(578, 394);
            this.panelParam.TabIndex = 0;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.panelParam);
            this.Name = "Parameters";
            this.ShowIcon = false;
            this.Text = "Parameters";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parameters_FormClosed);
            this.Load += new System.EventHandler(this.Parameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParam;
    }
}