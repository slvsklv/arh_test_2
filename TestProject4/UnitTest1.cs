using System.Collections.Generic;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareCollectionsByOrder_12345_true()
        {

            //arrange
            bool resutl = true;
            //act
            tesstik.Class1 class1 = new tesstik.Class1();
            List<int> collection1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> collection2 = new List<int> { 1, 2, 3, 4, 5 };
            bool actual = class1.CompareCollectionsByOrder(collection1, collection2);
            //assert
            Assert.AreEqual(resutl, actual);
        }
        [TestMethod]
        public void CompareCollectionsIgnoreOrder_12345_21345_true()
        {

            //arrange
            bool resutl = true;
            //act
            tesstik.Class2 class2 = new tesstik.Class2();
            List<int> collection1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> collection2 = new List<int> { 2, 1, 3, 4, 5 };
            bool actual = class2.CompareCollectionsIgnoreOrder(collection1, collection2);
            //assert
            Assert.AreEqual(resutl, actual);
        }
        [TestMethod]
        public void CalculatePercent_5_10_100()
        {

            //arrange
            double resutl = 100;
            //act
            tesstik.Class3 class3 = new tesstik.Class3();
            double initialValue = 5;
            double finalValue = 10;
            double actual = class3.CalculatePercent( initialValue,  finalValue);
            //assert
            Assert.AreEqual(resutl, actual);
        }
    }
}