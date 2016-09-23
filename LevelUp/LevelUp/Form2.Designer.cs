namespace LevelUp
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_btnCompleteQuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 70);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Congratulations! Press the button below to recieve your reward.";
            // 
            // m_btnCompleteQuest
            // 
            this.m_btnCompleteQuest.Location = new System.Drawing.Point(145, 209);
            this.m_btnCompleteQuest.Name = "m_btnCompleteQuest";
            this.m_btnCompleteQuest.Size = new System.Drawing.Size(149, 53);
            this.m_btnCompleteQuest.TabIndex = 1;
            this.m_btnCompleteQuest.Text = "Complete Quest";
            this.m_btnCompleteQuest.UseVisualStyleBackColor = true;
            this.m_btnCompleteQuest.Click += new System.EventHandler(this.m_btnCompleteQuest_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 274);
            this.Controls.Add(this.m_btnCompleteQuest);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button m_btnCompleteQuest;
    }
}