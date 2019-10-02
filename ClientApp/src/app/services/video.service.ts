import { Injectable } from '@angular/core';
import { Video } from '../model/video';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { EntityBase } from '../model/entity-base';

@Injectable({
  providedIn: 'root'
})
export class VideoService {

  constructor(private http: HttpClient) { }

  /**
   * Will fetch a single video if a videoId  is supplied.
   * If a videoId is not supplied then we will get all of the
   * videos for the signed in user.
   * @param videoId the primarey key of the video being requested
   */
  get(videoId?: number): Observable<Video> {
    return this.http.get<Video>(`/api/videos/${videoId}`, {});
  }

  /**
   * Updates the argued video
   * @param video the video to be updated
   * @returns the updated video
   */
  update(video: Video): Observable<Video> {
    return this.http.put<Video>(`/api/videos`, video);
  }

  delete(video: Video): Observable<any> {
    return this.http.delete(`/api/videos/${video}`)
  }

  create() {

  }
}
