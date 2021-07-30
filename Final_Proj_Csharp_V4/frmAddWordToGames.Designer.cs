
namespace Final_Proj_Csharp_V4
{
    partial class frmAddWordToGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWordToGames));
            this.lblBrowseSound = new System.Windows.Forms.Label();
            this.btnBrowseSoundFile = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnAddGameWord = new System.Windows.Forms.Button();
            this.lblBrowseImage = new System.Windows.Forms.Label();
            this.btnBrowseImgFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblBrowseSound
            // 
            this.lblBrowseSound.AutoSize = true;
            this.lblBrowseSound.Location = new System.Drawing.Point(147, 122);
            this.lblBrowseSound.Name = "lblBrowseSound";
            this.lblBrowseSound.Size = new System.Drawing.Size(0, 15);
            this.lblBrowseSound.TabIndex = 20;
            // 
            // btnBrowseSoundFile
            // 
            this.btnBrowseSoundFile.AutoSize = true;
            this.btnBrowseSoundFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseSoundFile.BackgroundImage")));
            this.btnBrowseSoundFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseSoundFile.Location = new System.Drawing.Point(17, 122);
            this.btnBrowseSoundFile.Name = "btnBrowseSoundFile";
            this.btnBrowseSoundFile.Size = new System.Drawing.Size(119, 28);
            this.btnBrowseSoundFile.TabIndex = 19;
            this.btnBrowseSoundFile.UseVisualStyleBackColor = true;
            this.btnBrowseSoundFile.Click += new System.EventHandler(this.btnBrowseSoundFile_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(105, 40);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(142, 23);
            this.txtWord.TabIndex = 15;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(37, 40);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(42, 15);
            this.lblWord.TabIndex = 11;
            this.lblWord.Text = "Word: ";
            // 
            // btnAddGameWord
            // 
            this.btnAddGameWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGameWord.BackgroundImage")));
            this.btnAddGameWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGameWord.Location = new System.Drawing.Point(656, 345);
            this.btnAddGameWord.Name = "btnAddGameWord";
            this.btnAddGameWord.Size = new System.Drawing.Size(120, 93);
            this.btnAddGameWord.TabIndex = 21;
            this.btnAddGameWord.UseVisualStyleBackColor = true;
            this.btnAddGameWord.Click += new System.EventHandler(this.btnAddGameWord_Click);
            // 
            // lblBrowseImage
            // 
            this.lblBrowseImage.AutoSize = true;
            this.lblBrowseImage.Location = new System.Drawing.Point(147, 189);
            this.lblBrowseImage.Name = "lblBrowseImage";
            this.lblBrowseImage.Size = new System.Drawing.Size(0, 15);
            this.lblBrowseImage.TabIndex = 23;
            // 
            // btnBrowseImgFile
            // 
            this.btnBrowseImgFile.AutoSize = true;
            this.btnBrowseImgFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseImgFile.BackgroundImage")));
            this.btnBrowseImgFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseImgFile.Location = new System.Drawing.Point(17, 176);
            this.btnBrowseImgFile.Name = "btnBrowseImgFile";
            this.btnBrowseImgFile.Size = new System.Drawing.Size(119, 28);
            this.btnBrowseImgFile.TabIndex = 22;
            this.btnBrowseImgFile.UseVisualStyleBackColor = true;
            this.btnBrowseImgFile.Click += new System.EventHandler(this.btnBrowseImgFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // frmAddWordToGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBrowseImage);
            this.Controls.Add(this.btnBrowseImgFile);
            this.Controls.Add(this.btnAddGameWord);
            this.Controls.Add(this.lblBrowseSound);
            this.Controls.Add(this.btnBrowseSoundFile);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddWordToGames";
            this.Text = "Add Word To Games";
            this.Load += new System.EventHandler(this.frmAddWordToGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowseSound;
        private System.Windows.Forms.Button btnBrowseSoundFile;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnAddGameWord;
        private System.Windows.Forms.Label lblBrowseImage;
        private System.Windows.Forms.Button btnBrowseImgFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}