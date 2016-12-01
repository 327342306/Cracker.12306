using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cracker._12306.Helper;
using System.Threading;
namespace Cracker._12306
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Load += Main_Load;
        }

        void Main_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            (new Thread(() =>
            {
                for (int i = 0; i < Stations.StationList.Count; i++)
                {
                    cbx_StartStation.Items.Add(Stations.StationList[i].Name);
                    cbx_EndStation.Items.Add(Stations.StationList[i].Name);
                }
            }){ 
                 IsBackground = true
            }).Start();
            
        }
    }
}
