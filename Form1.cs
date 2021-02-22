using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string no1,constfun;
       // public int no2;
        public bool inputstatus;
        
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            radioButton1.Checked = true;
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;

            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;

            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            } 
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;

            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;

            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button11.Text;

            }
            else
            {
                textBox1.Text = button11.Text;
                inputstatus = true;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button12.Text;

            }
            else
            {
                textBox1.Text = button12.Text;
                inputstatus = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button13.Text;

            }
            else
            {
                textBox1.Text = button13.Text;
                inputstatus = true;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button16.Text;

            }
            else
            {
                textBox1.Text = button16.Text;
                inputstatus = true;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button17.Text;

            }
            else
            {
                textBox1.Text = button17.Text;
                inputstatus = true;
            }

        }
        //when 9 is pressed
                private void button18_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button18.Text;

            }
            else
            {
                textBox1.Text = button18.Text;
                inputstatus = true;
            }

        }

        //. button
        private void button2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button2.Text;

            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }

        }

        //Add Operator 
        private void button3_Click(object sender, EventArgs e)
        {
              no1 = textBox1.Text;
              textBox1.Text = "";
              constfun = "+";

           
        }

        //subtract
        private void button9_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "-";
          
        }

        //multiply
        private void button10_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "*";
        }

        //divide
        private void button15_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "/";
           
    
        }

        //a user defined fun 
        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text=Convert.ToString( Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text));
                    
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));
                   
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinity";
                    }
                    else
                    {

                        textBox1.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(textBox1.Text));
                    }

                        break;
                

                             
                  
            }
        }


        //a user defined function to calculate factorial 
        private int  factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }

            return i;
        }


        //when = button is pressed
        private void button5_Click(object sender, EventArgs e)
        {
          
            funcal();
            inputstatus = false;
                 

        }

       
        //when AC is pressed to power on
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
          
        }


 
    

        //calculating squareroot
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;

        }


        

      
        //when CE button is pressed
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;

        }

   

        //sin function
        private void button24_Click(object sender, EventArgs e)
        {
        //if radian is selected

            if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
                //if degree is selected
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }


        //cos function
        private void button25_Click(object sender, EventArgs e)
        {
            //radian selected
           if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }

               //degree selected
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }


        //tan function
        private void button26_Click(object sender, EventArgs e)
        {
            
            //radian selected
               if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }

                   //degree selected
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
            

        }



       
        

     
        //backspace key is presseed
        private void button31_Click(object sender, EventArgs e)
        {
            no1= textBox1.Text;
            int n=no1.Length;
            textBox1.Text=(no1.Substring(0,n-1));

        }

        //when mod operator(%) is presseed
        private void button32_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "mod";

        }

        //coding for +/- key
        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
            inputstatus = false;

        }


        //Sin inverese fun
        private void button35_Click(object sender, EventArgs e)
        {
           if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }

        }

        //cos inverese fun
        private void button34_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //tan inverese fun
        private void button36_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {

                textBox1.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI)/180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

          
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       
        //coding for off button
        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "test";
            inputstatus = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }

        private void button4_Load(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
} 