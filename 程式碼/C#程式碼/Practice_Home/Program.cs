using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Home
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int currentAssignment = 5;
            int[] studentScore = new int[10];
            string currentStudentLetter = "";

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] AndrewScore = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScore = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
            int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 80 };
            int[] gregorScore = new int[] { 91, 91, 91, 91, 91, 91 };

            string[] studentName = { "Sophia", "Andrew", "Emma", "Logan","Becky","Chris","Eric","Gregor" };

            foreach(string name in studentName)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScore = sophiaScores;
                else if (currentStudent == "Andrew")
                    studentScore = AndrewScore;
                else if (currentStudent == "Emma")
                    studentScore = emmaScore;
                else if (currentStudent == "Logan")
                    studentScore = loganScores;
                else if (currentStudent == "Becky")
                    studentScore = beckyScores;
                else if (currentStudent == "Chris")
                    studentScore = chrisScores;
                else if ((currentStudent == "Eric"))
                    studentScore = ericScores;
                else if (currentStudent == "Gregor")
                    studentScore = gregorScore;
                else
                    continue;

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;

                int gradeAssignment = 0;

                foreach(int score in studentScore)
                {
                    gradeAssignment += 1;
                    if(gradeAssignment <= currentAssignment)
                    
                        sumAssignmentScores += score;
                    
                    else
                    
                        sumAssignmentScores += score / 10;
                    
                }

                currentStudentGrade = (decimal)sumAssignmentScores / currentAssignment;


                

                if (currentStudentGrade >= 97)
                    currentStudentLetter = "A+";
                else if (currentStudentGrade >= 93)
                    currentStudentLetter = "A";
                else if(currentStudentGrade>=90)
                    currentStudentLetter = "A-";
                else if (currentStudentGrade >=90)
                    currentStudentLetter = "B+";
                else if (currentStudentGrade >= 83)
                    currentStudentLetter = "B";
                else if(currentStudentGrade>=80)
                    currentStudentLetter = "B-";
                else if(currentStudentGrade >=77)
                    currentStudentLetter = "C+";
                else if(currentStudentGrade >=73)
                    currentStudentLetter = "C";
                else if(currentStudentGrade >=70)
                    currentStudentLetter = "C-";
                else if(currentStudentGrade >=67)
                    currentStudentLetter = "D+";
                else if(currentStudentGrade >=63)
                    currentStudentLetter = "D";
                else if (currentStudentGrade >= 60)
                    currentStudentLetter = "D-";
                else
                    currentStudentLetter = "F";

                Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetter}");
            }

            Console.WriteLine("Press the enter key to continue");


            

            Console.ReadLine();
        }
    }
}

