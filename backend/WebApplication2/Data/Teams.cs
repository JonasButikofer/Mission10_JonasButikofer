using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApplication2.Data;

namespace WebApplication2
{
    [Table("Teams")]
    public class Teams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; } = 0;

        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }

        public int? CaptainID { get; set; }

        // Navigation property for related Bowlers.
        // Marking with [JsonIgnore] prevents a cycle during serialization.
        [JsonIgnore]
        public ICollection<Bowlers> Bowlers { get; set; } = new List<Bowlers>();
    }
}
