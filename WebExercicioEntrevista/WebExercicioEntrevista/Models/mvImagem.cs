using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebExercicioEntrevista.CNImagem;

namespace WebExercicioEntrevista.Models
{
    public class mvImagem
    {
        public ddImagem Imagem { get; set; }
        public List<ddImagem> L_Imagem { get; set; }

        public mvImagem() {
            L_Imagem = new List<ddImagem>();
            Imagem = new ddImagem();
        }
        public mvImagem(int id, string url_imagem)
        {
            Imagem = new ddImagem(id, url_imagem);
        }
    }
}