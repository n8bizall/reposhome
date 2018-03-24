import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

import { Vendor } from '../models/vendor';

const url = 'http://localhost:61566/Vendors/';

@Injectable()
export class VendorService {

  List(): Observable<Vendor[]> {
    return this.http.get( url +  'List' ) as Observable<Vendor[]>;
  }
  Get(Id: string): Observable<Vendor> {
    return this.http.get(url + 'Get/' + Id) as Observable<Vendor>;
  }
  Create(vendor: Vendor): Observable<any> {
    return this.http.post(url + 'Create', vendor) as Observable<any>;
  }
  Change(vendor: Vendor): Observable<any> {
    return this.http.post(url + 'Change', vendor) as Observable<any>;
  }
  Remove(vendor: Vendor): Observable<any> {
    return this.http.post(url + 'Remove', vendor) as Observable<any>;
  }
  constructor( private http: HttpClient) { }

}
