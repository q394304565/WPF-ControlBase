﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using HeBianGu.Base.WpfBase;

namespace HeBianGu.Application.TouchWindow
{
    /// <summary> 说明</summary>
    internal class DataValueEntity : NotifyPropertyChanged
    {
        #region - 属性 -

        private string _value;
        /// <summary> 说明  </summary>
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaisePropertyChanged("Value");
            }
        }


        private bool _isBuzy = true;
        /// <summary> 说明  </summary>
        public bool IsBuzy
        {
            get { return _isBuzy; }
            set
            {
                _isBuzy = value;
                RaisePropertyChanged("IsBuzy");
            }
        }

        private string _range;
        /// <summary> 说明  </summary>
        public string Range
        {
            get { return _range; }
            set
            {
                _range = value;
                RaisePropertyChanged("Range");
            }
        }


        private string _name;
        /// <summary> 说明  </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        /// <summary> 测量完成设置值 </summary>
        public void SetValue(string value,string brush)
        {
            this.IsBuzy = false;

            this.Value = value;

            this.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(brush));
        }


        private Brush _foreground;
        /// <summary> 前景色  </summary>
        public Brush Foreground
        {
            get { return _foreground; }
            set
            {
                _foreground = value;
                RaisePropertyChanged("Foreground");
            }
        }

        /// <summary> 验证是否可用 </summary>
        public bool IsAvailable()
        {
            return !string.IsNullOrEmpty(this.Value) && this.IsBuzy == false;
        }

        #endregion

        #region - 命令 -

        #endregion

        #region - 方法 -

        protected override void RelayMethod(object obj)
        {
            string command = obj.ToString();

            //  Do：应用
            if (command == "Sumit")
            {


            }
            //  Do：取消
            else if (command == "Cancel")
            {


            }
        }

        #endregion
    }
}
