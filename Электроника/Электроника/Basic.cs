using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Электроника
{
    static public class Basic
    {
        static public int[] OpMemory = new int[34816];
        static public int curraddr=33280;
        static public int[] Registers = new int[7];
        static public string curraddrstr = Convert.ToString(curraddr, 16).ToUpper();
        static public int[] Stats = new int[5];
        static public int currreg;
        static Basic()
        {
            for (int i = 0; i < 34816; i++)
            {
                OpMemory[i] = 0;
            }
            for (int i = 0; i<7; i++)
            {
                Registers[i] = 0;
            }
        }
        static public void statstonull()
        {
            for (int i = 0; i < 5; i++)
            {
                Stats[i] = 0;
            }
        }
    }
   static public class Functions
    {
        static int statsworker;
        static int Statistic(int value)
        {
            if (value>256)
            {
                Basic.Stats[0] = 1;
                statsworker = value - 256;
            }
            else
            {
                Basic.Stats[0] = 0;
                statsworker = value;
            }         
            if (value==0)
            {
                Basic.Stats[1] = 1;
            }
            return (statsworker);
        }
        static public int Calculate(int funcode)
        {
            switch (funcode)
            {
                case 62:
                    Basic.Registers[0] = Basic.OpMemory[Basic.curraddr + 1];
                    return (1);
                case 14:
                    Basic.Registers[2] = Basic.OpMemory[Basic.curraddr + 1];
                    return (1);
                case 22:
                    Basic.Registers[3] = Basic.OpMemory[Basic.curraddr + 1];
                    return (1);
                case 129:
                    Basic.Registers[0] = Statistic(Basic.Registers[0] + Basic.Registers[2]);
                    return (0);
                case 130:
                    Basic.Registers[0] = Statistic(Basic.Registers[0] + Basic.Registers[3]);
                    return (0);
            }
            return (0);
        }
    }

}