using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Entities
{
    public class Class1
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Login { get; set; }
        [StringLength(50)]
        public string PassHash { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime BirtDate { get; set; }
        [StringLength(50)]
        public string Gender { get; set; }
        [Key]
        public int Avatar { get; set; }
        [StringLength(450)]
        public string Description { get; set; }
        [Key]
        public int CountryId { get; set; }
        [Key]
        public int CityID { get; set; }

        //public virtual ICollection<>

    }
}
