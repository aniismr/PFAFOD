import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { User } from '../model/user';
import { Observable, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { map, catchError } from 'rxjs/operators';
import { Role } from '../model/Role';

@Injectable({
  providedIn: 'root'
})
export class LogindbService {
  constructor(private http: HttpClient, public router: Router) {
  }
  currentUser = {};
  headers = new HttpHeaders().set('Content-Type', 'application/json');
  register(user: User): Observable<any> {
    let api = "http://localhost:5000/api/Utilisateurs";
    return this.http.post(api, user)
      .pipe(
        catchError(this.handleError)
      )
  }
  roles(){
    return this.http.get("http://localhost:5000/api/roles");
  }
login(user: User) 
{
  console.log(user);
  return this.http.post<any>("http://localhost:5000/api/signin", user)
  .subscribe((res: any) => {
    localStorage.setItem('access_token', res.token)
    this.getUserProfile(res._id).subscribe((res) => {
      this.currentUser = res;
      this.router.navigate(['/']);
    })
  })
      
}
getUserProfile(id): Observable<any> {
  let api = "http://localhost:5000/api/candidats/"+id;
  return this.http.get(api, { headers: this.headers }).pipe(
    map((res: Response) => {
      return res || {}
    }),
    catchError(this.handleError)
  )
}
handleError(error: HttpErrorResponse) {
  let msg = '';
  if (error.error instanceof ErrorEvent) {
    // client-side error
    msg = error.error.message;
  } else {
    // server-side error
    msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
  }
  return throwError(msg);
}
getToken() {
  return localStorage.getItem('access_token');
}

get isLoggedIn(): boolean {
  let authToken = localStorage.getItem('access_token');
  return (authToken !== null) ? true : false;
}
doLogout() {
  let removeToken = localStorage.removeItem('access_token');
  if (removeToken == null) {
    this.router.navigate(['log-in']);
  }
}

}
