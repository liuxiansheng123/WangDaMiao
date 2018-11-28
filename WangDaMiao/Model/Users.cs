using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangDaMiao.Requset
{
    public class Users
    {
        private string _userName;
        private string _userPwd;
        private string _cookie;
        private string _code;

        public string UserName { get => _userName; set => _userName = value; }
        public string UserPwd { get => _userPwd; set => _userPwd = value; }
        public string Cookie { get => _cookie; set => _cookie = value; }
        public string Code { get => _code; set => _code = value; }
    }
}
