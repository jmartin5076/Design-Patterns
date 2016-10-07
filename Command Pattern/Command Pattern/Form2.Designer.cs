namespace Command_Pattern
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
            this.m_tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_tbLog
            // 
            this.m_tbLog.Location = new System.Drawing.Point(53, 51);
            this.m_tbLog.Multiline = true;
            this.m_tbLog.Name = "m_tbLog";
            this.m_tbLog.Size = new System.Drawing.Size(321, 282);
            this.m_tbLog.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 384);
            this.Controls.Add(this.m_tbLog);
            this.Name = "Form2";
            this.Text = "Movement Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox m_tbLog;
    }
}