using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebExercicioEntrevista.CNCadastroVeiculo
{
    public class ddCadastroVeiculo
    {
        [Display(Name = "Id:")]
        public int id { get; set; }
        [Display(Name = "Placa:")]
        public string placa { get; set; }
        [Display(Name = "Tipo Veiculo:")]
        public string tipo_veiculo { get; set; }
        [Display(Name = "Proprietario:")]
        public string proprietario { get; set; }
    }
}