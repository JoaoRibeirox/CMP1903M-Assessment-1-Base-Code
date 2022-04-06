//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            // Gets the text from manual and file. This is used for the Report so it can directly send it across.
            string text;

            string input_type;

            List<int> parameters = new List<int>();

            //Creates Input objects
            Input input = new Input();

            //Create an Analyse objects
            Analyse analyse = new Analyse();


            //while loops has been used for error handling purposes
            while (true)
            {
                // User Input
                Console.WriteLine("type manual or file");
                input_type = Console.ReadLine();
                if (string.IsNullOrEmpty(input_type)) // If the string is empty then it shows
                {
                    Console.WriteLine("The input type you've inputed is empty. ");
                }
                else if (input_type == "manual")
                {
                    // Manual input
                    parameters = analyse.analyseText(input.manualTextInput());
                    text = input.manualTextInput();

                    //Report the results
                    Report report = new Report(text, parameters);
                    report.OutputConsole();
                    break;
                }
                else if (input_type == "file")
                {
                    // File input
                    parameters = analyse.analyseText(input.fileTextInput());
                    text = input.fileTextInput();

                    //results
                    Report report = new Report(text, parameters);
                    report.OutputConsole();
                    break;
                }
                else // only allows people to choose valid options
                {
                    Console.WriteLine("This is not a valid option, try again");
                    continue;
                }


            }

        }
        
    }
}
