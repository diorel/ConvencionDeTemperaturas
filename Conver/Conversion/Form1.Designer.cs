namespace Conversion
{
    partial class Conver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conver));
            this.etGradosC = new System.Windows.Forms.Label();
            this.etGradosF = new System.Windows.Forms.Label();
            this.ctGradosC = new System.Windows.Forms.TextBox();
            this.ctGradosF = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etGradosC
            // 
            this.etGradosC.AutoSize = true;
            this.etGradosC.Location = new System.Drawing.Point(12, 33);
            this.etGradosC.Name = "etGradosC";
            this.etGradosC.Size = new System.Drawing.Size(103, 13);
            this.etGradosC.TabIndex = 0;
            this.etGradosC.Text = "Grados Centigrados:";
            // 
            // etGradosF
            // 
            this.etGradosF.AutoSize = true;
            this.etGradosF.Location = new System.Drawing.Point(13, 76);
            this.etGradosF.Name = "etGradosF";
            this.etGradosF.Size = new System.Drawing.Size(97, 13);
            this.etGradosF.TabIndex = 1;
            this.etGradosF.Text = "Grados Fahrenheit:";
            // 
            // ctGradosC
            // 
            this.ctGradosC.Location = new System.Drawing.Point(121, 33);
            this.ctGradosC.Name = "ctGradosC";
            this.ctGradosC.Size = new System.Drawing.Size(233, 20);
            this.ctGradosC.TabIndex = 2;
            this.ctGradosC.Text = "0.00";
            this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctGradosC_KeyPress);
            // 
            // ctGradosF
            // 
            this.ctGradosF.Location = new System.Drawing.Point(121, 69);
            this.ctGradosF.Name = "ctGradosF";
            this.ctGradosF.Size = new System.Drawing.Size(233, 20);
            this.ctGradosF.TabIndex = 3;
            this.ctGradosF.Text = "0.00";
            this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctGradosF_KeyPress);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(190, 116);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(164, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // Conver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(385, 178);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.ctGradosF);
            this.Controls.Add(this.ctGradosC);
            this.Controls.Add(this.etGradosF);
            this.Controls.Add(this.etGradosC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Conver";
            this.Text = "Conversion de Temperaturas";
            this.Load += new System.EventHandler(this.Conver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etGradosC;
        private System.Windows.Forms.Label etGradosF;
        private System.Windows.Forms.TextBox ctGradosC;
        private System.Windows.Forms.TextBox ctGradosF;
        private System.Windows.Forms.Button btAceptar;
    }
}

