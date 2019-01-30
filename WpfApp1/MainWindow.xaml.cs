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

        /// <summary>
        /// shows the created window 
        /// </summary>
        public MainWindow()
        {
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
            
            Button b = (Button)sender;

            
            if (b == null)
            {
                ArgumentNullException argumentNullException = new ArgumentNullException(nameof(sender));
                throw argumentNullException;

            }else if ((string)b.Content ==  "CE")
            {

                displayTextBox.Clear();
            }
            else
            {
                if ((string)b.Content != "=")
                    displayTextBox.Text = displayTextBox.Text + b.Content;
                else
                    displayTextBox.Text = displayTextBox.Text + b.Content;
                    getSolution(displayTextBox.Text);
            }

        }

        private Result getSolutionByString(string stringResult)
        {
            
            double term1 = 0.0;
            double term2 = 0.0;

            for(int i = 0; i < eachButton.Length; i++)
            {
                if(eachButton[i] == '(')
                {
                  


                }
            }

            if(eachButton[0] != '+' && eachButton[0] != '-' && eachButton[0] != '/' && eachButton[0] != '*')
            {
                
            }

            Result doubleResult = new Result();
            return doubleResult;
        }
    }
}
