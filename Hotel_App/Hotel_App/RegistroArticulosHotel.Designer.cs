namespace Hotel_App
{
    partial class RegistroArticulosHotel
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
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.comboBox_HotelesActivos = new System.Windows.Forms.ComboBox();
            this.dataGridView_ArticulosRegistrados = new System.Windows.Forms.DataGridView();
            this.txt_idAsignacion = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_articulosAsociados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.asociados_idAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asociados_IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asociados_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asociados_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ArticulosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulosAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(672, 415);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Location = new System.Drawing.Point(713, 271);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_Asignar.TabIndex = 1;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = true;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // comboBox_HotelesActivos
            // 
            this.comboBox_HotelesActivos.FormattingEnabled = true;
            this.comboBox_HotelesActivos.Location = new System.Drawing.Point(161, 173);
            this.comboBox_HotelesActivos.Name = "comboBox_HotelesActivos";
            this.comboBox_HotelesActivos.Size = new System.Drawing.Size(180, 21);
            this.comboBox_HotelesActivos.TabIndex = 2;
            // 
            // dataGridView_ArticulosRegistrados
            // 
            this.dataGridView_ArticulosRegistrados.AllowUserToAddRows = false;
            this.dataGridView_ArticulosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ArticulosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Categoria});
            this.dataGridView_ArticulosRegistrados.Location = new System.Drawing.Point(378, 127);
            this.dataGridView_ArticulosRegistrados.Name = "dataGridView_ArticulosRegistrados";
            this.dataGridView_ArticulosRegistrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ArticulosRegistrados.Size = new System.Drawing.Size(410, 126);
            this.dataGridView_ArticulosRegistrados.TabIndex = 3;
            // 
            // txt_idAsignacion
            // 
            this.txt_idAsignacion.Location = new System.Drawing.Point(161, 101);
            this.txt_idAsignacion.Name = "txt_idAsignacion";
            this.txt_idAsignacion.Size = new System.Drawing.Size(180, 20);
            this.txt_idAsignacion.TabIndex = 5;
            // 
            // dateTimePicker_FechaAsignacion
            // 
            this.dateTimePicker_FechaAsignacion.Location = new System.Drawing.Point(161, 139);
            this.dateTimePicker_FechaAsignacion.Name = "dateTimePicker_FechaAsignacion";
            this.dateTimePicker_FechaAsignacion.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker_FechaAsignacion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID de Asignación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Asignación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hoteles Activos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Artículos Registrados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registro de artículos por hotel";
            // 
            // dataGridView_articulosAsociados
            // 
            this.dataGridView_articulosAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_articulosAsociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asociados_idAsignacion,
            this.asociados_IdArticulo,
            this.asociados_nombre,
            this.asociados_precio});
            this.dataGridView_articulosAsociados.Location = new System.Drawing.Point(44, 271);
            this.dataGridView_articulosAsociados.Name = "dataGridView_articulosAsociados";
            this.dataGridView_articulosAsociados.Size = new System.Drawing.Size(449, 141);
            this.dataGridView_articulosAsociados.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Articulos asociados:";
            // 
            // asociados_idAsignacion
            // 
            this.asociados_idAsignacion.HeaderText = "ID Asignacion";
            this.asociados_idAsignacion.Name = "asociados_idAsignacion";
            // 
            // asociados_IdArticulo
            // 
            this.asociados_IdArticulo.HeaderText = "ID Articulo";
            this.asociados_IdArticulo.Name = "asociados_IdArticulo";
            // 
            // asociados_nombre
            // 
            this.asociados_nombre.HeaderText = "Nombre";
            this.asociados_nombre.Name = "asociados_nombre";
            // 
            // asociados_precio
            // 
            this.asociados_precio.HeaderText = "Precio";
            this.asociados_precio.Name = "asociados_precio";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // RegistroArticulosHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_articulosAsociados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_FechaAsignacion);
            this.Controls.Add(this.txt_idAsignacion);
            this.Controls.Add(this.dataGridView_ArticulosRegistrados);
            this.Controls.Add(this.comboBox_HotelesActivos);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "RegistroArticulosHotel";
            this.Text = "Registro Articulos Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ArticulosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_articulosAsociados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Asignar;
        private System.Windows.Forms.ComboBox comboBox_HotelesActivos;
        private System.Windows.Forms.DataGridView dataGridView_ArticulosRegistrados;
        private System.Windows.Forms.TextBox txt_idAsignacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaAsignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_articulosAsociados;
        private System.Windows.Forms.DataGridViewTextBoxColumn asociados_idAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn asociados_IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn asociados_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn asociados_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}