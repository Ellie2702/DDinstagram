using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    class Image
    {
        [Key]
        public int ImageId { get; set; }
        [Key]
        public int ImageType { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
    }
}
