namespace IAmMap.Models
{
    public class MailFolder
    {
        private readonly string _Name;
        private readonly string _Path;
        private bool _HasChildren;
        private bool _Marked;

        public MailFolder(string path, string name)
        {
            _Name = name;
            _Path = path;
        }

        public string Name
        {
            get { return _Name; }
        }

        public string Path
        {
            get { return _Path; }
        }

        public bool Marked
        {
            get { return _Marked; }
        }

        public bool HasChildren
        {
            get { return _HasChildren; }
        }
    }
}