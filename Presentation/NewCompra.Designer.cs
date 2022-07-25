
namespace Presentation
{
    partial class NewCompra
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
            this.rutUsr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(175, 42);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 46;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptNuevo
            // 
            this.aceptNuevo.Location = new System.Drawing.Point(70, 42);
            this.aceptNuevo.Name = "aceptNuevo";
            this.aceptNuevo.Size = new System.Drawing.Size(75, 23);
            this.aceptNuevo.TabIndex = 45;
            this.aceptNuevo.Text = "Aceptar";
            this.aceptNuevo.UseVisualStyleBackColor = true;
            this.aceptNuevo.Click += new System.EventHandler(this.aceptNuevo_Click);
            // 
            // rutUsr
            // 
            this.rutUsr.Location = new System.Drawing.Point(167, 6);
            this.rutUsr.Name = "rutUsr";
            this.rutUsr.Size = new System.Drawing.Size(122, 23);
            this.rutUsr.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rut Proveedor (1123456-1):";
            // 
            // NewCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 78);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptNuevo);
            this.Controls.Add(this.rutUsr);
            this.Controls.Add(this.label1);
            this.Name = "NewCompra";
            this.Text = "NewCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptNuevo;
        private System.Windows.Forms.TextBox rutUsr;
        private System.Windows.Forms.Label label1;
    }
}