
namespace CapaPresentacion
{
    partial class frmRector
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnDarDeclaraciones = new System.Windows.Forms.Button();
            this.btnLiderarUniversidad = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(78, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 22);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(78, 109);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(132, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(78, 157);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(132, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(78, 200);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(132, 22);
            this.txtLugarNacimiento.TabIndex = 3;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(78, 246);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(132, 22);
            this.txtProfesion.TabIndex = 4;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Location = new System.Drawing.Point(113, 326);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(97, 23);
            this.btnAdministrar.TabIndex = 5;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnDarDeclaraciones
            // 
            this.btnDarDeclaraciones.Location = new System.Drawing.Point(258, 326);
            this.btnDarDeclaraciones.Name = "btnDarDeclaraciones";
            this.btnDarDeclaraciones.Size = new System.Drawing.Size(137, 23);
            this.btnDarDeclaraciones.TabIndex = 6;
            this.btnDarDeclaraciones.Text = "DarDeclaraciones";
            this.btnDarDeclaraciones.UseVisualStyleBackColor = true;
            this.btnDarDeclaraciones.Click += new System.EventHandler(this.btnDarDeclaraciones_Click);
            // 
            // btnLiderarUniversidad
            // 
            this.btnLiderarUniversidad.Location = new System.Drawing.Point(444, 326);
            this.btnLiderarUniversidad.Name = "btnLiderarUniversidad";
            this.btnLiderarUniversidad.Size = new System.Drawing.Size(169, 23);
            this.btnLiderarUniversidad.TabIndex = 7;
            this.btnLiderarUniversidad.Text = "Liderar Universidad";
            this.btnLiderarUniversidad.UseVisualStyleBackColor = true;
            this.btnLiderarUniversidad.Click += new System.EventHandler(this.btnLiderarUniversidad_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(355, 85);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(355, 133);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 9;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnLiderarUniversidad);
            this.Controls.Add(this.btnDarDeclaraciones);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmRector";
            this.Text = "Rector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnDarDeclaraciones;
        private System.Windows.Forms.Button btnLiderarUniversidad;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}