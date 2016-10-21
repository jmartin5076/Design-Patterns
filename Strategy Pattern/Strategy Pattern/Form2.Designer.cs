namespace Strategy_Pattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbWarrior = new System.Windows.Forms.TextBox();
            this.m_tbMages = new System.Windows.Forms.TextBox();
            this.m_tbRogue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warrior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rogue";
            // 
            // m_tbWarrior
            // 
            this.m_tbWarrior.Location = new System.Drawing.Point(93, 50);
            this.m_tbWarrior.Name = "m_tbWarrior";
            this.m_tbWarrior.ReadOnly = true;
            this.m_tbWarrior.Size = new System.Drawing.Size(194, 26);
            this.m_tbWarrior.TabIndex = 3;
            // 
            // m_tbMages
            // 
            this.m_tbMages.Location = new System.Drawing.Point(93, 116);
            this.m_tbMages.Name = "m_tbMages";
            this.m_tbMages.ReadOnly = true;
            this.m_tbMages.Size = new System.Drawing.Size(194, 26);
            this.m_tbMages.TabIndex = 4;
            // 
            // m_tbRogue
            // 
            this.m_tbRogue.Location = new System.Drawing.Point(93, 194);
            this.m_tbRogue.Name = "m_tbRogue";
            this.m_tbRogue.ReadOnly = true;
            this.m_tbRogue.Size = new System.Drawing.Size(194, 26);
            this.m_tbRogue.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 264);
            this.Controls.Add(this.m_tbRogue);
            this.Controls.Add(this.m_tbMages);
            this.Controls.Add(this.m_tbWarrior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Actions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox m_tbWarrior;
        public System.Windows.Forms.TextBox m_tbMages;
        public System.Windows.Forms.TextBox m_tbRogue;
    }
}