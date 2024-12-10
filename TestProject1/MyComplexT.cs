using Interface;
namespace TestProject1
{
    [TestClass]
    public sealed class MyComplexT
    {
        [TestMethod]
        public void TestAdd()
        {
            MyComplex comp1 = new(6, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Add(comp2);
            MyComplex expected = new(11, -3);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestAdd2()
        {
            MyComplex comp1 = new(-3, 2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Add(comp2);
            MyComplex expected = new(2, 1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestSubtract()
        {
            MyComplex comp1 = new(6, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Subtract(comp2);
            MyComplex expected = new(1, -1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestSubtract2()
        {
            MyComplex comp1 = new(-3, 2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Subtract(comp2);
            MyComplex expected = new(-8, 3);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestMul()
        {
            MyComplex comp1 = new(6, -2);
            MyComplex comp2 = new(5, -1);

            MyComplex actual = comp1.Multiply(comp2);
            MyComplex expected = new(28, -16);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestDiv()
        {
            MyComplex comp1 = new(2, -2);
            MyComplex comp2 = new(6, -2);

            MyComplex actual = comp1.Divide(comp2);
            MyComplex expected = new(12.1, -11.9);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestCopy()
        {
            MyComplex comp1 = new(-2, 2);
            MyComplex actual = new(comp1);
            MyComplex expected = new(-2, 2);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
    }
    

   
}
