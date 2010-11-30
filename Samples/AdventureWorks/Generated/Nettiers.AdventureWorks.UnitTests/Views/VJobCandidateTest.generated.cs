﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VJobCandidateTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="VJobCandidate"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VJobCandidateTest
    {
    	// the VJobCandidate instance used to test the repository.
		private VJobCandidate mock;
		
		// the VList<VJobCandidate> instance used to test the repository.
		private VList<VJobCandidate> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VJobCandidate Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {       	
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
		
		/// <summary>
		/// Selects a page of VJobCandidate objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VJobCandidateProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VJobCandidateProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some VJobCandidate objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VJobCandidateProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.VJobCandidateProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock VJobCandidate entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VJobCandidate.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VJobCandidate)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock VJobCandidate entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VJobCandidate.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VJobCandidate)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (VJobCandidate) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a VJobCandidate collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VJobCandidateCollection.xml";
		
			VList<VJobCandidate> mockCollection = new VList<VJobCandidate>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VJobCandidate>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<VJobCandidate> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a VJobCandidate collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VJobCandidateCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VJobCandidate>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<VJobCandidate> mockCollection = (VList<VJobCandidate>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VJobCandidate> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed VJobCandidate Entity with mock values.
		///</summary>
		static public VJobCandidate CreateMockInstance()
		{		
			VJobCandidate mock = new VJobCandidate();
						
			mock.JobCandidateId = TestUtility.Instance.RandomNumber();
			mock.EmployeeId = TestUtility.Instance.RandomNumber();
			mock.SafeNameNamePrefix = TestUtility.Instance.RandomString(14, false);;
			mock.SafeNameNameFirst = TestUtility.Instance.RandomString(14, false);;
			mock.SafeNameNameMiddle = TestUtility.Instance.RandomString(14, false);;
			mock.SafeNameNameLast = TestUtility.Instance.RandomString(14, false);;
			mock.SafeNameNameSuffix = TestUtility.Instance.RandomString(14, false);;
			mock.Skills = TestUtility.Instance.RandomString(2, false);;
			mock.SafeNameAddrType = TestUtility.Instance.RandomString(14, false);;
			mock.SafeNameAddrLocCountryRegion = TestUtility.Instance.RandomString(49, false);;
			mock.SafeNameAddrLocState = TestUtility.Instance.RandomString(49, false);;
			mock.SafeNameAddrLocCity = TestUtility.Instance.RandomString(49, false);;
			mock.SafeNameAddrPostalCode = TestUtility.Instance.RandomString(9, false);;
			mock.Email = TestUtility.Instance.RandomString(2, false);;
			mock.WebSite = TestUtility.Instance.RandomString(2, false);;
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
		   return (VJobCandidate)mock;
		}
		

		#endregion
    }
}