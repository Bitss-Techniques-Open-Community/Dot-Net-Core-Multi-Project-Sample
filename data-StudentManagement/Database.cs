namespace data_StudentManagement
{
    public class Database
    {
        private static readonly string[] Students = new[]
       {
        "Rahul", "Dave", "John", "Amit", "Deepak", "Ankit", "Sunil", "Jazz", "Swat", "Sats"
       };

        public static List<string> GetStudentNames()
        {

            return Database.Students.ToList();
        }

    }
}