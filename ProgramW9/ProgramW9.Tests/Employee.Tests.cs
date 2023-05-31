namespace ProgramW9.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMaxGrade()
        {
            var employee = new Employee("Mi³osz", "K");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(7, statistics.Max);
        }
        [Test]
        public void CheckMinGrade()
        {
            var employee = new Employee("Mi³osz", "K");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void CheckAverageGrade()
        {
            var employee = new Employee("Mi³osz", "K");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(4.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}