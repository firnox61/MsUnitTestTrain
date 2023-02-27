namespace MsTest
{
    [TestClass]//test sýnýfý olmazsa hiç test olmaz
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc) 
        { 
            Console.WriteLine("Bu önce class");
        }
        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("Bu sonra class");
        }
        [TestInitialize] public void BeforeTest()
        {
            Console.WriteLine("Bu önce test"); 
        }
        [TestCleanup] public void AfterTest()
        {
            Console.WriteLine("Bu sonra test");
        }
        [TestMethod]//test methodu olmadan methet çalýþmaz
        public void TestMethod1()
        {
            Console.WriteLine("bu ilk test");
        }
        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Console.WriteLine("Bu ikinci test");
        //}
        //[TestMethod]

        //public void TestMethod3()
        //{
        //    Console.WriteLine("Bu üçüncü test");
        //}
    }
}