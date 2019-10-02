namespace RTS__Task_One_
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
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.mapLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundTextLabel = new System.Windows.Forms.Label();
            this.informationTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Myanmar Text", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(398, 417);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 33);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Myanmar Text", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(398, 452);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(172, 33);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(39, 34);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(70, 17);
            this.mapLabel.TabIndex = 2;
            this.mapLabel.Text = "mapLabel";
            this.mapLabel.Click += new System.EventHandler(this.mapLabel_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Myanmar Text", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(694, 460);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(85, 25);
            this.roundLabel.TabIndex = 4;
            this.roundLabel.Text = "roundlabel";
            // 
            // roundTextLabel
            // 
            this.roundTextLabel.AutoSize = true;
            this.roundTextLabel.Font = new System.Drawing.Font("Myanmar Text", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTextLabel.Location = new System.Drawing.Point(694, 421);
            this.roundTextLabel.Name = "roundTextLabel";
            this.roundTextLabel.Size = new System.Drawing.Size(71, 25);
            this.roundTextLabel.TabIndex = 5;
            this.roundTextLabel.Text = "ROUND :";
            // 
            // informationTextBox
            // 
            this.informationTextBox.Location = new System.Drawing.Point(393, 28);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(371, 376);
            this.informationTextBox.TabIndex = 6;
            this.informationTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 500);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.roundTextLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Real Time Strategy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label roundTextLabel;
        private System.Windows.Forms.RichTextBox informationTextBox;
    }
}

