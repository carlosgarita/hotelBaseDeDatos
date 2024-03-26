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
    public class Cliente
    {
        private string id;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNacimiento;
        private char genero;

        public Cliente(string id, string nombre, string apellido1, string apellido2, 
                       DateTime fechaNacimiento, char genero)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
        }

        public string GetID()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido1()
        {
            return apellido1;
        }

        public string GetApellido2()
        {
            return apellido2;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public char GetGenero()
        {
            return genero;
        }

        public void SetID(string id)
        {
            this.id = id;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido1(string apellido1)
        {
            this.apellido1 = apellido1;
        }

        public void SetApellido2(string apellido2)
        {
            this.apellido2 = apellido2;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetGenero(char genero)
        {
            this.genero = genero;
        }


    }
}
