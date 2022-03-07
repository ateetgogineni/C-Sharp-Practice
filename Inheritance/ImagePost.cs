using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePolymorphism
{
    class ImagePost:Post   // Inherit from base class to derive class
    {
        public string Image { get; set; }

        public ImagePost()
        {
        }


        public ImagePost(string title, string username, string image, bool isprotected)     // first 4 from the Post class, Image is the property from ImagePost class.
        {   
            this.Id = GenerateId();
            this.Title = title;
            this.UserName = username;
            this.Image = image;
            this.IsProtected = isprotected;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}  {2}  {3}", Id, Title, UserName, Image);
        }

    }
}
