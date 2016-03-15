using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LeapYearTestCases();
            DayInYearTestCases();
            TestSmoosh();
            TestSquish();
        }

        public void LeapYearTestCases()
        {
            Assert.IsTrue(MyDate.IsLeapYear(2004));
            Assert.IsTrue(MyDate.IsLeapYear(2016));
            Assert.IsTrue(MyDate.IsLeapYear(2020));

            Assert.IsFalse(MyDate.IsLeapYear(1800));
            Assert.IsFalse(MyDate.IsLeapYear(1900));
            //Assert.IsFalse(MyDate.IsLeapYear(-1));
        }

        public void DayInYearTestCases()
        {
            DateTime dt = DateTime.Now;
            int nthDay = MyDate.DayInYear(dt);
            Assert.IsTrue(nthDay==68);

            dt = Convert.ToDateTime("01/01/2016");
            nthDay = MyDate.DayInYear(dt);
            Assert.IsTrue(nthDay == 1);

            dt = Convert.ToDateTime("12/31/2016");
            nthDay = MyDate.DayInYear(dt);
            Assert.IsTrue(nthDay == 366);

            dt = Convert.ToDateTime("12/31/2015");
            nthDay = MyDate.DayInYear(dt);
            Assert.IsTrue(nthDay == 365);
        }

        public void TestSmoosh()
        {
            int[] ints = { 0, 0, 0, 0, 1, 1, 0, 0, 0, 3, 3, 3, 1, 1, 0 };
            int[] resultInput = { 0, 1, 0, 3, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            Data_Structures_Labs.Lab2.smoosh(ints);
            int len = ints.Length;
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(ints[i], resultInput[i]);
            }

            
            int[] ints1 = { 0, 0, 1, 2, 3, 1, 1, 0, 0, 3, 3, 3, 1, 1, 0 };
            int[] resultInput1 = { 0, 1, 2, 3, 1, 0, 3, 1, 0, -1, -1, -1, -1, -1, -1 };
            Data_Structures_Labs.Lab2.smoosh(ints1);
            len = ints1.Length;
            for (int i=0; i<len; i++)
            {
                Assert.AreEqual(ints1[i], resultInput1[i]);
            }

            
            int[] ints2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 13 };
            int[] resultInput2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, -1, -1};
            Data_Structures_Labs.Lab2.smoosh(ints2);
            len = ints2.Length;
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(ints2[i], resultInput2[i]);
            }

            
            int[] ints3 = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 1, 1, 4, 1, 1, 0 };
            int[] resultInput3 = { 0, 1, 2, 3, 1, 4, 1, 0, -1, -1, -1, -1, -1, -1, -1 };
            Data_Structures_Labs.Lab2.smoosh(ints3);
            len = ints3.Length;
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(ints3[i], resultInput3[i]);
            }
            
            int[] ints4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] resultInput4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Data_Structures_Labs.Lab2.smoosh(ints4);
            len = ints4.Length;
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(ints4[i], resultInput4[i]);
            }

            
            int[] ints5 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] resultInput5 = { 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            Data_Structures_Labs.Lab2.smoosh(ints5);
            len = ints5.Length;
            for (int i = 0; i < len; i++)
            {
                Assert.AreEqual(ints5[i], resultInput5[i]);
            }
        }

        public void TestSquish()
        {
            Data_Structures_Labs.MyList list = new Data_Structures_Labs.MyList();
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(1);
            list.AddTail(1);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(0);
            list.AddTail(3);
            list.AddTail(3);
            list.AddTail(3);
            list.AddTail(1);
            list.AddTail(1);
            list.AddTail(0);

            // Call the method
            Data_Structures_Labs.LabList.squish(list);


            Data_Structures_Labs.MyList resultlist = new Data_Structures_Labs.MyList();
            resultlist.AddTail(0);
            resultlist.AddTail(1);
            resultlist.AddTail(0);
            resultlist.AddTail(3);
            resultlist.AddTail(1);
            resultlist.AddTail(0);

            Data_Structures_Labs.Node currentNode = list.GetHeadNode();
            Data_Structures_Labs.Node resultNode = resultlist.GetHeadNode();
            while (currentNode != null)
            {
                Assert.AreEqual(currentNode.Data, resultNode.Data);
                Console.WriteLine("{0}", currentNode.Data);
                currentNode = currentNode.Next;
                resultNode = resultNode.Next;
            }
        }
        }
}
