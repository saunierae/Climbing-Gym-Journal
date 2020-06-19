using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingGym.Data.Models
{
    public class SingleGym
    {
        //get information for the single gym
        [Key]
        public int GymId { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Type of Gym")]
        public GymType Type { get; set; }
    }
}
