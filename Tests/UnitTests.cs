using System;
using NUnit.Framework;
using static TravisCILab.Program;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Add("1", "2"));
            Assert.AreEqual(5, Add("3", "2"));
            Assert.AreEqual(12, Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Add("1", "a"));
            Assert.Throws<FormatException>(() => Add("a", "1"));
            Assert.Throws<FormatException>(() => Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Add(null, null));
        }

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Subtract("1", "2"));
            Assert.AreEqual(1, Subtract("3", "2"));
            Assert.AreEqual(-2, Subtract("5", "7"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Multiply("1", "2"));
            Assert.AreEqual(6, Multiply("3", "2"));
            Assert.AreEqual(35, Multiply("5", "7"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Multiply(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(0.5, Divide("1", "2"));
            Assert.AreEqual(1.5, Divide("3", "2"));
            Assert.AreEqual((double) 5 / 7, Divide("5", "7"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(78125, Program.Power("5", "7"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
