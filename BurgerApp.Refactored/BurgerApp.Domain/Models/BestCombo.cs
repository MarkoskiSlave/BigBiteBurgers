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
    public class BestCombo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BestComboId { get; set; }
        [ForeignKey("BurgerId")]
        public Burger Burger { get; set; }
        public int BurgerId { get; set; }
        [ForeignKey("FriesId")]
        public Fries Fries { get; set; }
        public int FriesId { get; set; }
        [ForeignKey("DrinkId")]
        public Drink Drink { get; set; }
        public int DrinkId { get; set; }
        public string BestComboName { get; set; }
        public int Calories { get; set; }
        public double Price { get; set; }
        public string RoadToImage { get; set; }
    }
}
