using System;
using System.Windows;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
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
        #region EventHandlers
        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            if (!IsON)
            {
                IsON = true;
                Status = "On";
                DisplayText = "";
            }
            else
            {
                IsON = false;
                Status = "Off";
                DisplayText = "";
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "1"; 
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "2";
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "3";
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "4";
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "5";
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "6";
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "7";
            }
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "8";
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10)
            {
                DisplayText += "9";
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Length < 10 && DisplayText.Length > 0)
            {
                DisplayText += "0";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = DisplayText.Remove(DisplayText.Length - 1);
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = "";
        }

        private void btnPlusMin_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText[0] != '-')
            {
                DisplayText = "-" + DisplayText; 
            }
            else
            {
                DisplayText = DisplayText.Remove(0, 1);
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
