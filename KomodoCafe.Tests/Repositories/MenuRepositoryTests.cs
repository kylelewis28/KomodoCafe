using KomodoCafe.Models;
using KomodoCafe.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//to test the proj
namespace KomodoCafe.Tests.Repositories
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _repo;
        private MenuItem _item;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _item = new MenuItem(1, "Burger", "A tasty burger", new List<string> { "Bun", "Patty", "Lettuce" }, 5.99m);
            _repo.AddMenuItem(_item);
        }

        [TestMethod]
        public void AddMenuItem_ShouldGetNotNull()
        {
        
            MenuItem item = new MenuItem(2, "Pizza", "Cheesy pizza", new List<string> { "Dough", "Cheese", "Tomato Sauce" }, 8.99m);

            
            _repo.AddMenuItem(item);
            MenuItem itemFromRepo = _repo.GetAllMenuItems().FirstOrDefault(m => m.MealNumber == 2);

            
            Assert.IsNotNull(itemFromRepo);
        }

        
    }
}
