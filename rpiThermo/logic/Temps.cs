using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace rpiThermo.logic
{
    public class Temps
    {
        public double GetTemp(int type)
        {
            switch (type)
            {
                case 1:
                    {
                        DirectoryInfo devicesDir = new DirectoryInfo("/sys/bus/w1/devices");
                        double temp = 0;
                        foreach (var deviceDir in devicesDir.EnumerateDirectories("28*"))
                        {
                            var w1slavetext =
                                deviceDir.GetFiles("w1_slave").FirstOrDefault().OpenText().ReadToEnd();
                            string temptext =
                                w1slavetext.Split(new string[] { "t=" }, StringSplitOptions.RemoveEmptyEntries)[1];

                            temp = double.Parse(temptext) / 1000;


                        }
                        return temp;
                    }
                case 2:
                    {
                        DirectoryInfo devicesDir = new DirectoryInfo("/sys/bus/w1/devices");
                        double temp = 0;
                        foreach (var deviceDir in devicesDir.EnumerateDirectories("28*"))
                        {
                            var w1slavetext =
                                deviceDir.GetFiles("w1_slave").FirstOrDefault().OpenText().ReadToEnd();
                            string temptext =
                                w1slavetext.Split(new string[] { "t=" }, StringSplitOptions.RemoveEmptyEntries)[1];

                            temp = double.Parse(temptext) / 1000;


                        }
                        temp = (temp * 1.8) + 32;
                        return temp;
                    }
                case 3:
                    {
                        return 75;
                    }
                default:
                    return 70;
            }
        }
    }
}
