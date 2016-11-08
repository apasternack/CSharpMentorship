using System;
using static Homework3.EnumsAndStructs;
using System.Collections.Generic;


namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //SET UP
            bool majorNotValid = true;
            bool exit = false;
            string major = null;
            List<ECE> eceStudents = new List<ECE>();
            eceStudents.Add(new ECE("Matt", 00001, Grade.A, Grade.B, Grade.C));
            eceStudents.Add(new ECE("Mark", 00002, Grade.A, Grade.A, Grade.B));
            eceStudents.Add(new ECE("Adam", 00003, Grade.A, Grade.C, Grade.D));
            List<CSE> cseStudents = new List<CSE>();
            cseStudents.Add(new CSE("Tommy G", 00004, Grade.B, Grade.B, Grade.A));
            cseStudents.Add(new CSE("Suzi Q", 00005, Grade.B, Grade.B, Grade.A));
            cseStudents.Add(new CSE("Snoop Dogg", 00006, Grade.A, Grade.A, Grade.C));




            //MAIN PROGRAM

            while (!exit)
            {

                Console.WriteLine("=========================================\n"
                                    + ":               MAIN MENU               :\n"
                                    + ":   Enter:                              :\n"
                                    + ":    \"CSE\" to view CSC student grades   :\n"
                                    + ":    \"ECE\" to view ECE student grades   :\n"
                                    + ":    \"Exit\" to exit program             :\n"
                                    + "=========================================");

                //Validating Input
                major = Console.ReadLine().ToLower();

                majorNotValid = true;

                while (majorNotValid)
                {
                    if (major == "ece" || major == "cse" || major == "exit")
                    {
                        majorNotValid = false;
                    }
                    else
                    {
                        Console.WriteLine("invalid entry.  Please enter \"CSE\" or \"ESE\" to view grades.");
                        major = Console.ReadLine();
                    }
                }

                //Responding to input
                if (major == "ece")
                {
                    FormatEceStudentOutput(eceStudents);
                }
                else if (major == "cse")
                {
                    FormatCseStudentOutput(cseStudents);
                }
                else
                {
                    exit = true;
                }
            }
        }
        
        //METHODS
        private static void FormatEceStudentOutput(List<ECE> students)
        {
            foreach (ECE student in students)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("{0,-25} {1, 10}", "Student:", student.StudentName);
                Console.WriteLine("{0,-25} {1, 10:00000}", "ID #:", student.Id);
                Console.WriteLine("{0,-25} {1, 10}", "Circuit Analysis", GetLetterGrade(student.CircuitAnalysisGrade));
                Console.WriteLine("{0,-25} {1, 10}", "Electronic Circuits:", GetLetterGrade(student.ElectronicCircuitsGrade));
                Console.WriteLine("{0,-25} {1, 10}", "Analog Communication:", GetLetterGrade(student.AnalogCommunicationGrade));
                Console.WriteLine("{0,-25} {1, 10:#.0}", "Average Grade:", student.AverageGrade);
                Console.WriteLine("------------------------------------\n");
            }
        }

        private static void FormatCseStudentOutput(List<CSE> students)
        {
            foreach (CSE student in students)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("{0,-25} {1, 10}", "Student:", student.StudentName);
                Console.WriteLine("{0,-25} {1, 10:00000}", "ID #:", student.Id);
                Console.WriteLine("{0,-25} {1, 10}", "Computer Network", GetLetterGrade(student.ComputerNetworkGrade));
                Console.WriteLine("{0,-25} {1, 10}", "Data Stucture:", GetLetterGrade(student.DataStructureGrade));
                Console.WriteLine("{0,-25} {1, 10}", "Testing:", GetLetterGrade(student.TestingGrade));
                Console.WriteLine("{0,-25} {1, 10:#.0}", "Average Grade:", student.AverageGrade);
                Console.WriteLine("------------------------------------\n");
            }
        }

        private static string GetLetterGrade(double gpa)
        {
            switch ((int) gpa)
            {
                case 0: return "F";
                case 1: return "D";
                case 2: return "C";
                case 3: return "B";
                case 4: return "A";
                default: return "ERROR";
            }
        }
    }
}
