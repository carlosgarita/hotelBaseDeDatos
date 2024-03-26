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
    internal class RegistroArticulos
    {
        private Articulo[] articulos;
        private int indice;

        public RegistroArticulos()
        {
            articulos = new Articulo[20];
            indice = 0;
        }

        public void AgregarArticulo(Articulo articulo)
        {
            if (indice < 20)
            {
                articulos[indice] = articulo;
                indice++;
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio disponible para agregar artículos.");
            }
        }

        public Articulo[] GetArticulos()
        {
            return articulos;
        }
    }
}
