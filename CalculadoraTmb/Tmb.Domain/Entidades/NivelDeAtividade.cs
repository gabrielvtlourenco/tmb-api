using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmb.Domain.Entidades
{
    public class NivelDeAtividade
    {
        public string Nome { get; set; }
        public int Valor { get; set; }

        public NivelDeAtividade(string nome, int valor)
        {
            Nome = nome; 
            Valor = valor;
        }
    }
}
