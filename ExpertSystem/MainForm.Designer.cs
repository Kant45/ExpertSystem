namespace ExpertSystem {
    public partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent() {
            this.label = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.ResultTitleLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.HelpPictureBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(494, 68);
            this.label.TabIndex = 0;
            this.label.Text = "Вам нужен универсальный грузовой автомобиль?";
            // 
            // YesButton
            // 
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(135, 177);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(119, 38);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.Location = new System.Drawing.Point(260, 177);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(119, 38);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // ResultTitleLabel
            // 
            this.ResultTitleLabel.AutoSize = true;
            this.ResultTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ResultTitleLabel.Location = new System.Drawing.Point(203, 86);
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(108, 24);
            this.ResultTitleLabel.TabIndex = 4;
            this.ResultTitleLabel.Text = "Результат:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.ResultLabel.Location = new System.Drawing.Point(12, 119);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(494, 55);
            this.ResultLabel.TabIndex = 3;
            // 
            // HelpPictureBox
            // 
            this.HelpPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpPictureBox.Image = global::ExpertSystem.Properties.Resources.Help_image;
            this.HelpPictureBox.Location = new System.Drawing.Point(461, 221);
            this.HelpPictureBox.Name = "HelpPictureBox";
            this.HelpPictureBox.Size = new System.Drawing.Size(45, 45);
            this.HelpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpPictureBox.TabIndex = 6;
            this.HelpPictureBox.TabStop = false;
            this.HelpPictureBox.Click += new System.EventHandler(this.HelpPictureBox_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::ExpertSystem.Properties.Resources.Back_image;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(234, 221);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 45);
            this.BackButton.TabIndex = 5;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 278);
            this.Controls.Add(this.HelpPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResultTitleLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.label);
            this.Name = "MainForm";
            this.Text = "Выбор грузового автомобиля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label ResultTitleLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox HelpPictureBox;
    }
}