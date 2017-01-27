﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    //ogolna klasa do obslugi danych
    class Data
    {
        protected string name;
        protected double value;
        protected double change;
        protected double changePercent;
        protected double opening;
        protected double max;
        protected double min;
        protected double moneyTurnover;
        protected string time;
        public Data(string name, List<double> listOfArguments, string time)
        {
            this.name = name;
            this.value = listOfArguments[0];
            this.change = listOfArguments[1];
            this.changePercent = listOfArguments[2];
            this.opening = listOfArguments[3];
            this.max = listOfArguments[4];
            this.min = listOfArguments[5];
            this.moneyTurnover = listOfArguments[6];
            this.time = time;
        }

        public string Name
        {
            get{ return name; }
        }       
        public double Value
        {
            get { return value; }
        }
        public double Change
        {
            get { return change; }
        }
        public double ChangePercent
        {
            get { return changePercent; }
        }
        public double Opening
        {
            get { return opening; }
        }
        public double Max
        {
            get { return max; }
        }
        public double Min
        {
            get { return min; }
        }
        public double MoneyTurnover
        {
            get { return moneyTurnover; }
        }
        public string Time
        {
            get { return time; }
        }
    }
}
