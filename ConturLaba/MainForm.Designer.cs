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
            this.btnChooseImage.Text = "Choose image";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 568);
            this.Controls.Add(this.btnApplyMask);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Климов Е.В. Выделение Контуров";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnApplyMask;
    }
}

