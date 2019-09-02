using S7.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    public class PlcConnect
    {
        public bool sendData(float data, string target)
        {
            using (var plc = new Plc(CpuType.S71500, "192.168.0.1", 0, 1))
            {
                try
                {
                    plc.Open();
                    plc.Write(target, data);
                    return true;
                }
                catch (Exception exp) { throw exp; }
            }
        }

        public IEnumerator SendAsyncData(float data, string target)
        {
            using (var plc = new Plc(CpuType.S71500, "192.168.0.1", 0, 1))
            {
                try
                {
                    plc.Open();
                    plc.Write(target, data);
                }
                catch (Exception exp) { throw exp; }
            }
            yield return null;
        }
    }
}
