using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Telerik.OpenAccess;
using System.Linq;
using Newtonsoft.Json.Linq;



namespace Data
{
    [TestClass]
    public class RepositoriyTest
    {
       IApplicationContext _context = new ApplicationContext(@"data source=.\sqlexpress;initial catalog=Denemeff;integrated security=True");
        IRepository _repo;


        [TestMethod]
        public void GetById_NotNull()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            var data = _repo.getById("DenemeD", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d4");

            //Assert           
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetAll_QueryableData_NotNull()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            IQueryable data = _repo.getAll("DenemeD");

            //Assert           
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void GetById_GetObject_NotNull()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            var data = _repo.getById("DenemeD", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d4");

            //Assert           
            Assert.IsNotNull(data);
        }


        [TestMethod]
        public void Insert_InsertData_GetObject()
        {
            //Arrange
            _repo = new DataAccessRepository(_context);
            Dictionary<string, string> entity = new Dictionary<string, string>();
            entity.Add("Ad", "Cantek");
            entity.Add("Soyad", "TEk");
            //Act
            var data = _repo.Insert("DenemeD", entity);

            //Assert           
            Assert.AreEqual(data.FieldValue<string>("Ad"), "Cantek");
        }


        [TestMethod]
        public void Update_UpdateData_GetObject()
        {
            //Arrange
            _repo = new DataAccessRepository(_context);
            Dictionary<string, string> entity = new Dictionary<string, string>();
            entity.Add("Id", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d4");
            entity.Add("Ad", "Cantek");
            entity.Add("Soyad", "TEkin");
           
            //Act
          var data=  _repo.Update("DenemeD", entity);

            //Assert           
            Assert.AreEqual(data.FieldValue<string>("Soyad"), "TEkin");
        }

      


        [TestMethod]
        public void Delete_setIsdelete_True()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            bool data = _repo.Delete("DenemeD", "fe7f5cad-98ff-44fa-baa6-fa3739cdc3d4");

            //Assert           
            Assert.IsTrue(data);
        }

        [TestMethod]
        public void Count_getCountRecord_Integer()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            int data = _repo.Count("DenemeD");

            //Assert           
            Assert.IsInstanceOfType(data,typeof(int));
        }

        [TestMethod]
        public void ExecuteSql_execSqlQuery_JArray()
        {
            //Arrange            
            _repo = new DataAccessRepository(_context);

            //Act
            JArray data = _repo.ExecuteSqlQueryJson("select * from DenemeD");

            //Assert           
            Assert.IsInstanceOfType(data, typeof(JArray));
        }

        [TestCleanup]
        public void Clean()
        {
            _repo = null;
        }
    }
}
