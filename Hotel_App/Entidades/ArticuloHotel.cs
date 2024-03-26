using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * UNED III Cuatrimestre 2024
 * Proyecto 01: Sistema de gestión de hoteles
 * Estudiante: Carlos Daniel Garita Porras
 * Fecha: 24/02/24
*/

namespace Entidades
{
    public class ArticuloHotel
    {
        private int id_asignacion;
        private DateTime fechaAsignacion;
        private Hotel hotel;
        private Articulo[] articuloAsignado = new Articulo[10];

        public ArticuloHotel(int id_asignacion, DateTime fechaAsignacion, Hotel hotel, Articulo[] articuloAsignado)
        {
            this.id_asignacion = id_asignacion;
            this.fechaAsignacion = fechaAsignacion;
            this.hotel = hotel;
            this.articuloAsignado = articuloAsignado;
        }

        public int GetIdAsignacion()
        {
            return id_asignacion;
        }

        public DateTime GetFechaAsignacion()
        {
            return fechaAsignacion;
        }

        public Hotel GetHotel()
        {
            return hotel;
        }

        public Articulo[] GetArticuloAsignado()
        {
            return articuloAsignado;
        }

        public void SetIdAsignacion(int id_asignacion)
        {
            this.id_asignacion = id_asignacion;
        }

        public void SetFechaAsignacion(DateTime fechaAsignacion)
        {
            this.fechaAsignacion = fechaAsignacion;
        }

        public void SetHotel(Hotel hotel)
        {
            this.hotel = hotel;
        }

        public void SetArticuloAsignado(Articulo[] articuloAsignado)
        {
            this.articuloAsignado = articuloAsignado;
        }

        public void AgregarArticulo(Articulo articulo)
        {
            for (int i = 0; i < articuloAsignado.Length; i++)
            {
                if (articuloAsignado[i] == null)
                {
                    articuloAsignado[i] = articulo;
                    break;
                }
            }
        }

        public void AsignarArticulo(Articulo articulo)
        {
            int indiceDisponible = Array.FindIndex(articuloAsignado, item => item == null);

            if (indiceDisponible != -1)
            {
                // Asigna el objeto Articulo al array en el índice disponible
                articuloAsignado[indiceDisponible] = articulo;
            }
            else
            {
                // Manejar el caso en el que no hay índices disponibles en el array
                // Por ejemplo, lanzar una excepción o agregar lógica para manejar el exceso de artículos
            }
        }

    }
}
