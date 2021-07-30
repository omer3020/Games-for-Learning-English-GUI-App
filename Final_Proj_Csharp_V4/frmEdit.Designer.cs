
namespace Final_Proj_Csharp_V4
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.btnAddToGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSpell.BackgroundImage")));
            this.btnAddSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSpell.Location = new System.Drawing.Point(49, 111);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(341, 53);
            this.btnAddSpell.TabIndex = 0;
            this.btnAddSpell.UseVisualStyleBackColor = true;
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // btnAddToGame
            // 
            this.btnAddToGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToGame.BackgroundImage")));
            this.btnAddToGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToGame.Location = new System.Drawing.Point(424, 111);
            this.btnAddToGame.Name = "btnAddToGame";
            this.btnAddToGame.Size = new System.Drawing.Size(341, 53);
            this.btnAddToGame.TabIndex = 1;
            this.btnAddToGame.UseVisualStyleBackColor = true;
            this.btnAddToGame.Click += new System.EventHandler(this.btnAddToGame_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToGame);
            this.Controls.Add(this.btnAddSpell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.Button btnAddToGame;
    }
}