using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Data  // Ensure this matches your project structure
{
    public class Bowlers  
    {
        [Key]
        public int BowlerID { get; set; }  // PRIMARY KEY

        [MaxLength(50)]
        public string? BowlerLastName { get; set; }

        [MaxLength(50)]
        public string? BowlerFirstName { get; set; }

        [MaxLength(1)]
        public string? BowlerMiddleInit { get; set; }

        [MaxLength(50)]
        public string? BowlerAddress { get; set; }

        [MaxLength(50)]
        public string? BowlerCity { get; set; }

        [MaxLength(2)]
        public string? BowlerState { get; set; }

        [MaxLength(10)]
        public string? BowlerZip { get; set; }

        [MaxLength(14)]
        public string? BowlerPhoneNumber { get; set; }

        [ForeignKey("Teams")]
        public int? TeamID { get; set; }
        public Teams? Team { get; set; }
    }
}
