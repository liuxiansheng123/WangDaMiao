using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangDaMiao.Model;

namespace MiaoDaDa.Boss.ViewModel
{
    public class TurnModel
    {
        private BackgroundImages _backgroundImages = new BackgroundImages();

        public string Logos
        {
            get { return _backgroundImages.Logo; }
        }
        public string Xmls
        {
            get { return _backgroundImages.Xml; }
        }
        /// <summary>
        /// word
        /// </summary>
        public string Words
        {
            get { return _backgroundImages.Word; }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        public string Closes { get => _backgroundImages.Close; }
        public string Technologys { get => _backgroundImages.Technology; }
        public string Backtopimgs { get => _backgroundImages.Backtopimg; }
        public string Fingerposts { get => _backgroundImages.Fingerpost; }
        public string Backbelowimgs { get => _backgroundImages.Backbelowimg; }
        public string Questions { get => _backgroundImages.Question; }
        public string Transitions { get => _backgroundImages.Transition; }
        public string Minimizes { get => _backgroundImages.Minimize; }

    }
}
