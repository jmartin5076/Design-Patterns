namespace AbstractFactory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_tbBody = new System.Windows.Forms.TextBox();
            this.m_tbEngine = new System.Windows.Forms.TextBox();
            this.m_tbTires = new System.Windows.Forms.TextBox();
            this.m_tbLogo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_tbLogo);
            this.groupBox1.Controls.Add(this.m_tbTires);
            this.groupBox1.Controls.Add(this.m_tbEngine);
            this.groupBox1.Controls.Add(this.m_tbBody);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Components";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Engine:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tires:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand:";
            // 
            // m_tbBody
            // 
            this.m_tbBody.Location = new System.Drawing.Point(153, 55);
            this.m_tbBody.Name = "m_tbBody";
            this.m_tbBody.ReadOnly = true;
            this.m_tbBody.Size = new System.Drawing.Size(387, 26);
            this.m_tbBody.TabIndex = 5;
            // 
            // m_tbEngine
            // 
            this.m_tbEngine.Location = new System.Drawing.Point(153, 107);
            this.m_tbEngine.Name = "m_tbEngine";
            this.m_tbEngine.ReadOnly = true;
            this.m_tbEngine.Size = new System.Drawing.Size(387, 26);
            this.m_tbEngine.TabIndex = 6;
            // 
            // m_tbTires
            // 
            this.m_tbTires.Location = new System.Drawing.Point(153, 165);
            this.m_tbTires.Name = "m_tbTires";
            this.m_tbTires.ReadOnly = true;
            this.m_tbTires.Size = new System.Drawing.Size(387, 26);
            this.m_tbTires.TabIndex = 7;
            // 
            // m_tbLogo
            // 
            this.m_tbLogo.Location = new System.Drawing.Point(153, 222);
            this.m_tbLogo.Name = "m_tbLogo";
            this.m_tbLogo.ReadOnly = true;
            this.m_tbLogo.Size = new System.Drawing.Size(387, 26);
            this.m_tbLogo.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Car";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_tbLogo;
        private System.Windows.Forms.TextBox m_tbTires;
        private System.Windows.Forms.TextBox m_tbEngine;
        private System.Windows.Forms.TextBox m_tbBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}