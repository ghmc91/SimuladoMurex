import { Component, OnInit } from "@angular/core";
import { Mo } from "../model/mo";
import { Router } from "@angular/router";
import { MoService } from "../services/mo/mo.service";

@Component({
  selector: "app-mo",
  templateUrl: "./mo.component.html",
  styleUrls: ["./mo.component.css"]
})
export class MoComponent implements OnInit {

  constructor() { }

  today: Date = new Date;

  mos: Mo[] = [
    { moId: 1, tradeDate: this.today, counterparty: 'Gustavo', typology: 1 }
  ]
  ngOnInit(): void {
  }
  
}




