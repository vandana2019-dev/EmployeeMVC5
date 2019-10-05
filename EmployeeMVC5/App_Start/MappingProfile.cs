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
            Mapper.CreateMap<Employee, EmployeeDto>();
            Mapper.CreateMap<EmployeeDto, Employee>();
        }
       

    }
}