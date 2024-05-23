using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27EFinConsole.Model
{
    //Plane CLR Object : POCO
    [Table("Customer")]
    public class Customer
    {
        [Column("No",TypeName ="int")]
        [Key]
        public int No { get; set; }

        [Column("Name",TypeName ="varchar")]
        [StringLength(50)]
        public string ?Name { get; set; }

        [Column("Address", TypeName = "varchar")]
        [StringLength(50)]
        public string ?Address { get; set; }
    }
}
