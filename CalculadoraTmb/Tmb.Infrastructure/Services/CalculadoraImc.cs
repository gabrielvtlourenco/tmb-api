using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;
using Tmb.Domain.Interfaces;

namespace Tmb.Infrastructure.Services
{
    public class CalculadoraImc : ICalculadoraImc
    {
        public double CalcularImc(Usuario usuario)
        {
            double imc;
            double alturaM = usuario.Altura / 100.0;
            imc = usuario.Peso / (alturaM * alturaM);
            return imc;
        }
    }
}
