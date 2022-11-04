using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fodor_Emanuela_lab2.Data;
using Fodor_Emanuela_lab2.Models;
using Fodor_Emanuela_lab2.Models.ViewModels;

namespace Fodor_Emanuela_lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context _context;

        public IndexModel(Fodor_Emanuela_lab2.Data.Fodor_Emanuela_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoriesIndexData CategoriesData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoriesData = new CategoriesIndexData();
            CategoriesData.Categories = await _context.Category
            .Include(i => i.BookCategories)
            .ThenInclude(c => c.Book)
            .ThenInclude(c=>c.Author)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();
            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoriesData.Categories
                .Where(i => i.ID == id.Value).Single();
                ICollection<BookCategory>? bookCategories = category.BookCategories;
                CategoriesData.Books = (List<Book>)bookCategories;
            }
        }
    }
}
