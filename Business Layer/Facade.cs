using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
   public class Facade
    {
        private Facade() { }
        public static Facade instance = null;
        public static Facade get_Controller()
        {
            if (instance == null)
            {
                instance = new Facade();
            }
            return instance;
        }
        public string get_Data_into_Facade(string name, string age)
        {
            MyLogic ml = new MyLogic();
            return ml.get_Data_into_Mylogic(name, age);
        }
        public DataSet retrive_Pass(string a)
        {
            MyLogic ml = new MyLogic();
            return ml.retrive_Pass_Mylogic(a);

        }
    }
}
