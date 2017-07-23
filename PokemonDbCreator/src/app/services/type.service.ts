import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/Rx';
import { Config } from '../app.config';
import { Types } from '../models/types';

@Injectable()
export class TypeService {
  server = Config.typeServer;
  types : Array<Types>;

  constructor(private http : Http) { }

  getAllTypes() : Observable<any>{
    return this.http.get(this.server)
      .map((res) => { return res.json(); });
  }

  getTypebyId(id : number) : Observable<Types>{
    return this.http.get(this.server + id)
      .map((res) => { return res.json(); });
  }
}
