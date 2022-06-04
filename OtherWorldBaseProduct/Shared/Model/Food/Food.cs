using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OtherWorldBaseProduct.Shared.Model.Food
{

    public class FoodResult
    {
        [JsonPropertyName("food")]
        public FoodData foodData { get; set; }

    }


    public class FoodData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("cal")]
        public int Cal { get; set; }
    }

}
