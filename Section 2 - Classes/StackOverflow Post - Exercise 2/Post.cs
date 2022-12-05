using System;
using System.Collections.Generic;

namespace StackOverflow_Post___Exercise_2
{
    public class Post
    {
        public int VoteCount { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public Post()
        {
            CreatedDate = DateTime.Now;
            VoteCount= 0;
        }
        public Post(string title, string description) : this()
        {
            Title = title; 
            Description = description;
        }

        public void Upvote() { VoteCount++; }

        public void Downvote() { VoteCount--; }
    }
}
