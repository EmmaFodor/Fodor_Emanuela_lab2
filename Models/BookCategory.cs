using Microsoft.EntityFrameworkCore;

namespace Fodor_Emanuela_lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
       // public Author? Author { get; set; } //navigation property


    }
}
