using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;

namespace Tmb.Domain.Interfaces
{
    public interface ITmbCalculadora
    {
        int Calcular(Usuario usuario);
    }
}
