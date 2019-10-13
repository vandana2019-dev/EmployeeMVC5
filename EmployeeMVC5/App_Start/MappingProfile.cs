using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EmployeeMVC5.Models;
using EmployeeMVC5.Dtos;

namespace EmployeeMVC5.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Employee, EmployeeDto>();
            Mapper.CreateMap<EmploymentType, EmploymentTypeDto>();

            // Dto to Domain
            Mapper.CreateMap<EmployeeDto, Employee>()
                    .ForMember(em => em.Id, opt => opt.Ignore());

            Mapper.CreateMap<EmploymentTypeDto, EmploymentType>();
        }
       

    }
}