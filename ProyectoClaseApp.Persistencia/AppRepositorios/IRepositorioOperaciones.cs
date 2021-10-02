using System;
using ProyectoClaseApp.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoClaseApp.Persistencia.AppRepositorios
{
    public interface IRepositorioOperaciones
    {
        IEnumerable<ListaOperaciones> GetAll(string num1, string num2, string opera,string rta);
    }
}