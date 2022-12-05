using System;
using System.Threading.Tasks;

namespace StackOverflow_Post___Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("First Post", "Testing the capabilities of this new class");
            post1.Upvote();
            post1.Upvote();
            Console.Write($"Post1 count after upvoting: {post1.VoteCount}\n");
            post1.Downvote();
            post1.Downvote();
            post1.Downvote();
            post1.Downvote();
            Console.Write($"Post1 count after downvoting: {post1.VoteCount}\n");
            Console.Write($"Post1 title: {post1.Title}\n");
            Console.Write($"Post1 description: {post1.Description}\n");
            Console.Write($"Post1 creation date: {post1.CreatedDate}\n");

            Task.Delay(5000).Wait();
            var post2 = new Post("Second Post", "Verifying this is a second set of data");
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            Console.Write($"Post2 count after upvoting: {post2.VoteCount}\n");
            Console.Write($"Post2 created date: {post2.CreatedDate}\n");

        }
    }
}
