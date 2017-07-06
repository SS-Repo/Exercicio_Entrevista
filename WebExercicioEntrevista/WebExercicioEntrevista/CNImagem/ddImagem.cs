using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExercicioEntrevista.CNImagem
{
    public class ddImagem
    {
        public int Id { get; set; }
        public string Url_Imagem { get; set; }

        public ddImagem() {

        }

        public ddImagem(int id, string url_imagem) {
          Id = id;
          Url_Imagem = url_imagem;
       }
    }
}