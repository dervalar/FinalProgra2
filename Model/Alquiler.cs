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
        public AlquilerEnum Estado { get; set; }
        public decimal CostoTotal { get; set; }


        public Alquiler(int id, int idCliente, List<int> idsInstrumentos, DateTime fechaAlquiler, DateTime fechaDev, decimal costoTotal, AlquilerEnum estado)
        {
            Id = id;
            IdCliente = idCliente;
            IdsInstrumentos = idsInstrumentos;
            FechaAlquiler = fechaAlquiler;
            FechaDev = fechaDev;
            CostoTotal = costoTotal;
            Estado = estado;
        }



    }
}
