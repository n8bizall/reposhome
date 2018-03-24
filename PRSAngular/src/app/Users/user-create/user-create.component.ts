import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { UserService } from '../../Services/user.service';
import { User } from '../../models/user';

@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html',
  styleUrls: ['./user-create.component.css']
})
export class UserCreateComponent implements OnInit {

  pagetitle: string = 'User Create';
  user: User = new User(0, '', '', '', '', '', '', false, false, true);

  constructor(
    private UserSvc: UserService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

create(): void {
  this.UserSvc.Create(this.user)
  .subscribe(res => {
    console.log(res);
    this.router.navigateByUrl('/users/list');
});
}

    ngOnInit() {}
}

