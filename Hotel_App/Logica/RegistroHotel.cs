using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*
 * UNED III Cuatrimestre 2024
 * Proyecto 01: Sistema de gestión de hoteles
 * Estudiante: Carlos Daniel Garita Porras
 * Fecha: 24/02/24
*/

namespace Logica
{
    public class RegistroHotel
    {
        private Hotel[] hoteles;
        private int indice;

        public RegistroHotel()
        {
            hoteles = new Hotel[20];
            indice = 0;
        }

        public void AgregarHotel(Hotel hotel)
        {
            if (indice < 20)
            {
                hoteles[indice] = hotel;
                indice++;
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio disponible para agregar hoteles.");
            }
        }

        public Hotel[] GetHoteles()
        {
            return hoteles;
        }
    }
}
