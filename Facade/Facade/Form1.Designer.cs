namespace Facade
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
            this.m_lblPlayer = new System.Windows.Forms.Label();
            this.m_lblWarrior = new System.Windows.Forms.Label();
            this.m_lblWhiteMage = new System.Windows.Forms.Label();
            this.m_lblBlackMage = new System.Windows.Forms.Label();
            this.m_lblRogue = new System.Windows.Forms.Label();
            this.m_btnOffense = new System.Windows.Forms.Button();
            this.m_btnDefense = new System.Windows.Forms.Button();
            this.m_btnUtility = new System.Windows.Forms.Button();
            this.m_btnSurvive = new System.Windows.Forms.Button();
            this.m_tbPlayer = new System.Windows.Forms.TextBox();
            this.m_tbWarrior = new System.Windows.Forms.TextBox();
            this.m_tbWhiteMage = new System.Windows.Forms.TextBox();
            this.m_tbBlackMage = new System.Windows.Forms.TextBox();
            this.m_tbRogue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lblPlayer
            // 
            this.m_lblPlayer.AutoSize = true;
            this.m_lblPlayer.Location = new System.Drawing.Point(77, 96);
            this.m_lblPlayer.Name = "m_lblPlayer";
            this.m_lblPlayer.Size = new System.Drawing.Size(52, 20);
            this.m_lblPlayer.TabIndex = 0;
            this.m_lblPlayer.Text = "Player";
            // 
            // m_lblWarrior
            // 
            this.m_lblWarrior.AutoSize = true;
            this.m_lblWarrior.Location = new System.Drawing.Point(77, 145);
            this.m_lblWarrior.Name = "m_lblWarrior";
            this.m_lblWarrior.Size = new System.Drawing.Size(60, 20);
            this.m_lblWarrior.TabIndex = 1;
            this.m_lblWarrior.Text = "Warrior";
            // 
            // m_lblWhiteMage
            // 
            this.m_lblWhiteMage.AutoSize = true;
            this.m_lblWhiteMage.Location = new System.Drawing.Point(77, 198);
            this.m_lblWhiteMage.Name = "m_lblWhiteMage";
            this.m_lblWhiteMage.Size = new System.Drawing.Size(94, 20);
            this.m_lblWhiteMage.TabIndex = 2;
            this.m_lblWhiteMage.Text = "White Mage";
            // 
            // m_lblBlackMage
            // 
            this.m_lblBlackMage.AutoSize = true;
            this.m_lblBlackMage.Location = new System.Drawing.Point(77, 252);
            this.m_lblBlackMage.Name = "m_lblBlackMage";
            this.m_lblBlackMage.Size = new System.Drawing.Size(92, 20);
            this.m_lblBlackMage.TabIndex = 3;
            this.m_lblBlackMage.Text = "Black Mage";
            // 
            // m_lblRogue
            // 
            this.m_lblRogue.AutoSize = true;
            this.m_lblRogue.Location = new System.Drawing.Point(77, 299);
            this.m_lblRogue.Name = "m_lblRogue";
            this.m_lblRogue.Size = new System.Drawing.Size(57, 20);
            this.m_lblRogue.TabIndex = 4;
            this.m_lblRogue.Text = "Rogue";
            // 
            // m_btnOffense
            // 
            this.m_btnOffense.Location = new System.Drawing.Point(197, 394);
            this.m_btnOffense.Name = "m_btnOffense";
            this.m_btnOffense.Size = new System.Drawing.Size(118, 51);
            this.m_btnOffense.TabIndex = 5;
            this.m_btnOffense.Text = "Offensive";
            this.m_btnOffense.UseVisualStyleBackColor = true;
            this.m_btnOffense.Click += new System.EventHandler(this.m_btnOffense_Click);
            // 
            // m_btnDefense
            // 
            this.m_btnDefense.Location = new System.Drawing.Point(353, 394);
            this.m_btnDefense.Name = "m_btnDefense";
            this.m_btnDefense.Size = new System.Drawing.Size(118, 51);
            this.m_btnDefense.TabIndex = 6;
            this.m_btnDefense.Text = "Defensive";
            this.m_btnDefense.UseVisualStyleBackColor = true;
            this.m_btnDefense.Click += new System.EventHandler(this.m_btnDefense_Click);
            // 
            // m_btnUtility
            // 
            this.m_btnUtility.Location = new System.Drawing.Point(197, 466);
            this.m_btnUtility.Name = "m_btnUtility";
            this.m_btnUtility.Size = new System.Drawing.Size(118, 51);
            this.m_btnUtility.TabIndex = 7;
            this.m_btnUtility.Text = "Utility";
            this.m_btnUtility.UseVisualStyleBackColor = true;
            this.m_btnUtility.Click += new System.EventHandler(this.m_btnUtility_Click);
            // 
            // m_btnSurvive
            // 
            this.m_btnSurvive.Location = new System.Drawing.Point(353, 466);
            this.m_btnSurvive.Name = "m_btnSurvive";
            this.m_btnSurvive.Size = new System.Drawing.Size(118, 51);
            this.m_btnSurvive.TabIndex = 8;
            this.m_btnSurvive.Text = "Survive";
            this.m_btnSurvive.UseVisualStyleBackColor = true;
            this.m_btnSurvive.Click += new System.EventHandler(this.m_btnSurvive_Click);
            // 
            // m_tbPlayer
            // 
            this.m_tbPlayer.Location = new System.Drawing.Point(197, 93);
            this.m_tbPlayer.Name = "m_tbPlayer";
            this.m_tbPlayer.ReadOnly = true;
            this.m_tbPlayer.Size = new System.Drawing.Size(370, 26);
            this.m_tbPlayer.TabIndex = 9;
            this.m_tbPlayer.Text = "Player controlled, tactics have no effect on this unit";
            // 
            // m_tbWarrior
            // 
            this.m_tbWarrior.Location = new System.Drawing.Point(197, 139);
            this.m_tbWarrior.Name = "m_tbWarrior";
            this.m_tbWarrior.ReadOnly = true;
            this.m_tbWarrior.Size = new System.Drawing.Size(370, 26);
            this.m_tbWarrior.TabIndex = 10;
            // 
            // m_tbWhiteMage
            // 
            this.m_tbWhiteMage.Location = new System.Drawing.Point(197, 198);
            this.m_tbWhiteMage.Name = "m_tbWhiteMage";
            this.m_tbWhiteMage.ReadOnly = true;
            this.m_tbWhiteMage.Size = new System.Drawing.Size(370, 26);
            this.m_tbWhiteMage.TabIndex = 11;
            // 
            // m_tbBlackMage
            // 
            this.m_tbBlackMage.Location = new System.Drawing.Point(197, 252);
            this.m_tbBlackMage.Name = "m_tbBlackMage";
            this.m_tbBlackMage.ReadOnly = true;
            this.m_tbBlackMage.Size = new System.Drawing.Size(370, 26);
            this.m_tbBlackMage.TabIndex = 12;
            // 
            // m_tbRogue
            // 
            this.m_tbRogue.Location = new System.Drawing.Point(197, 296);
            this.m_tbRogue.Name = "m_tbRogue";
            this.m_tbRogue.ReadOnly = true;
            this.m_tbRogue.Size = new System.Drawing.Size(370, 26);
            this.m_tbRogue.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select the tactics that you would like to apply, and changes will be made to repr" +
    "esent your decision.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbRogue);
            this.Controls.Add(this.m_tbBlackMage);
            this.Controls.Add(this.m_tbWhiteMage);
            this.Controls.Add(this.m_tbWarrior);
            this.Controls.Add(this.m_tbPlayer);
            this.Controls.Add(this.m_btnSurvive);
            this.Controls.Add(this.m_btnUtility);
            this.Controls.Add(this.m_btnDefense);
            this.Controls.Add(this.m_btnOffense);
            this.Controls.Add(this.m_lblRogue);
            this.Controls.Add(this.m_lblBlackMage);
            this.Controls.Add(this.m_lblWhiteMage);
            this.Controls.Add(this.m_lblWarrior);
            this.Controls.Add(this.m_lblPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lblPlayer;
        private System.Windows.Forms.Label m_lblWarrior;
        private System.Windows.Forms.Label m_lblWhiteMage;
        private System.Windows.Forms.Label m_lblBlackMage;
        private System.Windows.Forms.Label m_lblRogue;
        private System.Windows.Forms.Button m_btnOffense;
        private System.Windows.Forms.Button m_btnDefense;
        private System.Windows.Forms.Button m_btnUtility;
        private System.Windows.Forms.Button m_btnSurvive;
        private System.Windows.Forms.TextBox m_tbPlayer;
        private System.Windows.Forms.TextBox m_tbWarrior;
        private System.Windows.Forms.TextBox m_tbWhiteMage;
        private System.Windows.Forms.TextBox m_tbBlackMage;
        private System.Windows.Forms.TextBox m_tbRogue;
        private System.Windows.Forms.Label label1;
    }
}

