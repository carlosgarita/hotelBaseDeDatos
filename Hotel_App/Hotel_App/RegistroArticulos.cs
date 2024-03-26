using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();

            //Aqui se llena el datagrid de las categorias

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

                    dataGridView_categorias.Rows.Add(id, descripcion, estadoString);
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion de campos vacios

                if (string.IsNullOrEmpty(txt_id.Text) ||
                    string.IsNullOrEmpty(txt_nombre.Text) ||
                    string.IsNullOrEmpty(txt_precio.Text))
                {
                    throw new Exception("Por favor llenar todos los campos.");
                }

                //Validacion de seleccion de categoria

                if (dataGridView_categorias.SelectedRows.Count == 0)
                {
                    throw new Exception("Por favor seleccione una categoria.");
                }

                //Validacion numeros enteros para ID y Precio

                int idArticulo;
                int precioArticulo;
                if (!int.TryParse(txt_id.Text, out idArticulo) ||
                    !int.TryParse(txt_precio.Text, out precioArticulo))
                {
                    throw new Exception("El campo ID y Precio deben ser números enteros.");
                }

                //Validacion de ID repetido

                for (int j = 0; j < MenuPrincipal.contadorArticulo; j++)
                {
                    if (MenuPrincipal.articulosRegistrados[j] != null && idArticulo == MenuPrincipal.articulosRegistrados[j].GetID())
                    {
                        throw new Exception("El ID ingresado ya existe.");
                    }
                }

                //Definicion de los argumentos para el nuevo articulo

                int idCategoria = Convert.ToInt32(dataGridView_categorias.SelectedRows[0].Cells["Id"].Value);
                string descripcionCategoria = dataGridView_categorias.SelectedRows[0].Cells["Descripcion"].Value.ToString();

                string estadoString = dataGridView_categorias.SelectedRows[0].Cells["Estado"].Value.ToString();

                bool estadoCategoria;

                if (estadoString == "Activo")
                {
                    estadoCategoria = true;
                }
                else
                {
                    estadoCategoria = false;
                }

                //estadoCategoria = Convert.ToBoolean(dataGridView_categorias.SelectedRows[0].Cells["Estado"].Value);
                Categoria categoria = new Categoria(idCategoria, 
                                                    descripcionCategoria, 
                                                    estadoCategoria);

                //Definicion del nuevo articulo

                Articulo nuevoArticulo = new Articulo(idArticulo, 
                                                      txt_nombre.Text, 
                                                      precioArticulo, 
                                                      categoria);

                //Almacenar articulo en el array de 20 articulos

                //Se crea el array si no existe

                if (MenuPrincipal.articulosRegistrados == null)
                {
                    MenuPrincipal.articulosRegistrados = new Articulo[20];
                }

                //Buscar el primer espacio disponible en el array de 20 articulos

                int indice = Array.IndexOf(MenuPrincipal.articulosRegistrados, null);

                //Si hay espacio disponible, se guarda el articulo

                if (indice >= 0)
                {
                    MenuPrincipal.articulosRegistrados[indice] = nuevoArticulo;
                    MenuPrincipal.contadorArticulo++;
                    MessageBox.Show("Articulo guardado exitosamente.");

                    //Limpiar campos

                    txt_id.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";

                }
                else
                {
                    MessageBox.Show("No hay más espacio disponible para agregar articulos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
