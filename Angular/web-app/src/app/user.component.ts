import {Component} from '@angular/core';

@Component ({
  selector: 'app-user',
  templateUrl: './user.component.html'
})

export class UserComponent {
  userName = "";
  userList = [""];
  empty = true;

  onAddUser() {
    this.userList.push(this.userName);
    this.empty = false;
  }
}
