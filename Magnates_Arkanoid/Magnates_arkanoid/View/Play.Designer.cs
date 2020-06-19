using System.ComponentModel;

namespace Magnates_arkanoid
{
    partial class Play
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbTable = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbTable
            // 
            this.ptbTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbTable.BackColor = System.Drawing.Color.Transparent;
            this.ptbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbTable.Location = new System.Drawing.Point(188, 322);
            this.ptbTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbTable.Name = "ptbTable";
            this.ptbTable.Size = new System.Drawing.Size(224, 23);
            this.ptbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTable.TabIndex = 2;
            this.ptbTable.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ptbTable);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Play";
            this.Size = new System.Drawing.Size(600, 365);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Play_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox ptbTable;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}