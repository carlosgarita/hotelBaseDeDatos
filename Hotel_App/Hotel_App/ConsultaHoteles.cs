using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * UNED III Cuatrimestre 2024
 * Proyecto 01: Sistema de gestión de hoteles
 * Estudiante: Carlos Daniel Garita Porras
 * Fecha: 24/02/24
*/

namespace Hotel_App
{
    public partial class ConsultaHoteles : Form
    {
        public ConsultaHoteles()
        {
            InitializeComponent();

            foreach (Hotel hotel in MenuPrincipal.hotelesRegistrados)
            {
                if (hotel != null)
                {
                    int id = hotel.GetId();
                    string nombre = hotel.GetNombre();
                    string direccion = hotel.GetDireccion();
                    bool estado = hotel.GetEstado();

                    string estadoString;

                    if (estado)
                    {
                        estadoString = "Activo";
                    }
                    else
                    {
                        estadoString = "Inactivo";
                    }

                    string telefono = hotel.GetTelefono();

                    dataGridViewHoteles.Rows.Add(id, nombre, direccion, estadoString, telefono);
                }
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
