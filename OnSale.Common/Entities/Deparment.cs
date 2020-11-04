using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace OnSale.Common.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "La longitud del {0} no puede ser mayor a {1}")]
        [Required]

        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }


        //un departamento pertenece a un pais
        [JsonIgnore]
        public Country Country { get; set; }

    }
}


