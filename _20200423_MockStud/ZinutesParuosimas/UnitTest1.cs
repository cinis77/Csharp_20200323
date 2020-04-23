using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20200423_MockStud;

namespace ZinutesParuosimas
{
    [TestClass]
    public class ZinutesParuosimasUnitTest
    {
        [TestMethod]
        public void PradetiDuomenuSiuntima_pateiktiRaideA_tikimesgautiSuformuotaZinut()
        {
            FakeKomunikacija komunikacija = new FakeKomunikacija();
            _20200423_MockStud.ZinutesParuosimas zinute = 
                new _20200423_MockStud.ZinutesParuosimas(komunikacija, new FakeDuomenuNuskaitymas());

            string expectedValue = @"<Message><Body A/></Message>";


            zinute.PradetiDuomenuSiuntima();

            Assert.AreEqual(expectedValue, komunikacija.Zinutes);
        }

        [TestMethod]
        public void PradetiDuomenuSiuntima_PateiktiDidesniZodiNei256elmentai_tikimesgautiSuformuotas2Zinutes()
        {
            FakeKomunikacija komunikacija = new FakeKomunikacija();
            _20200423_MockStud.ZinutesParuosimas zinute =
               new _20200423_MockStud.ZinutesParuosimas(komunikacija, new FakeIlgasTekstasDuomenuNuskaitymas());
            string expectedValue = @"<Message><Body Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mollis varius dui, ut venenatis lacus lacinia vitae. Nunc accumsan nisi eget lacus semper, vel gravida justo vulputate. Praesent eget urna at elit condimentum interdum. Proin non efficitur ex. In/></Message>"
                + @"<Message><Body eger viverra, velit eu tristique faucibus, libero magna porttitor velit, at venenatis./></Message>";

            zinute.PradetiDuomenuSiuntima();

            Assert.AreEqual(expectedValue, komunikacija.Zinutes);
            //Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mollis varius dui, ut venenatis lacus lacinia vitae. Nunc accumsan nisi eget lacus semper, vel gravida justo vulputate. Praesent eget urna at elit condimentum interdum. Proin
        }

    }

    class FakeKomunikacija : IKomunikacija
    {
        public string Zinutes;

        public bool SiustiDuomenis(string zinute)
        {
            Zinutes = zinute;

            return true;
        }
    }

    class FakeIlgasTekstasDuomenuNuskaitymas : IDuomenuNuskaitymas
    {
        public string ReadDataString()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut mollis varius dui, ut venenatis lacus lacinia vitae. Nunc accumsan nisi eget lacus semper, vel gravida justo vulputate. Praesent eget urna at elit condimentum interdum. Proin non efficitur ex. Integer viverra, velit eu tristique faucibus, libero magna porttitor velit, at venenatis.";
        }
    }


    class FakeDuomenuNuskaitymas : IDuomenuNuskaitymas
    {
        public string ReadDataString()
        {
            return "A";
         }
    }


}
