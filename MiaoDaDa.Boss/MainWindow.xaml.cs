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
using WangDaMiao.Requset;

namespace MiaoDaDa.Boss
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Users _user = null;
        public MainWindow()
        {
            InitializeComponent();
            Bindings();
        }

        private void Bindings()
        {
            this.txt_userName.Text = Methods.GetSettingString("userName");
            this.txt_Pwd.Password = Methods.GetSettingString("password");
        }

        //登陆功能
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            _user = new Users();
            _user.UserName = this.txt_userName.Text.ToString();
            _user.UserPwd = this.txt_Pwd.Password.ToString();
            _user.Code = this.txt_yzm.Text.ToString();
            if (true)
            {
                Methods.UpdateSettingString("userName", _user.UserName);
                Methods.UpdateSettingString("password", _user.UserPwd);
                Home home = new Home();
                home.Show();
                this.Close();
            }
        }

        //获取验证码
        private void btn_gain_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
