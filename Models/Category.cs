using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;
namespace Fodor_Emanuela_lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        //public ICollection<BookCategory>? BookCategories { get; set; }
        //public Book? Book { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }

}
