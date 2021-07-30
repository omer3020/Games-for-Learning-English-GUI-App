
namespace Final_Proj_Csharp_V4
{
    partial class frmAddSpell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSpell));
            this.lblWord = new System.Windows.Forms.Label();
            this.lblWorng1 = new System.Windows.Forms.Label();
            this.lblWorng2 = new System.Windows.Forms.Label();
            this.lblWorng3 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtWorng1 = new System.Windows.Forms.TextBox();
            this.txtWorng2 = new System.Windows.Forms.TextBox();
            this.txtWorng3 = new System.Windows.Forms.TextBox();
            this.btnAddSpellWord = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(39, 20);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(42, 15);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word: ";
            // 
            // lblWorng1
            // 
            this.lblWorng1.AutoSize = true;
            this.lblWorng1.Location = new System.Drawing.Point(39, 74);
            this.lblWorng1.Name = "lblWorng1";
            this.lblWorng1.Size = new System.Drawing.Size(55, 15);
            this.lblWorng1.TabIndex = 1;
            this.lblWorng1.Text = "Worng 1:";
            // 
            // lblWorng2
            // 
            this.lblWorng2.AutoSize = true;
            this.lblWorng2.Location = new System.Drawing.Point(39, 128);
            this.lblWorng2.Name = "lblWorng2";
            this.lblWorng2.Size = new System.Drawing.Size(55, 15);
            this.lblWorng2.TabIndex = 2;
            this.lblWorng2.Text = "Worng 2:";
            // 
            // lblWorng3
            // 
            this.lblWorng3.AutoSize = true;
            this.lblWorng3.Location = new System.Drawing.Point(39, 184);
            this.lblWorng3.Name = "lblWorng3";
            this.lblWorng3.Size = new System.Drawing.Size(55, 15);
            this.lblWorng3.TabIndex = 3;
            this.lblWorng3.Text = "Worng 3:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(107, 20);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(142, 23);
            this.txtWord.TabIndex = 4;
            // 
            // txtWorng1
            // 
            this.txtWorng1.Location = new System.Drawing.Point(107, 71);
            this.txtWorng1.Name = "txtWorng1";
            this.txtWorng1.Size = new System.Drawing.Size(142, 23);
            this.txtWorng1.TabIndex = 5;
            // 
            // txtWorng2
            // 
            this.txtWorng2.Location = new System.Drawing.Point(107, 125);
            this.txtWorng2.Name = "txtWorng2";
            this.txtWorng2.Size = new System.Drawing.Size(142, 23);
            this.txtWorng2.TabIndex = 6;
            this.txtWorng2.TextChanged += new System.EventHandler(this.txtWorng2_TextChanged);
            // 
            // txtWorng3
            // 
            this.txtWorng3.Location = new System.Drawing.Point(107, 181);
            this.txtWorng3.Name = "txtWorng3";
            this.txtWorng3.Size = new System.Drawing.Size(142, 23);
            this.txtWorng3.TabIndex = 7;
            // 
            // btnAddSpellWord
            // 
            this.btnAddSpellWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSpellWord.BackgroundImage")));
            this.btnAddSpellWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSpellWord.Location = new System.Drawing.Point(631, 347);
            this.btnAddSpellWord.Name = "btnAddSpellWord";
            this.btnAddSpellWord.Size = new System.Drawing.Size(138, 77);
            this.btnAddSpellWord.TabIndex = 8;
            this.btnAddSpellWord.UseVisualStyleBackColor = true;
            this.btnAddSpellWord.Click += new System.EventHandler(this.btnAddSpellWord_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseFile.BackgroundImage")));
            this.btnBrowseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseFile.Location = new System.Drawing.Point(39, 245);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(91, 22);
            this.btnBrowseFile.TabIndex = 9;
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Location = new System.Drawing.Point(149, 252);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(0, 15);
            this.lblBrowse.TabIndex = 10;
            // 
            // frmAddSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.btnAddSpellWord);
            this.Controls.Add(this.txtWorng3);
            this.Controls.Add(this.txtWorng2);
            this.Controls.Add(this.txtWorng1);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWorng3);
            this.Controls.Add(this.lblWorng2);
            this.Controls.Add(this.lblWorng1);
            this.Controls.Add(this.lblWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSpell";
            this.Text = "Add Spell Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblWorng1;
        private System.Windows.Forms.Label lblWorng2;
        private System.Windows.Forms.Label lblWorng3;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtWorng1;
        private System.Windows.Forms.TextBox txtWorng2;
        private System.Windows.Forms.TextBox txtWorng3;
        private System.Windows.Forms.Button btnAddSpellWord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lblBrowse;
    }
}