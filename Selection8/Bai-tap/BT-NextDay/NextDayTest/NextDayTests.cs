using NUnit.Framework;
using NextDayService;
namespace NextDayTest
{
    public class NextDayTests
    {
        private NextDay _nextDay;
        [SetUp]
        public void Setup()
        {
            _nextDay = new NextDay();
        }
        [Test]
        public void NextDayTest1()
        {
            int date = 28;
            int month = 2;
            int year = 2020;
            string expected = "29/2/2020";
            string result = _nextDay.PrintNextDay(date, month, year);
            Assert.Pass(expected,result);
        }
        [Test]
        public void NextDayTest2()
        {
            int date = 31;
            int month = 12;
            int year = 2020;
            string expected = "1/1/2021";
            string result = _nextDay.PrintNextDay(date, month, year);
            Assert.IsTrue(expected==result);
        }
    }
}