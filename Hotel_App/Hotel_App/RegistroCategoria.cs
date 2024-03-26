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
    public partial class RegistroCategoria : Form
    {
        public RegistroCategoria()
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
                //Validacion campos vacios

                if (string.IsNullOrEmpty(txt_id.Text) || 
                    string.IsNullOrEmpty(txt_descripcion.Text))
                {
                    throw new Exception("Por favor llenar todos los campos.");
                }

                //Validacion de estado seleccionado

                if (comboBox_estado.SelectedItem == null)
                {
                    throw new Exception("Por favor elija un estado.");
                }

                //Validacion numero entero

                int idCategoria;
                if (!int.TryParse(txt_id.Text, out idCategoria))
                {
                    throw new Exception("El campo ID debe ser un número entero.");
                }

                //Validacion de ID repetido

                for (int j=0; j < MenuPrincipal.contadorCategoria; j++)
                {
                    if (MenuPrincipal.categoriasRegistradas[j] != null && idCategoria == MenuPrincipal.categoriasRegistradas[j].GetId())
                    {
                        throw new Exception("El ID ingresado ya existe.");
                    }
                }

                // Obtener estado seleccionado y asginar el string adecuado

                bool estadoSeleccionado;

                if (comboBox_estado.SelectedItem.ToString() == "Activo")
                {
                    estadoSeleccionado = true;
                }
                else
                {
                    estadoSeleccionado = false;
                }

                //Crear nueva categoria

                Categoria nuevaCategoria = new Categoria(idCategoria, 
                                                         txt_descripcion.Text, 
                                                         estadoSeleccionado);

                //Almacenar categoria

                //Si no hay categorias registradas, se crea un arreglo de 20 elementos

                if (MenuPrincipal.categoriasRegistradas == null)
                {
                    MenuPrincipal.categoriasRegistradas = new Categoria[20];
                }

                //Se busca el primer espacio disponible en el arreglo para almacenar la nueva categoria

                int indice = Array.IndexOf(MenuPrincipal.categoriasRegistradas, null);
                if (indice >= 0)
                {
                    //Guardar categoria en el arreglo de 20 categorias

                    MenuPrincipal.categoriasRegistradas[indice] = nuevaCategoria;
                    MenuPrincipal.contadorCategoria++;
                    MessageBox.Show("Categoria guardada exitosamente.");

                    //Limpiar campos
                    txt_id.Text = "";
                    txt_descripcion.Text = "";
                    comboBox_estado.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("No hay más espacio disponible para agregar categorias.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
