
namespace Final_Proj_Csharp_V4
{
    partial class frmPlayGround
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayGround));
            this.btnMissingLetter = new System.Windows.Forms.Button();
            this.btnImageToWord = new System.Windows.Forms.Button();
            this.btnPressTheWord = new System.Windows.Forms.Button();
            this.btnSoundToWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMissingLetter
            // 
            this.btnMissingLetter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMissingLetter.BackgroundImage")));
            this.btnMissingLetter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMissingLetter.Location = new System.Drawing.Point(60, 90);
            this.btnMissingLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMissingLetter.Name = "btnMissingLetter";
            this.btnMissingLetter.Size = new System.Drawing.Size(269, 71);
            this.btnMissingLetter.TabIndex = 0;
            this.btnMissingLetter.UseVisualStyleBackColor = true;
            this.btnMissingLetter.Click += new System.EventHandler(this.btnMissingLetter_Click);
            // 
            // btnImageToWord
            // 
            this.btnImageToWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImageToWord.BackgroundImage")));
            this.btnImageToWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageToWord.Location = new System.Drawing.Point(356, 90);
            this.btnImageToWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageToWord.Name = "btnImageToWord";
            this.btnImageToWord.Size = new System.Drawing.Size(269, 71);
            this.btnImageToWord.TabIndex = 1;
            this.btnImageToWord.UseVisualStyleBackColor = true;
            this.btnImageToWord.Click += new System.EventHandler(this.btnImageToWord_Click);
            // 
            // btnPressTheWord
            // 
            this.btnPressTheWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPressTheWord.BackgroundImage")));
            this.btnPressTheWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPressTheWord.Location = new System.Drawing.Point(661, 90);
            this.btnPressTheWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPressTheWord.Name = "btnPressTheWord";
            this.btnPressTheWord.Size = new System.Drawing.Size(269, 71);
            this.btnPressTheWord.TabIndex = 2;
            this.btnPressTheWord.UseVisualStyleBackColor = true;
            this.btnPressTheWord.Click += new System.EventHandler(this.btnPressTheWord_Click);
            // 
            // btnSoundToWord
            // 
            this.btnSoundToWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoundToWord.BackgroundImage")));
            this.btnSoundToWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoundToWord.Location = new System.Drawing.Point(388, 240);
            this.btnSoundToWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSoundToWord.Name = "btnSoundToWord";
            this.btnSoundToWord.Size = new System.Drawing.Size(269, 71);
            this.btnSoundToWord.TabIndex = 3;
            this.btnSoundToWord.UseVisualStyleBackColor = true;
            this.btnSoundToWord.Click += new System.EventHandler(this.btnSoundToWord_Click);
            // 
            // frmPlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 582);
            this.Controls.Add(this.btnSoundToWord);
            this.Controls.Add(this.btnPressTheWord);
            this.Controls.Add(this.btnImageToWord);
            this.Controls.Add(this.btnMissingLetter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlayGround";
            this.Text = "Play Ground";
            this.Load += new System.EventHandler(this.frmPlayGround_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMissingLetter;
        private System.Windows.Forms.Button btnImageToWord;
        private System.Windows.Forms.Button btnPressTheWord;
        private System.Windows.Forms.Button btnSoundToWord;
    }
}