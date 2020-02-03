using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sorting_aldorithym
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int[] MitArray;







   

        Random randomnumber = new Random();


        private void btnOne_Click(object sender, EventArgs e)
        {
            /*int Min = 1;
            int Max = 9;
            */
            
            int temp;

           


            int n = int.Parse(txtBox1.Text);
            MitArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                MitArray[i] = randomnumber.Next(1, generate);
            }
            

            


            /*for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomnumber.Next(Min, Max);
            }
            */



            /*foreach (int n in array)
            {
                randomnumber.Next(Min, Max);
            }



            //int[] array = new int[randomNumber];
            n = int.Parse(txtBox1.Text);
                 
            //int num = random.Next(1, 9);
            

            int[] array = new int[n];

            /*
            Array.Resize(ref array, array.Length + 1);
            array[array.GetUpperBound(0)] = num;
            */


           /* for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[j] > array[i + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                    }

                }

                
            }

            foreach (int item in array)
            {
                lstBox.Items.Add(item);

            }*/





       



        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberGenerator_Click(object sender, EventArgs e)
        {
            int generate = int.Parse(txtBox2.Text);
            int rnd = randomnumber.Next(1, generate);
        }
    }
}
