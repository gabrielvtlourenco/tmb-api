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
        public double Calcular(Usuario usuario)
        {
            return usuario.Sexo.ToUpper() == "M"
                    ? 66 + (13.8 * usuario.Peso) + (5 * usuario.Altura) - (6.8 * usuario.Idade)
                    : 655 + (9.6 * usuario.Peso) + (1.8 * usuario.Altura) - (4.7 * usuario.Idade);
        }
    }
}
