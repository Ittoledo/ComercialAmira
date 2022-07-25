
namespace Presentation
{
    partial class EditUsr
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
            this.tipoUsr = new System.Windows.Forms.ComboBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.rutUsr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(152, 137);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 47;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptEdit
            // 
            this.aceptEdit.Location = new System.Drawing.Point(47, 137);
            this.aceptEdit.Name = "aceptEdit";
            this.aceptEdit.Size = new System.Drawing.Size(75, 23);
            this.aceptEdit.TabIndex = 46;
            this.aceptEdit.Text = "Aceptar";
            this.aceptEdit.UseVisualStyleBackColor = true;
            this.aceptEdit.Click += new System.EventHandler(this.aceptEdit_Click);
            // 
            // tipoUsr
            // 
            this.tipoUsr.FormattingEnabled = true;
            this.tipoUsr.Location = new System.Drawing.Point(144, 41);
            this.tipoUsr.Name = "tipoUsr";
            this.tipoUsr.Size = new System.Drawing.Size(122, 23);
            this.tipoUsr.TabIndex = 45;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(144, 99);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(122, 23);
            this.apellido.TabIndex = 41;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(144, 70);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 40;
            // 
            // rutUsr
            // 
            this.rutUsr.Location = new System.Drawing.Point(144, 12);
            this.rutUsr.Name = "rutUsr";
            this.rutUsr.Size = new System.Drawing.Size(122, 23);
            this.rutUsr.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tipo Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Rut (1123456-1):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cambiar Contrasena";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptEdit);
            this.Controls.Add(this.tipoUsr);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.rutUsr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUsr";
            this.Text = "EditUsr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditUsr_FormClosed);
            this.Load += new System.EventHandler(this.EditUsr_Load);
            this.Shown += new System.EventHandler(this.EditUsr_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptEdit;
        private System.Windows.Forms.ComboBox tipoUsr;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox rutUsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}