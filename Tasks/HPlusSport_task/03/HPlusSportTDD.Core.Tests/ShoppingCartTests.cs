using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    internal class ShoppingCartTests
    {
        [SetUp]
        public void SetUp() // method is used for the assertion phase
        {

        }

        [Test]
        public void ShouldReturnArticleaddedToCart()
        {
            var item = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };

            var request = new AddToCartRequest()
            {
                Item = item
            };

            var mockManager = new Mock<IShoppingCartManager>();

            mockManager.Setup(manger => manger.AddToCart(It.IsAny<AddToCartRequest>()))
                .Returns((AddToCartRequest request) => new AddToCartResponse()
                {
                    Items = new AddToCartItem[] { request.Item }
                }
                );
            //var manager = new ShoppingCartManager();

            AddToCartResponse response = mockManager.Object.AddToCart(request);

            Assert.That(response, Is.Not.Null);
            Assert.That(response.Items, Does.Contain(item));
        }

        [Test]
        public void ShouldReturnArticlesAddedToCart()
        {
            var item1 = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };

            var request = new AddToCartRequest()
            {
                Item = item1
            };

            var manager = new ShoppingCartManager();

            AddToCartResponse response = manager.AddToCart(request);

            var item2 = new AddToCartItem()
            {
                ArticleId = 43,
                Quantity = 10
            };

            request = new AddToCartRequest()
            {
                Item = item2
            };

            response = manager.AddToCart(request);

            Assert.That(response, Is.Not.Null);
            Assert.That(response.Items, Does.Contain(item1));
            Assert.That(response.Items, Does.Contain(item2));
        }

        [Test]
        public void ShouldReturnCombinedArticlesAddedToCart()
        {
            var item1 = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };

            var request = new AddToCartRequest()
            {
                Item = item1
            };

            var manager = new ShoppingCartManager();

            AddToCartResponse response = manager.AddToCart(request);

            var item2 = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 10
            };

            request = new AddToCartRequest()
            {
                Item = item2
            };

            response = manager.AddToCart(request);
            Assert.Multiple(() =>
            {
                Assert.That(response, Is.Not.Null);
                Assert.That(Array.Exists(response.Items, item => item.ArticleId == 42 && item.Quantity == 15));
            });
        }
    }
}
