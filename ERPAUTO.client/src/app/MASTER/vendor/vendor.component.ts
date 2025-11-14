import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { VendorService } from './vendor.service';
import { Vendor } from './vendor.model';

@Component({
  selector: 'app-vendor',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './vendor.component.html',
  styleUrls: ['./vendor.component.css']
})
export class VendorComponent implements OnInit {

  vendor: Vendor = new Vendor();
  vendorList: Vendor[] = [];
  searchText: string = '';
  isEditing: boolean = false;

  constructor(private vendorService: VendorService) { }

  ngOnInit(): void {
    this.loadVendors();
  }

  //loadVendors() {
  //  this.vendorService.getAll().subscribe({
  //    next: (res) => (this.vendorList = res),
  //    error: (err) => console.error('Error loading vendors:', err),
  //  });
  //}

  loadVendors() {
    this.vendorService.getAll().subscribe({
      next: (res) => {
        this.vendorList = res;
        console.log('Vendor List Loaded:', this.vendorList); // 👈 check in console
      },
      error: (err) => console.error('Error loading vendors:', err),
    });
  }


  get filteredVendors() {
    if (!this.searchText) return this.vendorList;
    const search = this.searchText.toLowerCase();
    return this.vendorList.filter(v =>
      v.vendor.toLowerCase().includes(search) ||
      v.name.toLowerCase().includes(search) ||
      v.namear.toLowerCase().includes(search)
    );
  }

  onSubmit() {
    if (!this.isEditing) {
      this.vendorService.create(this.vendor).subscribe({
        next: () => {
          alert('Vendor added successfully!');
          this.vendor = new Vendor();
          this.loadVendors();
        },
        error: (err) => console.error('Error adding vendor:', err),
      });
    } else {
      this.vendorService.update(this.vendor.vendor, this.vendor).subscribe({
        next: () => {
          alert('Vendor updated successfully!');
          this.vendor = new Vendor();
          this.isEditing = false;
          this.loadVendors();
        },
        error: (err) => console.error('Error updating vendor:', err),
      });
    }
  }

  onEdit(v: Vendor) {
    this.vendor = { ...v };
    this.isEditing = true;
  }

  onDelete(vendorCode: string) {
    if (confirm('Are you sure you want to delete this vendor?')) {
      this.vendorService.delete(vendorCode).subscribe({
        next: () => {
          alert('Vendor deleted successfully!');
          this.loadVendors();
        },
        error: (err) => console.error('Error deleting vendor:', err),
      });
    }
  }
}
