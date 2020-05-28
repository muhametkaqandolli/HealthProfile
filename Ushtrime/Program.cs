using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushtrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string fname = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lname = Console.ReadLine();
            Console.Write("What is your year of birth? ");
            int yob = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your gender? ('M' or 'F') ");
            string gender = Console.ReadLine();
            Console.Write("What is your height in inches? ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your weight in pounds? ");
            int weight = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();
            HealthProfile patient1 = new HealthProfile(fname, lname, yob, gender, height, weight);

            Console.WriteLine("Name: {0} {1}", patient1.PatientFirstName, patient1.PatientLastName );
            Console.WriteLine("Year Of Birth: {0}", patient1.PatientYearOfBirth);
            Console.WriteLine("Age: {0}", patient1.Age());
            Console.WriteLine("Gender: {0}", patient1.PatientGender.ToUpper() == "M" ? "Male" : "Female");
            Console.WriteLine("Max safe heart rate: {0}. \n Workout heart rate target range {1} to {2}",
                patient1.MaxHeartRate(), patient1.MinTargetRate(), patient1.MaxTargetRate());
            Console.WriteLine("Height: {0}\". Weight {1} lbs.", patient1.PatientHeight, patient1.PatientWeight);
            Console.WriteLine("BMI: {0:##:##}%, which means you are {1}", patient1.BMI(), patient1.BmiEvaluation());


            Console.ReadLine();
        }
    }
}
