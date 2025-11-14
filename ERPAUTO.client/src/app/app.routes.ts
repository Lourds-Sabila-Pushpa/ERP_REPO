import { Routes } from '@angular/router';
import { PurchaseOrderComponent } from './MASTER/purchase-order/purchase-order.component';

export const routes: Routes = [
  { path: '', component: PurchaseOrderComponent },
  { path: 'purchase-order', component: PurchaseOrderComponent }
];
