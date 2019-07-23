using System;
using System.Collections.Generic;
using OnfDemo;
using OnfDemo.Models;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var vm = new MainViewModel();
            vm.Nom = "Dellai";

            // Act
            vm.DitesBonjour();

            // Assert
            Assert.Equal("Bonjour Dellai", vm.Message);
        }

        [Fact]
        public void GetDataTest()
        {
            // Arrange
            var vm = new MainViewModel(new MockDataService());

            // Act
            vm.GetData();

            // Assert
            Assert.Equal("Bonjour Dellai", vm.Message);
        }
    }

    public class MockDataService : IDatabaService
    {
        public List<Product> GetDataFromWebService()
        {
            return new List<Product>
            {
                new Product{ Name = "X-BOX-2", Cost = 400 },
                new Product{ Name = "PS 32", Cost = 600 },
                new Product{ Name = "PS 33", Cost = 600 },
            };
        }
    }
}
