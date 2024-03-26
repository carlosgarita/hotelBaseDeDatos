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
    public partial class ConsultaArticulosHotel : Form
    {
        public ConsultaArticulosHotel()
        {
            InitializeComponent();

            foreach (ArticuloHotel articuloHotel in MenuPrincipal.articulosHotelRegistrados)
            {
                if (articuloHotel != null)
                {
                    for (int i = 0; i < articuloHotel.GetArticuloAsignado().Length; i++)
                    {
                           if (articuloHotel.GetArticuloAsignado()[i] != null)
                        {
                            dataGridViewArticulosAsignados.Rows.Add(articuloHotel.GetIdAsignacion(),
                                                                    articuloHotel.GetFechaAsignacion(),
                                                                    articuloHotel.GetHotel(),
                                                                    articuloHotel.GetArticuloAsignado()[i].GetID(),
                                                                    articuloHotel.GetArticuloAsignado()[i].GetNombre(),
                                                                    articuloHotel.GetArticuloAsignado()[i].GetPrecio());
                        }
                    }
                   
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
