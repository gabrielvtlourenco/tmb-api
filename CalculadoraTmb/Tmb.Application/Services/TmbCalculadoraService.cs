using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmb.Domain.Entidades;
using Tmb.Domain.Interfaces;

namespace Tmb.Application.Services
{
    public class TmbCalculadoraService
    {
        private readonly ITmbCalculadora _calculadora;

        public TmbCalculadoraService(ITmbCalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        public double CalcularTmb(int idade, double peso, double altura, string sexo)
        {
            var usuario = new Usuario
            {
                Idade = idade,
                Peso = peso,
                Altura = altura,
                Sexo = sexo
            };

            return _calculadora.Calcular(usuario);
        }
    }
}
