using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress.Business;

namespace AliExpress.BusinessUTest
{
    /// <summary>
    /// Descripción resumida de TruncadorDecimalesUTest
    /// </summary>
    [TestClass]
    public class TruncadorDecimalesUTest
    {       
        [TestMethod]
        public void TruncarNumero_NumeroCon5Decimales_RetornaNumeroCon1Decimal()
        {
            //Arrange.
            var SUT = new TruncadorDecimales();

            //Act.
            var dNumeroTruncado = SUT.TruncarNumero(1988.12345M);

            //Assert.
            Assert.AreEqual(1988.1M, dNumeroTruncado);
        }
    }
}
