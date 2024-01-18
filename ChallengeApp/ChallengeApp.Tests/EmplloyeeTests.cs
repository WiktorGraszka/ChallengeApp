namespace ChallengeApp.Tests
{
    public class EmplloyeeTests
    {
        [Test]
        public void TestAvarageStatistics()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(6);


            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(4, result.Avarage);
        }
        [Test]
        public void TestMinStatistics()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(6);


            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, result.Min);
        }
        [Test]
        public void TestMaxStatistics()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(6);


            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, result.Max);
        }




    }

}