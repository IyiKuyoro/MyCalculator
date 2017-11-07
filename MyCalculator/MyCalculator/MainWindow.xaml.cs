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
        public string Exp
        {
            get
            {
                return (string)GetValue(ExpProperty);
            }
            set
            {
                SetValue(ExpProperty, value);
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
        public static DependencyProperty ExpProperty = DependencyProperty.Register("Exp", typeof(string), typeof(MainWindow), new PropertyMetadata(""));
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
            }
            else
            {
                IsON = false;
                Status = "Off";
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "1"; 
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "2";
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "3";
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "4";
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "5";
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "6";
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "7";
            }
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "8";
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10)
            {
                Exp += "9";
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (Exp.Length < 10 && Exp.Length > 0)
            {
                Exp += "0";
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Exp = Exp.Remove(Exp.Length - 1);
        }
    }
}
