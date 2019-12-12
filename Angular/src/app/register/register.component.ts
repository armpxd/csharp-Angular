import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { TouchSequence } from 'selenium-webdriver';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  constructor(private autService: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  register() {
    this.autService.register(this.model).subscribe(() => {
      this.alertify.success('registro satisfactorio');
    }, err => {
      this.alertify.error(err);
    });
  }

  cancel() {
    this.cancelRegister.emit(false);
    // console.log('cancelado');
  }
}
