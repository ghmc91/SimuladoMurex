import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class OperationsService {
  counterparty: string;

  constructor(private http: HttpClient) { }

  public getOperations() {
    return this.http.get("https://localhost:44329/api/operations");
  }
}
