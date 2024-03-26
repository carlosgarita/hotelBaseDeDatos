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
    public partial class ConsultaCategoria : Form
    {
        public ConsultaCategoria()
        {
            InitializeComponent();

            foreach (Categoria categoria in MenuPrincipal.categoriasRegistradas)
            {
                if (categoria != null)
                {
                    int id = categoria.GetId();
                    string descripcion = categoria.GetDescripcion();
                    bool estado = categoria.GetEstado();

                    string estadoString;

                    if (estado)
                    {
                        estadoString = "Activo";
                    }
                    else
                    {
                        estadoString = "Inactivo";
                    }

                    dataGridViewCategorias.Rows.Add(id, descripcion, estadoString);
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
