namespace DecoratorPattern
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_rbVanilla = new System.Windows.Forms.RadioButton();
            this.m_rbChocolate = new System.Windows.Forms.RadioButton();
            this.m_rbStrawberry = new System.Windows.Forms.RadioButton();
            this.m_rbTwist = new System.Windows.Forms.RadioButton();
            this.m_rbNeo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbOrderLog = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbSprinkles = new System.Windows.Forms.CheckBox();
            this.m_cbChocoSyrup = new System.Windows.Forms.CheckBox();
            this.m_cbHotFudge = new System.Windows.Forms.CheckBox();
            this.m_cbPeanuts = new System.Windows.Forms.CheckBox();
            this.m_cbCaramel = new System.Windows.Forms.CheckBox();
            this.m_cbGummyBears = new System.Windows.Forms.CheckBox();
            this.m_cbPeppermints = new System.Windows.Forms.CheckBox();
            this.m_cbButterscotch = new System.Windows.Forms.CheckBox();
            this.m_cbReese = new System.Windows.Forms.CheckBox();
            this.m_cbOreo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_rbNeo);
            this.panel1.Controls.Add(this.m_rbTwist);
            this.panel1.Controls.Add(this.m_rbStrawberry);
            this.panel1.Controls.Add(this.m_rbChocolate);
            this.panel1.Controls.Add(this.m_rbVanilla);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 212);
            this.panel1.TabIndex = 0;
            // 
            // m_rbVanilla
            // 
            this.m_rbVanilla.AutoSize = true;
            this.m_rbVanilla.Checked = true;
            this.m_rbVanilla.Location = new System.Drawing.Point(25, 51);
            this.m_rbVanilla.Name = "m_rbVanilla";
            this.m_rbVanilla.Size = new System.Drawing.Size(81, 24);
            this.m_rbVanilla.TabIndex = 1;
            this.m_rbVanilla.TabStop = true;
            this.m_rbVanilla.Text = "Vanilla";
            this.m_rbVanilla.UseVisualStyleBackColor = true;
            // 
            // m_rbChocolate
            // 
            this.m_rbChocolate.AutoSize = true;
            this.m_rbChocolate.Location = new System.Drawing.Point(25, 81);
            this.m_rbChocolate.Name = "m_rbChocolate";
            this.m_rbChocolate.Size = new System.Drawing.Size(106, 24);
            this.m_rbChocolate.TabIndex = 2;
            this.m_rbChocolate.TabStop = true;
            this.m_rbChocolate.Text = "Chocolate";
            this.m_rbChocolate.UseVisualStyleBackColor = true;
            // 
            // m_rbStrawberry
            // 
            this.m_rbStrawberry.AutoSize = true;
            this.m_rbStrawberry.Location = new System.Drawing.Point(25, 111);
            this.m_rbStrawberry.Name = "m_rbStrawberry";
            this.m_rbStrawberry.Size = new System.Drawing.Size(110, 24);
            this.m_rbStrawberry.TabIndex = 3;
            this.m_rbStrawberry.TabStop = true;
            this.m_rbStrawberry.Text = "Strawberry";
            this.m_rbStrawberry.UseVisualStyleBackColor = true;
            // 
            // m_rbTwist
            // 
            this.m_rbTwist.AutoSize = true;
            this.m_rbTwist.Location = new System.Drawing.Point(25, 141);
            this.m_rbTwist.Name = "m_rbTwist";
            this.m_rbTwist.Size = new System.Drawing.Size(70, 24);
            this.m_rbTwist.TabIndex = 4;
            this.m_rbTwist.TabStop = true;
            this.m_rbTwist.Text = "Twist";
            this.m_rbTwist.UseVisualStyleBackColor = true;
            // 
            // m_rbNeo
            // 
            this.m_rbNeo.AutoSize = true;
            this.m_rbNeo.Location = new System.Drawing.Point(25, 171);
            this.m_rbNeo.Name = "m_rbNeo";
            this.m_rbNeo.Size = new System.Drawing.Size(110, 24);
            this.m_rbNeo.TabIndex = 5;
            this.m_rbNeo.TabStop = true;
            this.m_rbNeo.Text = "Neopolitan";
            this.m_rbNeo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flavor";
            // 
            // m_tbOrderLog
            // 
            this.m_tbOrderLog.Location = new System.Drawing.Point(12, 343);
            this.m_tbOrderLog.Multiline = true;
            this.m_tbOrderLog.Name = "m_tbOrderLog";
            this.m_tbOrderLog.ReadOnly = true;
            this.m_tbOrderLog.Size = new System.Drawing.Size(545, 186);
            this.m_tbOrderLog.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cbOreo);
            this.panel2.Controls.Add(this.m_cbReese);
            this.panel2.Controls.Add(this.m_cbButterscotch);
            this.panel2.Controls.Add(this.m_cbPeppermints);
            this.panel2.Controls.Add(this.m_cbGummyBears);
            this.panel2.Controls.Add(this.m_cbCaramel);
            this.panel2.Controls.Add(this.m_cbPeanuts);
            this.panel2.Controls.Add(this.m_cbHotFudge);
            this.panel2.Controls.Add(this.m_cbChocoSyrup);
            this.panel2.Controls.Add(this.m_cbSprinkles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(241, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 212);
            this.panel2.TabIndex = 2;
            // 
            // m_btnOrder
            // 
            this.m_btnOrder.Location = new System.Drawing.Point(191, 285);
            this.m_btnOrder.Name = "m_btnOrder";
            this.m_btnOrder.Size = new System.Drawing.Size(161, 52);
            this.m_btnOrder.TabIndex = 3;
            this.m_btnOrder.Text = "Order Sundae";
            this.m_btnOrder.UseVisualStyleBackColor = true;
            this.m_btnOrder.Click += new System.EventHandler(this.m_btnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toppings";
            // 
            // m_cbSprinkles
            // 
            this.m_cbSprinkles.AutoSize = true;
            this.m_cbSprinkles.Location = new System.Drawing.Point(16, 52);
            this.m_cbSprinkles.Name = "m_cbSprinkles";
            this.m_cbSprinkles.Size = new System.Drawing.Size(100, 24);
            this.m_cbSprinkles.TabIndex = 1;
            this.m_cbSprinkles.Text = "Sprinkles";
            this.m_cbSprinkles.UseVisualStyleBackColor = true;
            // 
            // m_cbChocoSyrup
            // 
            this.m_cbChocoSyrup.AutoSize = true;
            this.m_cbChocoSyrup.Location = new System.Drawing.Point(16, 81);
            this.m_cbChocoSyrup.Name = "m_cbChocoSyrup";
            this.m_cbChocoSyrup.Size = new System.Drawing.Size(152, 24);
            this.m_cbChocoSyrup.TabIndex = 2;
            this.m_cbChocoSyrup.Text = "Chocolate Syrup";
            this.m_cbChocoSyrup.UseVisualStyleBackColor = true;
            // 
            // m_cbHotFudge
            // 
            this.m_cbHotFudge.AutoSize = true;
            this.m_cbHotFudge.Location = new System.Drawing.Point(16, 112);
            this.m_cbHotFudge.Name = "m_cbHotFudge";
            this.m_cbHotFudge.Size = new System.Drawing.Size(111, 24);
            this.m_cbHotFudge.TabIndex = 3;
            this.m_cbHotFudge.Text = "Hot Fudge";
            this.m_cbHotFudge.UseVisualStyleBackColor = true;
            // 
            // m_cbPeanuts
            // 
            this.m_cbPeanuts.AutoSize = true;
            this.m_cbPeanuts.Location = new System.Drawing.Point(16, 142);
            this.m_cbPeanuts.Name = "m_cbPeanuts";
            this.m_cbPeanuts.Size = new System.Drawing.Size(94, 24);
            this.m_cbPeanuts.TabIndex = 4;
            this.m_cbPeanuts.Text = "Peanuts";
            this.m_cbPeanuts.UseVisualStyleBackColor = true;
            // 
            // m_cbCaramel
            // 
            this.m_cbCaramel.AutoSize = true;
            this.m_cbCaramel.Location = new System.Drawing.Point(16, 172);
            this.m_cbCaramel.Name = "m_cbCaramel";
            this.m_cbCaramel.Size = new System.Drawing.Size(94, 24);
            this.m_cbCaramel.TabIndex = 5;
            this.m_cbCaramel.Text = "Caramel";
            this.m_cbCaramel.UseVisualStyleBackColor = true;
            // 
            // m_cbGummyBears
            // 
            this.m_cbGummyBears.AutoSize = true;
            this.m_cbGummyBears.Location = new System.Drawing.Point(170, 52);
            this.m_cbGummyBears.Name = "m_cbGummyBears";
            this.m_cbGummyBears.Size = new System.Drawing.Size(136, 24);
            this.m_cbGummyBears.TabIndex = 6;
            this.m_cbGummyBears.Text = "Gummy Bears";
            this.m_cbGummyBears.UseVisualStyleBackColor = true;
            // 
            // m_cbPeppermints
            // 
            this.m_cbPeppermints.AutoSize = true;
            this.m_cbPeppermints.Location = new System.Drawing.Point(170, 82);
            this.m_cbPeppermints.Name = "m_cbPeppermints";
            this.m_cbPeppermints.Size = new System.Drawing.Size(124, 24);
            this.m_cbPeppermints.TabIndex = 7;
            this.m_cbPeppermints.Text = "Peppermints";
            this.m_cbPeppermints.UseVisualStyleBackColor = true;
            // 
            // m_cbButterscotch
            // 
            this.m_cbButterscotch.AutoSize = true;
            this.m_cbButterscotch.Location = new System.Drawing.Point(170, 112);
            this.m_cbButterscotch.Name = "m_cbButterscotch";
            this.m_cbButterscotch.Size = new System.Drawing.Size(126, 24);
            this.m_cbButterscotch.TabIndex = 8;
            this.m_cbButterscotch.Text = "Butterscotch";
            this.m_cbButterscotch.UseVisualStyleBackColor = true;
            // 
            // m_cbReese
            // 
            this.m_cbReese.AutoSize = true;
            this.m_cbReese.Location = new System.Drawing.Point(170, 142);
            this.m_cbReese.Name = "m_cbReese";
            this.m_cbReese.Size = new System.Drawing.Size(144, 24);
            this.m_cbReese.TabIndex = 9;
            this.m_cbReese.Text = "Reese\'s Pieces";
            this.m_cbReese.UseVisualStyleBackColor = true;
            // 
            // m_cbOreo
            // 
            this.m_cbOreo.AutoSize = true;
            this.m_cbOreo.Location = new System.Drawing.Point(170, 171);
            this.m_cbOreo.Name = "m_cbOreo";
            this.m_cbOreo.Size = new System.Drawing.Size(121, 24);
            this.m_cbOreo.TabIndex = 10;
            this.m_cbOreo.Text = "Oreo Pieces";
            this.m_cbOreo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 541);
            this.Controls.Add(this.m_btnOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_tbOrderLog);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ice Cream Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m_rbNeo;
        private System.Windows.Forms.RadioButton m_rbTwist;
        private System.Windows.Forms.RadioButton m_rbStrawberry;
        private System.Windows.Forms.RadioButton m_rbChocolate;
        private System.Windows.Forms.RadioButton m_rbVanilla;
        private System.Windows.Forms.TextBox m_tbOrderLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox m_cbOreo;
        private System.Windows.Forms.CheckBox m_cbReese;
        private System.Windows.Forms.CheckBox m_cbButterscotch;
        private System.Windows.Forms.CheckBox m_cbPeppermints;
        private System.Windows.Forms.CheckBox m_cbGummyBears;
        private System.Windows.Forms.CheckBox m_cbCaramel;
        private System.Windows.Forms.CheckBox m_cbPeanuts;
        private System.Windows.Forms.CheckBox m_cbHotFudge;
        private System.Windows.Forms.CheckBox m_cbChocoSyrup;
        private System.Windows.Forms.CheckBox m_cbSprinkles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_btnOrder;
    }
}

