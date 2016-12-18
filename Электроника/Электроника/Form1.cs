using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Электроника
{
    public partial class Form1 : Form
    {
        int a,i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AMR.modesops(0);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AMR.modesops(2);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AMR.modesops(3);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AMR.modesops(5);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AMR.modesops(6);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AMR.modesops(7);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AMR.modesops(8);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "H-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[5], 16).ToUpper();
                        Basic.currreg = 5;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AMR.modesops(9);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "L-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[6], 16).ToUpper();
                        Basic.currreg = 6;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    { 
                    if (AMR.regchecker == 0)
                    {
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                    }
                    else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                    break;
                    }
            }
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            AMR.modesops(10);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "A-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[0], 16).ToUpper();
                        Basic.currreg = 0;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            AMR.modesops(11);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "B-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[1], 16).ToUpper();
                        Basic.currreg = 1;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            AMR.modesops(12);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "C-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[2], 16).ToUpper();
                        Basic.currreg = 2;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            AMR.modesops(13);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "D-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[3], 16).ToUpper();
                        Basic.currreg = 3;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            AMR.modesops(14);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "E-";
                        textBoxMEM.Text = Convert.ToString(Basic.Registers[4], 16).ToUpper();
                        Basic.currreg = 4;
                        AMR.selectedmode = 3;
                        AMR.regchecker = 1;
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            AMR.modesops(15);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr],16).ToUpper();
                        AMR.regchecker = 1;
                        break;
                    }
                case 2:
                    {
                        textBoxREG.Text = "F-";
                        // textBoxMEM.Text = 
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AMR.modesops(4);
            switch (AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr]);
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AMR.modesops(1);
            switch(AMR.selectedmode)
            {
                case 1:
                    {
                        textBoxADDR.Text = Basic.curraddrstr;
                        textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr]);
                        break;
                    }
                case 3:
                    {
                        if (AMR.regchecker == 0)
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
                        }
                        else
                        {
                            textBoxMEM.Text = Convert.ToString(Basic.Registers[Basic.currreg], 16).ToUpper();
                        }
                        break;
                    }
            }
        }

        private void REG_Click(object sender, EventArgs e)
        {
            AMR.selectedmode = 2;
            textBoxMEM.Text = "";
            textBoxADDR.Text = Convert.ToString(Basic.curraddr, 16).ToUpper();
            AMR.regchecker = 0;
            AMR.addri = 0;
        }

        private void MEM_Click(object sender, EventArgs e)
        {
            if ((AMR.addri != 0)||(Basic.curraddr < 32768)||(Basic.curraddr> 34815))
            {
                MessageBox.Show("Попытка записи в недоступный сегмент ОЗУ");
            }
            else
            {
                textBoxREG.Text = "";
                AMR.selectedmode = 3;
                AMR.regchecker = 0;
            }
        }
        private void ADDR_Click(object sender, EventArgs e)
        {
            textBoxREG.Text = "";
            AMR.selectedmode = 1;
            AMR.regchecker = 0;
            AMR.addri = 0;
            textBoxADDR.Text = Convert.ToString(Basic.curraddr, 16).ToUpper();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            Basic.curraddr++;
            AMR.addri = 0;
            textBoxADDR.Text = Convert.ToString(Basic.curraddr,16).ToUpper();
            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr],16).ToUpper();
            AMR.regchecker = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxADDR.Text = Basic.curraddrstr;
        }

        private void RUN_Click(object sender, EventArgs e)
        {
            while (Basic.OpMemory[Basic.curraddr]!=0)
            {
                a = Functions.Calculate(Basic.OpMemory[Basic.curraddr]);
                for (i = 0; i <= a; i++)
                    Basic.curraddr++;
                if (Basic.Stats[0] == 1)
                    pictureBoxCY.Image = Электроника.Properties.Resources._true;
                else
                    pictureBoxCY.Image = Электроника.Properties.Resources._false;
                if (Basic.Stats[1] == 1)
                    pictureBoxZ.Image = Электроника.Properties.Resources._true;
                else
                    pictureBoxZ.Image = Электроника.Properties.Resources._false;
            }
            textBoxADDR.Text = Convert.ToString(Basic.curraddr, 16).ToUpper();
            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void STEP_Click(object sender, EventArgs e)
        {
            Basic.statstonull();
            a = Functions.Calculate(Basic.OpMemory[Basic.curraddr]);
            for (i = 0; i <= a; i++)
                Basic.curraddr++;
            textBoxADDR.Text = Convert.ToString(Basic.curraddr, 16).ToUpper();
            textBoxMEM.Text = Convert.ToString(Basic.OpMemory[Basic.curraddr], 16).ToUpper();
            if (Basic.Stats[0] == 1)
                pictureBoxCY.Image = Электроника.Properties.Resources._true;
            else
                pictureBoxCY.Image = Электроника.Properties.Resources._false;
            if (Basic.Stats[1] == 1)
                pictureBoxZ.Image = Электроника.Properties.Resources._true;
            else
                pictureBoxZ.Image = Электроника.Properties.Resources._false;
        }
    }
}
