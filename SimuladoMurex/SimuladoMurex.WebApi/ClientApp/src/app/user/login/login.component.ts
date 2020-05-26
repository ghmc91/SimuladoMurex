import { Component } from "@angular/core";
import { User } from "../../../../model/user";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public user = new User();
  public autenthicUser: boolean;
  public users = ["user1", "user2", "user3"]
  constructor() {
    this.user = new User()
  }
 
  entrar() {
    if (this.user.email == "teste@teste" && this.user.password == "abc123") {
      this.autenthicUser = true;
    }
  }

  }

