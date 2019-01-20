using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherintanceC
{

    // ImagePost derives from Post and adds a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // Constructor
        public ImagePost() { }

        // Constructor
        public ImagePost(string title, string sendByUsernae, string imageURL, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsernae;
            this.IsPublic = isPublic;

            //Porperty Image URL is a member of ImagePost, but not Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
