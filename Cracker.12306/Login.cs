using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cracker._12306.UserControls;
namespace Cracker._12306
{
    public partial class Login : Form
    {
        Cracker._12306.Helper.Handle.Login _login = new Helper.Handle.Login();
        public Login()
        {
            InitializeComponent();
            _login.Init().GetDynamicFormUrl();
            this.Load += Login_Load;
            this.pic_PassCode.Click += pic_PassCode_Click;
            this.btn_Login.Click += button1_Click;
            this.pic_Refresh.Click += pic_Refresh_Click;
        }

        void pic_Refresh_Click(object sender, EventArgs e)
        {
            LoadCode();
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (PassCodeAllPoint.Count > 0)
            {
                if (_login.CheckPassCode(PassCodeAllPoint))
                {
                    this.btn_Login.Enabled = false;
                    this.btn_Login.Text = "正在登录";

                }
            }
            else
            {
                MessageBox.Show("傻呀，不点验证码！");
            }
        }
        List<Point> PassCodeAllPoint = new List<Point>();
        void pic_PassCode_Click(object sender, EventArgs e)
        {
            Point mouseInWindowsPoint=new Point(); //定义一个坐标结构
            mouseInWindowsPoint.X =  MousePosition.X; //用mousepostion获取鼠标在屏幕中的X轴位置
            mouseInWindowsPoint.Y = MousePosition.Y;//用mousepostion获取鼠标在屏幕中的Y轴位置
            //将鼠标坐标转化为控件内的坐标
            Point mouseInPictureBoxPoint = ((PictureBox)sender).PointToClient(mouseInWindowsPoint);
            //判断坐标是否在正规选中区域内
            if (mouseInPictureBoxPoint.X >= 6 && mouseInPictureBoxPoint.Y >= 42)
            {
                //创建图标空间 并赋值鼠标点击的坐标值到控件属性 以便删除时查找对应数组
                CodePointIcon codePointIcon = new CodePointIcon() {
                    point_x = mouseInPictureBoxPoint.X,
                    point_y = mouseInPictureBoxPoint.Y,
                    Name = "p_" + mouseInPictureBoxPoint.X + "_" + mouseInPictureBoxPoint.Y
                };
                //赋值控件顶点坐标
                codePointIcon.Location = new Point(mouseInPictureBoxPoint.X - 12, mouseInPictureBoxPoint.Y - 12);
                //添加空间点击事件
                codePointIcon.Click += codePointIcon_Click;
                //添加到验证码区域
                ((PictureBox)sender).Controls.Add(codePointIcon);

                //根据计算 算出12306所需坐标信息 存放在待提交数组中
                Point SitePoint = new Point();
                SitePoint.X = codePointIcon.point_x+3;
                SitePoint.Y = codePointIcon.point_y-16;
                PassCodeAllPoint.Add(SitePoint);
            }
        }

        void codePointIcon_Click(object sender, EventArgs e)
        {
            //查找该点击控件 在待提交数组中的位置
            int index = PassCodeAllPoint.FindIndex(i => i.X == ((CodePointIcon)sender).point_x + 3 && i.Y == ((CodePointIcon)sender).point_y - 16);
            //从数组中移除
            PassCodeAllPoint.RemoveAt(index);
            //从控件中移除
            pic_PassCode.Controls.Remove(((CodePointIcon)sender));
        }

        void Login_Load(object sender, EventArgs e)
        {
            LoadCode();
        }
        private void LoadCode()
        {
            pic_PassCode.Image = _login.GetPassCode();
            for (int i = 0; i < pic_PassCode.Controls.Count; i++)
            {
                pic_PassCode.Controls.RemoveAt(i);
            }
        }
    }
}
