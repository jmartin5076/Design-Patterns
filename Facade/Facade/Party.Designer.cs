namespace Facade
{
    partial class Party
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_tbWarrior = new System.Windows.Forms.TextBox();
            this.m_tbRogue = new System.Windows.Forms.TextBox();
            this.m_tbWhiteMage = new System.Windows.Forms.TextBox();
            this.m_tbBlackMage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of party actions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warrior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rogue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "White Mage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Black Mage";
            // 
            // m_tbWarrior
            // 
            this.m_tbWarrior.Location = new System.Drawing.Point(196, 112);
            this.m_tbWarrior.Name = "m_tbWarrior";
            this.m_tbWarrior.ReadOnly = true;
            this.m_tbWarrior.Size = new System.Drawing.Size(292, 26);
            this.m_tbWarrior.TabIndex = 5;
            // 
            // m_tbRogue
            // 
            this.m_tbRogue.Location = new System.Drawing.Point(196, 170);
            this.m_tbRogue.Name = "m_tbRogue";
            this.m_tbRogue.ReadOnly = true;
            this.m_tbRogue.Size = new System.Drawing.Size(292, 26);
            this.m_tbRogue.TabIndex = 6;
            // 
            // m_tbWhiteMage
            // 
            this.m_tbWhiteMage.Location = new System.Drawing.Point(196, 232);
            this.m_tbWhiteMage.Name = "m_tbWhiteMage";
            this.m_tbWhiteMage.ReadOnly = true;
            this.m_tbWhiteMage.Size = new System.Drawing.Size(292, 26);
            this.m_tbWhiteMage.TabIndex = 7;
            // 
            // m_tbBlackMage
            // 
            this.m_tbBlackMage.Location = new System.Drawing.Point(196, 296);
            this.m_tbBlackMage.Name = "m_tbBlackMage";
            this.m_tbBlackMage.ReadOnly = true;
            this.m_tbBlackMage.Size = new System.Drawing.Size(292, 26);
            this.m_tbBlackMage.TabIndex = 8;
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 407);
            this.Controls.Add(this.m_tbBlackMage);
            this.Controls.Add(this.m_tbWhiteMage);
            this.Controls.Add(this.m_tbRogue);
            this.Controls.Add(this.m_tbWarrior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Party";
            this.Text = "Party";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_tbWarrior;
        private System.Windows.Forms.TextBox m_tbRogue;
        private System.Windows.Forms.TextBox m_tbWhiteMage;
        private System.Windows.Forms.TextBox m_tbBlackMage;
    }
}