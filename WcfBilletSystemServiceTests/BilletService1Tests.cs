using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfBilletSystemService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLib;

namespace WcfBilletSystemService.Tests
{
    [TestClass()]
    public class BilletService1Tests
    {
        [TestMethod()]
        public void BilMedRabatTest()
        {
            var bilrabat = new Bil();
            bilrabat.BroBizz = true;
            Assert.AreEqual(228, bilrabat.Pris());

        }

        [TestMethod()]
        public void BilPrisTest()
        {
            var bilpris = new Bil();
            int pris = bilpris.Pris();
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void BilØresundTest()
        {
            var biløresund = new BilØresund();
            int pris = biløresund.Pris();
            Assert.AreEqual(410, pris);
        }

        [TestMethod()]
        public void BilØresundRabatTest()
        {
            var biløresundrabat = new BilØresund();
            biløresundrabat.BroBizz = true;
            Assert.AreEqual(161, biløresundrabat.Pris());
        }

        [TestMethod()]
        public void MCPrisTest()
        {
            var MCpris = new MC();
            int pris = MCpris.Pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void MCØresundTest()
        {
            var MCøresundpris = new MCØresund();
            int pris = MCøresundpris.Pris();
            Assert.AreEqual(210, pris);
        }

        [TestMethod()]
        public void MCØresundRabatTest()
        {
            var MCØresundRabat = new MCØresund();
            MCØresundRabat.BroBizz = true;
            Assert.AreEqual(73, MCØresundRabat.Pris());
        }
    }
}