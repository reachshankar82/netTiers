﻿

/*
	File Generated by NetTiers templates [www.nettiers.com]
	Generated on : Monday, July 24, 2006
	Important: Do not modify this file. Edit the file CourierTest.cs instead.
*/

#region Using directives

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using netTiers.Petshop.Entities;
using netTiers.Petshop.Data;

#endregion

namespace netTiers.Petshop.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="Courier"/> objects (entity, collection and repository).
    /// </summary>
   public partial class CourierTest
    {
    	// the Courier instance used to test the repository.
		static private Courier mock;
		
		// the TList<Courier> instance used to test the repository.
		static TList<Courier> mockCollection;
		
		static TransactionManager transactionManager = null;
        
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {
			mock = (Courier)CreateMockInstance();						
			
        	if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction();
			}
			
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the Courier Entity with the {0} --", netTiers.Petshop.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   
        	if (DataRepository.Provider.IsTransactionSupported && transactionManager!=null && transactionManager.IsOpen)
			{
				transactionManager.Rollback();
			}
			
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock Courier entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			Assert.IsTrue(DataRepository.CourierProvider.Insert(transactionManager, mock), "Insert failed");
									
			System.Console.WriteLine("DataRepository.CourierProvider.Insert(mock):");			
			System.Console.WriteLine(mock);			
		}
		
		
		/// <summary>
		/// Selects all Courier objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			mockCollection = DataRepository.CourierProvider.GetAll(transactionManager);
			Assert.IsTrue(mockCollection.Count > 0, "No records returned.");
			System.Console.WriteLine("DataRepository.CourierProvider.GetAll():");			
			System.Console.WriteLine(mockCollection);
					
			
			// get paged
			int count = 0;
			DataRepository.CourierProvider.GetPaged(transactionManager, 0, 10, out count);
			System.Console.WriteLine("#get paged count: " + count.ToString());
		}
		
		
		
		
		/// <summary>
		/// Deep load all Courier children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			if (mockCollection.Count > 0)
			{
				//mockCollection.Shuffle();			
				DataRepository.CourierProvider.DeepLoad(mockCollection[0]);
				System.Console.WriteLine("Courier instance correctly deep loaded at 1 level.");
								
				mockCollection.Add(mock);
				DataRepository.CourierProvider.DeepSave(transactionManager, mockCollection);
			}			
		}
		
		/// <summary>
		/// Updates a mock Courier entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			UpdateMockInstance(mock);
			Assert.IsTrue(DataRepository.CourierProvider.Update(transactionManager, mock), "Update failed.");			
		
			// TODO : select sur l'id
			// TODO : verif si l'object recup? est egal
			
			System.Console.WriteLine("DataRepository.CourierProvider.Update(mock):");			
			System.Console.WriteLine(mock);
		}
		
		
		/// <summary>
		/// Delete the mock Courier entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			Assert.IsTrue(DataRepository.CourierProvider.Delete(transactionManager, mock), "Delete failed.");
			System.Console.WriteLine("DataRepository.CourierProvider.Delete(mock):");			
			System.Console.WriteLine(mock);
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock Courier entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			string fileName = "temp_Courier.xml";
		
			//XmlSerializer mySerializer = new XmlSerializer(typeof(Courier)); 
			//StreamWriter myWriter = new StreamWriter(fileName); 
			//mySerializer.Serialize(myWriter, this.mock); 
			//myWriter.Close();
			EntityHelper.SerializeXml(mock, fileName);
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock Courier entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = "temp_Courier.xml";
		
			//XmlSerializer mySerializer = new XmlSerializer(typeof(Courier)); 
			//FileStream myFileStream = new FileStream(fileName,  FileMode.Open); 
			//this.mock = (Courier) mySerializer.Deserialize(myFileStream);
			//myFileStream.Close();
			StreamReader sr = File.OpenText(fileName);
			object item = EntityHelper.DeserializeEntityXml<Courier>(sr.ReadToEnd());
			sr.Close();
			File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a Courier collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			string fileName = "temp_CourierCollection.xml";
		
			TList<Courier> mockCollection = new TList<Courier>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Courier>)); 
			StreamWriter myWriter = new StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("TList<Courier> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a Courier collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = "temp_CourierCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Courier>)); 
			FileStream myFileStream = new FileStream(fileName,  FileMode.Open); 
			TList<Courier> mockCollection = (TList<Courier>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			File.Delete(fileName);
			System.Console.WriteLine("TList<Courier> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			Courier entity = mockCollection[0].Clone() as Courier;
			
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			Courier entity = mockCollection[0].Clone() as Courier;
			
			Courier t0 = DataRepository.CourierProvider.GetByCourierId(transactionManager, entity.CourierId);
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			Courier entity = mock.Copy() as Courier;
			//Assert.IsTrue(EntityHelper.AreObjectsEqual(entity, mock), "Copy is working");

			entity = (Courier)mock.Clone();
			//Assert.IsTrue(EntityHelper.AreObjectsEqual(entity, mock), "Clone is working");
			
			Assert.IsTrue(entity.Equals(mock), "Clone is working");


			//Assert.IsTrue(EntityHelper.AreObjectsEqual(mockCollection[0], mockCollection[0]), "AreObjectEqual");
		}
		
		
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed Courier Entity with mock values.
		///</summary>
		static public Courier CreateMockInstance()
		{		
			Courier mock = new Courier();
						
			mock.CourierId = new Guid("ef97c4c8-eb88-4d53-b5d7-d4c1357e83e7");
			mock.CourierName = "BYOOOVFMSLQKHU";
			mock.CourierDescription = "XIBTIXX[PZRDPOHEBZMORZXEOFXRO";
			mock.MinItems = (int)148;
			mock.MaxItems = (int)148;
			
		
			// create a temporary collection and add the item to it
			TList<Courier> tempMockCollection = new TList<Courier>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (Courier)mock;
		}
		
		
		///<summary>
		///  Update the Typed Courier Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance(Courier mock)
		{
			mock.CourierId = new Guid("6ebaf5c3-c950-4f97-bfb6-3448cd75b4d5");
			mock.CourierName = "BYOOOVFMSLQKHU2";
			mock.CourierDescription = "XIBTIXX[PZRDPOHEBZMORZXEOFXRO2";
			mock.MinItems = (int)148;
			mock.MaxItems = (int)148;
			
		}

		#endregion
    }
}
