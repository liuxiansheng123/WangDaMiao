using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WangDaMiao.Requset;

namespace MiaoDaDa.Boss.ViewModel
{
    public class ViewLoginModel: ObservableObject
    {
        private Users _user;

        public ICommand LoginCommand { get; set; }

        public ViewLoginModel()
        {
            _user = new Users();
            _user.UserName = Methods.GetSettingString("userName");
            _user.UserPwd = Methods.GetSettingString("password");
            LoginCommand = new DelegateCommand(ConvertText);
        }

        public string UserNames
        {
            get
            {
                return _user.UserName;
            }
            set
            {
                if (_user.UserName != value)
                {
                    _user.UserName = value;
                    RaisePropertyChangedEvent("UserNames");
                    RaisePropertyChangedEvent("IsLoginEnabled");
                }
            }
        }

        public string UserPwds
        {
            get
            {
                return _user.UserPwd;
            }
            set
            {
                if (_user.UserPwd != value)
                {
                    _user.UserPwd = value;
                    RaisePropertyChangedEvent("Password");
                    RaisePropertyChangedEvent("IsLoginEnabled");
                }
            }
        }

        public void ConvertText()
        {
            if (true)
            {
                Methods.UpdateSettingString("userName", _user.UserName);
                Methods.UpdateSettingString("password", _user.UserPwd);
                Console.Write(_user.UserName);
                //Home home = new Home();
                //home.Show();
                //this.Close();
            }
        }

        public bool IsLoginEnabled
        {
            get
            {
                if (UserNames == null || UserPwds == null)
                    return false;
                if (String.IsNullOrEmpty(UserNames.Trim()) || string.IsNullOrEmpty(UserPwds.Trim()))
                    return false;
                else
                    return true;

            }
        }
    }
}
