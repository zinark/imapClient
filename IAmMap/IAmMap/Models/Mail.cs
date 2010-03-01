using System;

namespace IAmMap.Models
{
    public class Mail
    {
        private string _Body;
        private DateTime _Date;
        private string _From;
        private string _Header;
        private string _To;
        private int _Uid;

        public int UID
        {
            get { return _Uid; }
            set { _Uid = value; }
        }

        public string Header
        {
            get { return _Header; }
            set { _Header = value; }
        }

        public string Body
        {
            get { return _Body; }
            set { _Body = value; }
        }

        public string From
        {
            get { return _From; }
            set { _From = value; }
        }

        public string To
        {
            get { return _To; }
            set { _To = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public override string ToString()
        {
            return _Uid + " " + _Body;
        }
    }
}