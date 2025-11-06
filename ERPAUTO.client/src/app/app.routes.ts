import { Routes } from '@angular/router';
import { VendorComponent } from './MASTER/vendor/vendor.component';

export const routes: Routes = [
  { path: '', component: VendorComponent },
  { path: 'vendor', component: VendorComponent }
];
