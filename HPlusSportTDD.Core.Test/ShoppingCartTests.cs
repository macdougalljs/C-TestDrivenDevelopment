﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    internal class ShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ShouldReturnArticleAddedToCart()
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

            var manager = new ShoppingCartManager();

            AddToCartResponse response = manager.AddToCart(request);

            Assert.NotNull(response);
            Assert.Contains(item, response.Items);

        }

        [Test]
        public void ShouldReturnArticlesAddedToCart()
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


            Assert.NotNull(response);
            Assert.Contains(item, response.Items);
            Assert.Contains(item2, response.Items);

        }
    }
}
