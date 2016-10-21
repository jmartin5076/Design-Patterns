namespace Composite_Pattern
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
            this.m_cbList = new System.Windows.Forms.ComboBox();
            this.m_rbAbility = new System.Windows.Forms.RadioButton();
            this.m_rbCombo = new System.Windows.Forms.RadioButton();
            this.m_tbLog = new System.Windows.Forms.TextBox();
            this.m_btnAbility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_cbList
            // 
            this.m_cbList.FormattingEnabled = true;
            this.m_cbList.Location = new System.Drawing.Point(34, 177);
            this.m_cbList.Name = "m_cbList";
            this.m_cbList.Size = new System.Drawing.Size(121, 28);
            this.m_cbList.TabIndex = 0;
            // 
            // m_rbAbility
            // 
            this.m_rbAbility.AutoSize = true;
            this.m_rbAbility.Location = new System.Drawing.Point(34, 54);
            this.m_rbAbility.Name = "m_rbAbility";
            this.m_rbAbility.Size = new System.Drawing.Size(75, 24);
            this.m_rbAbility.TabIndex = 1;
            this.m_rbAbility.TabStop = true;
            this.m_rbAbility.Text = "Ability";
            this.m_rbAbility.UseVisualStyleBackColor = true;
            this.m_rbAbility.CheckedChanged += new System.EventHandler(this.m_rbAbility_CheckedChanged);
            // 
            // m_rbCombo
            // 
            this.m_rbCombo.AutoSize = true;
            this.m_rbCombo.Location = new System.Drawing.Point(34, 96);
            this.m_rbCombo.Name = "m_rbCombo";
            this.m_rbCombo.Size = new System.Drawing.Size(85, 24);
            this.m_rbCombo.TabIndex = 2;
            this.m_rbCombo.TabStop = true;
            this.m_rbCombo.Text = "Combo";
            this.m_rbCombo.UseVisualStyleBackColor = true;
            this.m_rbCombo.CheckedChanged += new System.EventHandler(this.m_rbCombo_CheckedChanged);
            // 
            // m_tbLog
            // 
            this.m_tbLog.Location = new System.Drawing.Point(181, 48);
            this.m_tbLog.Multiline = true;
            this.m_tbLog.Name = "m_tbLog";
            this.m_tbLog.Size = new System.Drawing.Size(317, 271);
            this.m_tbLog.TabIndex = 3;
            // 
            // m_btnAbility
            // 
            this.m_btnAbility.Location = new System.Drawing.Point(19, 256);
            this.m_btnAbility.Name = "m_btnAbility";
            this.m_btnAbility.Size = new System.Drawing.Size(141, 63);
            this.m_btnAbility.TabIndex = 4;
            this.m_btnAbility.Text = "Use Ability";
            this.m_btnAbility.UseVisualStyleBackColor = true;
            this.m_btnAbility.Click += new System.EventHandler(this.m_btnAbility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 358);
            this.Controls.Add(this.m_btnAbility);
            this.Controls.Add(this.m_tbLog);
            this.Controls.Add(this.m_rbCombo);
            this.Controls.Add(this.m_rbAbility);
            this.Controls.Add(this.m_cbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbList;
        private System.Windows.Forms.RadioButton m_rbAbility;
        private System.Windows.Forms.RadioButton m_rbCombo;
        private System.Windows.Forms.TextBox m_tbLog;
        private System.Windows.Forms.Button m_btnAbility;
    }
}

