using Interface;
namespace Test_MyFrac
{
    [TestClass]
    public sealed class MyFra
    {
        [TestMethod]
        public void TestAdd()
        {
            MyFrac frac1 = new(5, 6);   
            MyFrac frac2 = new(7, 8);
            string expected = "41/24";   
            string actual = frac1.Add(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAdd2()
        {
            MyFrac frac1 = new(-5, 6);  
            MyFrac frac2 = new(4, 9);
            string expected = "-7/18";  
            string actual = frac1.Add(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul1()
        {
            MyFrac frac1 = new(3, 5);  
            MyFrac frac2 = new(2, 7);
            string expected = "6/35";    
            string actual = frac1.Multiply(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul2()
        {
            MyFrac frac1 = new(-3, 8);  
            MyFrac frac2 = new(4, -6);
            string expected = "1/4";     
            string actual = frac1.Multiply(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv1()
        {
            MyFrac frac1 = new(6, 7);   
            MyFrac frac2 = new(3, 5);
            string expected = "10/7";   
            string actual = frac1.Divide(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv2()
        {
            MyFrac frac1 = new(-9, 4);  
            MyFrac frac2 = new(3, -2);
            string expected = "3/2";    
            string actual = frac1.Divide(frac2).ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
