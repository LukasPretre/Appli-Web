using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace pizza_mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }

        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Display(Name = "Prix (€)")]
        public float prix { get; set; }

        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }

        [Display(Name = "Ingrédient")]
        [JsonIgnore]
        public string ingredient { get; set; }

        [NotMapped]
        [JsonPropertyName("ingredient")]
        public string[] listeIngredients
        {
            get
            {
                if((ingredient == null) ||(ingredient.Count() == 0))
                {
                    return null;
                }
                return ingredient.Split(", ");

            }
        }
    }
}
