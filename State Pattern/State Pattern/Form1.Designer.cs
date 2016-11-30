namespace State_Pattern
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
            this.m_tbBattleLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_rbParalyzed = new System.Windows.Forms.RadioButton();
            this.m_rbBurned = new System.Windows.Forms.RadioButton();
            this.m_rbPoisoned = new System.Windows.Forms.RadioButton();
            this.m_rbStunned = new System.Windows.Forms.RadioButton();
            this.m_rbNormal = new System.Windows.Forms.RadioButton();
            this.m_lblHealth = new System.Windows.Forms.Label();
            this.m_lblStatus = new System.Windows.Forms.Label();
            this.m_btnAttack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tbBattleLog
            // 
            this.m_tbBattleLog.Location = new System.Drawing.Point(12, 273);
            this.m_tbBattleLog.Multiline = true;
            this.m_tbBattleLog.Name = "m_tbBattleLog";
            this.m_tbBattleLog.ReadOnly = true;
            this.m_tbBattleLog.Size = new System.Drawing.Size(387, 168);
            this.m_tbBattleLog.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_rbParalyzed);
            this.panel1.Controls.Add(this.m_rbBurned);
            this.panel1.Controls.Add(this.m_rbPoisoned);
            this.panel1.Controls.Add(this.m_rbStunned);
            this.panel1.Controls.Add(this.m_rbNormal);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 227);
            this.panel1.TabIndex = 1;
            // 
            // m_rbParalyzed
            // 
            this.m_rbParalyzed.AutoSize = true;
            this.m_rbParalyzed.Location = new System.Drawing.Point(18, 187);
            this.m_rbParalyzed.Name = "m_rbParalyzed";
            this.m_rbParalyzed.Size = new System.Drawing.Size(103, 24);
            this.m_rbParalyzed.TabIndex = 6;
            this.m_rbParalyzed.Text = "Paralyzed";
            this.m_rbParalyzed.UseVisualStyleBackColor = true;
            // 
            // m_rbBurned
            // 
            this.m_rbBurned.AutoSize = true;
            this.m_rbBurned.Location = new System.Drawing.Point(18, 146);
            this.m_rbBurned.Name = "m_rbBurned";
            this.m_rbBurned.Size = new System.Drawing.Size(86, 24);
            this.m_rbBurned.TabIndex = 5;
            this.m_rbBurned.Text = "Burned";
            this.m_rbBurned.UseVisualStyleBackColor = true;
            // 
            // m_rbPoisoned
            // 
            this.m_rbPoisoned.AutoSize = true;
            this.m_rbPoisoned.Location = new System.Drawing.Point(18, 102);
            this.m_rbPoisoned.Name = "m_rbPoisoned";
            this.m_rbPoisoned.Size = new System.Drawing.Size(100, 24);
            this.m_rbPoisoned.TabIndex = 4;
            this.m_rbPoisoned.Text = "Poisoned";
            this.m_rbPoisoned.UseVisualStyleBackColor = true;
            // 
            // m_rbStunned
            // 
            this.m_rbStunned.AutoSize = true;
            this.m_rbStunned.Location = new System.Drawing.Point(18, 61);
            this.m_rbStunned.Name = "m_rbStunned";
            this.m_rbStunned.Size = new System.Drawing.Size(95, 24);
            this.m_rbStunned.TabIndex = 3;
            this.m_rbStunned.Text = "Stunned";
            this.m_rbStunned.UseVisualStyleBackColor = true;
            // 
            // m_rbNormal
            // 
            this.m_rbNormal.AutoSize = true;
            this.m_rbNormal.Checked = true;
            this.m_rbNormal.Location = new System.Drawing.Point(18, 21);
            this.m_rbNormal.Name = "m_rbNormal";
            this.m_rbNormal.Size = new System.Drawing.Size(84, 24);
            this.m_rbNormal.TabIndex = 2;
            this.m_rbNormal.TabStop = true;
            this.m_rbNormal.Text = "Normal";
            this.m_rbNormal.UseVisualStyleBackColor = true;
            // 
            // m_lblHealth
            // 
            this.m_lblHealth.AutoSize = true;
            this.m_lblHealth.Location = new System.Drawing.Point(201, 61);
            this.m_lblHealth.Name = "m_lblHealth";
            this.m_lblHealth.Size = new System.Drawing.Size(0, 20);
            this.m_lblHealth.TabIndex = 2;
            // 
            // m_lblStatus
            // 
            this.m_lblStatus.AutoSize = true;
            this.m_lblStatus.Location = new System.Drawing.Point(201, 101);
            this.m_lblStatus.Name = "m_lblStatus";
            this.m_lblStatus.Size = new System.Drawing.Size(0, 20);
            this.m_lblStatus.TabIndex = 3;
            // 
            // m_btnAttack
            // 
            this.m_btnAttack.Location = new System.Drawing.Point(201, 153);
            this.m_btnAttack.Name = "m_btnAttack";
            this.m_btnAttack.Size = new System.Drawing.Size(198, 114);
            this.m_btnAttack.TabIndex = 4;
            this.m_btnAttack.Text = "Attack";
            this.m_btnAttack.UseVisualStyleBackColor = true;
            this.m_btnAttack.Click += new System.EventHandler(this.m_btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 453);
            this.Controls.Add(this.m_btnAttack);
            this.Controls.Add(this.m_lblStatus);
            this.Controls.Add(this.m_lblHealth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_tbBattleLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbBattleLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton m_rbParalyzed;
        private System.Windows.Forms.RadioButton m_rbBurned;
        private System.Windows.Forms.RadioButton m_rbPoisoned;
        private System.Windows.Forms.RadioButton m_rbStunned;
        private System.Windows.Forms.RadioButton m_rbNormal;
        public System.Windows.Forms.Label m_lblHealth;
        private System.Windows.Forms.Label m_lblStatus;
        private System.Windows.Forms.Button m_btnAttack;
    }
}

