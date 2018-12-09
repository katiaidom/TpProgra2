namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    partial class Form4
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtContras = new System.Windows.Forms.TextBox();
            this.checkBoxterminos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(724, 85);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bienvenido a Notflix!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(14, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ingrese los siguientes datos:";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(210, 335);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(196, 38);
            this.btnRegistro.TabIndex = 13;
            this.btnRegistro.Text = "Registrarme!";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(14, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Llegaste aca por error?";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(450, 409);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 55);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Regresar a la pagina inicial";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(23, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contraseña:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(210, 188);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(196, 22);
            this.txtDni.TabIndex = 18;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtContras
            // 
            this.txtContras.Location = new System.Drawing.Point(210, 247);
            this.txtContras.Name = "txtContras";
            this.txtContras.Size = new System.Drawing.Size(196, 22);
            this.txtContras.TabIndex = 19;
            // 
            // checkBoxterminos
            // 
            this.checkBoxterminos.AutoSize = true;
            this.checkBoxterminos.Location = new System.Drawing.Point(68, 286);
            this.checkBoxterminos.Name = "checkBoxterminos";
            this.checkBoxterminos.Size = new System.Drawing.Size(544, 21);
            this.checkBoxterminos.TabIndex = 20;
            this.checkBoxterminos.Text = "Acepto vender mi alma al diablo para ver peliculas de gatitos cayendo de la cama";
            this.checkBoxterminos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxterminos.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 488);
            this.Controls.Add(this.checkBoxterminos);
            this.Controls.Add(this.txtContras);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtContras;
        private System.Windows.Forms.CheckBox checkBoxterminos;
    }
}