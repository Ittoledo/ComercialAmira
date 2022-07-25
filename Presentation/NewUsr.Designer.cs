
namespace Presentation
{
    partial class NewUsr
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
            this.tipoUsr = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.rutUsr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(161, 200);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 32;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptNuevo
            // 
            this.aceptNuevo.Location = new System.Drawing.Point(56, 200);
            this.aceptNuevo.Name = "aceptNuevo";
            this.aceptNuevo.Size = new System.Drawing.Size(75, 23);
            this.aceptNuevo.TabIndex = 31;
            this.aceptNuevo.Text = "Aceptar";
            this.aceptNuevo.UseVisualStyleBackColor = true;
            this.aceptNuevo.Click += new System.EventHandler(this.aceptNuevo_Click);
            // 
            // tipoUsr
            // 
            this.tipoUsr.FormattingEnabled = true;
            this.tipoUsr.Location = new System.Drawing.Point(153, 41);
            this.tipoUsr.Name = "tipoUsr";
            this.tipoUsr.Size = new System.Drawing.Size(122, 23);
            this.tipoUsr.TabIndex = 30;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(153, 128);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(122, 23);
            this.pass.TabIndex = 27;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(153, 99);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(122, 23);
            this.apellido.TabIndex = 26;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(153, 70);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 25;
            // 
            // rutUsr
            // 
            this.rutUsr.Location = new System.Drawing.Point(153, 12);
            this.rutUsr.Name = "rutUsr";
            this.rutUsr.Size = new System.Drawing.Size(122, 23);
            this.rutUsr.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Contrasena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rut (1123456-1):";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(153, 159);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(122, 23);
            this.pass2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Confirmar Contrasena:";
            // 
            // NewUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 248);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptNuevo);
            this.Controls.Add(this.tipoUsr);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.rutUsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUsr";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.NewUsr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptNuevo;
        private System.Windows.Forms.ComboBox tipoUsr;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox rutUsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label6;
    }
}