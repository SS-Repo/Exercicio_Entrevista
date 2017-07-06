using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExercicioEntrevista.CNVeiculo
{
    public class cnVeiculos
    {
        public List<ddVeiculos> Loadlist() {

            return new dalVeiculos().Loadlist();
        }
    }
}