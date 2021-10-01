using System;

namespace HomeWork_10_02_Task_2_
{
    partial class Program
    {
        class User
        {
            public string Name;
            public string Surname;
            public string Email;
            public string DateOfBirth;
            public bool IsSingle;
            public Post[] Posts;

            public User()
            {
                Console.WriteLine("create account!");
            }

            public User(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public User(string name, string surname, string email, bool isSingle)
            {
                Name = name;
                Surname = surname;
                Email = email;
                IsSingle = isSingle;
            }
        }
    }
}
