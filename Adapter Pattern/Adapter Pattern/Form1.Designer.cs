namespace Adapter_Pattern
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
            this.m_tbUSD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbEuro = new System.Windows.Forms.TextBox();
            this.m_btnAdapt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_tbUSD
            // 
            this.m_tbUSD.Location = new System.Drawing.Point(176, 59);
            this.m_tbUSD.Name = "m_tbUSD";
            this.m_tbUSD.Size = new System.Drawing.Size(100, 26);
            this.m_tbUSD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Euros";
            // 
            // m_tbEuro
            // 
            this.m_tbEuro.Location = new System.Drawing.Point(176, 130);
            this.m_tbEuro.Name = "m_tbEuro";
            this.m_tbEuro.ReadOnly = true;
            this.m_tbEuro.Size = new System.Drawing.Size(100, 26);
            this.m_tbEuro.TabIndex = 3;
            // 
            // m_btnAdapt
            // 
            this.m_btnAdapt.Location = new System.Drawing.Point(109, 190);
            this.m_btnAdapt.Name = "m_btnAdapt";
            this.m_btnAdapt.Size = new System.Drawing.Size(109, 40);
            this.m_btnAdapt.TabIndex = 4;
            this.m_btnAdapt.Text = "Adapt";
            this.m_btnAdapt.UseVisualStyleBackColor = true;
            this.m_btnAdapt.Click += new System.EventHandler(this.m_btnAdapt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 257);
            this.Controls.Add(this.m_btnAdapt);
            this.Controls.Add(this.m_tbEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbUSD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbUSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbEuro;
        private System.Windows.Forms.Button m_btnAdapt;
    }
}

