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
    public partial class RegistroHotel : Form
    {
        public RegistroHotel()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos

                if (string.IsNullOrEmpty(txt_id.Text) || 
                    string.IsNullOrEmpty(txt_nombreHotel.Text) || 
                    string.IsNullOrEmpty(txt_direccion.Text) ||
                    string.IsNullOrEmpty(txt_telefono.Text) ||
                    string.IsNullOrEmpty(txt_telefono.Text))
                {
                    throw new Exception("Por favor llenar todos los campos.");
                }

                // Validación de estado seleccionado

                if (combobox_estado.SelectedItem == null)
                {
                    throw new Exception("Por favor elija un estado.");
                }

                //Validacion numero entero

                int idHotel;
                if (!int.TryParse(txt_id.Text, out idHotel))
                {
                    throw new Exception("El campo ID debe ser un número entero.");
                }

                //Validacion de ID repetido

                for (int j=0; j < MenuPrincipal.contadorHotel; j++)
                {
                    if (MenuPrincipal.hotelesRegistrados[j] != null && idHotel == MenuPrincipal.hotelesRegistrados[j].GetId())
                    {
                        throw new Exception("El ID ingresado ya existe.");
                    }
                }             

                // Obtener estado seleccionado

                bool estadoSeleccionado;
                if (combobox_estado.SelectedItem.ToString() == "Activo")
                {
                    estadoSeleccionado = true;
                }
                else
                {
                    estadoSeleccionado = false;
                }

                // Crear nuevo hotel

                Hotel nuevoHotel = new Hotel(idHotel, 
                                             txt_nombreHotel.Text, 
                                             txt_direccion.Text, 
                                             estadoSeleccionado, 
                                             txt_telefono.Text);

                //Crear array de hoteles si no existe

                if (MenuPrincipal.hotelesRegistrados == null)
                {
                    MenuPrincipal.hotelesRegistrados = new Hotel[20];
                }

                // Buscar el primer espacio disponible en el array

                int indice = Array.IndexOf(MenuPrincipal.hotelesRegistrados, null);
                if (indice >= 0)
                {
                    // Guardar hotel en el array de 20 hoteles

                    MenuPrincipal.hotelesRegistrados[indice] = nuevoHotel;
                    MenuPrincipal.contadorHotel++;
                    MessageBox.Show("Hotel guardado exitosamente.");

                    // Limpiar campos

                    txt_id.Text = "";
                    txt_nombreHotel.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    combobox_estado.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay más espacio disponible para agregar hoteles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
