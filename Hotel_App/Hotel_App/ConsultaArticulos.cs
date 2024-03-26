using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

/*
 * UNED III Cuatrimestre 2024
 * Proyecto 01: Sistema de gestión de hoteles
 * Estudiante: Carlos Daniel Garita Porras
 * Fecha: 24/02/24
*/

namespace Hotel_App
{
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();

            foreach (Articulo articulo in MenuPrincipal.articulosRegistrados)
            {
                if (articulo != null)
                {
                    int id = articulo.GetID();
                    string nombre = articulo.GetNombre();
                    int precio = articulo.GetPrecio();
                    Categoria categoria = articulo.GetCategoria();

                    // Verificar si la categoría es null antes de intentar acceder a su ID
                    if (categoria != null)
                    {
                        dataGridView_articulos.Rows.Add(id, nombre, precio, categoria.GetId());
                    }
                    else
                    {
                        // Si la categoría es null, agregar un valor predeterminado o manejarlo según lo necesario
                        dataGridView_articulos.Rows.Add(id, nombre, precio, "Categoría no disponible");
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
