using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    internal class Instrumento
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; } // (Cuerda / Viento / Percusión / Teclado)
        public string Marca { get; set; }
        public int Codigo { get; set; }
        public bool Disponible { get; set; }
        


        public Instrumento(string nombre, string categoria, string marca, int codigo, bool disponible)
        {
            Nombre = nombre;
            Categoria = categoria;
            Marca = marca;
            Codigo = codigo;
            Disponible = disponible;
                
        }
    }
}
