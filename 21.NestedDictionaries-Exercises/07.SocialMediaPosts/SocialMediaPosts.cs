using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SocialMediaPosts
{
    class SocialMediaPosts
    {
        static Dictionary<string, Dictionary<string, string>> postComments = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = new Dictionary<string, int>();
        static Dictionary<string, int> postDislikes = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "drop")
            {
                string command = input[0];
                string postName = input[1];

                switch (command)
                {
                    case "post":
                        CreatePost(postName);
                        break;
                    case "like":
                        LikePost(postName);
                        break;
                    case "dislike":
                        DislikePost(postName);
                        break;
                    case "comment":
                        string commentator = input[2];
                        string content = string.Join(" ", input.Skip(3));
                        CommentPost(postName, commentator, content);
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }

            foreach (var commentData in postComments)
            {
                string postName = commentData.Key;
                Dictionary<string, string> comments = commentData.Value;

                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine($"Comments:");

                if (comments.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var item in comments)
                {
                    string comentator = item.Key;
                    string content = item.Value;

                    Console.WriteLine($"*  {comentator}: {content}");
                }
            }
        }

        static void CreatePost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);
        }
        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }
        static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }
        static void CommentPost(string postName, string comemnator, string content)
        {
            postComments[postName].Add(comemnator, content);
        }
    }
}
