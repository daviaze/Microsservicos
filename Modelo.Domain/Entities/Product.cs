using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Modelo.Domain.Entities
{
    public class Product
    {
        [Key]
        [JsonIgnore]
        public Guid id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }
}
