using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextJeuDroides
{
    [TestClass]
    public class Jedi
    {
        [TestMethod]
        public void TesterAttaquerOK()
        {
            ExempleJedis.Jedi jedi = new ExempleJedis.Jedi();
            ExempleJedis.Droide droide = new ExempleJedis.Droide() 
            {
                PointsDeVie = 100
            };
            jedi.Attaquer(droide);

            Assert.IsTrue(droide.PointsDeVie == 50);
        }
    }
}
