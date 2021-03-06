﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GraphX.Measure;
using GraphX.PCL.Common.Models;

namespace Graphs.Model
{
    [Serializable]
    public class DataEdge : EdgeBase<DataVertex>, INotifyPropertyChanged
    {
        public override Point[] RoutingPoints { get; set; }

        public DataEdge(DataVertex source, DataVertex target, double weight = 1)
            : base(source, target, weight)
        {
            Angle = 90;
        }

        public DataEdge()
            : base(null, null, 1)
        {
            Angle = 90;
        }

        public bool ArrowTarget { get; set; }

        public double Angle { get; set; }

        /// <summary>
        /// Node main description (header)
        /// </summary>
        private string _text;
        public string Text { get { return _text; } set { _text = value; OnPropertyChanged("Text"); } }
        public string ToolTipText { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
