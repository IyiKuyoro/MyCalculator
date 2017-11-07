using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
