namespace RandomFoxAPI_Oplossing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFox = new System.Windows.Forms.PictureBox();
            this.btnGetFoxImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).BeginInit();
            this.SuspendLayout();
            // 
            // picFox
            // 
            this.picFox.Location = new System.Drawing.Point(283, 12);
            this.picFox.Name = "picFox";
            this.picFox.Size = new System.Drawing.Size(211, 298);
            this.picFox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFox.TabIndex = 0;
            this.picFox.TabStop = false;
            // 
            // btnGetFoxImage
            // 
            this.btnGetFoxImage.Location = new System.Drawing.Point(283, 355);
            this.btnGetFoxImage.Name = "btnGetFoxImage";
            this.btnGetFoxImage.Size = new System.Drawing.Size(211, 23);
            this.btnGetFoxImage.TabIndex = 1;
            this.btnGetFoxImage.Text = "Get Fox Image";
            this.btnGetFoxImage.UseVisualStyleBackColor = true;
            this.btnGetFoxImage.Click += new System.EventHandler(this.btnGetFoxImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetFoxImage);
            this.Controls.Add(this.picFox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picFox;
        private Button btnGetFoxImage;
    }
}