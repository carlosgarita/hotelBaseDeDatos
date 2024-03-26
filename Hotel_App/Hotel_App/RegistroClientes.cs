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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
            
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos

                if (string.IsNullOrEmpty(txt_id.Text) || 
                    string.IsNullOrEmpty(txt_nombre.Text) || 
                    string.IsNullOrEmpty(txt_apellido1.Text) || 
                    string.IsNullOrEmpty(txt_apellido2.Text))
                {
                    throw new Exception("Por favor llenar todos los campos.");
                }

                //Validacion de genero seleccionado

                if (comboBox_genero.SelectedItem == null)
                {
                    throw new Exception("Por favor elija un genero.");
                }

                //*****  No hay validacion de numero entero porque el ID es un string  ******

                //Validacion de ID repetido

                for (int j=0; j < MenuPrincipal.contadorCliente; j++)
                {
                    //Este ID es un string. No es un numero entero.
                    if (MenuPrincipal.clientesRegistrados[j] != null && txt_id.Text == MenuPrincipal.clientesRegistrados[j].GetID())
                        {
                        throw new Exception("El ID ingresado ya existe.");
                    }
                }


                // Validación de fecha de nacimiento

                DateTime fechaSeleccionada = dateTimePickerFechaNacimiento.Value;

                if (fechaSeleccionada > DateTime.Now)
                {
                    throw new Exception("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }

                // Validación de género

                char generoSeleccionado = ((string)comboBox_genero.SelectedItem)[0];
                if (generoSeleccionado != 'M' && generoSeleccionado != 'F')
                {
                    throw new Exception("El género seleccionado no es válido.");
                }


                //Crear nuevo cliente

                // Convertir fecha a string

                string fechaNacimientoString = fechaSeleccionada.ToString("yyyy-MM-dd");

                Cliente nuevoCliente = new Cliente(txt_id.Text, 
                                                   txt_nombre.Text, 
                                                   txt_apellido1.Text, 
                                                   txt_apellido2.Text, 
                                                   fechaSeleccionada, 
                                                   generoSeleccionado);

                // Crear el array si no existe

                if (MenuPrincipal.clientesRegistrados == null)
                {
                    MenuPrincipal.clientesRegistrados = new Cliente[20];
                }

                // Buscar el primer espacio disponible en el array

                int indice = Array.IndexOf(MenuPrincipal.clientesRegistrados, null);
                if (indice >= 0)
                {
                    // Guardar cliente en el array de 20 clientes

                    MenuPrincipal.clientesRegistrados[indice] = nuevoCliente;
                    MenuPrincipal.contadorCliente++;
                    MessageBox.Show("Cliente guardado exitosamente.");

                    // Limpiar campos

                    txt_id.Text = "";
                    txt_nombre.Text = "";
                    txt_apellido1.Text = "";
                    txt_apellido2.Text = "";
                    dateTimePickerFechaNacimiento.Value = DateTime.Now;
                    comboBox_genero.SelectedItem = null;

                }
                else
                {
                    MessageBox.Show("No hay más espacio disponible para agregar clientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
