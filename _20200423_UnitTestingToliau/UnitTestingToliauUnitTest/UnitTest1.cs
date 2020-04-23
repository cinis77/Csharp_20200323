using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20200423_UnitTestingToliau;

namespace UnitTestingToliauUnitTest
{
    [TestClass]
    public class UnitTest_KlaseSkirtaTestuotis
    {
        public KlaseSkirtaTestuotis SukurtiObjekta()
        {
            var klase = new KlaseSkirtaTestuotis();
            return klase;
        }


        [TestMethod]
        public void Sandauga_Abuskaiciaiint5ir3_TikimasiGauti15()
        {
            KlaseSkirtaTestuotis klase = new KlaseSkirtaTestuotis();

            var rezultatas = klase.Sandauga(5, 3);
            int san = 5 * 3;

            Assert.AreEqual(san, rezultatas);
        }

        [TestMethod]
        public void Sandauga_PateiktiMaxValueAbuSkaicius_Overflow()
        {
            KlaseSkirtaTestuotis klase = new KlaseSkirtaTestuotis();

            var rezultatas = klase.Sandauga(int.MaxValue, int.MaxValue);

            Assert.AreEqual(1, rezultatas);

        }

        [TestMethod]
        public void FormatuojamasZodis_PateiksimeZodiLabas_TikimesGautiZodisSuformatuota()
        {
            KlaseSkirtaTestuotis klase = new KlaseSkirtaTestuotis();

            var rezultatas = klase.FormatuojamasZodis("Labas");

            Assert.AreEqual("xLabasx", rezultatas);
        }

        [TestMethod]
        public void FormatuojamasZodis_PateiktiEmptyString_TikimesGautiDux()
        {
            var klase = SukurtiObjekta();

            var rezultatas = klase.FormatuojamasZodis(string.Empty);

            Assert.AreEqual("xx", rezultatas);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FormuojamasZodis_PateiktiNull_TikimesKlaidos()
        {
            var klase = SukurtiObjekta();

            var rezultatas = klase.FormatuojamasZodis(null);

            string dd;
            dd = "";
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void SugeneruojaKlaidosKoda_iskvieciamasMetodas_IvykstaKlaida()
        {
            var klase = SukurtiObjekta();
            

            klase.SugeneruojaKlaidosKoda();
        }
    }
}
