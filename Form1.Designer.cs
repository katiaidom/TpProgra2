namespace TPFINAL_KATIADOMINGUES_PROGRAII
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
            this.lblNotflix = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblShame = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotflix
            // 
            this.lblNotflix.AutoSize = true;
            this.lblNotflix.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblNotflix.Location = new System.Drawing.Point(12, 9);
            this.lblNotflix.Name = "lblNotflix";
            this.lblNotflix.Size = new System.Drawing.Size(810, 95);
            this.lblNotflix.TabIndex = 0;
            this.lblNotflix.Text = "Bienvenido a Notflix!";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDatos.Location = new System.Drawing.Point(39, 108);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(488, 39);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Ingrese los datos de su cuenta:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDNI.Location = new System.Drawing.Point(23, 170);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 29);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblContra.Location = new System.Drawing.Point(28, 218);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(150, 29);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblShame
            // 
            this.lblShame.AutoSize = true;
            this.lblShame.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.lblShame.Location = new System.Drawing.Point(433, 301);
            this.lblShame.Name = "lblShame";
            this.lblShame.Size = new System.Drawing.Size(95, 15);
            this.lblShame.TabIndex = 9;
            this.lblShame.Text = "Shame on you...";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblRegistrarse.Location = new System.Drawing.Point(39, 277);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(375, 39);
            this.lblRegistrarse.TabIndex = 8;
            this.lblRegistrarse.Text = "Todavia no sos cliente?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(39, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Te vas? Te vamos a extrañar!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(241, 176);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(173, 22);
            this.txtDNI.TabIndex = 12;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(241, 224);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(173, 22);
            this.txtContra.TabIndex = 13;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(571, 188);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(163, 45);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegistrate.Location = new System.Drawing.Point(571, 277);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(163, 38);
            this.btnRegistrate.TabIndex = 15;
            this.btnRegistrate.Text = "Registrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalir.Location = new System.Drawing.Point(571, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 38);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 431);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShame);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblNotflix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotflix;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblShame;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.Button btnSalir;
    }
}

