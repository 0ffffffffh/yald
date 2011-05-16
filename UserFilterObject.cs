using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace yald
{
    [Serializable]
    public class UserFilterObject
    {
        private FilterList Filters;
        private string FilterName;
        private bool LinkWithAndState;

        public static bool SaveFilters(List<UserFilterObject> Filters, string Filename)
        {
            IFormatter BinFormat = new BinaryFormatter();
            Stream FileObj = null;

            try
            {
                FileObj = new FileStream(Filename, FileMode.Create, FileAccess.Write);
                BinFormat.Serialize(FileObj, Filters);
                FileObj.Close();
            }
            catch (Exception)
            { return false; }

            return true;
        }

        public static List<UserFilterObject> LoadFilters(string Filename)
        {
            IFormatter BinFormat = new BinaryFormatter();
            Stream FileObj = null;
            List<UserFilterObject> Filters;

            try
            {
                FileObj = new FileStream(Filename, FileMode.Open, FileAccess.Read);
                Filters = (List<UserFilterObject>)BinFormat.Deserialize(FileObj);
                FileObj.Close();
            }
            catch
            {
                return null;
            }

            return Filters;
        }

        public UserFilterObject()
        {
        }

        public UserFilterObject(FilterList List, string Name, bool LinkWithAnd)
        {
            Filters = List;
            FilterName = Name;
            LinkWithAndState = LinkWithAnd;
            Filters.LinkWithAnd = LinkWithAnd;
        }

        public FilterList FilterObject
        {
            get { return Filters; }
            set { Filters = value; }
        }

        public string Name
        {
            get { return FilterName; }
            set { FilterName = value; }
        }

        public override string ToString()
        {
            return FilterName;
        }
        
    }
}
