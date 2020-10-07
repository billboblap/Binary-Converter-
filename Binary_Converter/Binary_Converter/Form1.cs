using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Converter
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string HexLetter(int denaryValue)
        {
            string Letter = "";
            //switch statement
            //faster than an if satement (yandere-dev didnt do this..)
            switch (denaryValue)
            {
                case 10:
                    Letter = "A";
                    break;
                case 11:
                    Letter = "B";
                    break;
                case 12:
                    Letter = "C";
                    break;
                case 13:
                    Letter = "D";
                    break;
                case 14:
                    Letter = "E";
                    break;
                case 15:
                    Letter = "F";
                    break;
                default:
                    Letter = "Z";
                    break;

            }
            //returns hex exivelant based on deanry value 
            return Letter;
        }


        private string ToHex(int denaryValue)
        {

            string HexValue = "";

            for (int i = 0; i < 2; i++) //8 bits so must repeat 8 times eg 8++  CAN ONLY USE I J AND K EXCEPT FOR MOUS POS - X, Y
            {
                if ((denaryValue % 16) > 9)
                {
                    HexValue = HexLetter(denaryValue % 16) + HexValue;
                    
                }

                else
                {
                    HexValue = Convert.ToString(denaryValue % 16) + HexValue;                  
                }

                //denary is modded by 2 converted to string then added to binary value
                denaryValue /= 16;



            }

            return HexValue;


        }


        private string to_oct(int denaryValue)
        {
            int progressvalue = 0;
            string octvalue = "";

            for (int i = 0; i < 3; i++) //8 bits so must repeat 8 times eg 8++  CAN ONLY USE I J AND K EXCEPT FOR MOUS POS - X, Y
            {
                octvalue = Convert.ToString(denaryValue % 8) + octvalue;
                //denary is modded by 2 converted to string then added to binary value
                denaryValue /= 8;
                progressvalue = progressvalue + 10;
                progressBar1.Value = progressvalue;
            }

            return octvalue;
        }


        private string to_binary(int denaryValue)
        {
            int progressvalue = 0;
            string binaryValue = "";

            for (int i = 0; i < 8; i++) //8 bits so must repeat 8 times eg 8++  CAN ONLY USE I J AND K EXCEPT FOR MOUS POS - X, Y
            {   
                binaryValue = Convert.ToString(denaryValue % 2) + binaryValue;
                //denary is modded by 2 converted to string then added to binary value
                denaryValue /= 2;
                progressvalue = progressvalue + 10;
                progressBar1.Value = progressvalue;
            }

            return binaryValue;
        }
       

        private void Btn2Binary_Click(object sender, EventArgs e)
        {
            int denaryValue = 0; //holds value for the denary value / just declaring the variable
            string binaryValue = ""; //holds value for the binary value / just declaring the variable   
            int maxvalue = 255;
            //denaryValue = Convert.ToInt16(TxtDenary.Text);
            //read in text box value convert it to an integer and store
            try
            {
                denaryValue = int.Parse(TxtDenary.Text);//attempt the following code
                //if dv >= 0 (and) dv <= 255: do(something) 
                //VALIDATION    
                if (denaryValue <= 0 | denaryValue > maxvalue)
                {
                    TxtDenary.Clear();
                    TxtBinary.Clear();
                    Octaltxt.Clear();
                    MessageBox.Show("ERROR: ('GREATER-THAN-EXPECTED-PLEASE-TRY-<255')");
                }
            }
            catch //run if try failed
            {
                TxtDenary.Clear();
                TxtBinary.Clear();
                Octaltxt.Clear();
                MessageBox.Show("ERROR: ('INTEGERS-ONLY')");               

                return; //exit the function
            }

            txt_Hex.Text = ToHex(denaryValue);  
            
            to_binary(denaryValue);

            TxtBinary.Text = to_binary(denaryValue);

            Octaltxt.Text = to_oct(denaryValue);


        }

        private void Label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn2Denary_Click(object sender, EventArgs e)
        {
            //ERROR: ('')
            int progressvalue = 0;
            int denaryValue = 0; //holds value for the denary value / just declaring the variable
            int multiplier = 128;
            string binaryValue = ""; //holds value for the binary value / just declaring the variable
            char binary_digit;
            int character_value = 0;
            binaryValue = TxtBinary.Text;
            if (binaryValue.Length > 8)
           
            {
                MessageBox.Show("ERROR: ('OUT-OF-RANGE')");
                progressvalue = 0;
            }

            if (binaryValue.Length <= 0)
            {
                MessageBox.Show("ERROR: ('OUT-OF-RANGE')");
                progressvalue = 0;
                return;
            }
            for (int i = 0; i < 8; i++) //starts the for loop (loops it 8 times (8bits))
            {
                binary_digit = binaryValue[i]; //creates an arry and adds the loop to the array
                try
                {
                    character_value = int.Parse(binary_digit.ToString());//charactervalue is set to a string (so we dont get 48)
                }
                catch
                {
                    TxtDenary.Clear();
                    TxtBinary.Clear();
                    Octaltxt.Clear();
                    MessageBox.Show("ERROR: ('ENTER-A-CORRECT-BINARY-DIGIT')");
                }
                denaryValue += character_value * multiplier;//multiples i by the multipler and then adds to the current value of denary value
                multiplier /= 2;//divdes by 2 to get to the next value
                progressvalue = progressvalue + 10;
                progressBar1.Value = progressvalue;


            }
            TxtDenary.Text = denaryValue.ToString();//puts the value in the text box 
            Octaltxt.Text = to_oct(denaryValue);
            txt_Hex.Text = ToHex(denaryValue);
            //progressBar1.Value = 0;
            //encapsulation

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TxtDenary.Clear();
            TxtBinary.Clear();
            Octaltxt.Clear();
            txt_Hex.Clear();
            progressBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Usless.Text = trackBar1.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            while (true)
            {
                MessageBox.Show("MESSAGE('CANT-GET-RID')");
            }

        }
    }
}












































//shut up cracker