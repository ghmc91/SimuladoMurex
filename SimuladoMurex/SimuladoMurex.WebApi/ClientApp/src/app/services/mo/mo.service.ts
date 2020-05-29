import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs";
import { Mo } from "../../model/mo"

@Injectable({
  providedIn: "root"
})

export class MoService implements OnInit {
  private _baseUrl: string;
  public mos: Mo[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.mos = []
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public getAll(): Observable<Mo[]> {
    return this.http.get<Mo[]>(this._baseUrl + "api/mo");
  }
}
