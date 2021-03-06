import { Component, OnInit } from '@angular/core';
import { PharmacyService } from '../../services/pharmacy.service.service';

@Component({
  selector: 'app-name-search',
  templateUrl: './name-search.component.html',
  styleUrls: ['./name-search.component.css']
})
export class NameSearchComponent implements OnInit {

  firstName:string;

  constructor(private service:PharmacyService) { }

  ngOnInit(): void {
  }


  onSubmit(){



    this.service.GetPatient(this.firstName).subscribe(data =>{
      console.log(data);
    })
  }

}
