import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
@Injectable()
export class VehicleService {

  constructor(private http: Http) { }

  getMakes(){
    return this.http.get('/api/makes').map(res =>res.json());
    
  }
  getFeature(){
    return this.http.get('/api/features').map(res =>res.json());
    
  }
}
