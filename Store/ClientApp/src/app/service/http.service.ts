import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class HttpService {
    readonly apiUrl = 'http://localhost:37569/api/';

    constructor(private http: HttpClient) { }

    post(data: any, url: string): Observable<any> {
        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        return this.http.post<any>(this.apiUrl + url, data, httpOptions);
    }

    get(data: any, url: string): Observable<any> {
        if (data) {
            return this.http.get<any[]>(this.apiUrl + url + data);
        }
        else {
            return this.http.get<any[]>(this.apiUrl + url);
        }
    }
}