
namespace Presentation
{
    partial class EditProv
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
            this.aceptEdit = new System.Windows.Forms.Button();
            this.celular = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.rutUsr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(155, 131);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 58;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptEdit
            // 
            this.aceptEdit.Location = new System.Drawing.Point(50, 131);
            this.aceptEdit.Name = "aceptEdit";
            this.aceptEdit.Size = new System.Drawing.Size(75, 23);
            this.aceptEdit.TabIndex = 57;
            this.aceptEdit.Text = "Aceptar";
            this.aceptEdit.UseVisualStyleBackColor = true;
            this.aceptEdit.Click += new System.EventHandler(this.aceptEdit_Click);
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(147, 93);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(122, 23);
            this.celular.TabIndex = 55;
            this.celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celular_KeyPress);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(147, 64);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(122, 23);
            this.direccion.TabIndex = 54;
            // 
            // rutUsr
            // 
            this.rutUsr.Location = new System.Drawing.Point(147, 6);
            this.rutUsr.Name = "rutUsr";
            this.rutUsr.Size = new System.Drawing.Size(122, 23);
            this.rutUsr.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rut (1123456-1):";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(147, 35);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 60;
            // 
            // EditProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptEdit);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.rutUsr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProv";
            this.Text = "EditProv";
            this.Shown += new System.EventHandler(this.EditProv_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptEdit;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox rutUsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
    }
}