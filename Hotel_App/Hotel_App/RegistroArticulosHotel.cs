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
    public partial class RegistroArticulosHotel : Form
    {
        public RegistroArticulosHotel()
        {
            InitializeComponent();

            // Suscribir al evento SelectedIndexChanged del ComboBox
            comboBox_HotelesActivos.SelectedIndexChanged += ComboBox_HotelesActivos_SelectedIndexChanged;

            // Limpia el ComboBox antes de agregar los nuevos elementos activos

            comboBox_HotelesActivos.Items.Clear();

            // Limpia el DataGridView antes de agregar los nuevos elementos

            dataGridView_ArticulosRegistrados.Rows.Clear();

            // Filtra los hoteles activos

            var hotelesActivos = MenuPrincipal.hotelesRegistrados.Where(hotel => hotel != null && hotel.GetEstado() == true);
            
            // Agrega los hoteles activos al ComboBox

            foreach (var hotel in hotelesActivos)
            {
                comboBox_HotelesActivos.Items.Add(hotel);
            }          

            // Llena el DataGridView con los artículos registrados

            foreach (Articulo articulo in MenuPrincipal.articulosRegistrados)
            {
                if (articulo != null)
                {
                    int id = articulo.GetID();
                    string nombre = articulo.GetNombre();
                    int precio = articulo.GetPrecio();   
                    Categoria categoria = articulo.GetCategoria();

                    dataGridView_ArticulosRegistrados.Rows.Add(id, nombre, precio, categoria.GetId());
                }
            }


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método de evento que se ejecuta cuando se cambia la selección en el ComboBox
        private void ComboBox_HotelesActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el DataGridView si ya tiene datos

            dataGridView_articulosAsociados.Rows.Clear();

            // Obtener el hotel seleccionado del ComboBox

            Hotel hotelSeleccionado = (Hotel)comboBox_HotelesActivos.SelectedItem;

            foreach(ArticuloHotel articuloHotel in MenuPrincipal.articulosHotelRegistrados)
            {
                if (articuloHotel != null && hotelSeleccionado != null && hotelSeleccionado.GetId() == articuloHotel.GetHotel().GetId())
                {
                    foreach (Articulo articulo in articuloHotel.GetArticuloAsignado())
                    {
                        // Agrega una nueva fila al DataGridView
                        int indiceFila = dataGridView_articulosAsociados.Rows.Add();
                        // Asigna los valores de las propiedades del objeto a las celdas correspondientes

                        dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_idAsignacion"].Value = articuloHotel.GetIdAsignacion();
                        dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_IdArticulo"].Value = articulo.GetID();
                        dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_nombre"].Value = articulo.GetNombre();
                        dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_precio"].Value = articulo.GetPrecio();
                    } 
                }
            }

            //Console.WriteLine("Hotel seleccionado: " + hotelSeleccionado.GetId());

            // Supongamos que tienes una función ObtenerArticulosRelacionados que devuelve los artículos relacionados con el hotel seleccionado

            //List<Articulo> articulosRelacionados = ObtenerArticulosRelacionados(hotelSeleccionado);

            // Actualizar el DataGridView con los artículos relacionados
            //dataGridView_ArticulosRelacionados.DataSource = articulosRelacionados;
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion campos vacios

                if (string.IsNullOrEmpty(txt_idAsignacion.Text))
                {
                    throw new Exception("Por favor llenar el campo ID de asignación.");
                }

                //Validacion numero entero

                int idArticulo;

                if (!int.TryParse(txt_idAsignacion.Text, out idArticulo))
                {
                    throw new Exception("El campo ID debe ser un número entero.");
                }

                //Validacion de seleccion de hotel

                if (comboBox_HotelesActivos.SelectedItem == null)
                {
                    throw new Exception("Por favor seleccione un hotel.");
                }

                //Validacion de seleccion de articulo

                if (dataGridView_ArticulosRegistrados.SelectedRows.Count == 0)
                {
                    throw new Exception("Por favor seleccione un artículo.");
                }             

                //Validacion de ID repetido

                for (int j = 0; j < MenuPrincipal.contadorArticuloHotel; j++)
                {
                    if (MenuPrincipal.articulosHotelRegistrados[j] != null && idArticulo == MenuPrincipal.articulosHotelRegistrados[j].GetIdAsignacion())
                    {
                        throw new Exception("El ID ingresado ya existe.");
                    }
                }



                //Seleccion del articulo

                // Lista para almacenar los artículos seleccionados

                List<Articulo> articulosSeleccionados = new List<Articulo>();

                // Verifica si hay filas seleccionadas en el DataGridView

                if (dataGridView_ArticulosRegistrados.SelectedRows.Count > 0)
                {
                    // Itera sobre cada fila seleccionada
                    foreach (DataGridViewRow fila in dataGridView_ArticulosRegistrados.SelectedRows)
                    {
                        // Obtén los valores de las celdas correspondientes a cada propiedad del artículo

                        int id = Convert.ToInt32(fila.Cells["ID"].Value);
                        string nombre = fila.Cells["Nombre"].Value.ToString();
                        int precio = Convert.ToInt32(fila.Cells["Precio"].Value);
                        Categoria categoria = new Categoria(Convert.ToInt32(fila.Cells["Categoria"].Value), null, false);

                        // Crea un nuevo objeto Articulo con los valores obtenidos y agrégalo a la lista
                        Articulo articulo = new Articulo ( id, nombre, precio, categoria);
                        articulosSeleccionados.Add(articulo);
                    }
                }

                //Probamos que se hayan seleccionado artículos

                foreach (Articulo articulo in articulosSeleccionados)
                {
                    // Haz lo que necesites con cada artículo
                    Console.WriteLine($"ID_Articulo: {articulo.GetID()}, Nombre: {articulo.GetNombre()}, Precio: {articulo.GetPrecio()}, Categoria: {articulo.GetCategoria().GetId()}");
                }
                /*
                //Asignamos los datos del form al grid de abajo (articulos seleccionados y demas)

                // Limpia el DataGridView si ya tiene datos
                dataGridView_articulosAsociados.Rows.Clear();

                // Itera sobre cada objeto en el array articulos
                foreach (Articulo articulo in articulosSeleccionados)
                {
                    // Agrega una nueva fila al DataGridView
                    int indiceFila = dataGridView_articulosAsociados.Rows.Add();

                    // Asigna los valores de las propiedades del objeto a las celdas correspondientes
                    
                    dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_idAsignacion"].Value = txt_idAsignacion.Text;
                    dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_IdArticulo"].Value = articulosSeleccionados[indiceFila].GetID();
                    dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_nombre"].Value = articulosSeleccionados[indiceFila].GetNombre();
                    dataGridView_articulosAsociados.Rows[indiceFila].Cells["asociados_precio"].Value = articulosSeleccionados[indiceFila].GetPrecio();

                }
                */
                //Definicion del objeto articulo hotel

                int idAsignacion  = Convert.ToInt32(txt_idAsignacion.Text);
                DateTime fechaSeleccionada = dateTimePicker_FechaAsignacion.Value; //Esta fecha es para el objeto creado
                string fechaAsignacion = fechaSeleccionada.ToString("yyyy-MM-dd"); //Esta fecha es para llenar el grid
                Hotel hotelSeleccionado = (Hotel)comboBox_HotelesActivos.SelectedItem;
                Articulo[] articulos = new Articulo[articulosSeleccionados.Count];
                articulosSeleccionados.CopyTo(articulos);             

                ArticuloHotel articuloHotel = new ArticuloHotel(idAsignacion,
                                                    fechaSeleccionada,
                                                    hotelSeleccionado,
                                                    articulos);

                Console.WriteLine("ID de asignación: " + articuloHotel.GetIdAsignacion());
                Console.WriteLine("Fecha de asignación: " + articuloHotel.GetFechaAsignacion());
                Console.WriteLine("Hotel seleccionado: " + articuloHotel.GetHotel());
                Console.WriteLine("Artículos:");

                foreach (Articulo articulo in articuloHotel.GetArticuloAsignado())
                {
                    Console.WriteLine("ID: " + articulo.GetID());
                    Console.WriteLine("Nombre: " + articulo.GetNombre());
                    Console.WriteLine("Precio: " + articulo.GetPrecio());
                    //Console.WriteLine("Categoria: " + articulo.GetCategoria().GetDescripcion());
                }

                //Almacenar articulo por hotel en el array de 20 articulos por hotel

                //Obtiene el primer índice disponible en el array de 20 elementos

                int indice = Array.IndexOf(MenuPrincipal.articulosHotelRegistrados, null);
                if (indice >= 0)
                {
                    //Guarda el articulo por hotel en el array de 20 articulos por hotel

                    MenuPrincipal.articulosHotelRegistrados[indice] = articuloHotel;
                    MenuPrincipal.contadorArticuloHotel++;
                    MessageBox.Show("Articulo por hotel guardado exitosamente.");

                    //Limpia campos 

                    txt_idAsignacion.Text = "";
                    comboBox_HotelesActivos.SelectedItem = null;
                    dataGridView_ArticulosRegistrados.ClearSelection();
                    dateTimePicker_FechaAsignacion.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("No hay más espacio disponible para agregar articulos por hotel.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
