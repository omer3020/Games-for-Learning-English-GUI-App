
namespace Final_Proj_Csharp_V4
{
    partial class frmSpell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpell));
            this.btnSound = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblWrite = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSound
            // 
            this.btnSound.Image = ((System.Drawing.Image)(resources.GetObject("btnSound.Image")));
            this.btnSound.Location = new System.Drawing.Point(633, 43);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(57, 49);
            this.btnSound.TabIndex = 0;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Location = new System.Drawing.Point(583, 312);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 67);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(29, 147);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(29, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrite.Location = new System.Drawing.Point(29, 334);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(130, 25);
            this.lblWrite.TabIndex = 11;
            this.lblWrite.Text = "Write It down:";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(182, 335);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(251, 23);
            this.txtWrite.TabIndex = 12;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOr.Location = new System.Drawing.Point(254, 243);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(60, 39);
            this.lblOr.TabIndex = 13;
            this.lblOr.Text = "OR";
            // 
            // btnClean
            // 
            this.btnClean.AutoSize = true;
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Location = new System.Drawing.Point(430, 43);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(152, 25);
            this.btnClean.TabIndex = 14;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // frmSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(739, 427);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSpell";
            this.Text = "Spell";
            this.Load += new System.EventHandler(this.frmSpell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnClean;
    }
}