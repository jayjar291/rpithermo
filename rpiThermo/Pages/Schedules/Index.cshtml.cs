using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpiThermo.Models;

namespace rpiThermo.Pages.Schedules
{
    public class IndexModel : PageModel
    {
        private readonly rpiThermo.Models.rpiThermoContext _context;

        public IndexModel(rpiThermo.Models.rpiThermoContext context)
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
