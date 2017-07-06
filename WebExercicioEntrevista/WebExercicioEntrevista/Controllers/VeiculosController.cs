using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExercicioEntrevista.CNImagem;
using WebExercicioEntrevista.Models;


namespace WebExercicioEntrevista.Controllers
{
    public class VeiculosController : Controller
    {
        public static int cont;
        public static mvImagem mvImg = new mvImagem();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Formulario()
        {
            mvVeiculos mv = new mvVeiculos();
            mvCadastroVeiculo mvCadastro = new mvCadastroVeiculo();
            List<SelectListItem> li = new List<SelectListItem>();

            for (int i = 0; mv.L_Veiculos.Count > i; i++)
            {
                li.Add(new SelectListItem() { Text = mv.L_Veiculos[i].Tipo_Veiculos });
            }

            cont++;
            ViewData["lista"] = li;
            ViewBag.contador = cont;
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(List<HttpPostedFileBase> files, mvCadastroVeiculo mv)
        {
            ViewBag.lista = null;
            var path = "";

            foreach (var item in files)
            {
                if (item != null)
                {
                    if (item.ContentLength > 0)
                    {
                        if (Path.GetExtension(item.FileName).ToLower() == ".jpg"
                            || Path.GetExtension(item.FileName).ToLower() == ".png"
                                || Path.GetExtension(item.FileName).ToLower() == ".gif"
                                    || Path.GetExtension(item.FileName).ToLower() == ".jpeg")
                        {
                            path = Path.Combine(Server.MapPath(@"~/Content/Images"), item.FileName);
                            item.SaveAs(path);
                        }
                    }
                }
            }

            for (int i = 0;files.Count> i ; i++) {
                if (files != null)
                {
                    path = Path.Combine(Server.MapPath(@"~/Content/Images"), files[i].FileName);
                    mvImg.L_Imagem.Add(new ddImagem(cont, path));
                }
            }
            ModelState.Clear();
            return Formulario();
        }

        public ActionResult Visualizar()
        {
            return View(mvImg);
        }

        public FileResult Image(int? id)
        {
           if (id != null)
           {
                var imagem = mvImg.L_Imagem.FirstOrDefault(x => x.Id == id);
                if (imagem != null)
                {
                    var imageFile = imagem.Url_Imagem;
                    return File(imageFile, "image/jpeg");
                }
            }
            return null;
        }
    }
}