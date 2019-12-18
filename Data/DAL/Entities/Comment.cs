using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Key]
        public int UserId { get; set; }
        [StringLength(150)]
        public string Content { get; set; }
        [Key]
        public int PostId { get; set; }
    }
}
