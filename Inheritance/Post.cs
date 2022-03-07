using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePolymorphism
{
    class Post
    {
        // private field-member
        private static int currentPostId;

        // properies 
        protected int Id { get; set; }
        protected string UserName { get; set; }
        protected string Title { get; set; }
        protected bool IsProtected { get; set; }


        public Post()
        {
            Id = 123;
            UserName = "Venkat";
            Title = "First Post";
            IsProtected = true;
        }

        // instance constructor that has 3 parameters
        public Post(string name, string title, bool isprotected)
        {
            this.Id = GenerateId();
            this.UserName = name;
            this.Title = title;
            this.IsProtected = isprotected;
        }

        protected int GenerateId()
        {
            return currentPostId++;
        }

        protected void UpdatePost(string tile , bool isPublic)
        {
            this.Title = Title;
            this.IsProtected = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}  {2}", Id, Title, UserName);
        }
    }
}
