using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gatepass
{
    [Serializable]
    public class GatepassDetails
    {

        private string _date;
        public string Date
        {
            set { _date = value; }
            get { return _date; }
        }

        private string _jobNumber;
        public string JobNumber
        {
            set { _jobNumber = value; }
            get { return _jobNumber; }
        }

        private string _customerName;
        public string CustomerName
        {
            set { _customerName = value; }
            get { return _customerName; }
        }

        private string _customerAddress;
        public string CustomerAddress
        {
            set { _customerAddress = value; }
            get { return _customerAddress; }
        }

        private string _pONumber;
        public string PONumber
        {
            set { _pONumber = value; }
            get { return _pONumber; }
        }

        private string _design;
        public string Design
        {
            set { _design = value; }
            get { return _design; }
        }

        private string _quantity;
        public string Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        private string _a1;
        public string A1
        {
            set { _a1 = value; }
            get { return _a1; }
        }

        private string _b1;
        public string B1
        {
            set { _b1 = value; }
            get { return _b1; }
        }

        private string _item;
        public string Item
        {
            set { _item = value; }
            get { return _item; }
        }

        private string _printer;
        public string Printer
        {
            set { _printer = value; }
            get { return _printer; }
        }

        private string _part;
        public string Part
        {
            set { _part = value; }
            get { return _part; }
        }

        private string _itemCode;
        public string ItemCode
        {
            set { _itemCode = value; }
            get { return _itemCode; }
        }

        private string _salOrdNo;
        public string SalOrdNo
        {
            set { _salOrdNo = value; }
            get { return _salOrdNo; }
        }

        private bool _isPrint = false;
        public bool IsPrint
        {
            set { _isPrint = value; }
            get { return _isPrint; }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            set { _isSelected = value; }
            get { return _isSelected; }
        }
    }
}