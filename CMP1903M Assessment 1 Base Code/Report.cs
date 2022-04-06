using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        // Variables
        string text;
        List<int> parameters;

        public Report(string Text, List<int> Parameters)
        {
            // text inputed
            text = Text;

            // parameter result
            parameters = Parameters;
            
        }

        public void OutputConsole()
        {
            // All the values for each of them is printed
            List<string> report = new List<string>() 
            { 
                "Number of sentences: " + parameters[0], 
                "Number of vowels: " + parameters[1],
                "Number of consantants: " + parameters[2],
                "Number of upper case letters: " + parameters[3], 
                "Number of lower case letters: " + parameters[4], 
                "Total characters entered: " + parameters[5] };

            // Print
            foreach (string reports in report)
            {
                Console.WriteLine(reports);
            }
          
        }
    }
}
