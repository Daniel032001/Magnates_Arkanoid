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
            this.tmGame = new System.Windows.Forms.Timer(this.components);
            this.lblLifes = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbTable
            // 
            this.ptbTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbTable.BackColor = System.Drawing.Color.Transparent;
            this.ptbTable.BackgroundImage = global::Magnates_arkanoid.Properties.Resources.table;
            this.ptbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbTable.Location = new System.Drawing.Point(251, 495);
            this.ptbTable.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ptbTable.Name = "ptbTable";
            this.ptbTable.Size = new System.Drawing.Size(299, 35);
            this.ptbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTable.TabIndex = 2;
            this.ptbTable.TabStop = false;
            // 
            // tmGame
            // 
            this.tmGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLifes
            // 
            this.lblLifes.BackColor = System.Drawing.Color.Transparent;
            this.lblLifes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLifes.ForeColor = System.Drawing.Color.White;
            this.lblLifes.Location = new System.Drawing.Point(70, 0);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(141, 54);
            this.lblLifes.TabIndex = 3;
            this.lblLifes.Text = "label1";
            this.lblLifes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(671, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(129, 54);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = ": 0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magnates_arkanoid.Properties.Resources.play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblLifes);
            this.Controls.Add(this.ptbTable);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Play";
            this.Size = new System.Drawing.Size(800, 561);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Play_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.ptbTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox ptbTable;
        private System.Windows.Forms.Timer tmGame;

        #endregion

        private System.Windows.Forms.Label lblLifes;
        private System.Windows.Forms.Label lblPoints;
    }
}