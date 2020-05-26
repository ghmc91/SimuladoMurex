import { Component } from "@angular/core";
import { Mo } from "../model/mo";
import { MoService } "../services/mo";
import { Router } from "@angular/router";
import { MoService } from "../services/mo/mo.service";

@Component({
  selector: "app-mo",
  templateUrl: "./mo.component.html",
  styleUrls: ["./mo.component.css"]
})
export class MoComponent implements OnInit {
  public mo: Mo

  constructor(private moService: MoService, private router: Router) {

  }

  ngOnit(): void {
    var moSession = sessionStorage.getItem('moSession')
    if (moSession) {
      this.mo = JSON.parse(moSession);
    } else {
      this.mo = new Mo();
    }
  }
}



