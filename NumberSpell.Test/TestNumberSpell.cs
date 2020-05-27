using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSpell.Test
{
    [TestClass]
    public class TestNumberSpell
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int testData = 1234;

            //Act
            string spell = SpellNumber.GetSpell(testData);

            //Assert
            Assert.IsNotNull(spell);           
        }
    }
}
