using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Data
{
    [TestClass]
    public class RepositoryErrorTest
    {
        
        IApplicationContext _context=new ApplicationContext(@"data source=.\sqlexpress;initial catalog=Denemeff;integrated security=True");
        IRepository _repo;
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Insert_NullTableName_Exception()
        {  
            //Arrange
            _repo = new DataAccessRepository(_context);            

            //Act
            var data = _repo.Insert(null, null);

            //Assert           
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Update_NullTableName_Exception()
        {
            //Arrange
            _repo = new DataAccessRepository(_context);

            //Act
            var data = _repo.Update(null, null);

            //Assert           
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Update_NotRecord_Exception()
        {
            //Arrange
            _repo = new DataAccessRepository(_context);
            Dictionary<string, string> entity = new Dictionary<string, string>();
            entity.Add("Id", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d5");
            entity.Add("Ad", "Cantek");
            entity.Add("Soyad", "TEkin");

            //Act
            var data = _repo.Update("DenemeD", entity);

            //Assert           
            Assert.Fail();
           
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Delete_NotRecord_Exception()
        {
            //Arrange
            _repo = new DataAccessRepository(_context);           

            //Act
            var data = _repo.Delete("DenemeD", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d5");

            //Assert           
            Assert.Fail();
            
        }


        [TestCleanup]
        public void Clean()
        {          
            _repo=null;
        }



    }
}
