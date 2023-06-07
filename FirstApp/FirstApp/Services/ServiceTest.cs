using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public class ServiceTest : IServiceTest
    {
        public DateTime GetDateTimeNow() => DateTime.Now;
    }
}
