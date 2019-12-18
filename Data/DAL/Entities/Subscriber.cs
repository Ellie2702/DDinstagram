using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Subscriber
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int SubscriberId { get; set; }

    }
}
