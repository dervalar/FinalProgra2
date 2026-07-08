using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Model;

namespace ProyectoFinal.Repositorio
{
    public interface IRepositorio<T>
    {
        void Buscar(T entidad);
        List<T> ReturnData();
    }
}
