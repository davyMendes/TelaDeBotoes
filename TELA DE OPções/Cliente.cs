using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELA_DE_OPções
{
    public class Cliente
    {
        public Cliente(string codigo, string nome, string cidade, string uF)
        {
            Codigo = codigo.ToUpper();
            Nome = nome.ToUpper();
            Cidade = cidade.ToUpper();
            UF = uF.ToUpper();
        }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
