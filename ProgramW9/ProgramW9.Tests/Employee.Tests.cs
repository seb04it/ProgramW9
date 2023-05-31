namespace ProgramW9.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMaxGrade()
        {
            var employee = new Employee("Adam", "K");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(7, statistics.Max);
        }
    }
}