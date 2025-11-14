import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PurchaseOrderService {
  private baseUrl = 'https://localhost:7261/api/PurchaseOrder'; // adjust port if needed

  constructor(private http: HttpClient) { }

  // 🔹 Create Purchase Order (POST)
  createPurchaseOrder(dto: any): Observable<any> {
    return this.http.post(`${this.baseUrl}`, dto);
  }

  // (optional) You can later add getById(), getAll(), delete() etc.
}
