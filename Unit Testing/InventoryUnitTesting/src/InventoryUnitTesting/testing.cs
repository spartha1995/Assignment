using System.Collections.Generic;
using Xunit;
using System;
using Moq;
using System.Linq;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;
        private int Quantity;

        /// <summary>
        /// Adding product in inventory Pass Case
        /// </summary>

        [Fact]
        public void WhenAddingProductToInventory_InventoryListShouldbeIncreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 6,
                ProductId = 5,
                Quantity = 5,

            };

            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(list.Count, db.InventoryList.Count);
        }
        /// <summary>
        /// Adding product in inventory Failed Case
        /// </summary>

        [Fact]
        public void WhenAddingProductToInventory_InventoryListShouldbeIncreasedFailedCase()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 10,
                ProductId = 15,
                Quantity = 10,

            };

            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(list.Count, db.InventoryList.Count);
        }

        /// <summary>
        /// Deleting Product From Inventory
        /// </summary>

        [Fact]
        public void DeletingProductFromInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 2,
                ProductId = 2,
                Quantity = 10,

            };

            var prgm = new Program();
            var list = prgm.DeleteInventory(inventory);
            Assert.Equal(40, db.InventoryList.Count);
        }


        /// <summary>
        /// Deleting Product From Inventory Failed case
        /// </summary>

        [Fact]
        public void DeletingProductFromInventoryFailedCase()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 11,
                ProductId = 7,
                Quantity = 22,

            };

            var prgm = new Program();
            var list = prgm.DeleteInventory(inventory);
            Assert.Equal(40, db.InventoryList.Count);
        }

        /// <summary>
        /// Updating a Product
        /// </summary>
        [Fact]
        public void UpdatingAProductFromInventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 3,
                ProductId = 3,
                Quantity = 50,

            };

            var prgm = new Program();
            var list = prgm.UpdateInventory(inventory);
            Assert.Equal(200, db.InventoryList.Count);
        }

        /// <summary>
        /// Updating a Product Failed Case
        /// </summary>
        [Fact]
        public void UpdatingAProductFromInventoryFailedCase()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 1,
                ProductId = 1,
                Quantity = 60,

            };

            var prgm = new Program();
            var list = prgm.UpdateInventory(inventory);
            Assert.Equal(100, db.InventoryList.Count);
        }
        /// <summary>
        /// Checking a Product Is In Inventory Or Not
        /// </summary>
        [Fact]
        public void WhencheckProductExistOrNotCorrectAssumption()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                ProductId = 5,
            };
            var prgm = new Program();
            var assumption = "YES";
            var list = prgm.CheckProductIsExistInInventoryOrNot();
            Assert.Same(assumption, db.InventoryList.Contains(inventory));
        }
        /// <summary>
        /// Checking a Product Is In Inventory Or Not wrong Assumption
        /// </summary>
        [Fact]
          public void WhencheckProductExistOrNotWrongAssumption()
      {
           var db = new Database();
          var inventory = new Inventory()
    {
          ProductId = 9,
    };
        var prgm = new Program();
     var wrongassumption = "No";
        var list = prgm.CheckProductIsExistInInventoryOrNot();
        Assert.Same(wrongassumption, db.InventoryList.Contains(inventory));
        }



        /// <summary>
        /// Checking out Cart will upgrade as per Requirment
        /// </summary>

        [Fact]
        public void WhenCheckOutFromCart_InventoryWillUpdate()
        {
            var db = new Database();
            var cart = new Cart()
            {
                Id = 3,
                ProductId = 2,
                OrderedQuantity = 10
            };
            var prgm = new Program();
            var list = prgm.CheckOutTheCartandUpdateInventory();
            Assert.Equal(3, db.CartList.Count);

            var inventoryupdate = new Inventory()
            {
                Id = 1,
                ProductId = 1,
                Quantity = 5
            };
            var list2 = prgm.UpdateInventory(inventoryupdate);
            var assumption = "Yes";
            Assert.Same(assumption, db.InventoryList.Contains(inventoryupdate));
        }

        /// <summary>
        /// Checking out Cart will upgrade as per Requirment Failed Case
        /// </summary>

        [Fact]
        public void WhenCheckOutFromCart_InventoryWillUpdateWrongAssumption()
        {
            var db = new Database();
            var cart = new Cart()
            {
                Id = 2,
                ProductId = 2,
                OrderedQuantity = 10
            };
            var prgm = new Program();
            var list = prgm.CheckOutTheCartandUpdateInventory();
            Assert.Equal(3, db.CartList.Count);

            var inventoryupdate = new Inventory()
            {
                Id = 1,
                ProductId = 1,
                Quantity = 5
            };
            var list2 = prgm.UpdateInventory(inventoryupdate);
            var assumption = "NO";
            Assert.Same(assumption, db.InventoryList.Contains(inventoryupdate));
        }
    }
}