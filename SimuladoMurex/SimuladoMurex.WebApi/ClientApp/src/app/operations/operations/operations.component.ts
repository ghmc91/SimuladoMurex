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
        this.data = await (source)
      });
  }

  }
