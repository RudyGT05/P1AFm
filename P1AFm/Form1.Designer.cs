namespace P1AFm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.labelusr = new System.Windows.Forms.Label();
            this.labelpwd = new System.Windows.Forms.Label();
            this.textBoxpwd = new System.Windows.Forms.TextBox();
            this.textBoxusr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Location = new System.Drawing.Point(87, 135);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(35, 13);
            this.labeltitulo.TabIndex = 3;
            this.labeltitulo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Padre:Form1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P1AFm.Properties.Resources.caradeccla;
            this.pictureBox1.Location = new System.Drawing.Point(535, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 223);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(352, 124);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(114, 70);
            this.btnIngreso.TabIndex = 5;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // labelusr
            // 
            this.labelusr.AutoSize = true;
            this.labelusr.Location = new System.Drawing.Point(261, 237);
            this.labelusr.Name = "labelusr";
            this.labelusr.Size = new System.Drawing.Size(35, 13);
            this.labelusr.TabIndex = 6;
            this.labelusr.Text = "label1";
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.Location = new System.Drawing.Point(261, 320);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(35, 13);
            this.labelpwd.TabIndex = 7;
            this.labelpwd.Text = "label1";
            // 
            // textBoxpwd
            // 
            this.textBoxpwd.Location = new System.Drawing.Point(359, 320);
            this.textBoxpwd.Name = "textBoxpwd";
            this.textBoxpwd.PasswordChar = '*';
            this.textBoxpwd.Size = new System.Drawing.Size(83, 20);
            this.textBoxpwd.TabIndex = 8;
            // 
            // textBoxusr
            // 
            this.textBoxusr.Location = new System.Drawing.Point(359, 234);
            this.textBoxusr.Name = "textBoxusr";
            this.textBoxusr.Size = new System.Drawing.Size(83, 20);
            this.textBoxusr.TabIndex = 9;
            this.textBoxusr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxusr);
            this.Controls.Add(this.textBoxpwd);
            this.Controls.Add(this.labelpwd);
            this.Controls.Add(this.labelusr);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label labelusr;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.TextBox textBoxpwd;
        private System.Windows.Forms.TextBox textBoxusr;
    }
}

