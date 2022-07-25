
namespace Presentation
{
    partial class VentasView
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
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.listCompras = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(12, 50);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 32);
            this.delete.TabIndex = 5;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(12, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 32);
            this.edit.TabIndex = 4;
            this.edit.Text = "Editar";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // listCompras
            // 
            this.listCompras.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCompras.HideSelection = false;
            this.listCompras.Location = new System.Drawing.Point(119, 12);
            this.listCompras.MultiSelect = false;
            this.listCompras.Name = "listCompras";
            this.listCompras.Size = new System.Drawing.Size(669, 426);
            this.listCompras.TabIndex = 3;
            this.listCompras.UseCompatibleStateImageBehavior = false;
            // 
            // VentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.listCompras);
            this.Name = "VentasView";
            this.Text = "VentasView";
            this.Load += new System.EventHandler(this.ViewCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ListView listCompras;
    }
}