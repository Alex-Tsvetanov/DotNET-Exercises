using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Email = "user@users.db",
                    Role = UserRolesEnum.STUDENT,
                    FacultyNumber = "1234567890"
                });
                context.SaveChanges();
                var users = context.Users.ToList();
            }
        }
    }
}
