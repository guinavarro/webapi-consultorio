using Consultorio.Models.Entities;
using System.Collections.Generic;

namespace Consultorio.Models.Dtos
{
    public class EspecialidadeDetalhesDto
    {
        public string Nome { get; set; }
        public bool Ativa { get; set; }
        public List<ProfissionalDto> Profissional { get; set; }
    }
}
