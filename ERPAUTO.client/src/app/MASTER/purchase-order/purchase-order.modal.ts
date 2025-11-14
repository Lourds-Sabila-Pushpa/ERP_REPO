// purchase-order.model.ts
export interface PurchaseOrderDTO {
  header: HeaderDTO;
  details: DetailDTO[];
}

export interface HeaderDTO {
  vendor: string;
  doctype: string;
  docdt: string; // use ISO string for backend
}

export interface DetailDTO {
  part: number;
  make: string;
  qty: number;
  price: number;
  value: number;
  discount: number;
}
