﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'PurchaseOrderHeader' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPurchaseOrderHeader 
	{
		/// <summary>			
		/// PurchaseOrderID : Primary key.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "PurchaseOrderHeader"</remarks>
		System.Int32 PurchaseOrderId { get; set; }
				
		
		
		/// <summary>
		/// RevisionNumber : Incremental number to track changes to the purchase order over time.
		/// </summary>
		System.Byte  RevisionNumber  { get; set; }
		
		/// <summary>
		/// Status : Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
		/// </summary>
		System.Byte  Status  { get; set; }
		
		/// <summary>
		/// EmployeeID : Employee who created the purchase order. Foreign key to Employee.EmployeeID.
		/// </summary>
		System.Int32  EmployeeId  { get; set; }
		
		/// <summary>
		/// VendorID : Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.
		/// </summary>
		System.Int32  VendorId  { get; set; }
		
		/// <summary>
		/// ShipMethodID : Shipping method. Foreign key to ShipMethod.ShipMethodID.
		/// </summary>
		System.Int32  ShipMethodId  { get; set; }
		
		/// <summary>
		/// OrderDate : Purchase order creation date.
		/// </summary>
		System.DateTime  OrderDate  { get; set; }
		
		/// <summary>
		/// ShipDate : Estimated shipment date from the vendor.
		/// </summary>
		System.DateTime?  ShipDate  { get; set; }
		
		/// <summary>
		/// SubTotal : Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
		/// </summary>
		System.Decimal  SubTotal  { get; set; }
		
		/// <summary>
		/// TaxAmt : Tax amount.
		/// </summary>
		System.Decimal  TaxAmt  { get; set; }
		
		/// <summary>
		/// Freight : Shipping cost.
		/// </summary>
		System.Decimal  Freight  { get; set; }
		
		/// <summary>
		/// TotalDue : Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
		/// </summary>
		System.Decimal  TotalDue  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _purchaseOrderDetailPurchaseOrderId
		/// </summary>	
		TList<PurchaseOrderDetail> PurchaseOrderDetailCollection {  get;  set;}	

		#endregion Data Properties

	}
}


