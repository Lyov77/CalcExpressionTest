using System.Numerics;

namespace CalcExpressionTest.Test
{
	public class TestComplexNum
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void TestToString()
		{
			// init
			ComplexNum complex = new ComplexNum(1, 2);

			// action
			string str = complex.ToString();

			// assert
			Assert.AreEqual("1 + 2i", str);
		}

		[Test]
		public void TestEquals()
		{
			// init
			ComplexNum complex1 = new ComplexNum(1, 2);
			ComplexNum complex2 = new ComplexNum(1, 2);
			ComplexNum complex3 = new ComplexNum(1, 3);

			// action
			bool trueResult = complex1.Equals(complex2);
			bool falseResult = complex1.Equals(complex3);

			// assert
			Assert.IsTrue(trueResult);
			Assert.IsFalse(falseResult);
		}

		[Test]
		public void TestSum()
		{
			int x = 10;
			int y = 20;

			int z = x + y;
			// init
			ComplexNum complex1 = new ComplexNum(1, 2);
			ComplexNum complex2 = new ComplexNum(3, 4);

			// action
			ComplexNum complex3 = complex1 + complex2;

			// assert
			Assert.AreEqual(new ComplexNum(4, 6), complex3);

			Assert.Throws<NullReferenceException>(CalcSum);
		}

		private void CalcSum()
		{
			ComplexNum complex1 = new ComplexNum(1, 2);

			ComplexNum c = complex1 + null;
			c = null + complex1;
		}
	}
}