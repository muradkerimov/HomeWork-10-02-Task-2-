namespace HomeWork_10_02_Task_2_
{
    partial class Program
    {
        class Post
        {
            public string Text;
            public string SharedDate;
            public int LikeCount;
            public int CommentCount;
            public Comment[] Comments;

            public Post()
            {

            }

            public Post(string text, string shareDate, int likeCount, int commentCount)
            {
                Text = text;
                SharedDate = shareDate;
                LikeCount = likeCount;
                CommentCount = commentCount;
            }
        }
    }
}
