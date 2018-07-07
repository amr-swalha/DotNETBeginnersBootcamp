using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Section21.EntityFrameWork
{
    public class Grades
    {
        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string Grade { get; set; }
    }
}
