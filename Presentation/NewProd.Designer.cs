
namespace Presentation
{
    partial class NewProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idProd = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.ppcu = new System.Windows.Forms.TextBox();
            this.ppm = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.tipoProd = new System.Windows.Forms.ComboBox();
            this.aceptNuevo = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.newCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio por Unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio por Mayor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // idProd
            // 
            this.idProd.Location = new System.Drawing.Point(147, 16);
            this.idProd.Name = "idProd";
            this.idProd.Size = new System.Drawing.Size(122, 23);
            this.idProd.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(147, 74);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 8;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(147, 103);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(122, 23);
            this.descripcion.TabIndex = 9;
            // 
            // ppcu
            // 
            this.ppcu.Location = new System.Drawing.Point(147, 132);
            this.ppcu.Name = "ppcu";
            this.ppcu.Size = new System.Drawing.Size(122, 23);
            this.ppcu.TabIndex = 10;
            this.ppcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ppcu_KeyPress);
            // 
            // ppm
            // 
            this.ppm.Location = new System.Drawing.Point(147, 161);
            this.ppm.Name = "ppm";
            this.ppm.Size = new System.Drawing.Size(122, 23);
            this.ppm.TabIndex = 11;
            this.ppm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ppm_KeyPress);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(147, 190);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(122, 23);
            this.stock.TabIndex = 12;
            this.stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_KeyPress);
            // 
            // tipoProd
            // 
            this.tipoProd.FormattingEnabled = true;
            this.tipoProd.Location = new System.Drawing.Point(147, 45);
            this.tipoProd.Name = "tipoProd";
            this.tipoProd.Size = new System.Drawing.Size(122, 23);
            this.tipoProd.TabIndex = 13;
            // 
            // aceptNuevo
            // 
            this.aceptNuevo.Location = new System.Drawing.Point(56, 238);
            this.aceptNuevo.Name = "aceptNuevo";
            this.aceptNuevo.Size = new System.Drawing.Size(75, 23);
            this.aceptNuevo.TabIndex = 14;
            this.aceptNuevo.Text = "Aceptar";
            this.aceptNuevo.UseVisualStyleBackColor = true;
            this.aceptNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(161, 238);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 15;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // newCat
            // 
            this.newCat.Location = new System.Drawing.Point(276, 45);
            this.newCat.Name = "newCat";
            this.newCat.Size = new System.Drawing.Size(52, 23);
            this.newCat.TabIndex = 16;
            this.newCat.Text = "Nueva";
            this.newCat.UseVisualStyleBackColor = true;
            this.newCat.Click += new System.EventHandler(this.newCat_Click);
            // 
            // NewProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 273);
            this.Controls.Add(this.newCat);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptNuevo);
            this.Controls.Add(this.tipoProd);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.ppm);
            this.Controls.Add(this.ppcu);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.idProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProd";
            this.Text = "Nuevo Producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewProd_FormClosed);
            this.Load += new System.EventHandler(this.NewProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idProd;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox ppcu;
        private System.Windows.Forms.TextBox ppm;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.ComboBox tipoProd;
        private System.Windows.Forms.Button aceptNuevo;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button newCat;
    }
}