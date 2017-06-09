using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    class Citizens
    {
        public Citizen currentCitizen = null;

        public List<Citizen> citizens = new List<Citizen>();

        public void Load(string filePath)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {

                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] buf = line.Split('|');

                    string firstSymbol = buf[0];
                    switch (firstSymbol)
                    {
                        case "О":
                            {
                                AddHumanCitizen(buf);
                            }
                            break;
                        case "Л":
                            {
                                AddCategory(buf);
                            }
                            break;
                        case "М":
                            {
                                AddPay(buf); 
                            }
                            break;

                        default:
                            break;
                    }

                }
                sr.Close();
            }

            Console.ReadLine();
        }
        public void AddHumanCitizen(string[] citizenInfo)
        {
            // fisrt input
            if (currentCitizen != null)
            {
                citizens.Add(currentCitizen);
            }
            currentCitizen = new Citizen();// создали нового человека
            for (int i = 1; i < citizenInfo.Length; i++) //  нулевой символ О 
            {
                currentCitizen.HumanCitizen.Add(citizenInfo[i]);

            }


        }
        public void AddCategory(string[] categoryInfo)
        {
            for (int i = 1; i < categoryInfo.Length; i++) //  нулевой символ О 
            {
                currentCitizen.Category.Add(categoryInfo[i]);

            }

        }
        public void AddPay(string[] payInfo)
        {
            List<string> pay = new List<string>();
            for (int i = 1; i < payInfo.Length; i++) //  нулевой символ О 
            {
                pay.Add(payInfo[i]);
            }
            currentCitizen.Pay.Add(pay);

        }
    }

}
