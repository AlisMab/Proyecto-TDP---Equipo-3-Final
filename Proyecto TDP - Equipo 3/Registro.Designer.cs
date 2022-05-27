namespace Proyecto_TDP___Equipo_3
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SALIR = new System.Windows.Forms.Button();
            this.ACCEDER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(182, 211);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(177, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correo electrónico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SALIR
            // 
            this.SALIR.Font = new System.Drawing.Font("RomanC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALIR.Location = new System.Drawing.Point(284, 284);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(99, 31);
            this.SALIR.TabIndex = 9;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // ACCEDER
            // 
            this.ACCEDER.Font = new System.Drawing.Font("RomanC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCEDER.Location = new System.Drawing.Point(160, 284);
            this.ACCEDER.Name = "ACCEDER";
            this.ACCEDER.Size = new System.Drawing.Size(99, 31);
            this.ACCEDER.TabIndex = 8;
            this.ACCEDER.Text = "ACCEDER";
            this.ACCEDER.UseVisualStyleBackColor = true;
            this.ACCEDER.Click += new System.EventHandler(this.ACCEDER_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 357);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.ACCEDER);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SALIR;
        private System.Windows.Forms.Button ACCEDER;
    }
}