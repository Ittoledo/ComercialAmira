
namespace Presentation
{
    partial class UserView
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
            this.listUser = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.RadioButton();
            this.Consultar = new System.Windows.Forms.RadioButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.delartBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUser
            // 
            this.listUser.HideSelection = false;
            this.listUser.Location = new System.Drawing.Point(195, 93);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(653, 310);
            this.listUser.TabIndex = 0;
            this.listUser.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Consultar);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 69);
            this.panel1.TabIndex = 1;
            // 
            // Salir
            // 
            this.Salir.Appearance = System.Windows.Forms.Appearance.Button;
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Location = new System.Drawing.Point(880, 14);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(89, 44);
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = true;
            this.Salir.Text = "Cerrar Sesion";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.CheckedChanged += new System.EventHandler(this.Salir_CheckedChanged);
            // 
            // Consultar
            // 
            this.Consultar.Appearance = System.Windows.Forms.Appearance.Button;
            this.Consultar.Location = new System.Drawing.Point(38, 14);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(76, 44);
            this.Consultar.TabIndex = 0;
            this.Consultar.TabStop = true;
            this.Consultar.Text = "Consultar \r\n   Precio";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.CheckedChanged += new System.EventHandler(this.Consultar_CheckedChanged);
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(866, 376);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(100, 27);
            this.lblHora.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(605, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(243, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(62, 236);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 47);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Agregar Producto";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(20, 171);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(145, 23);
            this.txtDatos.TabIndex = 3;
            this.txtDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatos_KeyPress);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Tomato;
            this.cancelarBtn.Location = new System.Drawing.Point(614, 436);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(119, 64);
            this.cancelarBtn.TabIndex = 4;
            this.cancelarBtn.Text = "Cancelar\r\n   Venta";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.finalizarBtn.Location = new System.Drawing.Point(825, 423);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(131, 77);
            this.finalizarBtn.TabIndex = 5;
            this.finalizarBtn.Text = "Finalizar \r\n  Venta";
            this.finalizarBtn.UseVisualStyleBackColor = false;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(117, 207);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 23);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // delartBtn
            // 
            this.delartBtn.Location = new System.Drawing.Point(891, 93);
            this.delartBtn.Name = "delartBtn";
            this.delartBtn.Size = new System.Drawing.Size(75, 41);
            this.delartBtn.TabIndex = 9;
            this.delartBtn.Text = "Eliminar Articulo";
            this.delartBtn.UseVisualStyleBackColor = true;
            this.delartBtn.Click += new System.EventHandler(this.delartBtn_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.delartBtn);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listUser);
            this.Name = "UserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comercial Amira";
            this.Load += new System.EventHandler(this.UserView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Salir;
        private System.Windows.Forms.RadioButton Consultar;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button finalizarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button delartBtn;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}