using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using video_site.Models;

namespace video_site.Controllers {
    
    [Route("api/[controller]")]
    public class VideoController : Controller {

        [HttpGet("[action]")]
        public IEnumerable<Video> Get() {
            var videoList = new List<Video>();
            return videoList;
        }
    }
}