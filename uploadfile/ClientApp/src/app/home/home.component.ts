import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public hostUrl: string = 'https://localhost:44370/';
  public ajaxSettings: object = {
    url: this.hostUrl + 'api/FileManager/FileOperations',
    uploadUrl: this.hostUrl + 'api/FileManager/Upload'
  };
}
