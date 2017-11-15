using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace EquationGenerator
{
    public partial class EquationGenerator : Form
    {
        public EquationGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //generate button clicked
        {
           if (operandsBox.SelectedItems.Count > 0)
            {
                List<char> operands = new List<char> { };
                foreach (ListViewItem operand in operandsBox.SelectedItems) //get all selected operators
                {
                    var operandChar = operand.Text;
                    operands.Add(char.Parse(operandChar)); //add them to the list of possible operators to use
                }
                Dictionary<string, object> output = GenerateMathProblem(int.Parse(numberOfOperatorsBox.Text), int.Parse(difficultyBox.Text), operands);
                solutionBox.Clear();
                solutionBox.Text += "Your generated problem: " + output["problem"] + System.Environment.NewLine;
                solutionBox.Text += "The correct solution: " + output["solution"];
            } else
            {
                MessageBox.Show("Please select 1 or more operators to use");
            }

        }

        private static Dictionary<string, object> GenerateMathProblem(int numberOfVariables, int difficulty, List<char> operands)
        {
            Random r = new Random(); //we define random here to get C#'s math.random to work (since it's based on system clock)

            StringBuilder problem = new StringBuilder();
            int randomNumber;
            for (int i = 0; i < numberOfVariables - 1; i++) //loop through number of variables
            {
                randomNumber = getRandomNumber(difficulty, r); 
                problem.Append(randomNumber); //get a random number based on difficulty and add it to the problem

                char randomOperand = operands[r.Next(0, operands.Count)];
                problem.Append(randomOperand); //get a random operand from user curated list and add to the problem
            }
            problem.Append(getRandomNumber(difficulty, r)); // add a number at the end

            Dictionary<string, object> outputDictionary = new Dictionary<string, object>();
            outputDictionary.Add("problem", problem);
            Expression e = new Expression(problem.ToString());
            outputDictionary.Add("solution", Math.Round(decimal.Parse(e.Evaluate().ToString()), 2));
            return outputDictionary;
        }

        public static int getRandomNumber(int difficulty, Random r)
        {
            return r.Next(1, (difficulty * 10));
        }

  
    }
}
