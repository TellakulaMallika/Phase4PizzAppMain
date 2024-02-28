using Microsoft.AspNetCore.Mvc;
using WebAppPhase4Mainpizza.Controllers;

namespace TestProject1
{
    
    public class Tests
    {
        PizzaController controller;
        [SetUp]
        public void Setup()
        {
            controller = new PizzaController();
        }

        [Test]
        public void DisplayAllTest()
        {
            foreach(var item in controller.DisplayAll())
            {
                Assert.IsNotNull(item);
            }
        }
        [Test]
        public void DisplayByIdTest2()
        {
            foreach(var item1 in controller.pizzaByid(2))
            {
                Assert.IsNotNull(item1);
            }
        }
        [Test]
        public void ActionTest1()
        {
            PizzaController p = new PizzaController();
            ViewResult res = p.Index() as ViewResult;
            Assert.IsNotNull(res);
        }
        [Test]
        public void ActionTest2()
        {
            PizzaController p = new PizzaController();
            ViewResult res = p.Checkout() as ViewResult;
        }
        [Test]
        public void ActionTest3()
        {
            PizzaController p = new PizzaController();
            ViewResult res = p.Buy() as ViewResult;
            Assert.IsnotNull(res);
        }
    }
}