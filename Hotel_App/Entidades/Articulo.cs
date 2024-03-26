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
    public class Articulo
    {
        private int id;
        private string nombre;
        private int precio;
        private Categoria categoria;

        public Articulo(int id, string nombre, int precio, Categoria categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }

        public int GetID()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }

        public int GetPrecio()
        {
            return precio;
        }

        public Categoria GetCategoria()
        {
            return categoria;
        }

        public void SetID(int id)
        {
            this.id = id;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPrecio(int precio)
        {
            this.precio = precio;
        }

        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
    }
}
