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
        public DateTime Birthday_date { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string House_Address { get; set; }
        //public TypeOfStudent Type_of_Student { get; set; }

        //Test
        //public static Students CreateNewStudent(int ID, string Name, string Lastname, string Birthday_date, string Email, string Phone_Number, string House_Address, string Type_of_Student)
    }

}
