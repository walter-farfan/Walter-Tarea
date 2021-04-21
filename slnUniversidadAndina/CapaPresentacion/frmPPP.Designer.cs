
namespace CapaPresentacion
{
    partial class frmPPP
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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNroMeses = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnGanarExperiencia = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnAplicarConocimientos = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(84, 56);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(122, 22);
            this.txtEmpresa.TabIndex = 0;
            // 
            // txtNroMeses
            // 
            this.txtNroMeses.Location = new System.Drawing.Point(84, 105);
            this.txtNroMeses.Name = "txtNroMeses";
            this.txtNroMeses.Size = new System.Drawing.Size(122, 22);
            this.txtNroMeses.TabIndex = 1;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(84, 159);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(122, 22);
            this.txtProfesion.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(84, 204);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(122, 22);
            this.txtArea.TabIndex = 3;
            // 
            // btnGanarExperiencia
            // 
            this.btnGanarExperiencia.Location = new System.Drawing.Point(84, 292);
            this.btnGanarExperiencia.Name = "btnGanarExperiencia";
            this.btnGanarExperiencia.Size = new System.Drawing.Size(138, 23);
            this.btnGanarExperiencia.TabIndex = 4;
            this.btnGanarExperiencia.Text = "Ganar Experiencia";
            this.btnGanarExperiencia.UseVisualStyleBackColor = true;
            this.btnGanarExperiencia.Click += new System.EventHandler(this.btnGanarExperiencia_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(290, 292);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 5;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnAplicarConocimientos
            // 
            this.btnAplicarConocimientos.Location = new System.Drawing.Point(414, 292);
            this.btnAplicarConocimientos.Name = "btnAplicarConocimientos";
            this.btnAplicarConocimientos.Size = new System.Drawing.Size(172, 23);
            this.btnAplicarConocimientos.TabIndex = 6;
            this.btnAplicarConocimientos.Text = "Aplicar Conociemientos";
            this.btnAplicarConocimientos.UseVisualStyleBackColor = true;
            this.btnAplicarConocimientos.Click += new System.EventHandler(this.btnAplicarConocimientos_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(318, 78);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(318, 141);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAplicarConocimientos);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnGanarExperiencia);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtNroMeses);
            this.Controls.Add(this.txtEmpresa);
            this.Name = "frmPPP";
            this.Text = "PPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNroMeses;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnGanarExperiencia;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnAplicarConocimientos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}