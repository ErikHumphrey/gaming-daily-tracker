using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaming_daily_tracker
{
    public partial class frmGamingDailyTracker : Form
    {
        public frmGamingDailyTracker()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimeLeftGW2.Text = lblTimeLeftBlackDesertOnline.Text = lblTimeLeftTheDivision.Text = lblTimeLeftTI6.Text = GetTimeUntilNextHour(20).ToString().Substring(0, 8);
            lblTimeLeftGOG.Text = GetTimeUntilNextHour(9).ToString().Substring(0, 5);
            lblTimeLeftBrawlhalla.Text = lblTimeLeftHearthstone.Text = lblTimeLeftWow.Text = lblTimeLeftHeroes.Text = GetTimeUntilNextHour(4).ToString().Substring(0, 8);
            tmrUpdater.Start();
        }

        public static TimeSpan GetTimeUntilNextHour(int hour)
        {
            var currentTime = DateTime.Now;
            var desiredTime = new DateTime(DateTime.Now.Year,
                DateTime.Now.Month, DateTime.Now.Day, hour, 0, 0);
            return currentTime.Hour >= hour ?
                (desiredTime.AddDays(1) - currentTime) :
                desiredTime - currentTime;
        }

        private void tmrUpdater_Tick(object sender, EventArgs e)
        {
            lblTimeLeftGW2.Text = lblTimeLeftBlackDesertOnline.Text = lblTimeLeftTheDivision.Text = GetTimeUntilNextHour(20).ToString().Substring(0, 8);
            lblTimeLeftGOG.Text = GetTimeUntilNextHour(9).ToString().Substring(0, 8);
            lblTimeLeftBrawlhalla.Text = lblTimeLeftHearthstone.Text = lblTimeLeftWow.Text = lblTimeLeftHeroes.Text = GetTimeUntilNextHour(4).ToString().Substring(0, 8);
            lblTimeLeftHearthstone.Text = GetTimeUntilNextHour(3).ToString().Substring(0, 8);
        }
    }


}
