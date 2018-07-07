using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Section21.EntityFrameWork
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
