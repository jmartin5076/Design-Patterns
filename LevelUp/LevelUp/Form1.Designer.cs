namespace LevelUp
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
            this.m_btnQuest = new System.Windows.Forms.Button();
            this.m_tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_btnQuest
            // 
            this.m_btnQuest.Location = new System.Drawing.Point(66, 68);
            this.m_btnQuest.Name = "m_btnQuest";
            this.m_btnQuest.Size = new System.Drawing.Size(146, 61);
            this.m_btnQuest.TabIndex = 0;
            this.m_btnQuest.Text = "Get Quest";
            this.m_btnQuest.UseVisualStyleBackColor = true;
            this.m_btnQuest.Click += new System.EventHandler(this.m_btnQuest_Click);
            // 
            // m_tbStatus
            // 
            this.m_tbStatus.Location = new System.Drawing.Point(66, 172);
            this.m_tbStatus.Multiline = true;
            this.m_tbStatus.Name = "m_tbStatus";
            this.m_tbStatus.Size = new System.Drawing.Size(529, 307);
            this.m_tbStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level:";
            // 
            // m_tbLevel
            // 
            this.m_tbLevel.Location = new System.Drawing.Point(459, 85);
            this.m_tbLevel.Name = "m_tbLevel";
            this.m_tbLevel.ReadOnly = true;
            this.m_tbLevel.Size = new System.Drawing.Size(100, 26);
            this.m_tbLevel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 542);
            this.Controls.Add(this.m_tbLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbStatus);
            this.Controls.Add(this.m_btnQuest);
            this.Name = "Form1";
            this.Text = "Experience Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnQuest;
        private System.Windows.Forms.TextBox m_tbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbLevel;
    }
}

