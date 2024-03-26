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
    public class Categoria
    {
        private int id;
        private string descripcion;
        private bool estado;

        public Categoria(int id, string descripcion, bool estado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public int GetId()
        {
            return id;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public bool GetEstado()
        {
            return estado;
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void SetEstado(bool estado)
        {
            this.estado = estado;
        }
    }
}
