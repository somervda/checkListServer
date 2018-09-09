using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using checkListServer.Controllers.Resources;
using checkListServer.Models;
using checkListServer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace checkListServer.Controllers
{
    public class CheckListsController : Controller
    {
        private readonly ChecklistDBContext context;
        private readonly IMapper mapper;
        public CheckListsController(ChecklistDBContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/checklists")]
        public async Task<IEnumerable<CheckListResource>> GetLists()
        {
            var checkLists = await context.CheckLists.Include(l => l.CheckListItems).ToListAsync();
            return mapper.Map<List<CheckList>, List<CheckListResource>>(checkLists);
        }

    }
}