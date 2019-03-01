namespace Windows_Forms_Application
{
    partial class Window
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
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.factorsTextBox = new System.Windows.Forms.TextBox();
            this.factorsLabel = new System.Windows.Forms.Label();
            this.factorWordsLabel = new System.Windows.Forms.Label();
            this.maxNumberLabel = new System.Windows.Forms.Label();
            this.factorWordsTextBox = new System.Windows.Forms.TextBox();
            this.maxNumberTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(560, 265);
            this.outputRichTextBox.TabIndex = 0;
            this.outputRichTextBox.Text = "";
            // 
            // factorsTextBox
            // 
            this.factorsTextBox.Location = new System.Drawing.Point(99, 287);
            this.factorsTextBox.Name = "factorsTextBox";
            this.factorsTextBox.Size = new System.Drawing.Size(473, 20);
            this.factorsTextBox.TabIndex = 1;
            this.factorsTextBox.Text = "3,5";
            // 
            // factorsLabel
            // 
            this.factorsLabel.AutoSize = true;
            this.factorsLabel.Location = new System.Drawing.Point(40, 290);
            this.factorsLabel.Name = "factorsLabel";
            this.factorsLabel.Size = new System.Drawing.Size(45, 13);
            this.factorsLabel.TabIndex = 2;
            this.factorsLabel.Text = "Factors:";
            // 
            // factorWordsLabel
            // 
            this.factorWordsLabel.AutoSize = true;
            this.factorWordsLabel.Location = new System.Drawing.Point(11, 320);
            this.factorWordsLabel.Name = "factorWordsLabel";
            this.factorWordsLabel.Size = new System.Drawing.Size(74, 13);
            this.factorWordsLabel.TabIndex = 3;
            this.factorWordsLabel.Text = "Factor Words:";
            // 
            // maxNumberLabel
            // 
            this.maxNumberLabel.AutoSize = true;
            this.maxNumberLabel.Location = new System.Drawing.Point(16, 350);
            this.maxNumberLabel.Name = "maxNumberLabel";
            this.maxNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.maxNumberLabel.TabIndex = 4;
            this.maxNumberLabel.Text = "Max Number:";
            // 
            // factorWordsTextBox
            // 
            this.factorWordsTextBox.Location = new System.Drawing.Point(99, 317);
            this.factorWordsTextBox.Name = "factorWordsTextBox";
            this.factorWordsTextBox.Size = new System.Drawing.Size(473, 20);
            this.factorWordsTextBox.TabIndex = 5;
            this.factorWordsTextBox.Text = "Fizz,Buzz";
            // 
            // maxNumberTextBox
            // 
            this.maxNumberTextBox.Location = new System.Drawing.Point(99, 347);
            this.maxNumberTextBox.Name = "maxNumberTextBox";
            this.maxNumberTextBox.Size = new System.Drawing.Size(473, 20);
            this.maxNumberTextBox.TabIndex = 6;
            this.maxNumberTextBox.Text = "100";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(19, 373);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(553, 26);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Update";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.maxNumberTextBox);
            this.Controls.Add(this.factorWordsTextBox);
            this.Controls.Add(this.maxNumberLabel);
            this.Controls.Add(this.factorWordsLabel);
            this.Controls.Add(this.factorsLabel);
            this.Controls.Add(this.factorsTextBox);
            this.Controls.Add(this.outputRichTextBox);
            this.Name = "Window";
            this.Text = "Fizz Buzz";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.TextBox factorsTextBox;
        private System.Windows.Forms.Label factorsLabel;
        private System.Windows.Forms.Label factorWordsLabel;
        private System.Windows.Forms.Label maxNumberLabel;
        private System.Windows.Forms.TextBox factorWordsTextBox;
        private System.Windows.Forms.TextBox maxNumberTextBox;
        private System.Windows.Forms.Button goButton;
    }
}

