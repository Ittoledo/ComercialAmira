
namespace Presentation
{
    partial class CambiarPass
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
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(149, 79);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 53;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptEdit
            // 
            this.aceptEdit.Location = new System.Drawing.Point(44, 79);
            this.aceptEdit.Name = "aceptEdit";
            this.aceptEdit.Size = new System.Drawing.Size(75, 23);
            this.aceptEdit.TabIndex = 52;
            this.aceptEdit.Text = "Aceptar";
            this.aceptEdit.UseVisualStyleBackColor = true;
            this.aceptEdit.Click += new System.EventHandler(this.aceptEdit_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(144, 40);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(122, 23);
            this.pass2.TabIndex = 51;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(144, 11);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(122, 23);
            this.pass1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Confirmar Contrasena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Contrasena Nueva: ";
            // 
            // CambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 115);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptEdit);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CambiarPass";
            this.Text = "CambiarPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptEdit;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}