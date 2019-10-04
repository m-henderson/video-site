using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using video_site.Models;

namespace video_site.Controllers {
    
    [Route("api/[controller]")]
    public class VideoController : Controller {

        [HttpGet]
        public IEnumerable<Video> Get() {
            var videoList = new List<Video>();
            var video = new Video();
            video.BehindPayWall = true;
            video.Created = DateTime.Now;
            video.Updated = DateTime.Now;
            video.Title = "How To Tie Your Shoe";
            video.Description = "An informative video on how to tie your shoe.";
            video.Id = 90;
            video.PlayListId = 3;
            video.Tags.Add("Lifestyle");

            var video2 = new Video();
            video2.BehindPayWall = true;
            video2.Created = DateTime.Now;
            video2.Updated = DateTime.Now;
            video2.Title = "How To Build a Boat";
            video2.Description = "This is a neat boat that I am building ";
            video2.Id = 90;
            video2.PlayListId = 3;
            video2.Tags.Add("Lifestyle");


            var video3 = new Video();
            video3.BehindPayWall = true;
            video3.Created = DateTime.Now;
            video3.Updated = DateTime.Now;
            video3.Title = "How To Build a Boat";
            video3.Description = "This is a neat boat that I am building ";
            video3.Id = 90;
            video3.PlayListId = 3;
            video3.Tags.Add("Lifestyle");
            


            var video4 = new Video();
            video4.BehindPayWall = true;
            video4.Created = DateTime.Now;
            video4.Updated = DateTime.Now;
            video4.Title = "How To Build a Boat";
            video4.Description = "This is a neat boat that I am building ";
            video4.Id = 90;
            video4.PlayListId = 3;
            video4.Tags.Add("Lifestyle");
            


            var video5 = new Video();
            video5.BehindPayWall = true;
            video5.Created = DateTime.Now;
            video5.Updated = DateTime.Now;
            video5.Title = "How To Build a Boat";
            video5.Description = "This is a neat boat that I am building ";
            video5.Id = 90;
            video5.PlayListId = 3;
            video5.Tags.Add("Lifestyle");
            
            
            videoList.Add(video);
            videoList.Add(video2);
            videoList.Add(video3);
            videoList.Add(video4);
            videoList.Add(video5);


            return videoList;
        }
    }
}