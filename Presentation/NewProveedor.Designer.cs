
namespace Presentation
{
    partial class NewProveedor
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
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptNuevo = new System.Windows.Forms.Button();
            this.celular = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.rutProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(152, 134);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 46;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptNuevo
            // 
            this.aceptNuevo.Location = new System.Drawing.Point(47, 134);
            this.aceptNuevo.Name = "aceptNuevo";
            this.aceptNuevo.Size = new System.Drawing.Size(75, 23);
            this.aceptNuevo.TabIndex = 45;
            this.aceptNuevo.Text = "Aceptar";
            this.aceptNuevo.UseVisualStyleBackColor = true;
            this.aceptNuevo.Click += new System.EventHandler(this.aceptNuevo_Click);
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(147, 94);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(122, 23);
            this.celular.TabIndex = 43;
            this.celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celular_KeyPress);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(147, 65);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(122, 23);
            this.direccion.TabIndex = 42;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(147, 36);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 41;
            // 
            // rutProv
            // 
            this.rutProv.Location = new System.Drawing.Point(147, 6);
            this.rutProv.Name = "rutProv";
            this.rutProv.Size = new System.Drawing.Size(122, 23);
            this.rutProv.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Celular (9 1234 1234):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rut (1123456-1):";
            // 
            // NewProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 164);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptNuevo);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.rutProv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewProveedor";
            this.Text = "Nuevo Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptNuevo;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox rutProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}