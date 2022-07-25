
namespace Presentation
{
    partial class Consulta
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
            this.consultaBtn = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listprecio = new System.Windows.Forms.ListView();
            this.Precio = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // consultaBtn
            // 
            this.consultaBtn.Location = new System.Drawing.Point(165, 23);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(98, 41);
            this.consultaBtn.TabIndex = 8;
            this.consultaBtn.Text = "Consultar";
            this.consultaBtn.UseVisualStyleBackColor = true;
            this.consultaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(37, 41);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(100, 23);
            this.txtconsulta.TabIndex = 7;
            this.txtconsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconsulta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Producto";
            // 
            // listprecio
            // 
            this.listprecio.BackColor = System.Drawing.SystemColors.Control;
            this.listprecio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Precio,
            this.columnHeader1});
            this.listprecio.HideSelection = false;
            this.listprecio.Location = new System.Drawing.Point(41, 107);
            this.listprecio.Name = "listprecio";
            this.listprecio.Scrollable = false;
            this.listprecio.Size = new System.Drawing.Size(222, 70);
            this.listprecio.TabIndex = 9;
            this.listprecio.UseCompatibleStateImageBehavior = false;
            this.listprecio.View = System.Windows.Forms.View.Details;
            // 
            // Precio
            // 
            this.Precio.Text = "precio detalle";
            this.Precio.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "precio por mayor";
            this.columnHeader1.Width = 120;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.listprecio);
            this.Controls.Add(this.consultaBtn);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.label1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consultaBtn;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listprecio;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}