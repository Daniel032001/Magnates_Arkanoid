using System.ComponentModel;

namespace Magnates_arkanoid
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.buttonJugar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonJugar.BackColor = System.Drawing.Color.Transparent;
            this.buttonJugar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJugar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonJugar.FlatAppearance.BorderSize = 3;
            this.buttonJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonJugar.ForeColor = System.Drawing.Color.White;
            this.buttonJugar.Location = new System.Drawing.Point(134, 390);
            this.buttonJugar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(379, 46);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.73094F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.24963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.979073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80867F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.buttonRegresar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonJugar, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.735849F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.622642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.245283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.35849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 530);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegresar.BackColor = System.Drawing.Color.Black;
            this.buttonRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRegresar.FlatAppearance.BorderSize = 5;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonRegresar.ForeColor = System.Drawing.Color.White;
            this.buttonRegresar.Location = new System.Drawing.Point(558, 392);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(73, 42);
            this.buttonRegresar.TabIndex = 1;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(135, 302);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(377, 38);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "User";
            this.Size = new System.Drawing.Size(669, 530);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUsuario;

        #endregion
    }
}