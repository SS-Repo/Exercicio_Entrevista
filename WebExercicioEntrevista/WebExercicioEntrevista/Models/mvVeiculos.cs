using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebExercicioEntrevista.CNVeiculo;

namespace WebExercicioEntrevista.Models
{
    public class mvVeiculos
    {
        public List<ddVeiculos> L_Veiculos { get; set; }

        public mvVeiculos() {
            L_Veiculos = new cnVeiculos().Loadlist();
        }
    }
}