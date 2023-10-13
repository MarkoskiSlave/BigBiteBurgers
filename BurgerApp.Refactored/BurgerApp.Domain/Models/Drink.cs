using BurgerApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BurgerApp.Domain.Models
{
    public class Drink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Calories { get; set; }
        public double Price { get; set; }
        public string RoadToImage { get; set; }
    }
}
