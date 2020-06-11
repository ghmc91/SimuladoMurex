import { Component, OnInit } from '@angular/core';
import { OperationsService } from "./operations.service";
import { map } from 'rxjs/operators';
import { rejects } from 'assert';


@Component({
  selector: 'app-operations',
  templateUrl: './operations.component.html',
  styleUrls: ['./operations.component.css']
})
export class OperationsComponent implements OnInit {

  data: any;

  constructor(private operationsService: OperationsService) { }

  ngOnInit(): void {
    this.loadOperations();
  }

  loadOperations() {
    return this.operationsService
      .getOperations()
      .subscribe(async source => {
        this.data = await this.Customers(source)
      });
  }
  

  Customers = dataArr => {
    return new Promise((resolve, reject) => {
      const UniArr = []
      const map = new Map()
      for (const item of dataArr) {
        if (!map.has(item.counterparty)) {
          map.set(item.counterparty, true)
          UniArr.push(item)
        }
      }
      resolve(UniArr)
    })
  }


}
