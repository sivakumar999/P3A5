using CalcApp;

namespace CalcTest
{
    public class Tests
    {
        [Test]
        public void AddsTwoNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}