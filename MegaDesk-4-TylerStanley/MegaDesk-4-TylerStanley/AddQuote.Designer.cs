namespace MegaDesk_3_TylerStanley
{
    partial class AddQuote
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
            this.submit = new System.Windows.Forms.Button();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDrawersTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialTextBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rushOrderOptionTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(197, 226);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(172, 56);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateWidthInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Width";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(172, 82);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 3;
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDepthInput);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Number of Drawers";
            // 
            // numDrawersTextBox
            // 
            this.numDrawersTextBox.Location = new System.Drawing.Point(172, 108);
            this.numDrawersTextBox.Name = "numDrawersTextBox";
            this.numDrawersTextBox.Size = new System.Drawing.Size(100, 20);
            this.numDrawersTextBox.TabIndex = 4;
            this.numDrawersTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumofDrawers);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(172, 30);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateName);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter your Name";
            // 
            // materialTextBox
            // 
            this.materialTextBox.FormattingEnabled = true;
            this.materialTextBox.Location = new System.Drawing.Point(172, 138);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 21);
            this.materialTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Desk Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rush Order Option";
            // 
            // rushOrderOptionTextBox
            // 
            this.rushOrderOptionTextBox.FormattingEnabled = true;
            this.rushOrderOptionTextBox.Items.AddRange(new object[] {
            "3 day",
            "5 day",
            "7 day"});
            this.rushOrderOptionTextBox.Location = new System.Drawing.Point(172, 168);
            this.rushOrderOptionTextBox.Name = "rushOrderOptionTextBox";
            this.rushOrderOptionTextBox.Size = new System.Drawing.Size(100, 21);
            this.rushOrderOptionTextBox.TabIndex = 14;
            this.rushOrderOptionTextBox.Text = "3 day";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rushOrderOptionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.numDrawersTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.submit);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numDrawersTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materialTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rushOrderOptionTextBox;
    }
}