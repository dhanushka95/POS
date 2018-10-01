using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class ServerDetailsFile: ServerDetails
    {
        private string _Ip, _UserName, _password, _dataBase, _filePath;
        

       
       public ServerDetailsFile()
        {
            
        }

        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string dataBase
        {
            get { return _dataBase; }
            set { _dataBase = value; }
        }
        public string filePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }


        public void Read()
        {
            //All line read in text file
            var lines = File.ReadAllLines(_filePath);
            this._Ip = convertBinaryToString(lines[0]);
            this._UserName = convertBinaryToString(lines[1]);
            this._password = convertBinaryToString(lines[2]);
            this._dataBase = convertBinaryToString(lines[3]);
        }
        public bool Write()
        { //All write data line by line in text file
            try {
                using (StreamWriter sw = new StreamWriter(_filePath)) {
                    sw.WriteLine(convertStringToBinary(this._Ip));
                    sw.WriteLine(convertStringToBinary(this._UserName));
                    sw.WriteLine(convertStringToBinary(this._password));
                    sw.WriteLine(convertStringToBinary(this._dataBase));
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
          
        }

        private string convertStringToBinary(string _string)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in _string.ToCharArray())
            {
                sb.Append(Convert.ToString(c,2).PadLeft(8,'0'));

            }
            return sb.ToString();
        }

        private string convertBinaryToString(string _string)
        {

            List<Byte> byteList = new List<byte>();
            for (int i=0;i<_string.Length;i+=8)
            {

                byteList.Add(Convert.ToByte(_string.Substring(i,8),2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

    }
}
