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

        public int CalcularTmb(int idade, double peso, double altura, string sexo, int nivelAtividade)
        {
            var usuario = new Usuario
            {
                Idade = idade,
                Peso = peso,
                Altura = altura,
                Sexo = sexo,
                NivelAtividade = nivelAtividade
            };

            return _calculadora.Calcular(usuario);
        }
    }
}
