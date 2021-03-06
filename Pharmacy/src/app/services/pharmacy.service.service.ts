import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class PharmacyService {

  queryUrl:string = `http://localhost:5000`



  constructor(private http:HttpClient) { }


  GetPatient(firstName:string){

    let res = this.http.get<any>(`${this.queryUrl}/patients/firstname/${firstName}`);
    console.log(res);
    return (res);
  }

}
