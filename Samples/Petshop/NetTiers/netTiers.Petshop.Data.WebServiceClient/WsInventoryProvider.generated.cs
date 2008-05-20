﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Generated on : Monday, July 24, 2006
	Important: Do not modify this file. Edit the file netTiers.Petshop.Entities.Inventory.cs instead.
*/

#region "Using directives"

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using netTiers.Petshop.Entities;
using netTiers.Petshop.Data.Bases;

#endregion

namespace netTiers.Petshop.Data.WebServiceClient
{

	///<summary>
	/// This class is the webservice client implementation that exposes CRUD methods for netTiers.Petshop.Entities.Inventory objects.
	///</summary>
	public partial class WsInventoryProvider : InventoryProviderBase
	{
		#region "Declarations"	
	
		/// <summary>
		/// the Url of the webservice.
		/// </summary>
		protected string _url;
			
		#endregion "Declarations"
		
		#region "Constructors"
	
		/// <summary>
		/// Creates a new <see cref="WsInventoryProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		public WsInventoryProvider()
		{		
		}
		
		/// <summary>
		/// Creates a new <see cref="WsInventoryProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="url">The url to the nettiers webservice.</param>
		public WsInventoryProvider(string url)
		{
			this._url = url;
		}
			
		#endregion "Constructors"
		
		public string Url
        {
        	get {return this._url;}
        	set {this._url = value;}
        }
		
		#region "Convertion utility"
		
		/// <summary>
		/// Convert a collection from the ws proxy to a nettiers collection.
		/// </summary>
		public static netTiers.Petshop.Entities.TList<Inventory> Convert(WsProxy.Inventory[] items)
		{
			netTiers.Petshop.Entities.TList<Inventory> outItems = new netTiers.Petshop.Entities.TList<Inventory>();
			foreach(WsProxy.Inventory item in items)
			{
				outItems.Add(Convert(item));
			}
			return outItems;
		}
		
		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static netTiers.Petshop.Entities.Inventory Convert(WsProxy.Inventory item)
		{	
			netTiers.Petshop.Entities.Inventory outItem = new netTiers.Petshop.Entities.Inventory();
			Convert(outItem, item);					
			return outItem;
		}
		
		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static netTiers.Petshop.Entities.Inventory Convert(netTiers.Petshop.Entities.Inventory outItem , WsProxy.Inventory item)
		{	
			outItem.ItemId = item.ItemId;
			outItem.SuppId = item.SuppId;
			outItem.Qty = item.Qty;
			outItem.Timestamp = item.Timestamp;
			
			outItem.OriginalItemId = item.ItemId;
			outItem.OriginalSuppId = item.SuppId;
							
			outItem.AcceptChanges();			
			return outItem;
		}
		
		/// <summary>
		/// Convert a nettiers entity to the ws proxy entity.
		/// </summary>
		public static WsProxy.Inventory Convert(netTiers.Petshop.Entities.Inventory item)
		{			
			WsProxy.Inventory outItem = new WsProxy.Inventory();			
			outItem.ItemId = item.ItemId;
			outItem.SuppId = item.SuppId;
			outItem.Qty = item.Qty;
			outItem.Timestamp = item.Timestamp;

			outItem.OriginalItemId = item.OriginalItemId;
			outItem.OriginalSuppId = item.OriginalSuppId;
							
			return outItem;
		}
		
		/// <summary>
		/// Convert a collection from  to a nettiers collection to a the ws proxy collection.
		/// </summary>
		public static WsProxy.Inventory[] Convert(netTiers.Petshop.Entities.TList<Inventory> items)
		{
			WsProxy.Inventory[] outItems = new WsProxy.Inventory[items.Count];
			int count = 0;
		
			foreach (netTiers.Petshop.Entities.Inventory item in items)
			{
				outItems[count++] = Convert(item);
			}
			return outItems;
		}

		
		#endregion
		
		#region "Get from  Many To Many Relationship Functions"
		#endregion	
		
		
		#region "Delete Functions"			
			
			/// <summary>
			/// 	Deletes a row from the DataSource.
			/// </summary>
			/// <param name="ItemId">. Primary Key.</param>	
			/// <param name="SuppId">. Primary Key.</param>	
			/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
			/// <remarks>Deletes based on primary key(s).</remarks>
			/// <returns>Returns true if operation suceeded.</returns>
			public override bool Delete(TransactionManager transactionManager, System.Guid itemId, System.Guid suppId, byte[] timestamp)
			{
				// call the proxy
				WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
				proxy.Url = this._url;
				
				bool result = proxy.InventoryProvider_Delete(itemId, suppId, timestamp);				
				return result;
			}
			
			#endregion
	
		
		#region "Find Functions"
		
		
		/// <summary>
		/// 	Returns rows meeting the whereclause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks>Operators must be capitalized (OR, AND)</remarks>
		/// <returns>Returns a typed collection of netTiers.Petshop.Entities.Inventory objects.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> Find(TransactionManager transactionManager, string whereClause, int start, int pagelen, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			
			WsProxy.Inventory[] items = proxy.InventoryProvider_Find(whereClause, start, pagelen, out count);
			
			return Convert(items); 
		}
		
		#endregion "Find Functions"
		
		
		#region "GetList Functions"
				
		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>			
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of netTiers.Petshop.Entities.Inventory objects.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
				
			WsProxy.Inventory[] items = proxy.InventoryProvider_GetAll(start, pageLength, out count);
			
			return Convert(items); 
		}
		
		#endregion
		
		#region Get Paged
						
		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of netTiers.Petshop.Entities.Inventory objects.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			
			WsProxy.Inventory[] items = proxy.InventoryProvider_GetPaged(whereClause, orderBy, start, pageLength, out count);
			
			// Create a collection and fill it with the dataset
			return Convert(items); 
		}
		
		#endregion		
	
		
		#region "Get By Foreign Key Functions"
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Inventory_Item key.
		///		FK_Inventory_Item Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="itemId"></param>
		/// <param name="count">out parameter to get total records for query</param>	
		/// <remarks></remarks>		
		/// <returns>Returns a typed collection of netTiers.Petshop.Entities.Inventory objects.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> GetByItemId(TransactionManager transactionManager, System.Guid itemId, int start, int pageLength, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			WsProxy.Inventory[] items = proxy.InventoryProvider_GetByItemId(itemId, start, pageLength, out count);
			
			return Convert(items); 
		}
			
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_Inventory_Supplier key.
		///		FK_Inventory_Supplier Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="suppId"></param>
		/// <param name="count">out parameter to get total records for query</param>	
		/// <remarks></remarks>		
		/// <returns>Returns a typed collection of netTiers.Petshop.Entities.Inventory objects.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> GetBySuppId(TransactionManager transactionManager, System.Guid suppId, int start, int pageLength, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			WsProxy.Inventory[] items = proxy.InventoryProvider_GetBySuppId(suppId, start, pageLength, out count);
			
			return Convert(items); 
		}
			
		#endregion
		
		
		#region "Get By Index Functions"
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Inventory index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="itemId"></param>
		/// <param name="suppId"></param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>	
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="netTiers.Petshop.Entities.Inventory"/> class.</returns>
		public override netTiers.Petshop.Entities.Inventory GetByItemIdSuppId(TransactionManager transactionManager, System.Guid itemId, System.Guid suppId, int start, int pageLength, out int count)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			WsProxy.Inventory items = proxy.InventoryProvider_GetByItemIdSuppId(itemId, suppId, start, pageLength, out count);
			
			return Convert(items); 
		}
		
		#endregion "Get By Index Functions"
	
	
		#region "Insert Functions"
		/// <summary>
		/// 	Inserts a netTiers.Petshop.Entities.Inventory object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">netTiers.Petshop.Entities.Inventory object to insert.</param>		
		/// <remarks></remarks>		
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Insert(TransactionManager transactionManager, netTiers.Petshop.Entities.Inventory entity)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			
			try
			{
				WsProxy.Inventory result = proxy.InventoryProvider_Insert(Convert(entity));
				Convert(entity, result);
				return true;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				return false;
			}
		}
	
		/// <summary>
		/// Lets you efficiently bulk many entity to the database.
		/// </summary>
		/// <param name="transactionManager">NOTE: The transaction manager should be null for the web service client implementation.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		/// After inserting into the datasource, the netTiers.Petshop.Entities.Inventory object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		public override void BulkInsert(TransactionManager transactionManager, TList<netTiers.Petshop.Entities.Inventory> entityList)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			try
			{
				proxy.InventoryProvider_BulkInsert(Convert(entityList));
			}
			catch (Exception ex)
			{	
				System.Diagnostics.Debug.WriteLine(ex);
			}
		}

		#endregion
	
	
		#region "Update Functions"
						
		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">netTiers.Petshop.Entities.Inventory object to update.</param>		
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Update(TransactionManager transactionManager, netTiers.Petshop.Entities.Inventory entity)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			
			try
			{
				WsProxy.Inventory result = proxy.InventoryProvider_Update(Convert(entity));
				Convert(entity, result);
				entity.AcceptChanges();
				return true;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				return false;
			}
		}
		
		#endregion
			
		#region "Custom Methods"
		
	
		#region "CSP_Inventory_GetMaxSupplier"
				
		/// <summary>
		///	This method wrap the 'CSP_Inventory_GetMaxSupplier' stored procedure. 
		/// </summary>
			/// <param name="itemId"> A <c>System.Guid?</c> instance.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remark>This method is generate from a stored procedure.</remark>
		/// <returns>A <see cref="netTiers.Petshop.Entities.TList<Inventory>"/> instance.</returns>
		public override netTiers.Petshop.Entities.TList<Inventory> GetMaxSupplier(TransactionManager transactionManager, int start, int pageLength , System.Guid? itemId)
		{
			WsProxy.petshopDBServices proxy = new WsProxy.petshopDBServices();
			proxy.Url = this._url;
			
			WsProxy.Inventory[] items = proxy.InventoryProvider_GetMaxSupplier(start, pageLength , itemId);
			return Convert(items); 
		}
		
		#endregion
		
		
		#endregion
					
	}//end class
} // end namespace