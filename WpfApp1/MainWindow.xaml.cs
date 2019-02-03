using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>
/// calculator
/// </summary>
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// MainWindow extends Window class (xaml)
    /// </summary>
    public partial class MainWindow : Window
    {
        private string mathOperator;
        private string firstTerm;
        private string secondTerm;
        

        /// <summary>
        /// shows the created window 
        /// </summary>
        public MainWindow()
        {
            this.mathOperator = "";
            this.firstTerm = "";
            this.secondTerm = "";

            InitializeComponent();
            
        }

        /// <summary>
        /// handling button clicks
        /// </summary>
        /// <param name="sender">
        /// sender lets you store any type of variable in it because it is an object
        /// in our case, its a buttons content which is a string
        /// </param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button buttonClick = (Button) sender;
            string button = buttonClick.Content.ToString();

            switch (button)
            {
                case "1":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "1";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "1" : "";
                    break;
                case "2":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "2";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "2" : "";
                    break;
                case "3":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "3";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "3" : "";
                    break;
                case "4":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "4";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "4" : "";
                    break;
                case "5":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "5";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "5" : "";
                    break;
                case "6":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "6";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "6" : "";
                    break;
                case "7":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "7";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "7" : "";
                    break;
                case "8":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "8";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "8" : "";
                    break;
                case "9":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "9";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "9" : "";
                    break;
                case "0":
                    displayTextBox.Text = displayTextBox.Text + buttonClick.Content;
                    this.firstTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "" : "0";
                    this.secondTerm += this.mathOperator == "+" || this.mathOperator == "-" || this.mathOperator == "X" || this.mathOperator == "/" ? "0" : "";
                    break;
                case "CE":
                    displayTextBox.Clear();
                    this.firstTerm = "";
                    this.mathOperator = "";
                    this.secondTerm = "";
                    break;

                case "+":
                        
                    if (this.mathOperator != "" && this.firstTerm != "" && this.secondTerm != "")
                    {
                        this.firstTerm = getSolution().ToString();
                        this.mathOperator = "+";
                        this.secondTerm = "";
                    }
                    else
                    {
                        this.mathOperator = "+";
                    }
                    displayTextBox.Text += buttonClick.Content;

                    break;
                case "-":
                    if (this.mathOperator != "" && this.firstTerm != "" && this.secondTerm != "")
                    {
                        this.firstTerm = getSolution().ToString();
                        this.mathOperator = "-";
                        this.secondTerm = "";
                    }
                    else
                    {
                        this.mathOperator = "-";
                    }
                    displayTextBox.Text += buttonClick.Content;
                    break;
                case "X":
                    if (this.mathOperator != "" && this.firstTerm != "" && this.secondTerm != "")
                    {
                        this.firstTerm = getSolution().ToString();
                        this.mathOperator = "X";
                        this.secondTerm = "";
                    }
                    else
                    {
                        this.mathOperator = "X";
                    }
                    displayTextBox.Text += buttonClick.Content;
                    break;
                case "/":
                    if (this.mathOperator != "" && this.firstTerm != "" && this.secondTerm != "")
                    {
                        this.firstTerm = getSolution().ToString();
                        this.mathOperator = "/";
                        this.secondTerm = "";
                    }
                    else
                    {
                        this.mathOperator = "/";
                    }
                    displayTextBox.Text += buttonClick.Content;
                    break;
                case "=":
                    displayTextBox.Text = "";
                    historyMemoryLabel.Content += getSolution().ToString() +"\n";
                    this.firstTerm = "";
                    this.mathOperator = "";
                    this.secondTerm = "";
                    break;
                case ".":
                    if(!this.firstTerm.Contains("."))
                    {
                        if (this.firstTerm == "" && this.mathOperator == "" && this.secondTerm == "")
                        {
                            displayTextBox.Text += "0.";
                            this.firstTerm = "0.";
                        }

                        if (this.firstTerm != "" && this.mathOperator == "" && this.secondTerm == "")
                        {
                            displayTextBox.Text += ".";
                            this.firstTerm += ".";
                        }
                    }
                    if(!this.secondTerm.Contains("."))
                    {
                        if (this.firstTerm != "" && this.mathOperator != "" && this.secondTerm == "")
                        {
                            displayTextBox.Text += "0.";
                            this.secondTerm = "0.";
                        }

                        if (this.firstTerm != "" && this.mathOperator != "" && this.secondTerm != "")
                        {
                            displayTextBox.Text += ".";
                            this.secondTerm += ".";
                        }
                    }
                    break;


            }
            

        }

        private double getSolution()
        {
            double result = 0.0;
            switch(this.mathOperator)
            {
                case "+":
                    result = Convert.ToDouble(this.firstTerm) + Convert.ToDouble(this.secondTerm);
                    break;
                case "-":
                    result = Convert.ToDouble(this.firstTerm) - Convert.ToDouble(this.secondTerm);
                    break;
                case "X":
                    result = Convert.ToDouble(this.firstTerm) * Convert.ToDouble(this.secondTerm);
                    break;
                case "/":
                    result = Convert.ToDouble(this.firstTerm) / Convert.ToDouble(this.secondTerm);
                    break;
                default:
                    if (this.firstTerm != "")
                        result = Convert.ToDouble(this.firstTerm);
                    if (this.secondTerm != "")
                        result = Convert.ToDouble(this.secondTerm);
                    break;
            }



            return result;
        }
    }
}
