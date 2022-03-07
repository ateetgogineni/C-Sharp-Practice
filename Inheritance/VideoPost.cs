using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePolymorphism
{
    class VideoPost:Post
    {
        //protected string videoLink;
        //protected int videoLength;

        public string VideoLink { get; set; }
        public int VideoLength { get; set; }
      
        public VideoPost()
        {

        }

        public VideoPost(string title, string username, bool isprotected, string videolink, int videolength)
        { 
            this.Id = GenerateId();
            this.Title = title;
            this.UserName = username;
            this.IsProtected = isprotected;
            this.VideoLink = videolink;
            this.VideoLength = videolength;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}  {2}  {3}  {4} ", Id, Title, UserName, VideoLink, VideoLength);
        }
    }
}
