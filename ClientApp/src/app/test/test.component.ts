import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class testComponent {
  constructor(private http: HttpClient,private router: Router, @Inject('BASE_URL') private baseUrl: string) 
  { 
    this.prueba_test();
  }

  prueba_test()
  {
    this.http.get<Equipo[]>(this.baseUrl + 'equipo/seeEquipos').subscribe(
      result=>{
        console.log(result);
      }, error=>{console.log("error");})
  }
}

interface Equipo
{
  Id_equipo: number;
  Codigo_Equipo: string;
  Nombre_equipo: string
  Estado_Equipo: string;
  Detalle_equipo: string;
}