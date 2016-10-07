namespace Command_Pattern
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
            this.m_btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_tbPiece = new System.Windows.Forms.TextBox();
            this.m_tbStart = new System.Windows.Forms.TextBox();
            this.m_tbEnd = new System.Windows.Forms.TextBox();
            this.m_tbUndo = new System.Windows.Forms.Button();
            this.m_tbRedo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnMove
            // 
            this.m_btnMove.Location = new System.Drawing.Point(429, 267);
            this.m_btnMove.Name = "m_btnMove";
            this.m_btnMove.Size = new System.Drawing.Size(142, 64);
            this.m_btnMove.TabIndex = 0;
            this.m_btnMove.Text = "Move Piece";
            this.m_btnMove.UseVisualStyleBackColor = true;
            this.m_btnMove.Click += new System.EventHandler(this.m_btnMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ending Position";
            // 
            // m_tbPiece
            // 
            this.m_tbPiece.Location = new System.Drawing.Point(143, 85);
            this.m_tbPiece.Name = "m_tbPiece";
            this.m_tbPiece.Size = new System.Drawing.Size(183, 26);
            this.m_tbPiece.TabIndex = 4;
            // 
            // m_tbStart
            // 
            this.m_tbStart.Location = new System.Drawing.Point(143, 188);
            this.m_tbStart.Name = "m_tbStart";
            this.m_tbStart.Size = new System.Drawing.Size(183, 26);
            this.m_tbStart.TabIndex = 5;
            // 
            // m_tbEnd
            // 
            this.m_tbEnd.Location = new System.Drawing.Point(143, 289);
            this.m_tbEnd.Name = "m_tbEnd";
            this.m_tbEnd.Size = new System.Drawing.Size(183, 26);
            this.m_tbEnd.TabIndex = 6;
            // 
            // m_tbUndo
            // 
            this.m_tbUndo.Location = new System.Drawing.Point(429, 81);
            this.m_tbUndo.Name = "m_tbUndo";
            this.m_tbUndo.Size = new System.Drawing.Size(138, 29);
            this.m_tbUndo.TabIndex = 8;
            this.m_tbUndo.Text = "Undo";
            this.m_tbUndo.UseVisualStyleBackColor = true;
            this.m_tbUndo.Click += new System.EventHandler(this.m_tbUndo_Click);
            // 
            // m_tbRedo
            // 
            this.m_tbRedo.Location = new System.Drawing.Point(429, 179);
            this.m_tbRedo.Name = "m_tbRedo";
            this.m_tbRedo.Size = new System.Drawing.Size(138, 29);
            this.m_tbRedo.TabIndex = 9;
            this.m_tbRedo.Text = "Redo";
            this.m_tbRedo.UseVisualStyleBackColor = true;
            this.m_tbRedo.Click += new System.EventHandler(this.m_tbRedo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pick a chess piece, it\'s starting posiiton, and where it will be moved to.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_tbRedo);
            this.Controls.Add(this.m_tbUndo);
            this.Controls.Add(this.m_tbEnd);
            this.Controls.Add(this.m_tbStart);
            this.Controls.Add(this.m_tbPiece);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnMove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_tbUndo;
        private System.Windows.Forms.Button m_tbRedo;
        public System.Windows.Forms.TextBox m_tbPiece;
        public System.Windows.Forms.TextBox m_tbStart;
        public System.Windows.Forms.TextBox m_tbEnd;
        private System.Windows.Forms.Label label4;
    }
}

