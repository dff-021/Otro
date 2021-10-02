using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoClaseApp.Dominio;
using ProyectoClaseApp.Persistencia.AppRepositorios;

namespace ProyectoClaseApp.Frontend.Pages
{
    public class CalculadoraModel : PageModel
    {
        private readonly IRepositorioOperaciones ObjetoRepositorio;
        public IEnumerable<ListaOperaciones> Oper {get;set;}

        [BindProperty(SupportsGet = true)]
        public string Seleccion {get;set;}
        public string ResultadoOperacion {get; set;}
        public string SostenerNumeroI {get;set;}
        public string SostenerNumeroII {get;set;}
        

        public CalculadoraModel(IRepositorioOperaciones Repositorio)
        {
            ObjetoRepositorio = Repositorio;           

        }

        public void OnGet(string NumeroI, string NumeroII, string OperaSelect)
        {

            SostenerNumeroI = NumeroI;
            SostenerNumeroII = NumeroII;
            Seleccion = OperaSelect;
            if (NumeroI != null && NumeroII != null)
            {
                
                if(OperaSelect == "Sumar")
                {
                    ResultadoOperacion = "=  " + (int.Parse(NumeroI) + int.Parse(NumeroII));
                   
                }else if (OperaSelect == "Restar")
                {
                    ResultadoOperacion = "=  " + (int.Parse(NumeroI) - int.Parse(NumeroII));
                    
                }else if (OperaSelect == "Dividir")
                {
                    ResultadoOperacion = "=  " + (int.Parse(NumeroI) / int.Parse(NumeroII));

                }else if (OperaSelect == "Multiplicar")
                {
                    ResultadoOperacion = "=  " + (int.Parse(NumeroI) * int.Parse(NumeroII));
                }
            }
                Oper= ObjetoRepositorio.GetAll(NumeroI,NumeroII,OperaSelect,ResultadoOperacion);
        }
    }
}

