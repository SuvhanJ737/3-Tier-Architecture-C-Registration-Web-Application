using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Layer;

namespace Business_Layer
{
    class MyLogic
    {
        public string get_Data_into_Mylogic(string name, string age)
        {
            Database sd = new Database();
            return sd.store_Data(name, age);
        }
        public DataSet retrive_Pass_Mylogic(string a)
        {
            Database ds = new Database();
            return ds.retrive_My_Data(a);
        }
    }
}
