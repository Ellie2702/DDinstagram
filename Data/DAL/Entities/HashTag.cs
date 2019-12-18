using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class HashTag
    {
        [Key]
        public int HashTagId { get; set; }
        [StringLength(50)]
        public int HashName { get; set; }
    }
}
