using System;
using ProyectoClaseApp.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoClaseApp.Persistencia.AppRepositorios
{
    public class RepositorioOperaciones : IRepositorioOperaciones
    {
        public int idcontador {get; set;}
        
        List<ListaOperaciones> listado = new List<ListaOperaciones>()
            {
                new ListaOperaciones{Id=0,NumeroUno="",NumeroDos="",OperacionSeleccionada=""}
            };
        List<ListaOperaciones> listado2 = new List<ListaOperaciones>()
            {
                new ListaOperaciones{Id=1,NumeroUno="5",NumeroDos="5",OperacionSeleccionada=""}
            };
        public  RepositorioOperaciones()
        {
            idcontador = 0;
        }
       /* public  RepositorioOperaciones()
        {
            listado = new List<ListaOperaciones>()
            {
                new ListaOperaciones{Id=0,NumeroUno="",NumeroDos="",OperacionSeleccionada=""}
            };
        }*/
        public IEnumerable<ListaOperaciones> GetAll(string num1, string num2, string opera, string rta)
        {
           if (idcontador == 0)
           {
               idcontador += 1;
               //listado.Add( new ListaOperaciones(){Id=idcontador,NumeroUno=num1,NumeroDos=num2,OperacionSeleccionada=opera});
                return listado;
           }else {
               if( opera == "Sumar")
               {
                   listado.Add( new ListaOperaciones(){Id=idcontador,NumeroUno=num1,NumeroDos=num2,OperacionSeleccionada="+",Resultado=rta});
                   idcontador += 1;
               }else if( opera == "Restar")
               {
                   listado.Add( new ListaOperaciones(){Id=idcontador,NumeroUno=num1,NumeroDos=num2,OperacionSeleccionada="-",Resultado=rta});
                   idcontador += 1;

               }else if( opera == "Multiplicar")
               {
                   listado.Add( new ListaOperaciones(){Id=idcontador,NumeroUno=num1,NumeroDos=num2,OperacionSeleccionada="*",Resultado=rta});
                   idcontador += 1;

               }else if( opera == "Dividir")
               {
                   listado.Add( new ListaOperaciones(){Id=idcontador,NumeroUno=num1,NumeroDos=num2,OperacionSeleccionada="/",Resultado=rta});
                   idcontador += 1;
               }
               return listado;
           }
          
        }
    }
}