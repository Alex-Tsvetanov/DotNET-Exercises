using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    internal class Program
    {
        public static UserRolesEnum Str2Role(string str)
        {
            str = str.ToUpper();
            if (str == "ANONYMOUS") return UserRolesEnum.ANONYMOUS;
            if (str == "ADMIN") return UserRolesEnum.ADMIN;
            if (str == "INSPECTOR") return UserRolesEnum.INSPECTOR;
            if (str == "PROFESSOR") return UserRolesEnum.PROFESSOR;
            if (str == "STUDENT") return UserRolesEnum.STUDENT;
            return UserRolesEnum.ANONYMOUS;
        }
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();
                while (true)
                {
                    Console.WriteLine("List of commands:\nadd - Adds a new user to the database\nremoveEnter command:");
                    string command = Console.ReadLine();
                    if (command == "exit")
                        break;
                    if (command == "add")
                    {
                        Console.WriteLine("Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Password:");
                        var password = Console.ReadLine();
                        Console.WriteLine("Email:");
                        var email = Console.ReadLine();
                        Console.WriteLine("Role:");
                        var role = Str2Role(Console.ReadLine());
                        Console.WriteLine("Faculty Number:");
                        var facultyNumber = Console.ReadLine();
                        context.Add<DatabaseUser>(new DatabaseUser()
                        {
                            Name = name,
                            Password = password,
                            Expires = DateTime.Now.AddYears(10),
                            Email = email,
                            Role = role,
                            FacultyNumber = facultyNumber
                        });
                        context.SaveChanges();
                    }
                    else if (command == "remove")
                    {
                        Console.WriteLine("Name:");
                        var name = Console.ReadLine();
                        var user = context.Users.FirstOrDefault(u => u.Name == name);
                        if (user == null)
                        {
                            Console.WriteLine("User not found.");
                            continue;
                        }
                        context.Remove<DatabaseUser>(user);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
