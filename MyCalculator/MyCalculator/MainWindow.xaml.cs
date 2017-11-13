using System;
using System.Windows;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Enumertion
        enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }
        #endregion Enumeration

        #region Fields
        bool executed = false;
        Operations opertor = Operations.None;
        double result = 0;
        #endregion Fields

        #region Properties
        public string DisplayText
        {
            get
            {
                return (string)GetValue(DisplayTextProperty);
            }
            set
            {
                SetValue(DisplayTextProperty, value);
            }
        }
        private bool IsON
        {
            get
            {
                return (bool)GetValue(IsONProperty);
            }
            set
            {
                SetValue(IsONProperty, value);
            }
        }
        public string Status
        {
            get
            {
                return (string)GetValue(StatusProperty);
            }
            set
            {
                SetValue(StatusProperty, value);
            }
        }

        #region DependencyProperties
        public static DependencyProperty DisplayTextProperty = DependencyProperty.Register("DisplayText", typeof(string), typeof(MainWindow), new PropertyMetadata(""));
        public static DependencyProperty StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(MainWindow), new PropertyMetadata("Off"));
        public static DependencyProperty IsONProperty = DependencyProperty.Register("IsON", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));
        #endregion DependencyProperties
        #endregion Properties

        #region Methods
        /// <summary>
        /// This method checks if execution has already occured and resets all parameters based on outcome.
        /// </summary>
        private void CheckExecution()
        {
            if (executed == true)
            {
                //computation was completed refreash result.
                result = 0;
                DisplayText = "";
                executed = false;
            }
        }

        #region EventHandlers
        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            if (!IsON)
            {
                IsON = true;
                Status = "On";

            }
            else
            {
                IsON = false;
                Status = "Off";
            }
            executed = false;
            result = 0;
            opertor = Operations.None;
            DisplayText = "";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "1";
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "2";
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "3";
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "4";
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "5";
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "6";
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "7";
            }
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "8";
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10)
            {
                DisplayText += "9";
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            CheckExecution();

            if (DisplayText.Length < 10 && DisplayText.Length > 0)
            {
                DisplayText += "0";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = DisplayText.Remove(DisplayText.Length - 1);

            if (DisplayText == "-")
            {
                DisplayText = "";
            }
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            opertor = Operations.None;
            DisplayText = "";
            executed = false;
        }

        private void btnPlusMin_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length == 0)
                return;

            if (DisplayText[0] != '-')
            {
                DisplayText = "-" + DisplayText; 
            }
            else
            {
                DisplayText = DisplayText.Remove(0, 1);
            }
        }
        
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            //Check if text is decimal
            if (!DisplayText.Contains("."))
            {
                if (DisplayText.Length != 0)
                {
                    DisplayText += ".";
                }
                else
                {
                    DisplayText += "0.";
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            opertor = Operations.Add;
            if (!executed)
            {
                result += double.Parse(DisplayText);
            }
            else
            {
                executed = false;
                result = double.Parse(DisplayText);
            }
            DisplayText = "";
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            opertor = Operations.Subtract;
            if (!executed)
            {
                if (result == 0)
                    result = double.Parse(DisplayText);
                else
                    result -= double.Parse(DisplayText);
            }
            else
            {
                executed = false;
                result = double.Parse(DisplayText);
            }
            DisplayText = "";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            opertor = Operations.Multiply;
            if (!executed)
            {
                if (result == 0)
                {
                    result = double.Parse(DisplayText); 
                }
                else
                {
                    result *= double.Parse(DisplayText);
                }
            }
            else
            {
                executed = false;
                result = double.Parse(DisplayText);
            }
            DisplayText = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            opertor = Operations.Divide;
            if (!executed)
            {
                if (result == 0)
                    result = double.Parse(DisplayText);
                else
                    result /= double.Parse(DisplayText);
            }
            else
            {
                executed = false;
                result = double.Parse(DisplayText);
            }
            DisplayText = "";
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            executed = true;
            try
            {
                switch (opertor)
                {
                    case (Operations.Add):
                        result += double.Parse(DisplayText);
                        DisplayText = result.ToString();
                        break;
                    case (Operations.Subtract):
                        result -= double.Parse(DisplayText);
                        DisplayText = result.ToString();
                        break;
                    case (Operations.Multiply):
                        result *= double.Parse(DisplayText);
                        DisplayText = result.ToString();
                        break;
                    case (Operations.Divide):
                        result /= double.Parse(DisplayText);
                        DisplayText = result.ToString();
                        break;
                    default:
                        DisplayText = result.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayText = "Error!";
                result = 0;
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                IsON = false;
            }
        }
        #endregion EventHndlers
        #endregion Methods

        #region Constructors
        public MainWindow()
        {
            IsON = false;
            Status = "Off";
            InitializeComponent();
        }
        #endregion Constructors
    }
}
