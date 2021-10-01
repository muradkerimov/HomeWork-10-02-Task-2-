namespace HomeWork_10_02_Task_2_
{
    partial class Program
    {
        class Comment
        {
            public string Text;
            public string CommentedDate;
            public User[] Users;

            public Comment()
            {

            }
            public Comment(string text, string commentedDate)
            {
                Text = text;
                CommentedDate = commentedDate;
            }
        }
    }
}
