using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A nutritionist who works for a fitness club helps members by evaluating their diets. As part of her evaluation,
//she asks members for the number of fat grams and carbohydrate grams that they consumed in a day. Then, she calculates
//the number of calories that result from the fat, using the following formula:
// Calories from Fat = Fat Grams x 9
// Next, she calculates the number of calories that result from the carbohydrates using the following formula:
// Calories from carbs = Carbs grams x 4
// Create an application that will make these calculations. In the application, you should have the following methods:
// FatCalories – This method should accept a number of fat grams as an argument and return the number of calories from that amount of fat.
// CarbCalories – This method should accept a number of carbohydrates grams as an argument and return the number of calories
// from that amount of carbohydrates.

namespace Week_4_Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Event handler when Calculate Button is pressed.
        private void calculateButton_Click(object sender, EventArgs e)
        {   // Create varables for data double.
            double fatGrams, carbGrams, caloriesFromFat, caloriesFromCarbs;

            // Build a User friendly exception alert.
            if (double.TryParse(fatGramsTextBox.Text, out fatGrams))
            {   // Build a User friendly exception alert.
                if (double.TryParse(carbohydrateTextBox.Text, out carbGrams))
                {
                    // Method call for math formula user input * 9 to calculate the amount of calories from fat.
                    caloriesFromFat = FatCalories(fatGrams);
                    // Method call for math formula user input * 4 to calculate the amount of calories from Carbs.
                    caloriesFromCarbs = CarbCalories(carbGrams);
                    // Send result to GUI in string format to textbox.
                    fatCaloriesTextBox.Text = caloriesFromFat.ToString();
                    // Send result to GUI in string format to textbox.
                    carbohydrateGramsTextBox1.Text = caloriesFromCarbs.ToString();
                }
                else
                {
                    // Alert box to user to only enter a whole number.
                    MessageBox.Show("Please enter whole numbers only! ** Fat from Grams Field");
                }
            }
            else
            {
                // Alert box to user to only enter a whole number.
                MessageBox.Show("Please enter whole numbers only! ** Carbohydrate Field");
            }

        }
        // Method to calculate fat grams to amount of calories.
        private double FatCalories(double fGrams)
        {
            //Numerical varable to store the value nine.
            double formula = 9;
            // User input fat grams * numerical varable  
            double calories = fGrams * formula;
            // return answer from calculations
            return calories;
        }
        // Method to calculate Carbs to amount of calories.
        private double CarbCalories(double cGrams)
        {
            //Numerical varable to store the value four.
            double formula = 4;
            // User input carbs * numerical varable 
            double calories = cGrams * formula;
            // return answer from calculations
            return calories;
        }
        // Rest fields once button is pressed.
        private void resetButton_Click(object sender, EventArgs e)
        {   // Clear Field
            fatGramsTextBox.Text = "";
            // Clear Field
            carbohydrateGramsTextBox1.Text = "";
            // Clear Field
            carbohydrateTextBox.Text = "";
            // Clear Field
            fatCaloriesTextBox.Text = "";

            // Focus Crusor on fatCaloriesTextBox.
            fatCaloriesTextBox.Focus();
        }
        // Close button to end program.
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Terminate Program.
            this.Close();
        }
    }
}
