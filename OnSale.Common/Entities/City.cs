﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} character")]
        [Required]


        public string Name { get; set; }

        [JsonIgnore]
        [NotMapped]
        public int IdDepartment { get; set; }


        //Una ciudad pertenece a un departamento
        [JsonIgnore]
        public Department Department { get; set; }


    }
}
