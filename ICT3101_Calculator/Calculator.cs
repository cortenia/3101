using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ICT3101_Calculator
{
    public class CalculatorContext 
    {
        public Calculator _calc;
        public CalculatorContext() 
        {
            _calc = new Calculator();
        }
    }
    public class Calculator
    {
        public Calculator() 
        {
            
        }
        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d": 
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "c":
                    result = CurrentFailureIntensity(num1, num2, num3);
                    break;
                case "e":
                    result = ExpectedFailureIntensity(num1, num2, num3);
                    break;
                case "l":
                    result = LogCurrentFailureIntensity(num1, num2, num3);
                    break;
                case "i":
                    result = SSI(num1, num2, num3);
                    break;
                // Return text for an incorrect option entry.
                default: break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            Regex re = new Regex(@"\b[10]+\b");
            string n1 = num1.ToString();
            string n2 = num2.ToString();
            if (re.IsMatch(n1) && re.IsMatch(n2))
                return Convert.ToInt64( n1+n2 , 2);
            else 
                return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            try
            {
                if (num1==0 && num2==0)
                {
                    return 1;
                    //throw new ArgumentException();
                }
                else
                {
                    return (num1 / num2); ;
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
        }
        public double Factorial(double num)
        {
            if (num < 0) throw new ArgumentException();
            double result = 1;
            for (double i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }
        public double AreaTriangle(double num1, double num2)
        {
            if (double.IsNegative(num1) | double.IsNegative(num2)
                | num1 == 0 | num2 == 0) throw new ArgumentException();
            return 0.5 * num1 * num2;
        }
        public double AreaCircle(double num)
        {
            if (double.IsNegative(num) | num == 0) throw new ArgumentException();
            return Math.Round(Math.Pow(num, 2) * Math.PI, 2);
        }
        public double UnknownFunctionA(double num1, double num2)
        {
            if (num2 > num1 | double.IsNegative(num1) | double.IsNegative(num2))
                throw new ArgumentException();
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }
        public double UnknownFunctionB(double num1, double num2)
        {
            if (num2 > num1 | double.IsNegative(num1) | double.IsNegative(num2))
                throw new ArgumentException();
            return Divide(Factorial(num1), Multiply(Factorial(num2),Factorial(Subtract(num1, num2))));
        }
        public double CurrentFailureIntensity(double i, double u, double v)
        {
            return Math.Round(
                Multiply(i, Subtract(1, Divide(u, v)))
                , 1, MidpointRounding.AwayFromZero);
        }
        public double ExpectedFailureIntensity(double v, double i, double t)
        {
            return Math.Round(
                Multiply(v, Subtract(1, Math.Exp( -1 * Multiply(Divide(i,v), t)) ) )
                , 1, MidpointRounding.AwayFromZero); 
        }
        public double LogCurrentFailureIntensity(double i, double t, double u)
        {
            Console.WriteLine(Math.Round(
                Multiply(i, Math.Exp(-1 * Multiply(t, u)))
                , 1, MidpointRounding.AwayFromZero));
            return Math.Round(
                Multiply(i, Math.Exp( -1 * Multiply(t, u) ) ) 
                , 1, MidpointRounding.AwayFromZero);
        }
        public double SSI(double ssi, double csi, double c)
        {
            return Subtract(Add(ssi, csi), c);
        }
        public double GenMagicNum(double input, IFileReader getTheMagic)
        {
            double result = 0.0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------ 
            //FileReader getTheMagic = new FileReader();
            //---------------------------------------- 
            string[] magicStrings = getTheMagic.Read(Path.Combine(Environment.CurrentDirectory, @"..\..\..\MagicNumbers.txt"));

            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
//commit

/** Week2 Lab 
 * Q19 - Epic
 * As a Quality Enginner
 * I want to perform different types of complex calculations 
 * So that I quantify the quality of a system
 * 
 * Q20 - User Stories
 * As a Quality Engineer
 * I want to be able to calculate the defect density of a system
 * So that I can identify how many defects there are in a release
 * 
 * As a Quality Engineer
 * I want to be able to calculate SSIs in the 2nd release of a system
 * So that I know the KLOCs currently in the 2nd release
 * 
 * As a Quality Engineer
 * I want to be able to calculate the failure intensity using the Musa Logarithmic model
 * So that I can get a better estimate over the Basic Model.
 */