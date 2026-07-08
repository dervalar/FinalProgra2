using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Repositorio
{
    public class Repositorio<T> : IRepositorio<T>
    {
        private List<T> _data;
        public void Buscar(T entidad)
        {
            
        }

        public List<T> ReturnData()
        {
            return _data;
        }
    }
}
