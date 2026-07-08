using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Model;
using ProyectoFinal.Repositorio;


namespace ProyectoFinal.Controller
{
    public class ClienteController
    {
        Repositorio<Cliente> _repo;
        public Cliente BuscarCliente(string dni)
        {
            List<Cliente> lista = _repo.ReturnData();
            Cliente clienteEncontrado = lista.Find(i => i.Dni == dni);
            return clienteEncontrado;
        }
    }
}
