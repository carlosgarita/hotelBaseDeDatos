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
    public class Hotel
    {
        private int id;
        private string nombre;
        private string direccion;
        private bool estado;
        private string telefono;

        public Hotel(int id, string nombre, string direccion, bool estado, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estado = estado;
            this.telefono = telefono;
        }

        //Metodos Get
        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public bool GetEstado()
        {
            return estado;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        //Metodos Set
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public void SetEstado(bool estado)
        {
            this.estado = estado;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"{GetId()} - {GetNombre()} - {GetDireccion()}";
        }
    }
}
