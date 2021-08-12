import { Component, OnInit } from '@angular/core';
import { Channels } from '@app/models/channel';
import { ChannelService } from '@app/services/channel.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-channels',
  templateUrl: './channels.component.html',
  styleUrls: ['./channels.component.css']
})
export class ChannelsComponent implements OnInit {
  loading = false;
  channels: Channels[];


  constructor(private channelService: ChannelService) { }

  ngOnInit(): void {
    this.loading = true;
    this.channelService.getChannels().pipe(first()).subscribe(channels => {
        this.loading = false;
        this.channels = channels;
    });
  }

}
