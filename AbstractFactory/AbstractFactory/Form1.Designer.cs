namespace AbstractFactory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_btnCamaro = new System.Windows.Forms.Button();
            this.m_btnMalibu = new System.Windows.Forms.Button();
            this.m_btnSilverado = new System.Windows.Forms.Button();
            this.m_btnMustang = new System.Windows.Forms.Button();
            this.m_btnFusion = new System.Windows.Forms.Button();
            this.m_btnF150 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chevy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ford";
            // 
            // m_btnCamaro
            // 
            this.m_btnCamaro.Location = new System.Drawing.Point(62, 164);
            this.m_btnCamaro.Name = "m_btnCamaro";
            this.m_btnCamaro.Size = new System.Drawing.Size(133, 57);
            this.m_btnCamaro.TabIndex = 2;
            this.m_btnCamaro.Text = "Camaro";
            this.m_btnCamaro.UseVisualStyleBackColor = true;
            this.m_btnCamaro.Click += new System.EventHandler(this.m_btnCamaro_Click);
            // 
            // m_btnMalibu
            // 
            this.m_btnMalibu.Location = new System.Drawing.Point(226, 164);
            this.m_btnMalibu.Name = "m_btnMalibu";
            this.m_btnMalibu.Size = new System.Drawing.Size(133, 57);
            this.m_btnMalibu.TabIndex = 3;
            this.m_btnMalibu.Text = "Malibu";
            this.m_btnMalibu.UseVisualStyleBackColor = true;
            this.m_btnMalibu.Click += new System.EventHandler(this.m_btnMalibu_Click);
            // 
            // m_btnSilverado
            // 
            this.m_btnSilverado.Location = new System.Drawing.Point(386, 164);
            this.m_btnSilverado.Name = "m_btnSilverado";
            this.m_btnSilverado.Size = new System.Drawing.Size(133, 57);
            this.m_btnSilverado.TabIndex = 4;
            this.m_btnSilverado.Text = "Silverado";
            this.m_btnSilverado.UseVisualStyleBackColor = true;
            this.m_btnSilverado.Click += new System.EventHandler(this.m_btnSilverado_Click);
            // 
            // m_btnMustang
            // 
            this.m_btnMustang.Location = new System.Drawing.Point(62, 340);
            this.m_btnMustang.Name = "m_btnMustang";
            this.m_btnMustang.Size = new System.Drawing.Size(133, 57);
            this.m_btnMustang.TabIndex = 5;
            this.m_btnMustang.Text = "Mustang";
            this.m_btnMustang.UseVisualStyleBackColor = true;
            this.m_btnMustang.Click += new System.EventHandler(this.m_btnMustang_Click);
            // 
            // m_btnFusion
            // 
            this.m_btnFusion.Location = new System.Drawing.Point(226, 340);
            this.m_btnFusion.Name = "m_btnFusion";
            this.m_btnFusion.Size = new System.Drawing.Size(133, 57);
            this.m_btnFusion.TabIndex = 6;
            this.m_btnFusion.Text = "Fusion";
            this.m_btnFusion.UseVisualStyleBackColor = true;
            this.m_btnFusion.Click += new System.EventHandler(this.m_btnFusion_Click);
            // 
            // m_btnF150
            // 
            this.m_btnF150.Location = new System.Drawing.Point(386, 340);
            this.m_btnF150.Name = "m_btnF150";
            this.m_btnF150.Size = new System.Drawing.Size(133, 57);
            this.m_btnF150.TabIndex = 7;
            this.m_btnF150.Text = "F150";
            this.m_btnF150.UseVisualStyleBackColor = true;
            this.m_btnF150.Click += new System.EventHandler(this.m_btnF150_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 481);
            this.Controls.Add(this.m_btnF150);
            this.Controls.Add(this.m_btnFusion);
            this.Controls.Add(this.m_btnMustang);
            this.Controls.Add(this.m_btnSilverado);
            this.Controls.Add(this.m_btnMalibu);
            this.Controls.Add(this.m_btnCamaro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Factory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_btnCamaro;
        private System.Windows.Forms.Button m_btnMalibu;
        private System.Windows.Forms.Button m_btnSilverado;
        private System.Windows.Forms.Button m_btnMustang;
        private System.Windows.Forms.Button m_btnFusion;
        private System.Windows.Forms.Button m_btnF150;
    }
}

