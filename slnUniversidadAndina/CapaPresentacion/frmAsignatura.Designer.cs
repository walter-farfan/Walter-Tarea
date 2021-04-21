
namespace CapaPresentacion
{
    partial class frmAsignatura
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnExposiciones = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(94, 127);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(121, 22);
            this.txtProfesor.TabIndex = 1;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(94, 178);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(121, 22);
            this.txtUnidades.TabIndex = 2;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(94, 231);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(121, 22);
            this.txtCreditos.TabIndex = 3;
            // 
            // btnTareas
            // 
            this.btnTareas.Location = new System.Drawing.Point(133, 332);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(75, 23);
            this.btnTareas.TabIndex = 4;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnExposiciones
            // 
            this.btnExposiciones.Location = new System.Drawing.Point(310, 332);
            this.btnExposiciones.Name = "btnExposiciones";
            this.btnExposiciones.Size = new System.Drawing.Size(102, 23);
            this.btnExposiciones.TabIndex = 5;
            this.btnExposiciones.Text = "Exposiciones";
            this.btnExposiciones.UseVisualStyleBackColor = true;
            this.btnExposiciones.Click += new System.EventHandler(this.btnExposiciones_Click);
            // 
            // btnExamenes
            // 
            this.btnExamenes.Location = new System.Drawing.Point(465, 332);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(105, 23);
            this.btnExamenes.TabIndex = 6;
            this.btnExamenes.Text = "Examenes";
            this.btnExamenes.UseVisualStyleBackColor = true;
            this.btnExamenes.Click += new System.EventHandler(this.btnExamenes_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(337, 86);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(337, 161);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnExamenes);
            this.Controls.Add(this.btnExposiciones);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAsignatura";
            this.Text = "Asignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnExposiciones;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}