﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpiThermo.Models;

namespace rpiThermo.Pages.Schedules
{
    public class DetailsModel : PageModel
    {
        private readonly rpiThermo.Models.rpiThermoContext _context;

        public DetailsModel(rpiThermo.Models.rpiThermoContext context)
        {
            _context = context;
        }

        public Schedule Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Schedule = await _context.Schedule.FirstOrDefaultAsync(m => m.ID == id);

            if (Schedule == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
