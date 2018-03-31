namespace Prog2
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateRegisterLabel = new System.Windows.Forms.Label();
            this.timeRegisterLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(54, 36);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(75, 13);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours Earned:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Last Name:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(135, 33);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(108, 20);
            this.hoursTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(108, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(80, 207);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(98, 36);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Generate";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(12, 103);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(103, 13);
            this.registrationLabel.TabIndex = 5;
            this.registrationLabel.Text = "Earliest Registration:";
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(135, 127);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 23);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateRegisterLabel
            // 
            this.dateRegisterLabel.AutoSize = true;
            this.dateRegisterLabel.Location = new System.Drawing.Point(96, 132);
            this.dateRegisterLabel.Name = "dateRegisterLabel";
            this.dateRegisterLabel.Size = new System.Drawing.Size(36, 13);
            this.dateRegisterLabel.TabIndex = 7;
            this.dateRegisterLabel.Text = "Date: ";
            // 
            // timeRegisterLabel
            // 
            this.timeRegisterLabel.AutoSize = true;
            this.timeRegisterLabel.Location = new System.Drawing.Point(96, 168);
            this.timeRegisterLabel.Name = "timeRegisterLabel";
            this.timeRegisterLabel.Size = new System.Drawing.Size(33, 13);
            this.timeRegisterLabel.TabIndex = 8;
            this.timeRegisterLabel.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(135, 163);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 23);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 260);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeRegisterLabel);
            this.Controls.Add(this.dateRegisterLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.hoursLabel);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateRegisterLabel;
        private System.Windows.Forms.Label timeRegisterLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

