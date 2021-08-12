import { Component, OnInit } from '@angular/core';
import { Videos } from '@app/models/videos';
import { VideosService } from '@app/services/videos.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-videos',
  templateUrl: './videos.component.html',
  styleUrls: ['./videos.component.css']
})
export class VideosComponent implements OnInit {
  loading = false;
  videos: Videos[];

  constructor(private videosService: VideosService) { }

  ngOnInit(): void {
    this.loading = true;
    this.videosService.getVideos().pipe(first()).subscribe(videos => {
        this.loading = false;
        this.videos = videos;
    });
  }
}
