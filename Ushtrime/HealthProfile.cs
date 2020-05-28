using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushtrime
{
    class HealthProfile
    {
        private int _patientYearOfBirth;
        private string _patientGender;

        public HealthProfile(string fname, string lname, int yob, string gender, int height, int weight)
        {
            PatientFirstName = fname;
            PatientLastName = lname;
            PatientYearOfBirth = yob;
            PatientGender = gender;
            PatientHeight = height;
            PatientWeight = weight;
        }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int PatientHeight { get; set; }
        public int PatientWeight { get; set; }

        public int PatientYearOfBirth
        {
            get { return _patientYearOfBirth; }
            set
            {
                while (value < 1900 || value > 2016)
                {
                    Console.WriteLine("Invalid year of birth. Please re-enter: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                _patientYearOfBirth = value;
            }
        }

        public string PatientGender
        {
            get { return _patientGender; }
            set
            {
                while (value.ToUpper() != "M" && value.ToUpper() != "F")
                {
                    Console.WriteLine("Please enter valid gender (M or F)");
                    value = Console.ReadLine();
                }

                _patientGender = value;
            }
        }

        public int Age()
        {
            return DateTime.Today.Year - PatientYearOfBirth;
        }

        public int MaxHeartRate()
        {
            return 220 - Age();
        }

        public int MaxTargetRate()
        { 
            return (Convert.ToInt32(MaxHeartRate()* 0.85));
        }

        public int MinTargetRate()
        { 
            return (Convert.ToInt32(MaxHeartRate()* 0.5));
        }

        public double BMI()
        {
            return (PatientWeight / (Math.Pow(PatientHeight, 2))) * 703;
        }

        public string BmiEvaluation()
        {
            if (BMI() < 18.5)
                return "Underweight";
            else if (BMI() < 25)
                return "Normal";
            else if (BMI() < 30)
                return "Overweight";
            else
                return "Obese";
            
        }
    }
}
