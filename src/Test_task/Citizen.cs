using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    class Citizen
    {
        /*
         * О|Иванов|Александр|Петрович|01.01.1950|Адрес|
Л|Участник ВОВ|01.01.2000|01.01.2010|
М|1|2009|100.45|
М|1|2009|100.45|
М|1|2009|100.45|
М|1|2009|100.45|
         * */
        public List<string> HumanCitizen = new List<string>();
        public List<string> Category = new List<string>();
        public List<List<string>> Pay = new List<List<string>>();


    }
}
