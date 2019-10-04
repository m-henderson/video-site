using System;
using System.Collections.Generic;

namespace video_site.Models {
    // this class is used to model a video object
    public class Video {
        // primary key of video
        public int Id { get; set; }
        // date entity was created // TODO: move to entity base
        public DateTime Created { get; set; }
        // date entity was updated // TODO: move to entity base
        public DateTime Updated { get; set; }
        // The title of the video
        public string Title { get; set; }
        
        // The detailed description of the video
        public string Description { get; set; }

        // ASP.NET Core actually has a way of handling
        // files with a new type. we can set that type later
        // The actual file object of the video being uploaded
        public string File { get; set; }

        // The tags used for curating and sorting via algorythm
        public List<string> Tags { get; set; }

        // The playlist category that the video is associated with
        public int PlayListId { get; set; }

        // Bit value to determine if the user wants the video to be 
        // currated behind the metered paywall
        public bool BehindPayWall { get; set; }

        public Video()
        {
            this.Tags = new List<string>();
        }
    }
}