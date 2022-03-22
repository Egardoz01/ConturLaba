namespace ConturLaba
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnApplyMask = new System.Windows.Forms.Button();
            this.cmbMask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(757, 532);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(963, 510);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(99, 34);
            this.btnChooseImage.TabIndex = 1;
            this.btnChooseImage.Text = "Browse image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnApplyMask
            // 
            this.btnApplyMask.Location = new System.Drawing.Point(855, 510);
            this.btnApplyMask.Name = "btnApplyMask";
            this.btnApplyMask.Size = new System.Drawing.Size(102, 34);
            this.btnApplyMask.TabIndex = 2;
            this.btnApplyMask.Text = "Apply mask";
            this.btnApplyMask.UseVisualStyleBackColor = true;
            this.btnApplyMask.Click += new System.EventHandler(this.btnApplyMask_Click);
            // 
            // cmbMask
            // 
            this.cmbMask.FormattingEnabled = true;
            this.cmbMask.Location = new System.Drawing.Point(823, 102);
            this.cmbMask.Name = "cmbMask";
            this.cmbMask.Size = new System.Drawing.Size(239, 21);
            this.cmbMask.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Mask";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMask);
            this.Controls.Add(this.btnApplyMask);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Климов Е.В. Выделение Контуров";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnApplyMask;
        private System.Windows.Forms.ComboBox cmbMask;
        private System.Windows.Forms.Label label1;
    }
}

