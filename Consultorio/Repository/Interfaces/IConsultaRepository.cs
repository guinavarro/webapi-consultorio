﻿using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consultorio.Repository.Interfaces
{
    public interface IConsultaRepository: IBaseRepository
    {
        Task<IEnumerable<Consulta>> GetConsultas(ConsultaParams parms);

        Task<Consulta> GetConsultaById(int id);
    }
}
