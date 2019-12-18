using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Like
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int PostId { get; set; }
    }
}
