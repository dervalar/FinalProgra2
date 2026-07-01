using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public List<int> IdsInstrumentos { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDev { get; set; }


        public Alquiler(int id, int idCliente, List<int> idsInstrumentos, DateTime fechaAlquiler, DateTime fechaDev)
        {
            Id = id;
            IdCliente = idCliente;
            IdsInstrumentos = idsInstrumentos;
            FechaAlquiler = fechaAlquiler;
            FechaAlquiler = FechaDev;
        }



    }
}
