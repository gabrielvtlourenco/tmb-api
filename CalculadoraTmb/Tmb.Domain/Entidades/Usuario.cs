﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmb.Domain.Entidades
{
    public class Usuario
    {
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }
        public int NivelAtividade { get; set; }
    }
}
