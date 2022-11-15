using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fodor_Emanuela_lab2.Data;
using Fodor_Emanuela_lab2.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Fodor_Emanuela_lab2.Pages.Categories
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context _context;

        public DetailsModel(Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
