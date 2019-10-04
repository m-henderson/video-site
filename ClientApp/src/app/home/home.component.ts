import { Component, OnInit } from '@angular/core';
import { VideoService } from '../services/video.service';
import { Video } from '../model/video';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  videos: Video[];
  constructor(private videoService: VideoService) {
  }

  ngOnInit() {
    this.videoService.getAll().subscribe(videos => {
      this.videos = videos;
    }, err => console.warn(err), () => {console.log(this.videos)});
  }
}
