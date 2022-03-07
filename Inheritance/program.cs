using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inheritance allows to define a class in term of other class which makes easier and maintain
             * This also provides an opportunity to reuse the code functionality and speeds up the code.
             * Example : MonoBehaviour is the best example in unity.
             */

            Post post = new Post("Good morning", "Hello", true);
            Console.WriteLine(post.ToString());
            ImagePost image = new ImagePost("First Post", "Hi", "Image", true);
            Console.WriteLine(image.ToString());


            VideoPost video = new VideoPost("Hi", "Hey", true, "video", 15);
            Console.WriteLine(video.ToString());


            Console.Read();
        }
    }
}
