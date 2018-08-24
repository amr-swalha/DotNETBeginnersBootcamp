using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExampleDB.Models;
using SQLite;

namespace ExampleDB
{
    public class NETDatabase
    {
        readonly SQLiteAsyncConnection database;
        public NETDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Student>().Wait();
        }

        public Task<List<Student>> GetAllStudentsAsync()
        {
            return database.Table<Student>().ToListAsync();
        }

        public Task<Student> GetStudentByIdAsync(int id)
        {
            return database.Table<Student>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveStudentAsync(Student item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteStudentAsync(Student item)
        {
            return database.DeleteAsync(item);
        }
    }
}
