using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;

namespace Tmb.Domain.StaticData
{
    public static class NivelDeAtividadeData
    {
        public static List<NivelDeAtividade> ObterTodos()
        {
            return new List<NivelDeAtividade>
            {
                new NivelDeAtividade("Sedentário", 120),
                new NivelDeAtividade("Levemente Ativo", 137),
                new NivelDeAtividade("Moderadamente Ativo", 155),
                new NivelDeAtividade("Muito Ativo", 172),
                new NivelDeAtividade("Extremamente Ativo", 190)
            };
        }
    }
}
