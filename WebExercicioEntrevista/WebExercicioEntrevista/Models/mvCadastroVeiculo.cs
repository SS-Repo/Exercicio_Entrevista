using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExercicioEntrevista.CNCadastroVeiculo;
using WebExercicioEntrevista.CNVeiculo;

namespace WebExercicioEntrevista.Models
{
    public class mvCadastroVeiculo
    {
        public ddCadastroVeiculo CadastroVeiculo { get; set; }

        public mvCadastroVeiculo(){
            CadastroVeiculo = new ddCadastroVeiculo();
        }
    }
}