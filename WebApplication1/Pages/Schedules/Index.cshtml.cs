using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.Schedules
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public IndexModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<Schedule> Schedule { get;set; }

        public async Task OnGetAsync()
        {
            Schedule = await _context.Schedule.ToListAsync();
        }
    }
}
