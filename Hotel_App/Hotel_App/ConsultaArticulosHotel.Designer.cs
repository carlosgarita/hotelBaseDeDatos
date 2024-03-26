namespace Hotel_App
{
    partial class ConsultaArticulosHotel
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dataGridViewArticulosAsignados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloAsignado_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloAsignado_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloAsignado_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulosAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(677, 387);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dataGridViewArticulosAsignados
            // 
            this.dataGridViewArticulosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Hotel,
            this.articuloAsignado_ID,
            this.articuloAsignado_Nombre,
            this.articuloAsignado_Precio});
            this.dataGridViewArticulosAsignados.Location = new System.Drawing.Point(36, 116);
            this.dataGridViewArticulosAsignados.Name = "dataGridViewArticulosAsignados";
            this.dataGridViewArticulosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulosAsignados.Size = new System.Drawing.Size(716, 242);
            this.dataGridViewArticulosAsignados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consulta de artículos por hotel";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hotel
            // 
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            // 
            // articuloAsignado_ID
            // 
            this.articuloAsignado_ID.HeaderText = "Artículo ID";
            this.articuloAsignado_ID.Name = "articuloAsignado_ID";
            // 
            // articuloAsignado_Nombre
            // 
            this.articuloAsignado_Nombre.HeaderText = "Articulo Nombre";
            this.articuloAsignado_Nombre.Name = "articuloAsignado_Nombre";
            // 
            // articuloAsignado_Precio
            // 
            this.articuloAsignado_Precio.HeaderText = "Articulo Precio";
            this.articuloAsignado_Precio.Name = "articuloAsignado_Precio";
            // 
            // ConsultaArticulosHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewArticulosAsignados);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "ConsultaArticulosHotel";
            this.Text = "Consulta Articulos Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulosAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dataGridViewArticulosAsignados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloAsignado_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloAsignado_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloAsignado_Precio;
    }
}