using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        
        string text;
        string textfile;
        
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        
        public string manualTextInput()
        {
            Console.WriteLine("Please enter the text you would like analysed: ");
            text = Console.ReadLine();
            return text;
        }
        
        
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public string fileTextInput(string fileName) 
        {
            string Error = ("Incorrect file, please try again");
            
            string file = File.ReadAllText(@$"../../../../{fileName}");
            return file;
        }

        internal string fileTextInput()
        {
            throw new NotImplementedException();
        }
    }
}
