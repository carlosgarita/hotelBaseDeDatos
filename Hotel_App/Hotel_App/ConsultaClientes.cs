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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();

            foreach (Cliente cliente in MenuPrincipal.clientesRegistrados)
            {
                if (cliente != null)
                {
                    string id = cliente.GetID();
                    string nombre = cliente.GetNombre();
                    string apellido1 = cliente.GetApellido1();
                    string apellido2 = cliente.GetApellido2();
                    DateTime fechaNacimiento = cliente.GetFechaNacimiento();
                    char genero = cliente.GetGenero();


                    dataGridViewClientes.Rows.Add(id, nombre, apellido1, apellido2,
                                                  fechaNacimiento, genero);
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
