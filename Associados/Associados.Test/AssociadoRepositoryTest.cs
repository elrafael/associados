using Associados.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Test
{
    [TestClass]
    public class AssociadoRepositoryTest
    {
        AssociadoRepository Repo;

        [TestInitialize]
        public void TestSetup()
        {
            AssociadoDbInit db = new AssociadoDbInit();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new AssociadoRepository();
        }

        [TestMethod]
        public void IsRepositoryInitializeWithValidNumberOfData()
        {
            var result = Repo.List();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(1, numberOfRecords);
        }
    }
}
