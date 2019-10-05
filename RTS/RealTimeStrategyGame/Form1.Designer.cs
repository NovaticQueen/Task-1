namespace RealTimeStrategyGame
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
            this.mapLabel = new System.Windows.Forms.Label();
            this.unitInfoTxtBox = new System.Windows.Forms.TextBox();
            this.startPauseButton = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapLabel.Location = new System.Drawing.Point(19, 23);
            this.mapLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(61, 13);
            this.mapLabel.TabIndex = 0;
            this.mapLabel.Text = "mapLabel";
            // 
            // unitInfoTxtBox
            // 
            this.unitInfoTxtBox.Location = new System.Drawing.Point(656, 10);
            this.unitInfoTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitInfoTxtBox.Multiline = true;
            this.unitInfoTxtBox.Name = "unitInfoTxtBox";
            this.unitInfoTxtBox.Size = new System.Drawing.Size(236, 340);
            this.unitInfoTxtBox.TabIndex = 1;
            // 
            // startPauseButton
            // 
            this.startPauseButton.Location = new System.Drawing.Point(656, 354);
            this.startPauseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(110, 27);
            this.startPauseButton.TabIndex = 2;
            this.startPauseButton.Text = "Start/Pause";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.startPauseButton_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(817, 364);
            this.lblRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(65, 13);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "RoundLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 418);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.unitInfoTxtBox);
            this.Controls.Add(this.mapLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Real Time Strategy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.TextBox unitInfoTxtBox;
        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Label lblRound;
    }
}

