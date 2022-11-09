using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fodor_Emanuela_lab2.Data;
using Fodor_Emanuela_lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Fodor_Emanuela_lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context _context;

        public DetailsModel(Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.Include("Member").Include("Book").FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }


            ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
            ViewData["BookID"] = new SelectList(_context.Book, "ID", "Title");
            return Page();
        }
    }
}
