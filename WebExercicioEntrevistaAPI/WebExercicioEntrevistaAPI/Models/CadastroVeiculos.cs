using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExercicioEntrevistaAPI.Models
{
    public class CadastroVeiculos
    {
        public int Id { get; set; }
        public string Placa  { get; set; }
        public string Tipo_Veiculo { get; set; }
        public string Proprietario { get; set; }

        public CadastroVeiculos() {

        }

        public CadastroVeiculos(int id,string placa,string tipo_veiculo,string proprietario) {
            this.Id = id;
            this.Placa = placa;
            this.Tipo_Veiculo = tipo_veiculo;
            this.Proprietario = proprietario;
        }
    }
}