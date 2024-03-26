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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Creamos las variables estaticas aqui porque esta ventana no se cierra

        public static Hotel[] hotelesRegistrados = new Hotel[20];
        public static int contadorHotel = 0;

        public static Cliente[] clientesRegistrados = new Cliente[20];
        public static int contadorCliente = 0;

        public static Categoria[] categoriasRegistradas = new Categoria[20];
        public static int contadorCategoria = 0;

        public static Articulo[] articulosRegistrados = new Articulo[20];
        public static int contadorArticulo = 0;

        public static ArticuloHotel[] articulosHotelRegistrados = new ArticuloHotel[20];
        public static int contadorArticuloHotel = 0;


        private void btn_hotelRegistro_Click(object sender, EventArgs e)
        {
            RegistroHotel ventana = new RegistroHotel();
            ventana.ShowDialog(this);
        }

        private void btn_consultaHotel_Click(object sender, EventArgs e)
        {
            ConsultaHoteles ventana = new ConsultaHoteles();
            ventana.ShowDialog(this);
        }

        private void btn_registroCliente_Click(object sender, EventArgs e)
        {
            RegistroClientes ventana = new RegistroClientes();
            ventana.ShowDialog(this);
        }

        private void btn_consultaCliente_Click(object sender, EventArgs e)
        {
            ConsultaClientes ventana = new ConsultaClientes();
            ventana.ShowDialog(this);
        }

        private void btn_registroCategoria_Click(object sender, EventArgs e)
        {
            RegistroCategoria ventana = new RegistroCategoria();
            ventana.ShowDialog(this);
        }

        private void btn_ConsultaCategoria_Click(object sender, EventArgs e)
        {
            ConsultaCategoria ventana = new ConsultaCategoria();
            ventana.ShowDialog(this);
        }

        private void btn_registroArticulo_Click(object sender, EventArgs e)
        {
            RegistroArticulos ventana = new RegistroArticulos();
            ventana.ShowDialog(this);
        }

        private void btn_consultaArticulo_Click(object sender, EventArgs e)
        {
            ConsultaArticulos ventana = new ConsultaArticulos();
            ventana.ShowDialog(this);
        }

        private void btn_registroArticuloHotel_Click(object sender, EventArgs e)
        {
            RegistroArticulosHotel ventana = new RegistroArticulosHotel();
            ventana.ShowDialog(this);
        }

        private void btn_consultaArticuloHotel_Click(object sender, EventArgs e)
        {
            ConsultaArticulosHotel ventana = new ConsultaArticulosHotel();
            ventana.ShowDialog(this);
        }
    }
}
