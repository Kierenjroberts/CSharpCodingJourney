using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Post
    {
         public string title;
         public string description;

         public string ForumPost(string title, string description)
         {
             var date = DateTime.Now;
             var stackOverflowPost = String.Join(',', title, description, Convert.ToString(date));
             return stackOverflowPost;
         }

         public int VoteCountAdd(int vote)
         {
             vote += 1;
             return vote;
         }

         public int VoteCountSubtract(int vote)
         {
             vote -= 1;
             return vote;
         }
    }
}
