namespace SistemaVentas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategorias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(101, 268);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(232, 144);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorías\n";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Gestión Comercial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(516, 268);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(225, 144);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos\n";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(101, 470);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(232, 134);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes\n";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(516, 484);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(243, 120);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 774);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategorias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
    }
}

