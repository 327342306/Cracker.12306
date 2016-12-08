using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cracker._12306.UserControls
{
    public partial class CodePointIcon : UserControl
    {
        public CodePointIcon()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 鼠标点击的x坐标
        /// </summary>
        [Browsable(true)]
        [Description("鼠标点击的x坐标"), Category("基础属性"), DefaultValue(0)]
        public int point_x { get; set; }

        /// <summary>
        /// 鼠标点击的y坐标
        /// </summary>
        [Browsable(true)]
        [Description("鼠标点击的y坐标"), Category("基础属性"), DefaultValue(0)]
        public int point_y { get; set; } 
    }
}
