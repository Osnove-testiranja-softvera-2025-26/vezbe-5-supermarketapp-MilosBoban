using NUnit.Framework;
using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OTS_Supermarket.Test
{
    [TestFixture]
    public class CartTest
    {
        [Test]
        /*public void AddOneToCart_ShouldAddItemToCart_Success()
        {
            //Arange
            Cart cart = new Cart();
            Monitor monitor = new Monitor();

            //Act
            cart.AddOneToCart(monitor);

            //Assert
            Assert.That(cart.Size, Is.EqualTo(1));
            Assert.That(cart.Amount, Is.EqualTo(100));
        }*/
        
        [TestCase(4)]
        [TestCase(2)]
        [TestCase(9)]
        public void DeketeAll_ShouldDeleteAllItems_SuccessDataDriven(int counter)
        {
            Cart cart = new Cart();
            cart.Size = counter;

            cart.DeleteAll();

            Assert.That(cart.Size, Is.EqualTo(0));
        }

        [Test]
        public void DeleteAll_CartIsAlreadyEmpty_Exception()
        {
            Cart cart = new Cart();
            cart.Size = 0;

            Exception exception = Assert.Throws<Exception>(() => cart.DeleteAll());

            Assert.That(exception.Message, Is.EqualTo("Cannot restore empty cart!"));
        }

        [Test]
        public void Print_CartIsEmpty_Exception()
        {
            Cart cart = new Cart();
            cart.Size = 0;

            Exception exception = Assert.Throws<Exception>(() => cart.DeleteAll());

            Assert.That(exception.Message, Is.EqualTo("Cannot print empty cart!"));
        }

        [Test]
        public void Print_ShouldPrintLaptop_Success()
        {
            Cart cart = new Cart();
            Laptop laptop = new Laptop();
            cart.AddOneToCart(laptop);


            Assert.That(cart.Print, Is.EqualTo("Laptop"));
        }
    }
}
