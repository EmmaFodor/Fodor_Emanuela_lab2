using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fodor_Emanuela_lab2.Data;
using Fodor_Emanuela_lab2.Models;

namespace Fodor_Emanuela_lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context _context;

        public CreateModel(Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "CategoryName");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
