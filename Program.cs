namespace Session2Assiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Aya Ahmed";
            emp.Age = 23;
            emp.Salary = 6000;
            emp.DisplayInfo();

            Employee emp2 = new Employee();
            emp2.Name = "Ahmed Ali";
            emp2.Age = 25;
            emp2.Salary = 8000; 
            emp2.DisplayInfo();
        }
    }
}
