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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SIPI_SL
{
    /// <summary>
    /// Interaction logic for SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        private LoginUI m_LoginUI;

        private DispatcherTimer splashAnimationTimer;

        private const string Loading = "Loading";

        public SplashWindow()
        {
            InitializeComponent();

            splashAnimationTimer = new DispatcherTimer();
            splashAnimationTimer.Interval = TimeSpan.FromMilliseconds(500);
            splashAnimationTimer.Tick += new EventHandler(splashAnimationTimer_Tick);
            splashAnimationTimer.Start();

            m_LoginUI = new LoginUI();

            m_LoginUI.ReadyToShow += new LoginUI.ReadyToShowDelegate(m_LoginUI_ReadyToShow);

            m_LoginUI.Closed += new EventHandler(m_LoginUI_Closed);
        }
        void splashAnimationTimer_Tick(object sender, EventArgs e)
        {

            int dotsCount = lblProgress.Content.ToString().Replace(Loading, string.Empty).Length;

            if (dotsCount < 6)
            {
                dotsCount++;
            }
            else
            {
                dotsCount = 0;
            }

            lblProgress.Content = Loading.PadRight(Loading.Length + dotsCount, '.');
        }
        void m_LoginUI_ReadyToShow(object sender, EventArgs args)
        {

            #region Animate the splash screen fading

            Storyboard sb = new Storyboard();
            //
            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };
            //
            Storyboard.SetTarget(da, this);
            Storyboard.SetTargetProperty(da, new PropertyPath(OpacityProperty));
            sb.Children.Add(da);
            //
            sb.Completed += new EventHandler(sb_Completed);
            //
            sb.Begin();

            #endregion // Animate the splash screen fading
        }

        void sb_Completed(object sender, EventArgs e)
        {

            m_LoginUI.Visibility = System.Windows.Visibility.Visible;
        }

        void m_LoginUI_Closed(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
