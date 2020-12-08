using SpecFlowIntro1.Steps_definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowIntro1
{
    [Binding]
    class SampleFeatureSteps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("WhenTheTwoNumbersAreAdded");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if (result == 121)
                Console.WriteLine("The Test Passed");
            else
            {
                Console.WriteLine("Test Failed");
                throw new Exception("The value is different");
            }
            
        }
        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
           var details= table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The details of employee :" + emp.Name);
                Console.WriteLine("***********************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }

        }
        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormClaudeAnd(string name,int age,Int64 Phone)
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Phone number :" + Phone);

            ScenarioContext.Current["InfoForNextStep"] = "Step1 Passed";
            Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name="Abraham",
                    Age=20,
                    Email="Abraham@gmail.com",
                    Phone=12345678
                },
                 new EmployeeDetails()
                {
                    Name="Ali",
                    Age=22,
                    Email="Ali@gmail.com",
                    Phone=12345673
                },
                  new EmployeeDetails()
                {
                    Name="Steven",
                    Age=19,
                    Email="Steven@gmail.com",
                    Phone=12345178
                }
            };

            ScenarioContext.Current.Add("EmpDetails", empDetails);
            var emplist=ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The employee name is :" + emp.Name);
                Console.WriteLine("The employee Age is :" + emp.Age);
                Console.WriteLine("The employee Email is :" + emp.Email);
                Console.WriteLine("The employee Phone is :" + emp.Phone);
                Console.WriteLine("\n");

            }
        }


    }



}
