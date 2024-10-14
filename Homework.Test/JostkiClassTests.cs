using System.Diagnostics;
using System.Drawing;

namespace Homework.Test
{
    public class JostkiClassTests
    {
        [TestCase(1, 220)]
        [TestCase(0, 150)]
        public void Dz1_1Test(double a, double Price)
        {
            double actual = JostkiClass.Dz1_1(a);

            Assert.AreEqual(Price, actual);
        }

        [TestCase(110, 100, 1.1)]
        [TestCase(100, 110, 0)]
        public void Dz1_2Test(double amountSales, double salesPlan, double prize)
        {
            double actual = JostkiClass.Dz1_2(amountSales, salesPlan);

            Assert.AreEqual(prize, actual);
        }

        [TestCase(10, 1)]
        [TestCase(21, 2.1)]
        public void Dz1_3Test(double a, double amountDeposit)
        {
            double actual = JostkiClass.Dz1_3(a);

            Assert.AreEqual(amountDeposit, actual);
        }
    }
}
        