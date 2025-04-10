using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;
using Tmb.Domain.Interfaces;

namespace Tmb.Infrastructure.Services
{
    public class TmbCalculadora : ITmbCalculadora
    {
        public int Calcular(Usuario usuario)
        {
            double resultado = usuario.Sexo.ToUpper() == "M"
                    ? (10 * usuario.Peso) + (6.25 * usuario.Altura) - (5 * usuario.Idade) + 5
                    : (10 * usuario.Peso) + (6.25 * usuario.Altura) - (5 * usuario.Idade) - 161;

            double fatorAtividade = (int)usuario.NivelAtividade / 100.0;

            double tdee = resultado * fatorAtividade;

            return (int)Math.Round(tdee);
        }
    }
}
