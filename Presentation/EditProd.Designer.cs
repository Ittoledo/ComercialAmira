
namespace Presentation
{
    partial class EditProd
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
            this.tipoProd = new System.Windows.Forms.ComboBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.ppm = new System.Windows.Forms.TextBox();
            this.ppcu = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.idProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(157, 236);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 31;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptEdit
            // 
            this.aceptEdit.Location = new System.Drawing.Point(52, 236);
            this.aceptEdit.Name = "aceptEdit";
            this.aceptEdit.Size = new System.Drawing.Size(75, 23);
            this.aceptEdit.TabIndex = 30;
            this.aceptEdit.Text = "Aceptar";
            this.aceptEdit.UseVisualStyleBackColor = true;
            this.aceptEdit.Click += new System.EventHandler(this.aceptEdit_Click);
            // 
            // tipoProd
            // 
            this.tipoProd.FormattingEnabled = true;
            this.tipoProd.Location = new System.Drawing.Point(143, 43);
            this.tipoProd.Name = "tipoProd";
            this.tipoProd.Size = new System.Drawing.Size(122, 23);
            this.tipoProd.TabIndex = 29;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(143, 188);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(122, 23);
            this.stock.TabIndex = 28;
            // 
            // ppm
            // 
            this.ppm.Location = new System.Drawing.Point(143, 159);
            this.ppm.Name = "ppm";
            this.ppm.Size = new System.Drawing.Size(122, 23);
            this.ppm.TabIndex = 27;
            // 
            // ppcu
            // 
            this.ppcu.Location = new System.Drawing.Point(143, 130);
            this.ppcu.Name = "ppcu";
            this.ppcu.Size = new System.Drawing.Size(122, 23);
            this.ppcu.TabIndex = 26;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(143, 101);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(122, 23);
            this.descripcion.TabIndex = 25;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(143, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 23);
            this.nombre.TabIndex = 24;
            // 
            // idProd
            // 
            this.idProd.Location = new System.Drawing.Point(143, 14);
            this.idProd.Name = "idProd";
            this.idProd.Size = new System.Drawing.Size(122, 23);
            this.idProd.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio por Mayor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio por Unidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Producto:";
            // 
            // EditProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 273);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptEdit);
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
            this.Name = "EditProd";
            this.Text = "Editar Producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProd_FormClosed);
            this.Load += new System.EventHandler(this.EditProd_Load);
            this.Shown += new System.EventHandler(this.EditProd_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptEdit;
        private System.Windows.Forms.ComboBox tipoProd;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox ppm;
        private System.Windows.Forms.TextBox ppcu;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox idProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}