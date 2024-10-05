using project_6_math_quize.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6_math_quize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          Random random = new Random();

        enum enlevel { easy,hard,med,mix };
        enum enoperations { add,sub,mul,div,mixe};

        //struct stgameinfo
        //{
        //  // public stround [] roundinfo;
        //   public List<stround> roundinfo;
        //    //public   byte numberofwin;
        //    //public   byte numberoftimestheloss;
       
   
        //}
        struct stround
        {
            public  short number1;
            public short number2;
            public char operationtype; 
            public int trueresult;
            public int playerresult;
    

        }
     

          enlevel level =enlevel.easy;
          enoperations operation=enoperations.mixe;

          int numberofguestions=3;
          int numberofwin=0;
          int numberoftimestheloss=0;

          stround eround;


        int calculateresult(short number1, short number2,enoperations temp)
        {
            
            switch (temp)
            {

                case enoperations.add:

                    return number1 + number2;
                    break;

                case enoperations.sub:

                    return number1 - number2;
                    break;

                case enoperations.mul:

                    return number1 * number2;
                    break;
                case enoperations.div:

                    return number1 / number2;
                    break;

            }

            return number1;
        }

        stround generatround()
        {
        
            switch (level)
            {
                case  enlevel.easy:
                    eround.number1 = (short)random.Next(1, 10);
                  eround.number2 = (short)random.Next(1, 10);
                    break;
                case enlevel.med:
                    eround.number1 = (short)random.Next(10, 50);
                    eround.number2 = (short)random.Next(10, 50);
                    break;
                case enlevel.hard:
                    eround.number1 = (short)random.Next(50, 100);
                    eround.number2 = (short)random.Next(50, 100);
                    break;
                case enlevel.mix:
                    eround.number1 = (short)random.Next(1, 100);
                    eround.number2 = (short)random.Next(1, 100);
                    break;

            }


            enoperations temp = operation;
            if (temp == enoperations.mixe)
            {
                temp = (enoperations)random.Next(1, 4);
            }

            switch (temp)
            {

                case enoperations.add:

                    eround.operationtype = '+';
                    break;

                case enoperations.sub:
          
                    eround.operationtype = '-';
                    break;

                case enoperations.mul:
              
                    eround.operationtype = '*';
                    break;

                case enoperations.div:

                    eround.operationtype = '/';
                    break;


            }

          
         //  operation = temp;

            eround.trueresult = calculateresult(eround.number1, eround.number2,temp);

         
           //temp = enoperations.mixe;
            return eround;
        }

        enlevel choselevel()
        {

            if (rdbeasy.Checked)
            {
                level = enlevel.easy;
            }
            if(rdbHard.Checked)
            {
                level = enlevel.hard;
            }    
            if(rdbmed.Checked)
            {
                level = enlevel.med;
            }

            if(rdbmix.Checked)
            {
                level = enlevel.mix;
            }

            return level;

        }

        enoperations choseoperation()
        {

            if (rdbadd.Checked)
            {
                operation = enoperations.add;
            }
            if (rdbsub.Checked)
            {
                operation = enoperations.sub;
            }
            if (rdbmul.Checked)
            {
                operation = enoperations.mul;
            }
            if (rdbmixe.Checked)
            {
                operation = enoperations.mixe;
            }
            if (rdbdiv.Checked)
            {
                operation = enoperations.div;
            }
            return operation;
        }

        void chosenumberofquestions()
        {
            numberofguestions = Convert.ToInt16(textBox1.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void showquestion()
        {
            lbnumber1.Text = eround.number1.ToString();
            lbnumber2.Text = eround.number2.ToString();
            lboperation.Text = eround.operationtype.ToString();
            txtinputresult.Text = "";
        }

        bool checkeresult()
        {


                eround.playerresult = 0;

            if(txtinputresult.Text!="")
            { 
                eround.playerresult =Convert.ToInt32(txtinputresult.Text);
            }


            if(eround.playerresult==eround.trueresult)
            {
                if (MessageBox.Show("CORRECT ANSWER", "CORRECT ANSWER"
            , MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                   numberofwin++;
            
                          startgame();
                    
                }
             
                return true;
            }
            else
            {
                if( MessageBox.Show("WRONG ANSWER", "WRONG ANSWER"
                , MessageBoxButtons.OK, MessageBoxIcon.Hand)==DialogResult.OK)
                {
                       numberoftimestheloss++;
                        startgame();
                    
                }
            
                return false;
            }


        }

        bool finalresult()
        {
            lbnumber1.ForeColor = Color.Red;


            lboperation.Text =  numberofwin.ToString();
            lbnumber2.Text = numberoftimestheloss.ToString();
            label5.Text = "CORRECT ANSWERS : ";

            label6.Text = "WRONG ANSWERS   : ";

            MessageBox.Show("GAME OVER", "GAME OVER"
              , MessageBoxButtons.OK, MessageBoxIcon.Hand);

            if (numberofwin==numberoftimestheloss)
            {
                lbnumber1.Text = "DROW";
                label8.Text = "";
                return false;
            }

            if(numberofwin>numberoftimestheloss)
            {
                lbnumber1.Text = "YOU WON";
                label8.Text = "";
                return true;
            }

            if(numberofwin<numberoftimestheloss)
            {
                lbnumber1.Text = "YOU LOST";
        
                label8.Text = "";
                return false;
            }


               

            return true;
        }


        void  startgame()
        {
            if (numberofguestions == 0)
            {
                finalresult();
                return;
            }

            numberofguestions--;
 
            generatround();
            showquestion();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure of your options?", "Confirmation of options"
                 , MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                chosenumberofquestions();
                choselevel();
                choseoperation();
                startgame();
                
                numberofwin = 0;
                numberoftimestheloss = 0;
                label5.Text = "";
                label6.Text = "";
                lbnumber1.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkeresult();
        }











}
}
