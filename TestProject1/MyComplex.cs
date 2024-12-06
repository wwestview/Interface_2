using Interface;
namespace TestProject1
{
    [TestClass]
    public sealed class MyComplex
    {
        [TestMethod]
        public void TestAdd()
        {
            Interface.MyComplex comp1 = new(6, -2);
            Interface.MyComplex comp2 = new(5, -1);

            Interface.MyComplex actual = comp1.Add(comp2);
            Interface.MyComplex expected = new(11, -3);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestAdd2()
        {
            Interface.MyComplex comp1 = new(-3, 2);
            Interface.MyComplex comp2 = new(5, -1);

            Interface.MyComplex actual = comp1.Add(comp2);
            Interface.MyComplex expected = new(2, 1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestSubtract()
        {
            Interface.MyComplex comp1 = new(6, -2);
            Interface.MyComplex comp2 = new(5, -1);

            Interface.MyComplex actual = comp1.Subtract(comp2);
            Interface.MyComplex expected = new(1, -1);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestSubtract2()
        {
            Interface.MyComplex comp1 = new(-3, 2);
            Interface.MyComplex comp2 = new(5, -1);

            Interface.MyComplex actual = comp1.Subtract(comp2);
            Interface.MyComplex expected = new(-8, 3);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestMul()
        {
            Interface.MyComplex comp1 = new(6, -2);
            Interface.MyComplex comp2 = new(5, -1);

            Interface.MyComplex actual = comp1.Multiply(comp2);
            Interface.MyComplex expected = new(28, -16);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
        [TestMethod]
        public void TestDiv()
        {
            Interface.MyComplex comp1 = new(2, -2);
            Interface.MyComplex comp2 = new(6, -2);

            Interface.MyComplex actual = comp1.Divide(comp2);
            Interface.MyComplex expected = new(12.1, -11.9);
            string act = actual.ToString();
            string exp = expected.ToString();
            Assert.AreEqual(act, exp);
        }
    }
    

   
}
