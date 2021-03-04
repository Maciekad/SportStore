using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SportStoreDal.Models
{
    public abstract class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataType(DataType.Text), MaxLength(50), Display(Name ="Full Name")]
        public string FullName { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress), MaxLength(50)]
        [Display(Name ="Email Address")]
        public string EmailAdress { get; set; }
        

    }
}
