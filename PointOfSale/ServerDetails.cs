using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    interface ServerDetails
    {
        void Read();
        string Ip
        {
            get;
            set;
        }
        string UserName
        {
            get;
            set;
        }
        string password
        {
            get;
            set;
        }
        string dataBase
        {
            get;
            set;
        }
        string filePath
        {
            get;
            set;
        }
        bool Write();
        
    }
}
