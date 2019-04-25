using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Douglas.Models
{
    public class Cliente
    {
        public double Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Data_Nascimento { get; set; }
        public double Telefone { get; set; }
        public string Data_Criacao { get; set; }
        public string Data_Atualizacao { get; set; }
    }
}
