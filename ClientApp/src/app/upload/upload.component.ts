import { Component, OnInit } from "@angular/core";
import { FormGroup, FormControl } from "@angular/forms";
import { Video } from "../model/video";

@Component({
  selector: "app-upload",
  templateUrl: "./upload.component.html",
  styleUrls: ["./upload.component.css"]
})
export class UploadComponent implements OnInit {
  // TODO: move to constants file or db driven
  payWallDesc =
    "Make story eligible to earn money and allow curators to recommend my video to interested viewers";
  uploadForm: FormGroup;
  constructor() {}

  ngOnInit() {
    // TODO: add validation
    this.uploadForm = new FormGroup({
      title: new FormControl(''),
      description: new FormControl(''),
      file: new FormControl(''), //TODO: handle file with angular forms?
      behindPayWall: new FormControl(''),
      tags: new FormControl(''),
      playList: new FormControl(''),
      isPublic: new FormControl('')
    });
  }

  /**
   * Build the video object from form values so
   * we can send it to the server.
   */
  upload() {
    console.log(this.uploadForm.value);
    let video: Video = Object.assign({}, this.uploadForm.value);
    console.log('video', video);
  }
}
