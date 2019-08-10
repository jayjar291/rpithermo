using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rpiThermo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        // GET: api/Temp
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Temp/5
        [HttpGet("{id}", Name = "Get")]
        public double Get(int id)
        {
            switch (id)
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

        // POST: api/Temp
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Temp/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
