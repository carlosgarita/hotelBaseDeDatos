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
    internal class RegistroCliente
    {
        private Cliente[] clientes;
        private int indice;

        public RegistroCliente()
        {
            clientes = new Cliente[20];
            indice = 0;
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (indice < 20)
            {
                clientes[indice] = cliente;
                indice++;
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio disponible para agregar clientes.");
            }
        }

        public Cliente[] GetClientes()
        {
            return clientes;
        }
    }
}
