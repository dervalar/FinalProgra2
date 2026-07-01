using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    public class Cliente
    {
        public string NombreCompleto {  get; set; }
        public string Dni {  get; set; }
        public string Email { get; set; }   
        public ClienteEnum Tipo { get; set; }

        public Cliente(string nombreCompleto, string dni, string email, ClienteEnum tipo)
        {
            NombreCompleto = nombreCompleto,
            Dni = dni;
            Email = email;
            Tipo = tipo;
        }
    }
}
