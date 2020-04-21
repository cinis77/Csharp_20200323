using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20200421_UnitTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTestRezervacija
    {
        [TestMethod]
        public void AtsauktiRezervacija_KlientasYraAdministratorius_GautiTrue()
        {
            // Susikuriami visi kintamieji
            Rezervacija rezervacija = new Rezervacija(new Klientas(false));
            Klientas administratorius = new Klientas(true);
            //Atliekami veiksmai
            var resultatas = rezervacija.AtsauktiRezervacija(administratorius);

            //Atliekamas ivertinimas
            Assert.IsTrue(resultatas);

        }

        [TestMethod]
        public void AtsauktiRezervacija_KlientasYraUzsakytojas_GautiTrue()
        {
            Klientas rezervuotojas = new Klientas(false);
            Rezervacija rezervacija = new Rezervacija(rezervuotojas);

            var resultatas = rezervacija.AtsauktiRezervacija(rezervuotojas);

            Assert.IsTrue(resultatas);
        }

        [TestMethod]
        public void AtsauktiRezervacija_AtsaukejasNeraUZsakytojas_GautiFalse()
        {
            Rezervacija rezervacija = new Rezervacija(new Klientas(false));
            Klientas atsaukejas = new Klientas(false);

            var resultatas = rezervacija.AtsauktiRezervacija(atsaukejas);

            Assert.IsFalse(resultatas);
        }
    }
}
