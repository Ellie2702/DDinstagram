using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Post
    {
        [Key]
        public int PostId { get; set; }
        [Key]
        public int UserId { get; set; }
        [StringLength(300)]
        public string Content { get; set; }
        [Key]
        public int Image { get; set; }

    }
}
