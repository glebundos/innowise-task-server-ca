using AutoMapper;
using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Responses;
using innowise_task_server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innowise_task_server.Application.Mappers
{
    public class FridgeMappingProfile: Profile
    {
        public FridgeMappingProfile()
        {
            CreateMap<Fridge, FridgeResponse>().ReverseMap();
            CreateMap<Fridge, CreateFridgeCommand>().ReverseMap();
            CreateMap<Fridge, UpdateFridgeCommand>().ReverseMap();
        }
    }
}
