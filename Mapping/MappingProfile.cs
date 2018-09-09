using AutoMapper;
using checkListServer.Controllers.Resources;
using checkListServer.Models;

namespace checkListServer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CheckList, CheckListResource>();
            CreateMap<CheckListItem, CheckListItemResource>();
        }
    }
}