
using SistemaRecados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaRecados.Controllers
{
    public class RecadoController : Controller
    {
        private static long ProxId = 1;

        private static IList<Recado> lista = new List<Recado>()
        {
            new Recado()
            {
                RecadoID = ProxId++,
                Mensagem = "Subiu mural",
                DataHora = DateTime.Now,
                Autor = "Admin"
            }
        };

        public RecadoController()
        {
            /*
             Recado r = new Recado();
            r.RecadoID = 1;
            r.Mensagem = "Traz pão";
            r.DataHora = DateTime.Now;
            r.Autor = "Zé";
            
            lista.Add(r);

            r = new Recado();
            r.RecadoID = 2;
            r.Mensagem = "Compra Mortandela?";
            r.DataHora = DateTime.Now;
            r.Autor = "Jão";

            lista.Add(r);

            lista.Add(new Recado()
            {
                RecadoID = 3,
                Mensagem = "Quantas gramas?",
                DataHora = DateTime.Now,
                Autor = "Zé"
            });

            */
        }

        // GET: Recado
        public ActionResult Index()
        {
            return View(lista);
        }

        public ActionResult GetDetalhe(int id)
        {
            Recado rec = lista.First<Recado>(r => r.RecadoID == id);
            if (rec != null)
            {
                return View(rec);
            }
            return HttpNotFound();

            /*
            foreach (Recado rec in lista)
            {
                if (rec.RecadoID == id)
                {
                    return View(rec);
                }
            }

            return HttpNotFound();
            */
        }
    
        public ActionResult NovoRecado()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NovoRecado(Recado recado)
        {
            recado.DataHora = DateTime.Now;
            recado.RecadoID = ProxId++;
            lista.Add(recado);
            return View();
        }
    }
}