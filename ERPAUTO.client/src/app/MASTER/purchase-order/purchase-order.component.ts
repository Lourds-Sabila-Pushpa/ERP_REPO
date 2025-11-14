import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PurchaseOrderService } from './purchase-order.service';

@Component({
  selector: 'app-purchase-order',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './purchase-order.component.html',
  styleUrls: ['./purchase-order.component.css']
})
export class PurchaseOrderComponent {
  // 🔹 Header fields
  header = {
    vendor: '',
    doctype: '',
    docdt: new Date().toISOString().split('T')[0] // default today's date
  };

  // 🔹 Detail entry form (for inline add)
  detail = {
    part: 0,
    make: '',
    qty: 0,
    price: 0,
    value: 0,
    discount: 0,
    vat: 0,
  };

  // 🔹 Details grid list
  details: any[] = [];

  constructor(private poService: PurchaseOrderService) { }

  // 🔸 Update total value for current row
  updateValue() {
    const qty = this.detail.qty || 0;
    const price = this.detail.price || 0;
    const discount = this.detail.discount || 0;
    this.detail.value = (qty * price) * (discount / 100);
  }

  // 🔸 Add current detail to list
  addDetail() {
    if (!this.detail.part || !this.detail.make || this.detail.qty <= 0 || this.detail.price <= 0) {
      alert('Please fill all required detail fields');
      return;
    }
    this.details.push({ ...this.detail }); // shallow copy
    this.detail = { part: 0, make: '', qty: 0, price: 0, value: 0, discount: 0, vat: 0 }; // reset form
  }

  // 🔸 Remove row
  removeDetail(index: number) {
    this.details.splice(index, 1);
  }

  // 🔸 Save Purchase Order
  savePurchaseOrder() {
    if (!this.header.vendor || !this.header.doctype) {
      alert('Please fill header details');
      return;
    }
    if (this.details.length === 0) {
      alert('Please add at least one item');
      return;
    }

    const dto = {
      header: {
        vendor: this.header.vendor,
        doctype: this.header.doctype,
        docdt: this.header.docdt
      },
      details: this.details.map(d => ({
        part: d.part,
        make: d.make,
        qty: d.qty,
        price: d.price,
        discount: d.discount,
        vat: d.vat,
        value: d.value
      }))
    };

    this.poService.createPurchaseOrder(dto).subscribe({
      next: (res) => {
        alert('Purchase Order saved successfully!');
        console.log('Response:', res);
        this.resetForm();
      },
      error: (err) => {
        console.error('Save failed:', err);
        alert('Error saving Purchase Order');
      }
    });
  }

  // 🔹 Reset form after save
  resetForm() {
    this.header = { vendor: '', doctype: '', docdt: new Date().toISOString().split('T')[0] };
    this.details = [];
    this.detail = { part: 0, make: '', qty: 0, price: 0, value: 0, discount: 0, vat: 0 };
  }
}
