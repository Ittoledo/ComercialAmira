
namespace Presentation
{
    partial class EditCompra
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
            this.cantidad = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(147, 38);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(122, 23);
            this.cantidad.TabIndex = 73;
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(147, 9);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(122, 23);
            this.precio.TabIndex = 72;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 66;
            this.label5.Text = "Precio:";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(154, 75);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 61;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptEdit
            // 
            this.aceptEdit.Location = new System.Drawing.Point(49, 75);
            this.aceptEdit.Name = "aceptEdit";
            this.aceptEdit.Size = new System.Drawing.Size(75, 23);
            this.aceptEdit.TabIndex = 60;
            this.aceptEdit.Text = "Aceptar";
            this.aceptEdit.UseVisualStyleBackColor = true;
            this.aceptEdit.Click += new System.EventHandler(this.aceptEdit_Click);
            // 
            // EditCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 113);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptEdit);
            this.Name = "EditCompra";
            this.Text = "EditCompra";
            this.Shown += new System.EventHandler(this.EditProd_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptEdit;
    }
}