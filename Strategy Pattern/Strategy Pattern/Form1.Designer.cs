namespace Strategy_Pattern
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
            this.m_btnAttack = new System.Windows.Forms.Button();
            this.m_btnNormal = new System.Windows.Forms.Button();
            this.m_btnUtility = new System.Windows.Forms.Button();
            this.m_btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnAttack
            // 
            this.m_btnAttack.Location = new System.Drawing.Point(62, 37);
            this.m_btnAttack.Name = "m_btnAttack";
            this.m_btnAttack.Size = new System.Drawing.Size(95, 39);
            this.m_btnAttack.TabIndex = 5;
            this.m_btnAttack.Text = "Attacking";
            this.m_btnAttack.UseVisualStyleBackColor = true;
            this.m_btnAttack.Click += new System.EventHandler(this.m_btnAttack_Click);
            // 
            // m_btnNormal
            // 
            this.m_btnNormal.Location = new System.Drawing.Point(198, 37);
            this.m_btnNormal.Name = "m_btnNormal";
            this.m_btnNormal.Size = new System.Drawing.Size(75, 39);
            this.m_btnNormal.TabIndex = 6;
            this.m_btnNormal.Text = "Normal";
            this.m_btnNormal.UseVisualStyleBackColor = true;
            this.m_btnNormal.Click += new System.EventHandler(this.m_btnNormal_Click);
            // 
            // m_btnUtility
            // 
            this.m_btnUtility.Location = new System.Drawing.Point(135, 98);
            this.m_btnUtility.Name = "m_btnUtility";
            this.m_btnUtility.Size = new System.Drawing.Size(75, 39);
            this.m_btnUtility.TabIndex = 7;
            this.m_btnUtility.Text = "Utility";
            this.m_btnUtility.UseVisualStyleBackColor = true;
            this.m_btnUtility.Click += new System.EventHandler(this.m_btnUtility_Click);
            // 
            // m_btnRandom
            // 
            this.m_btnRandom.Location = new System.Drawing.Point(62, 179);
            this.m_btnRandom.Name = "m_btnRandom";
            this.m_btnRandom.Size = new System.Drawing.Size(211, 38);
            this.m_btnRandom.TabIndex = 8;
            this.m_btnRandom.Text = "Random Encounter";
            this.m_btnRandom.UseVisualStyleBackColor = true;
            this.m_btnRandom.Click += new System.EventHandler(this.m_btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 249);
            this.Controls.Add(this.m_btnRandom);
            this.Controls.Add(this.m_btnUtility);
            this.Controls.Add(this.m_btnNormal);
            this.Controls.Add(this.m_btnAttack);
            this.Name = "Form1";
            this.Text = "Tactics";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button m_btnAttack;
        private System.Windows.Forms.Button m_btnNormal;
        private System.Windows.Forms.Button m_btnUtility;
        private System.Windows.Forms.Button m_btnRandom;
    }
}

