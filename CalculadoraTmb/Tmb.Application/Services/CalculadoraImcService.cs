using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;
using Tmb.Domain.Interfaces;

namespace Tmb.Application.Services
{
    public class CalculadoraImcService
    {
        private readonly ICalculadoraImc _calculadoraImc;

        public CalculadoraImcService(ICalculadoraImc calculadoraImc)
        {
            _calculadoraImc = calculadoraImc;
        }

        public double CalcularImc(double peso, double altura)
        {
            var usuario = new Usuario
            {
                Peso = peso,
                Altura = altura
            };

            return _calculadoraImc.CalcularImc(usuario);
        }
    }
}
