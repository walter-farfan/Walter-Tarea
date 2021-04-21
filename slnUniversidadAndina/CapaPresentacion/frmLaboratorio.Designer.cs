
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtMateriales = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnExperimentos = new System.Windows.Forms.Button();
            this.btnPracticas = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(105, 72);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(138, 22);
            this.txtNombreCurso.TabIndex = 0;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(105, 124);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(138, 22);
            this.txtProfesor.TabIndex = 1;
            // 
            // txtMateriales
            // 
            this.txtMateriales.Location = new System.Drawing.Point(105, 183);
            this.txtMateriales.Name = "txtMateriales";
            this.txtMateriales.Size = new System.Drawing.Size(138, 22);
            this.txtMateriales.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(105, 241);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(138, 22);
            this.txtUbicacion.TabIndex = 3;
            // 
            // btnClases
            // 
            this.btnClases.Location = new System.Drawing.Point(119, 339);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(75, 23);
            this.btnClases.TabIndex = 4;
            this.btnClases.Text = "Clases";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnExperimentos
            // 
            this.btnExperimentos.Location = new System.Drawing.Point(261, 339);
            this.btnExperimentos.Name = "btnExperimentos";
            this.btnExperimentos.Size = new System.Drawing.Size(114, 23);
            this.btnExperimentos.TabIndex = 5;
            this.btnExperimentos.Text = "Experimentos";
            this.btnExperimentos.UseVisualStyleBackColor = true;
            this.btnExperimentos.Click += new System.EventHandler(this.btnExperimentos_Click);
            // 
            // btnPracticas
            // 
            this.btnPracticas.Location = new System.Drawing.Point(421, 339);
            this.btnPracticas.Name = "btnPracticas";
            this.btnPracticas.Size = new System.Drawing.Size(75, 23);
            this.btnPracticas.TabIndex = 6;
            this.btnPracticas.Text = "Practicas";
            this.btnPracticas.UseVisualStyleBackColor = true;
            this.btnPracticas.Click += new System.EventHandler(this.btnPracticas_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(330, 123);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(330, 183);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnPracticas);
            this.Controls.Add(this.btnExperimentos);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtMateriales);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.txtNombreCurso);
            this.Name = "frmLaboratorio";
            this.Text = "Laboratorio";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtMateriales;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnExperimentos;
        private System.Windows.Forms.Button btnPracticas;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}