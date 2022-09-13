using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjectModel
{

    [Table("Students")]
    public abstract class Students // Base Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Birthday_date { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string House_Address { get; set; }
    }

}
