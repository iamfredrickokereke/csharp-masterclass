﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InherintanceC
{
    class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {
            //Inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //propertiy VideoUrl is a member of VideoPost
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }

        }

        private void TimerCallBack(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}",
                this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
    }
}
