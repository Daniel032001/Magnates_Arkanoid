using System.ComponentModel;

namespace Magnates_arkanoid
{
    partial class Game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = ": 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(690, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ptbTable
            // 
            this.ptbTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbTable.BackColor = System.Drawing.Color.Transparent;
            this.ptbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbTable.Image = global::Magnates_arkanoid.Properties.Resources.table;
            this.ptbTable.Location = new System.Drawing.Point(250, 496);
            this.ptbTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbTable.Name = "ptbTable";
            this.ptbTable.Size = new System.Drawing.Size(298, 36);
            this.ptbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTable.TabIndex = 2;
            this.ptbTable.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magnates_arkanoid.Properties.Resources.play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.ptbTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbTable;
    }
}