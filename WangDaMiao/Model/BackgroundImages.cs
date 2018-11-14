using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangDaMiao.Model
{
    public class BackgroundImages
    {
        private string _logo;
        private string _word;
        private string _xml;
        private string _close;
        private string _technology;
        private string _backtopimg;
        private string _fingerpost;
        private string _backbelowimg;
        private string _question;
        private string _transition;
        private string _minimize;

        public string Logo { get => _logo; set => _logo = value; }
        public string Xml { get => _xml; set => _xml = value; }
        public string Word { get => _word; set => _word = value; }
        public string Close { get => _close; set => _close = value; }
        public string Technology { get => _technology; set => _technology = value; }
        public string Backtopimg { get => _backtopimg; set => _backtopimg = value; }
        public string Fingerpost { get => _fingerpost; set => _fingerpost = value; }
        public string Backbelowimg { get => _backbelowimg; set => _backbelowimg = value; }
        public string Question { get => _question; set => _question = value; }
        public string Transition { get => _transition; set => _transition = value; }
        public string Minimize { get => _minimize; set => _minimize = value; }

        public BackgroundImages()
        {
            Logo = "/img/logo.png";
            Xml = "/img/XML文件.png";
            Word = "/img/world.png";
            Close = "/img/关闭.png";
            Technology = "/img/技术支持.png";
            Backtopimg = "/img/上-背景.png";
            Fingerpost = "/img/使用指南.png";
            Backbelowimg = "/img/下-形状.png";
            Question = "/img/选题题库.png";
            Transition = "/img/转换.png";
            Minimize = "/img/最小化.png";
        }
    }
}
