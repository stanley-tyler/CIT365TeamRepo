namespace MegaDesk_3_TylerStanley
{
    partial class SearchQuotes
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
            this.searchedQuote = new System.Windows.Forms.Label();
            this.materialSearchBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchedQuote
            // 
            this.searchedQuote.AutoSize = true;
            this.searchedQuote.Location = new System.Drawing.Point(12, 67);
            this.searchedQuote.Name = "searchedQuote";
            this.searchedQuote.Size = new System.Drawing.Size(0, 13);
            this.searchedQuote.TabIndex = 0;
            // 
            // materialSearchBox
            // 
            this.materialSearchBox.FormattingEnabled = true;
            this.materialSearchBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "RoseWood",
            "Veneer"});
            this.materialSearchBox.Location = new System.Drawing.Point(104, 38);
            this.materialSearchBox.Name = "materialSearchBox";
            this.materialSearchBox.Size = new System.Drawing.Size(94, 21);
            this.materialSearchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Material";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(204, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialSearchBox);
            this.Controls.Add(this.searchedQuote);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchedQuote;
        private System.Windows.Forms.ComboBox materialSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}