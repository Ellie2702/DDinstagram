using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class HashTagPost
    {
        [Key]
        public int PostId { get; set; }
        [Key]
        public int HashTagId { get; set; }
    }
}
