using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Section22.ASPNETCoreAdvanced.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime DOG { get; set; }
    }
}
