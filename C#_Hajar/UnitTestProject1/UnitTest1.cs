using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTambah()
        {
            MainWindow kal = new MainWindow();
            double a1 = 3;
            double b1 = 3;
            double result = kal.tambah(a1, b1);
            double hasil = 6;

            Assert.AreEqual(hasil, result, "Salah");
        }

        [TestMethod]
        public void TestMethodKurang()
        {
            MainWindow kal = new MainWindow();
            double a1 = 4;
            double b1 = 2;
            double result = kal.kurang(a1, b1);
            double hasil = 2;

            Assert.AreEqual(hasil, result, "Salah");
        }

        [TestMethod]
        public void TestMethodKali()
        {
            MainWindow kal = new MainWindow();
            double a1 = 4;
            double b1 = 2;
            double result = kal.kali(a1, b1);
            double hasil = 8;

            Assert.AreEqual(hasil, result, "Salah");
        }

        [TestMethod]
        public void TestMethodBagi()
        {
            MainWindow kal = new MainWindow();
            double a1 = 4;
            double b1 = 2;
            double result = kal.bagi(a1, b1);
            double hasil = 2;

            Assert.AreEqual(hasil, result, "Salah");
        }
    }
}
