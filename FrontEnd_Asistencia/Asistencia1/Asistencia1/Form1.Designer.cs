namespace Asistencia1
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
            this.button_Control = new System.Windows.Forms.Button();
            this.Button_Gestion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Control
            // 
            this.button_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_Control.Location = new System.Drawing.Point(485, 114);
            this.button_Control.Name = "button_Control";
            this.button_Control.Size = new System.Drawing.Size(234, 95);
            this.button_Control.TabIndex = 0;
            this.button_Control.Text = "Control";
            this.button_Control.UseVisualStyleBackColor = true;
            // 
            // Button_Gestion
            // 
            this.Button_Gestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Button_Gestion.Location = new System.Drawing.Point(485, 267);
            this.Button_Gestion.Name = "Button_Gestion";
            this.Button_Gestion.Size = new System.Drawing.Size(234, 95);
            this.Button_Gestion.TabIndex = 1;
            this.Button_Gestion.Text = "Gestion";
            this.Button_Gestion.UseVisualStyleBackColor = true;
            this.Button_Gestion.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Gestion);
            this.Controls.Add(this.button_Control);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Control;
        private System.Windows.Forms.Button Button_Gestion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

