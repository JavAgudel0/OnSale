using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

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

    }
}
