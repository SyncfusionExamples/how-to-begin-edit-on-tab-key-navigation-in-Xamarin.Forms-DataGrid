﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        public OrderInfo()
        {

        }

        #region private variables

        private int _employeeID;
        private string _customerID;
        private string _firstname;
        private string _lastname;
        private string _gender;
        private string _shipCity;
        private string _shipCountry;
        private double _freight;
        private DateTime? _shippingDate;
        private bool _isClosed;
        private DateTime? _minimum_date;
        private DateTime? _maximum_date;

        #endregion

        #region Public Properties

        private int _orderID;
        public int Number
        {
            get
            {
                return _orderID;
            }
            set
            {
                this._orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }


        //public int EmployeeID
        //{
        //    get
        //    {
        //        return _employeeID;
        //    }
        //    set
        //    {
        //        this._employeeID = value;
        //        RaisePropertyChanged("EmployeeID");
        //    }
        //}

        //public string CustomerID
        //{
        //    get
        //    {
        //        return _customerID;
        //    }
        //    set
        //    {
        //        this._customerID = value;
        //        RaisePropertyChanged("CustomerID");
        //    }
        //}
        private string foreGroundColor;
        public string ForeGroundColor
        {
            get
            {
                return foreGroundColor;
            }
            set
            {
                foreGroundColor = value;
                RaisePropertyChanged("ForeGroundColor");
            }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                this._firstname = value;
                RaisePropertyChanged("FirstName");
            }
        }

        //public string LastName
        //{
        //    get
        //    {
        //        return _lastname;
        //    }
        //    set
        //    {
        //        this._lastname = value;
        //        RaisePropertyChanged("LastName");
        //    }
        //}

        //public string Gender
        //{
        //    get
        //    {
        //        return _gender;
        //    }
        //    set
        //    {
        //        this._gender = value;
        //        RaisePropertyChanged("Gender");
        //    }
        //}

        //public string ShipCity
        //{
        //    get
        //    {
        //        return _shipCity;
        //    }
        //    set
        //    {
        //        this._shipCity = value;
        //        RaisePropertyChanged("ShipCity");
        //    }
        //}

        //public string ShipCountry
        //{
        //    get
        //    {
        //        return _shipCountry;
        //    }
        //    set
        //    {
        //        this._shipCountry = value;
        //        RaisePropertyChanged("ShipCountry");
        //    }
        //}

        //public double Freight
        //{
        //    get
        //    {
        //        return _freight;
        //    }
        //    set
        //    {
        //        this._freight = value;
        //        RaisePropertyChanged("Freight");
        //    }
        //}


        //private bool enabled;

        //public bool Enabled
        //{
        //    get
        //    {
        //        return enabled;
        //    }
        //    set
        //    {
        //        enabled = value;
        //        RaisePropertyChanged("Enabled");
        //    }
        //}


        //public bool IsClosed
        //{
        //    get
        //    {
        //        return _isClosed;
        //    }
        //    set
        //    {
        //        this._isClosed = value;
        //        RaisePropertyChanged("IsClosed");
        //    }
        //}

        public DateTime? End
        {
            get
            {
                return _shippingDate;
            }
            set
            {
                this._shippingDate = value;
                RaisePropertyChanged("End");
            }
        }

        public DateTime? Minimumdate
        {
            get
            {
                return _minimum_date;
            }
            set
            {
                this._minimum_date = value;
                RaisePropertyChanged("Minimumdate");
            }
        }

        public DateTime? Maximumdate
        {
            get
            {
                return _maximum_date;
            }
            set
            {
                this._maximum_date = value;
                RaisePropertyChanged("Maximumdate");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        #endregion
    }
}
