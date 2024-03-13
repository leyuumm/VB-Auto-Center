namespace BrandPartNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VBAutoCenterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrandARadioButton = new System.Windows.Forms.RadioButton();
            this.BrandCRadioButton = new System.Windows.Forms.RadioButton();
            this.BrandXRadioButton = new System.Windows.Forms.RadioButton();
            this.PartNumberLabel = new System.Windows.Forms.Label();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VBAutoCenterLabel
            // 
            this.VBAutoCenterLabel.AutoSize = true;
            this.VBAutoCenterLabel.BackColor = System.Drawing.Color.Transparent;
            this.VBAutoCenterLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VBAutoCenterLabel.Location = new System.Drawing.Point(239, 41);
            this.VBAutoCenterLabel.Name = "VBAutoCenterLabel";
            this.VBAutoCenterLabel.Size = new System.Drawing.Size(205, 29);
            this.VBAutoCenterLabel.TabIndex = 0;
            this.VBAutoCenterLabel.Text = "VB Auto Center";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.PartNumberTextBox);
            this.panel1.Controls.Add(this.PartNumberLabel);
            this.panel1.Controls.Add(this.BrandXRadioButton);
            this.panel1.Controls.Add(this.BrandCRadioButton);
            this.panel1.Controls.Add(this.BrandARadioButton);
            this.panel1.Controls.Add(this.VBAutoCenterLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(112, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 376);
            this.panel1.TabIndex = 1;
            // 
            // BrandARadioButton
            // 
            this.BrandARadioButton.AutoSize = true;
            this.BrandARadioButton.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandARadioButton.Location = new System.Drawing.Point(56, 125);
            this.BrandARadioButton.Name = "BrandARadioButton";
            this.BrandARadioButton.Size = new System.Drawing.Size(88, 27);
            this.BrandARadioButton.TabIndex = 1;
            this.BrandARadioButton.TabStop = true;
            this.BrandARadioButton.Text = "Brand A";
            this.BrandARadioButton.UseVisualStyleBackColor = true;
            // 
            // BrandCRadioButton
            // 
            this.BrandCRadioButton.AutoSize = true;
            this.BrandCRadioButton.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandCRadioButton.Location = new System.Drawing.Point(56, 163);
            this.BrandCRadioButton.Name = "BrandCRadioButton";
            this.BrandCRadioButton.Size = new System.Drawing.Size(88, 27);
            this.BrandCRadioButton.TabIndex = 2;
            this.BrandCRadioButton.TabStop = true;
            this.BrandCRadioButton.Text = "Brand C";
            this.BrandCRadioButton.UseVisualStyleBackColor = true;
            // 
            // BrandXRadioButton
            // 
            this.BrandXRadioButton.AutoSize = true;
            this.BrandXRadioButton.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandXRadioButton.Location = new System.Drawing.Point(56, 205);
            this.BrandXRadioButton.Name = "BrandXRadioButton";
            this.BrandXRadioButton.Size = new System.Drawing.Size(88, 27);
            this.BrandXRadioButton.TabIndex = 3;
            this.BrandXRadioButton.TabStop = true;
            this.BrandXRadioButton.Text = "Brand X";
            this.BrandXRadioButton.UseVisualStyleBackColor = true;
            // 
            // PartNumberLabel
            // 
            this.PartNumberLabel.AutoSize = true;
            this.PartNumberLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberLabel.Location = new System.Drawing.Point(232, 124);
            this.PartNumberLabel.Name = "PartNumberLabel";
            this.PartNumberLabel.Size = new System.Drawing.Size(120, 24);
            this.PartNumberLabel.TabIndex = 4;
            this.PartNumberLabel.Text = "Part Number:";
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Location = new System.Drawing.Point(352, 125);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(110, 24);
            this.PartNumberTextBox.TabIndex = 5;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(274, 230);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(137, 52);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 483);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "VB Auto Center";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VBAutoCenterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PartNumberLabel;
        private System.Windows.Forms.RadioButton BrandXRadioButton;
        private System.Windows.Forms.RadioButton BrandCRadioButton;
        private System.Windows.Forms.RadioButton BrandARadioButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox PartNumberTextBox;
    }
}

