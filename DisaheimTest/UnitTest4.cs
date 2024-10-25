using Disaheim;
namespace DisaheimTest
{
    [TestClass]
    public class UnitTest4
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2;
        CourseRepository courses;
        MerchandiseRepository merchandises;
        //BookRepository books;
        //AmuletRepository amulets;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            InitBook();

            InitAmulet();

            InitCourse();

            merchandises = new MerchandiseRepository();
            courses = new CourseRepository();

            // Act
            courses.AddCourse(c1);
            courses.AddCourse(c2);
        }

        private void InitCourse()
        {
            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);
        }

        private void InitAmulet()
        {
            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");
        }

        private void InitBook()
        {
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);
        }

        private void AddMerchandiseBook()
        {
            merchandises.AddMerchandise(b1);
            merchandises.AddMerchandise(b2);
            merchandises.AddMerchandise(b3);
        }

        private void AddMerchandiseAmulet()
        {
            merchandises.AddMerchandise(a1);
            merchandises.AddMerchandise(a2);
            merchandises.AddMerchandise(a3);
        }

        [TestMethod]
        public void TestGetBook()
        {
            // Act
            AddMerchandiseBook();
            // Assert
            Assert.AreEqual(b2, merchandises.GetMerchandise("2"));
        }
        [TestMethod]
        public void TestGetAmulet()
        {
            // Act
            AddMerchandiseAmulet();
            // Assert
            Assert.AreEqual(a3, merchandises.GetMerchandise("13"));
        }
        [TestMethod]
        public void TestGetCourse()
        {
            // Assert
            Assert.AreEqual(c1, courses.GetCourse("Eufori med røg"));
        }
        [TestMethod]
        public void TestGetTotalValueForBook()
        {
            // Act
            AddMerchandiseBook();
            // Assert
            Assert.AreEqual(123.55, merchandises.GetTotalValue());
        }
        [TestMethod]
        public void TestGetTotalValueForAmulet()
        {
            // Act
            AddMerchandiseAmulet();
            // Assert
            Assert.AreEqual(60.0, merchandises.GetTotalValue());
        }
        [TestMethod]
        public void TestGetTotalValueForCourse()
        {
            // Assert
            Assert.AreEqual(2625.0, courses.GetTotalValue());
        }
    }

}
