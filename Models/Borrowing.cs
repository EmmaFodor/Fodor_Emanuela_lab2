using System.ComponentModel.DataAnnotations;

namespace Fodor_Emanuela_lab2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; } //navigation property
        public int? BookID { get; set; }
        public Book? Book { get; set; } //navigation property
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
