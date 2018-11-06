using MyWfpDome.Model;
using Prism.Commands;
using Prism.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyWfpDome.ViewModel
{
    public class StudentViewModel
    {
        public ICommand ButtonCommand
        {
            get
            {
                return new DelegateCommand<string>((str) =>
                {
                    ConvertText(str);
                });
            }
        }

        private void ConvertText(string str)
        {
            MessageBox.Show(str);
        }
    }
}
