namespace IteratorPattern
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
            this.m_btnIterate = new System.Windows.Forms.Button();
            this.m_lbMembers = new System.Windows.Forms.ListBox();
            this.m_rbMostImport = new System.Windows.Forms.RadioButton();
            this.m_rbLeastImport = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // m_btnIterate
            // 
            this.m_btnIterate.Location = new System.Drawing.Point(37, 48);
            this.m_btnIterate.Name = "m_btnIterate";
            this.m_btnIterate.Size = new System.Drawing.Size(129, 64);
            this.m_btnIterate.TabIndex = 0;
            this.m_btnIterate.Text = "Iterate";
            this.m_btnIterate.UseVisualStyleBackColor = true;
            this.m_btnIterate.Click += new System.EventHandler(this.m_btnIterate_Click);
            // 
            // m_lbMembers
            // 
            this.m_lbMembers.FormattingEnabled = true;
            this.m_lbMembers.ItemHeight = 20;
            this.m_lbMembers.Location = new System.Drawing.Point(170, 159);
            this.m_lbMembers.Name = "m_lbMembers";
            this.m_lbMembers.Size = new System.Drawing.Size(425, 424);
            this.m_lbMembers.TabIndex = 1;
            // 
            // m_rbMostImport
            // 
            this.m_rbMostImport.AutoSize = true;
            this.m_rbMostImport.Location = new System.Drawing.Point(323, 60);
            this.m_rbMostImport.Name = "m_rbMostImport";
            this.m_rbMostImport.Size = new System.Drawing.Size(226, 24);
            this.m_rbMostImport.TabIndex = 2;
            this.m_rbMostImport.TabStop = true;
            this.m_rbMostImport.Text = "Ordered By Most Important";
            this.m_rbMostImport.UseVisualStyleBackColor = true;
            this.m_rbMostImport.CheckedChanged += new System.EventHandler(this.m_rbMostImport_CheckedChanged);
            // 
            // m_rbLeastImport
            // 
            this.m_rbLeastImport.AutoSize = true;
            this.m_rbLeastImport.Location = new System.Drawing.Point(323, 90);
            this.m_rbLeastImport.Name = "m_rbLeastImport";
            this.m_rbLeastImport.Size = new System.Drawing.Size(231, 24);
            this.m_rbLeastImport.TabIndex = 3;
            this.m_rbLeastImport.TabStop = true;
            this.m_rbLeastImport.Text = "Ordered By Least Important";
            this.m_rbLeastImport.UseVisualStyleBackColor = true;
            this.m_rbLeastImport.CheckedChanged += new System.EventHandler(this.m_rbLeastImport_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 625);
            this.Controls.Add(this.m_rbLeastImport);
            this.Controls.Add(this.m_rbMostImport);
            this.Controls.Add(this.m_lbMembers);
            this.Controls.Add(this.m_btnIterate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnIterate;
        private System.Windows.Forms.ListBox m_lbMembers;
        private System.Windows.Forms.RadioButton m_rbMostImport;
        private System.Windows.Forms.RadioButton m_rbLeastImport;
    }
}

