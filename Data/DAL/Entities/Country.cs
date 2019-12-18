using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Country
    {
        [Key]
        public int CountryId { get; set; }
        [StringLength(150)]
        public string CountryName { get; set; }

    }
}
