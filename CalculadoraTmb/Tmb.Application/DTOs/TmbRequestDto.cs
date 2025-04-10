using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmb.Application.DTOs
{
    public class TmbRequestDto
    {
        [Range(0, 120)]
        public int Idade { get; set; }
        [Range(0, 500)]
        public double Peso { get; set; }
        public double Altura { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public int NivelDeAtividade { get; set; }

    }
}
