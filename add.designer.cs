namespace ADD
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
            this.firstno_label = new System.Windows.Forms.Label();
            this.secondno_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.firstno_textBox = new System.Windows.Forms.TextBox();
            this.secondno_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstno_label
            // 
            this.firstno_label.AutoSize = true;
            this.firstno_label.Location = new System.Drawing.Point(27, 36);
            this.firstno_label.Name = "firstno_label";
            this.firstno_label.Size = new System.Drawing.Size(61, 13);
            this.firstno_label.TabIndex = 0;
            this.firstno_label.Text = "1st Number";
            // 
            // secondno_label
            // 
            this.secondno_label.AutoSize = true;
            this.secondno_label.Location = new System.Drawing.Point(30, 75);
            this.secondno_label.Name = "secondno_label";
            this.secondno_label.Size = new System.Drawing.Size(65, 13);
            this.secondno_label.TabIndex = 1;
            this.secondno_label.Text = "2nd Number";
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Location = new System.Drawing.Point(30, 124);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(0, 13);
            this.add_label.TabIndex = 2;
            // 
            // firstno_textBox
            // 
            this.firstno_textBox.Location = new System.Drawing.Point(125, 36);
            this.firstno_textBox.Name = "firstno_textBox";
            this.firstno_textBox.Size = new System.Drawing.Size(100, 20);
            this.firstno_textBox.TabIndex = 3;
            // 
            // secondno_textBox
            // 
            this.secondno_textBox.Location = new System.Drawing.Point(125, 75);
            this.secondno_textBox.Name = "secondno_textBox";
            this.secondno_textBox.Size = new System.Drawing.Size(100, 20);
            this.secondno_textBox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(33, 204);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(136, 204);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.secondno_textBox);
            this.Controls.Add(this.firstno_textBox);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.secondno_label);
            this.Controls.Add(this.firstno_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstno_label;
        private System.Windows.Forms.Label secondno_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.TextBox firstno_textBox;
        private System.Windows.Forms.TextBox secondno_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button exit_button;
    }
}
