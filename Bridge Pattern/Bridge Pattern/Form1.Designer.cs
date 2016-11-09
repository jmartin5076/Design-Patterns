namespace Bridge_Pattern
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
            this.m_btnAdmin = new System.Windows.Forms.Button();
            this.m_btnRegular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnAdmin
            // 
            this.m_btnAdmin.Location = new System.Drawing.Point(12, 106);
            this.m_btnAdmin.Name = "m_btnAdmin";
            this.m_btnAdmin.Size = new System.Drawing.Size(115, 53);
            this.m_btnAdmin.TabIndex = 0;
            this.m_btnAdmin.Text = "Admin User";
            this.m_btnAdmin.UseVisualStyleBackColor = true;
            this.m_btnAdmin.Click += new System.EventHandler(this.m_btnAdmin_Click);
            // 
            // m_btnRegular
            // 
            this.m_btnRegular.Location = new System.Drawing.Point(133, 106);
            this.m_btnRegular.Name = "m_btnRegular";
            this.m_btnRegular.Size = new System.Drawing.Size(115, 53);
            this.m_btnRegular.TabIndex = 1;
            this.m_btnRegular.Text = "Regular User";
            this.m_btnRegular.UseVisualStyleBackColor = true;
            this.m_btnRegular.Click += new System.EventHandler(this.m_btnRegular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose a user profile.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnRegular);
            this.Controls.Add(this.m_btnAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnAdmin;
        private System.Windows.Forms.Button m_btnRegular;
        private System.Windows.Forms.Label label1;
    }
}

