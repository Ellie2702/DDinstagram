using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class City
    {
        [Key]
        public int CityId { get; set; }
        [StringLength(150)]
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
