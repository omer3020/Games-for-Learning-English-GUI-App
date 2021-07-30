
namespace Final_Proj_Csharp_V4
{
    partial class frmTypingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypingGame));
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWorng = new System.Windows.Forms.Label();
            this.lblCheckText = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorrect.Location = new System.Drawing.Point(36, 32);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(102, 30);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "Correct: 0";
            // 
            // lblWorng
            // 
            this.lblWorng.AutoSize = true;
            this.lblWorng.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWorng.Location = new System.Drawing.Point(559, 32);
            this.lblWorng.Name = "lblWorng";
            this.lblWorng.Size = new System.Drawing.Size(117, 30);
            this.lblWorng.TabIndex = 1;
            this.lblWorng.Text = "Incorrect: 0";
            // 
            // lblCheckText
            // 
            this.lblCheckText.AutoSize = true;
            this.lblCheckText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckText.Location = new System.Drawing.Point(22, 285);
            this.lblCheckText.Name = "lblCheckText";
            this.lblCheckText.Size = new System.Drawing.Size(650, 25);
            this.lblCheckText.TabIndex = 3;
            this.lblCheckText.Text = "Press the Check btn or Enter to check the if the Word matching to the Image";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(192, 69);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(299, 188);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 4;
            this.imageBox.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Location = new System.Drawing.Point(287, 381);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 41);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(201, 330);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(277, 23);
            this.txtAnswer.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(559, 381);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 41);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmTypingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 489);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.lblCheckText);
            this.Controls.Add(this.lblWorng);
            this.Controls.Add(this.lblCorrect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTypingGame";
            this.Text = "Typing Game";
            this.Load += new System.EventHandler(this.frmTypingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWorng;
        private System.Windows.Forms.Label lblCheckText;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
    }
}