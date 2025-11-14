import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vendor } from './vendor.model';

@Injectable({
  providedIn: 'root',
})
export class VendorService {

  private url: string = 'https://localhost:7261/api/Vendor'; 
  vendorList: Vendor[] = [];

  constructor(private http: HttpClient) { }

  // ✅ GET all vendors
  getAll(): Observable<Vendor[]> {
    return this.http.get<Vendor[]>(this.url);
  }

  // ✅ POST new vendor
  create(vendor: Vendor): Observable<Vendor> {
    return this.http.post<Vendor>(this.url, vendor);
  }

  // ✅ PUT update vendor (by ID)
  update(vendorCode: string, vendordet: Vendor): Observable<void> {
    return this.http.put<void>(`${this.url}/${vendorCode}`, vendordet);
  }

  // ✅ DELETE vendor (by ID)
  delete(vendorCode: string): Observable<void> {
    return this.http.delete<void>(`${this.url}/${vendorCode}`);
  }

  // ✅ Refresh list (optional, for local caching)
  refreshList() {
    this.http.get<Vendor[]>(this.url).subscribe({
      next: (res) => (this.vendorList = res),
      error: (err) => console.error('Error loading vendors:', err),
    });
  }
}
