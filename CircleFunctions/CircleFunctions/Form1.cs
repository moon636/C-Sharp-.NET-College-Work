using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleFunctions
{
    public partial class Form1 : Form
    {
        const float PI = 3.14159F;

        //This is a CONSTANT called PI. It can be used in the rest of the program
        //instead of the literal number. This helps make the program more readable
        //and maintainable.
        //TRY USING THE CONSTANT WHEN YOU WRITE THE FUNCTIONS //REQUESTED BELOW
        //FIND OUT WHAT IS MEANT BY MAINTAINABLE CODE

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float radius, diameter, area; //LOCAL VARIABLES - these are only accessible in the
                                    //btnCalculate_Click function

            double circumference;

            //input radius
            radius = float.Parse(txtRadius.Text);

            //Call the CalculateDiameter function to work out the diameter
            //We pass the radius as an ARGUMENT that is used inside the CalculateDiameter  function

            //The CalculateDiameter function returns a float value, which is the diameter it has calculated.
            //We put the returned value into the diameter variable so we can display it later.

            diameter = CalculateDiameter(radius);
            circumference = CalculateCircumference(radius);
            area = CalculateArea(radius);

            //WRITE FUNCTIONS TO CALCULATE THE CIRCUMFERENCE AND AREA OF THE CIRCLE

            //Call the DisplayResults function to display the results (just the diameter so far)
            //Notice the DisplayResults function just performs its job. It DOESN'T RETURN a value.

            DisplayResults(diameter,circumference,area);

            //MODIFY DisplayResults TO DISPLAY ALL THE RESULTS OF THE CALCULATIONS
        }

        //Function to return diameter given the radius
        float CalculateDiameter(float myRadius)  //radius is passed in as an ARGUMENT. Function RETURNS a float value
        {
            float myDiameter;  //LOCAL VARIABLE to hold the diameter when it's calculated below

            myDiameter = myRadius * 2; //calculate the diameter using the radius ARGUMENT

            return myDiameter; //function RETURNS a float value. In this case, the diameter that has been calculated

        }

        double CalculateCircumference(float myRadius)  //radius is passed in as an ARGUMENT. Function RETURNS a float value
        {
            double myCircumference;  //LOCAL VARIABLE to hold the diameter when it's calculated below

            myCircumference = 2* Math.PI * myRadius ; //calculate the diameter using the radius ARGUMENT

            return myCircumference; //function RETURNS a float value. In this case, the diameter that has been calculated

        }

        float CalculateArea(float myRadius)  //radius is passed in as an ARGUMENT. Function RETURNS a float value
        {

            float myArea;  //LOCAL VARIABLE to hold the diameter when it's calculated below

            myArea = myRadius * myRadius * (float)Math.PI ; //calculate the diameter using the radius ARGUMENT

            return myArea; //function RETURNS a float value. In this case, the diameter that has been calculated


        }
        //Function to display the results of the calculations
        void DisplayResults(float myDiameter,double circumference, float area) //This function doesn't return a value so its RETURN TYPE is VOID
        {
            //This function displays the diameter the program calculated earlier.
            //MODIFY THE FUNCTION TO DISPLAY ALL THE RESULTS OF THE CALCULATIONS YOU HAVE ADDED

            txtDiameter.Text = myDiameter.ToString();
            txtCircumference.Text = circumference.ToString();
            txtArea.Text = area.ToString();

            //No need for a RETURN statement because this function doesn't return a value.
        }

        private void txtCircumference_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


