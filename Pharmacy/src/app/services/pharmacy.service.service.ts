import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PharmacyService {

  queryUrl:string = `https://localhost:5001/`



  constructor(private http:HttpClient) { }


  GetPatient(){

  }

}
