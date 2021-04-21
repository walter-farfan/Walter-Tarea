
namespace CapaPresentacion
{
    partial class frmJefePractica
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
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnApruevaNotas = new System.Windows.Forms.Button();
            this.btnExplica = new System.Windows.Forms.Button();
            this.btnCalifica = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(84, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(124, 22);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(84, 127);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(124, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(84, 173);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(124, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(84, 227);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(124, 22);
            this.txtProfesion.TabIndex = 3;
            // 
            // btnApruevaNotas
            // 
            this.btnApruevaNotas.Location = new System.Drawing.Point(84, 324);
            this.btnApruevaNotas.Name = "btnApruevaNotas";
            this.btnApruevaNotas.Size = new System.Drawing.Size(124, 23);
            this.btnApruevaNotas.TabIndex = 4;
            this.btnApruevaNotas.Text = "ApruevaNotas";
            this.btnApruevaNotas.UseVisualStyleBackColor = true;
            this.btnApruevaNotas.Click += new System.EventHandler(this.btnApruevaNotas_Click);
            // 
            // btnExplica
            // 
            this.btnExplica.Location = new System.Drawing.Point(311, 323);
            this.btnExplica.Name = "btnExplica";
            this.btnExplica.Size = new System.Drawing.Size(75, 23);
            this.btnExplica.TabIndex = 5;
            this.btnExplica.Text = "Explica";
            this.btnExplica.UseVisualStyleBackColor = true;
            this.btnExplica.Click += new System.EventHandler(this.btnExplica_Click);
            // 
            // btnCalifica
            // 
            this.btnCalifica.Location = new System.Drawing.Point(507, 324);
            this.btnCalifica.Name = "btnCalifica";
            this.btnCalifica.Size = new System.Drawing.Size(75, 23);
            this.btnCalifica.TabIndex = 6;
            this.btnCalifica.Text = "Califica";
            this.btnCalifica.UseVisualStyleBackColor = true;
            this.btnCalifica.Click += new System.EventHandler(this.btnCalifica_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(302, 102);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(302, 172);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmJefePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnCalifica);
            this.Controls.Add(this.btnExplica);
            this.Controls.Add(this.btnApruevaNotas);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmJefePractica";
            this.Text = "JefePractica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Button btnApruevaNotas;
        private System.Windows.Forms.Button btnExplica;
        private System.Windows.Forms.Button btnCalifica;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}