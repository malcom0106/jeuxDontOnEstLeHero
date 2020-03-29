using JeuxDontOnEstLeHero.Web.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWebUI
{
    [TestClass]
    public class HomeControllerUnityTest
    {
        [TestMethod]
        public void TestAboutIsOK()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();

            //On test que l'on obtient bien un ViewResult
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            //On peut donc enregistré result en tant que viewResult
            ViewResult viewResult = result as ViewResult;


        }
    }
}
