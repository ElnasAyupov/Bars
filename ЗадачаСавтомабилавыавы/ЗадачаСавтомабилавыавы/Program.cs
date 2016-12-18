using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ЗадачаСавтомабилавыавы
{
    static class Display
    {
        public static void Show(string Value, int Priority)
        {
            Console.WriteLine("\n");
            for(int i = 0; i<Priority*10;i++)
            {
               Value = Value.Insert(0, "");
            }
            Console.WriteLine(Value);
        }
    }
    class Transport
    {
        private string sTransportType;
        private string sBrand;
        private string sModel;
        public string getType()
        {
            return (sTransportType);
        }
        public string getBrand()
        {
            return (sBrand);
        }
        public string getModel()
        {
            return (sModel);
        }
        public void setType(string sCurType)
        {
            sTransportType = sCurType;
        }
        public void setBrand(string sCurBrand)
        {
            sBrand = sCurBrand;
        }
        public void setModel(string sCurModel)
        {
            sModel = sCurModel;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            Console.WriteLine("Введите полный адрес файла в формате C:\\Users\\имяфайла.txt");
            string sAddress = Console.ReadLine();
            string[] smLines = File.ReadAllLines(sAddress);
            int iLinesCount = smLines.Count();
            Transport[] stReplicTrans = new Transport[iLinesCount];
            string[] sValues = new string[3];
            for (i=0;i<iLinesCount;i++)
            {
                sValues = smLines[i].Split(' ');
                stReplicTrans[i] = new Transport();
                stReplicTrans[i].setType(sValues[0]);
                stReplicTrans[i].setBrand(sValues[1]);
                stReplicTrans[i].setModel(sValues[2]);
            }
            string sCurrentType="";
            string sCurrentBrand="";
            int iCounter=0;
            while (iCounter!=iLinesCount)
            {
                for(i = 0; i < iLinesCount; i++)
                {
                    if (sCurrentType != stReplicTrans[i].getType())
                    {
                        sCurrentType = stReplicTrans[i].getType();
                        Display.Show(sCurrentType,0);
                        break;
                    }
                }
                for (i = 0; i < iLinesCount; i++)
                {
                    if (sCurrentType == stReplicTrans[i].getType())
                    {
                        if (sCurrentBrand != stReplicTrans[i].getBrand())
                        {
                            sCurrentBrand = stReplicTrans[i].getBrand();
                            Display.Show(sCurrentType, 1);
                            break;
                        }
                    }
                }
                for (i=0;i<iLinesCount;i++)
                {
                    if (sCurrentType == stReplicTrans[i].getType())
                    {
                        if (sCurrentBrand == stReplicTrans[i].getBrand())
                        {
                            Display.Show(stReplicTrans[i].getModel(), 2);
                            iCounter++;
                        }
                    }
                }
                        }
            Console.ReadLine();
        }
                }
            }
