namespace ProxyPattern
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
            this.m_tbDescription = new System.Windows.Forms.TextBox();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_tbDescription
            // 
            this.m_tbDescription.Location = new System.Drawing.Point(12, 12);
            this.m_tbDescription.Multiline = true;
            this.m_tbDescription.Name = "m_tbDescription";
            this.m_tbDescription.ReadOnly = true;
            this.m_tbDescription.Size = new System.Drawing.Size(378, 322);
            this.m_tbDescription.TabIndex = 0;
            // 
            // m_btnClose
            // 
            this.m_btnClose.Location = new System.Drawing.Point(134, 340);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(123, 46);
            this.m_btnClose.TabIndex = 1;
            this.m_btnClose.Text = "Close";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 398);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_tbDescription);
            this.Name = "Form2";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox m_tbDescription;
        private System.Windows.Forms.Button m_btnClose;
    }
}