using SQLite;

namespace ExampleDB.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string StudentName { get; set; }
    }
}
