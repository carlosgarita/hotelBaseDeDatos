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
    internal class RegistroCategoria
    {
        private Categoria[] categorias;
        private int indice;

        public RegistroCategoria()
        {
            categorias = new Categoria[20];
            indice = 0;
        }

        public void AgregarCategoria(Categoria categoria)
        {
            if (indice < 20)
            {
                categorias[indice] = categoria;
                indice++;
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio disponible para agregar categorías.");
            }
        }

        public Categoria[] GetCategorias()
        {
            return categorias;
        }
    }
}
