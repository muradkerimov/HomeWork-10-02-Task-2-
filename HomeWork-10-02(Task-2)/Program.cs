using System;

namespace HomeWork_10_02_Task_2_
{
    partial class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Murad", "Kerimov", "kerimovmurad1912@gmail.com", true);
            User user2 = new User("Inqilab", "Kerimov", "kerimovingilab0409@gmail.com", false);
            //Console.WriteLine(user1.Name);
            //Console.WriteLine(user1.Surname);
            Post post1 = new Post("lorem impus 1", "01/08/2020", 73, 10);
            Post post2 = new Post("lorem impus 2", "01/09/2020", 100, 40);
            //Console.WriteLine(post1.Text);
            //Console.WriteLine(post2.CommentCount);
            Comment comment1 = new Comment("Lorem Ipsum text 1", "01/10/2021");
            Comment comment2 = new Comment("Lorem Ipsum text 2", "01/10/2021");
            //Console.WriteLine(comment1.Text);
            //Console.WriteLine(comment1.CommentedDate);
            Post[] posts = { post1, post2 };
            user1.Posts = posts;
            //Console.WriteLine(user1.Posts[1].CommentCount);
            Comment[] comments = { comment1, comment2 };
            post1.Comments = comments;
            //Console.WriteLine(post1.Comments[1].Text);
            User[] users = { user1, user2 };
            comment1.Users = users;
            //Console.WriteLine(comment1.Users[0].Name + " " + comment1.Users[0].Surname);
        }
    }
}
