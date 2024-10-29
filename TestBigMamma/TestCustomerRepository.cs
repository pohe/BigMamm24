using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBigMamma
{
      
    [TestClass()]
    public class TestCustomerRepository
        {
        private ICustomerRepository _repository = new CustomerRepository();

        public void TestSetup()
        {
            //Dictionary<string, Customer> _customerData =
            //new Dictionary<string, Customer>()
            //{
            //    { "12312312", new Customer("Mikkel", "12312312", "Street 123") },
            //    { "32132132", new Customer("Charlotte", "32132132", "Avenue 321") },
            //    { "23423423", new Customer("Carina", "23423423", "High Street 234") },
            //};
        }

        [TestMethod()]
        public void AddCustomerTest()
        {
            // Arrange
            TestSetup();

            // Act
            int beforeCount = _repository.Count;
            _repository.AddCustomer(new Customer("Peter", "1212127", "Vej 123"));
            int afterCount = _repository.Count;

            // Assert
            Assert.AreEqual(4, beforeCount);
            Assert.AreEqual(beforeCount + 1, afterCount);
        }

        [TestMethod()]
        public void LookupBookTest_ExistingBook()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //Book? result = _repository.LookupBook("AD1337");

            //// Assert
            //Assert.AreNotEqual(null, result);
            //Assert.AreEqual(result?.ISBN, "AD1337");
        }

        [TestMethod()]
        public void LookupBookTest_NonExistingBook_Case1()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //Book? result = _repository.LookupBook("AD1338");

            //// Assert
            //Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void LookupBookTest_NonExistingBook_Case2()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //Book? result = _repository.LookupBook("...");

            //// Assert
            //Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void LookupBookTest_NonExistingBook_Case3()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //Book? result = _repository.LookupBook("ad1337");

            //// Assert
            //Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void DeleteBookTest_ExistingBook()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //int beforeCount = _repository.Count;
            //_repository.DeleteBook("XS3220");
            //int afterCount = _repository.Count;

            //// Assert
            //Assert.AreEqual(4, beforeCount);
            //Assert.AreEqual(beforeCount - 1, afterCount);
        }

        [TestMethod()]
        public void DeleteBookTest_NonExistingBook()
        {
            //// Arrange
            //TestSetup();

            //// Act
            //int beforeCount = _repository.Count;
            //_repository.DeleteBook("SX2320");
            //int afterCount = _repository.Count;

            //// Assert
            //Assert.AreEqual(4, beforeCount);
            //Assert.AreEqual(beforeCount, afterCount);
        }
    }

}
