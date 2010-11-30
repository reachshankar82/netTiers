﻿

/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file BillOfMaterialsTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="BillOfMaterials"/> objects (entity, collection and repository).
    /// </summary>
   public partial class BillOfMaterialsTest
    {
    	// the BillOfMaterials instance used to test the repository.
		protected BillOfMaterials mock;
		
		// the TList<BillOfMaterials> instance used to test the repository.
		protected TList<BillOfMaterials> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the BillOfMaterials Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock BillOfMaterials entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.BillOfMaterialsProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.BillOfMaterialsProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all BillOfMaterials objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.BillOfMaterialsProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.BillOfMaterialsProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.BillOfMaterialsProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all BillOfMaterials children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.BillOfMaterialsProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.BillOfMaterialsProvider.DeepLoading += new EntityProviderBaseCore<BillOfMaterials, BillOfMaterialsKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.BillOfMaterialsProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("BillOfMaterials instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.BillOfMaterialsProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock BillOfMaterials entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				BillOfMaterials mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.BillOfMaterialsProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.BillOfMaterialsProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.BillOfMaterialsProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock BillOfMaterials entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (BillOfMaterials)CreateMockInstance(tm);
				DataRepository.BillOfMaterialsProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.BillOfMaterialsProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.BillOfMaterialsProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock BillOfMaterials entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BillOfMaterials.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock BillOfMaterials entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BillOfMaterials.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<BillOfMaterials>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a BillOfMaterials collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BillOfMaterialsCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<BillOfMaterials> mockCollection = new TList<BillOfMaterials>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<BillOfMaterials> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a BillOfMaterials collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_BillOfMaterialsCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<BillOfMaterials>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<BillOfMaterials> mockCollection = (TList<BillOfMaterials>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<BillOfMaterials> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				BillOfMaterials entity = CreateMockInstance(tm);
				bool result = DataRepository.BillOfMaterialsProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<BillOfMaterials> t0 = DataRepository.BillOfMaterialsProvider.GetByComponentId(tm, entity.ComponentId, 0, 10);
				TList<BillOfMaterials> t1 = DataRepository.BillOfMaterialsProvider.GetByProductAssemblyId(tm, entity.ProductAssemblyId, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				BillOfMaterials entity = CreateMockInstance(tm);
				bool result = DataRepository.BillOfMaterialsProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				BillOfMaterials t0 = DataRepository.BillOfMaterialsProvider.GetByProductAssemblyIdComponentIdStartDate(tm, entity.ProductAssemblyId, entity.ComponentId, entity.StartDate);
				TList<BillOfMaterials> t1 = DataRepository.BillOfMaterialsProvider.GetByUnitMeasureCode(tm, entity.UnitMeasureCode);
				BillOfMaterials t2 = DataRepository.BillOfMaterialsProvider.GetByBillOfMaterialsId(tm, entity.BillOfMaterialsId);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				BillOfMaterials entity = mock.Copy() as BillOfMaterials;
				entity = (BillOfMaterials)mock.Clone();
				Assert.IsTrue(BillOfMaterials.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				BillOfMaterials mock = CreateMockInstance(tm);
				bool result = DataRepository.BillOfMaterialsProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				BillOfMaterialsQuery query = new BillOfMaterialsQuery();
			
				query.AppendEquals(BillOfMaterialsColumn.BillOfMaterialsId, mock.BillOfMaterialsId.ToString());
				if(mock.ProductAssemblyId != null)
					query.AppendEquals(BillOfMaterialsColumn.ProductAssemblyId, mock.ProductAssemblyId.ToString());
				query.AppendEquals(BillOfMaterialsColumn.ComponentId, mock.ComponentId.ToString());
				query.AppendEquals(BillOfMaterialsColumn.StartDate, mock.StartDate.ToString());
				if(mock.EndDate != null)
					query.AppendEquals(BillOfMaterialsColumn.EndDate, mock.EndDate.ToString());
				query.AppendEquals(BillOfMaterialsColumn.UnitMeasureCode, mock.UnitMeasureCode.ToString());
				query.AppendEquals(BillOfMaterialsColumn.BomLevel, mock.BomLevel.ToString());
				query.AppendEquals(BillOfMaterialsColumn.PerAssemblyQty, mock.PerAssemblyQty.ToString());
				query.AppendEquals(BillOfMaterialsColumn.ModifiedDate, mock.ModifiedDate.ToString());
				
				TList<BillOfMaterials> results = DataRepository.BillOfMaterialsProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed BillOfMaterials Entity with mock values.
		///</summary>
		static public BillOfMaterials CreateMockInstance_Generated(TransactionManager tm)
		{		
			BillOfMaterials mock = new BillOfMaterials();
						
			mock.StartDate = TestUtility.Instance.RandomDateTime();
			mock.EndDate = TestUtility.Instance.RandomDateTime();
			mock.BomLevel = TestUtility.Instance.RandomShort();
			mock.PerAssemblyQty = (decimal)TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			Product mockProductByComponentId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByComponentId);
			mock.ComponentId = mockProductByComponentId.ProductId;
			//OneToOneRelationship
			Product mockProductByProductAssemblyId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductAssemblyId);
			mock.ProductAssemblyId = mockProductByProductAssemblyId.ProductId;
			//OneToOneRelationship
			UnitMeasure mockUnitMeasureByUnitMeasureCode = UnitMeasureTest.CreateMockInstance(tm);
			DataRepository.UnitMeasureProvider.Insert(tm, mockUnitMeasureByUnitMeasureCode);
			mock.UnitMeasureCode = mockUnitMeasureByUnitMeasureCode.UnitMeasureCode;
		
			// create a temporary collection and add the item to it
			TList<BillOfMaterials> tempMockCollection = new TList<BillOfMaterials>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (BillOfMaterials)mock;
		}
		
		
		///<summary>
		///  Update the Typed BillOfMaterials Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, BillOfMaterials mock)
		{
			mock.StartDate = TestUtility.Instance.RandomDateTime();
			mock.EndDate = TestUtility.Instance.RandomDateTime();
			mock.BomLevel = TestUtility.Instance.RandomShort();
			mock.PerAssemblyQty = (decimal)TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			Product mockProductByComponentId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByComponentId);
			mock.ComponentId = mockProductByComponentId.ProductId;
					
			//OneToOneRelationship
			Product mockProductByProductAssemblyId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductAssemblyId);
			mock.ProductAssemblyId = mockProductByProductAssemblyId.ProductId;
					
			//OneToOneRelationship
			UnitMeasure mockUnitMeasureByUnitMeasureCode = UnitMeasureTest.CreateMockInstance(tm);
			DataRepository.UnitMeasureProvider.Insert(tm, mockUnitMeasureByUnitMeasureCode);
			mock.UnitMeasureCode = mockUnitMeasureByUnitMeasureCode.UnitMeasureCode;
					
		}
		#endregion
    }
}