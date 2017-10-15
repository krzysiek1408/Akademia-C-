using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Akademia_C
{


    class Levels
    {
        public string strRecord1;
        public int nRecord1;
        public string strRecord2;
        public int nRecord2;
        public string strRecord3;
        public int nRecord3;
        public string strRecord4;
        public int nRecord4;
        public string strRecord5;
        public int nRecord5;

        public void Read()
        {
            using (StreamReader File = new StreamReader("BestScores.txt"))
            {
                string strTemp;
                strRecord1 = File.ReadLine();
                strTemp = File.ReadLine();
                nRecord1 = Convert.ToInt32(strTemp);
                strRecord2 = File.ReadLine();
                strTemp = File.ReadLine();
                nRecord2 = Convert.ToInt32(strTemp);
                strRecord3 = File.ReadLine();
                strTemp = File.ReadLine();
                nRecord3 = Convert.ToInt32(strTemp);
                strRecord4 = File.ReadLine();
                strTemp = File.ReadLine();
                nRecord4 = Convert.ToInt32(strTemp);
                strRecord5 = File.ReadLine();
                strTemp = File.ReadLine();
                nRecord5 = Convert.ToInt32(strTemp);
            };
        }

        public void Write()
        {
            //Console.WriteLine(line);
        }
    }
}
