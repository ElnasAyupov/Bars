using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Электроника
{
    static public class AMR
    {
        static public int selectedmode = 0;
        static public int addri = 0;
        static public string mem;
        static public int i, regchecker=0;
        static public string a;
        static public void modesops(int value)
        {
            switch (selectedmode)
            {
                case 0:
                    break;
                case 1:
                    {
                        if (addri == 0)
                        {
                            addri = 4;
                            Basic.curraddrstr = "0000";
                        }  
                        if (addri > 0)
                        {
                            for(i=addri;4-i>0;i++)
                            {
                                a = Convert.ToString(Basic.curraddrstr[i]);
                                Basic.curraddrstr=Basic.curraddrstr.Remove(i-1, 1).Insert(i-1, a);
                            }
                            Basic.curraddrstr=Basic.curraddrstr.Remove(3, 1).Insert(3, Convert.ToString(value, 16).ToUpper());
                            addri--;
                        }
                        if (addri == 0)
                        {
                            Basic.curraddr = Convert.ToInt32((Convert.ToInt32(Basic.curraddrstr, 16)).ToString(), 10);
                        }
                        break;
                    }
                case 2:
                    {
                        
                        break;
                    }
                case 3:
                    {
                        if(regchecker==0)
                        { 
                        a = Convert.ToString(Basic.OpMemory[Basic.curraddr],16).ToUpper();
                            if (a.Length < 2)
                            {
                                a = "0" + a;
                            }
                            mem = a[1] + Convert.ToString(value, 16).ToUpper();
                        Basic.OpMemory[Basic.curraddr] = Convert.ToInt32(Convert.ToInt32(mem, 16).ToString(),10);
                        break;
                        }
                        else
                        {
                            a = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                            if (a.Length<2)
                            {
                                a = "0" + a;
                            }
                            mem = a[1] + Convert.ToString(value, 16).ToUpper();
                            Basic.Registers[Basic.currreg] = Convert.ToInt32(Convert.ToInt32(mem, 16).ToString(), 10);
                            break;
                        }
                    }
            }
        }
    }
}
