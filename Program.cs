using S7.Net;
using S7.Net.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7Example;





namespace S7Net
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var plc= new Plc(CpuType.S71500,"192.168.0.1",0,1))
                {
                     plc.Open();

                var sendLocation = new  SendLocation(); 

                
                
                //Plc Read Value Xp
                float Xp = sendLocation.xp;
                plc.Write("DB1.DBD26.0",Xp);

                //Plc Read Value Yp
                float Yp = sendLocation.yp;
                plc.Write("DB1.DBD30.0", Yp);

                //Plc Read Value Zp
                float Zp = sendLocation.zp;
                plc.Write("DB1.DBD34.0", Zp);

                //Plc Read Value Xr
                float Xr =sendLocation.xr;
                plc.Write("DB1.DBD38.0", Xr);

                //Plc Read Value Yr
                float Yr = sendLocation.yr;
                plc.Write("DB1.DBD42.0", Yr);

                //Plc Read Value Zr
                float Zr = sendLocation.zr;
                plc.Write("DB1.DBD46.0",Zr);


                /*
                //Plc Write Db Area 
                //Xp PositionVarible
                var db1DıntXp = (uint)plc.Read("DB1.DBD26.0");
                Console.WriteLine("DB1.DBD26.0" + db1DıntXp);

                //Yp PositionVarible
                var db1DıntYp = (uint)plc.Read("DB1.DBD30.0");
                Console.WriteLine("DB1.DBD30.0" + db1DıntYp);

                //Zp PositionVarible
                var db1DıntZp = (uint)plc.Read("DB1.DBD34.0");
                Console.WriteLine("DB1.DBD34.0" + db1DıntZp);

                //Xr RotationVarible
                var db1DıntXr = (uint)plc.Read("DB1.DBD38.0");
                Console.WriteLine("DB1.DBD38.0" + db1DıntXr);

                //Yr RotationVarible
                var db1DıntYr = (uint)plc.Read("DB1.DBD42.0");
                Console.WriteLine("DB1.DBD42.0" + db1DıntYr);

                //Zr RotationVarible
                var db1DıntZr = (uint)plc.Read("DB1.DBD46.0");
                Console.WriteLine("DB1.DBD46.0" + db1DıntZr);  */
            }
                Console.ReadKey();
        }
    }
}
