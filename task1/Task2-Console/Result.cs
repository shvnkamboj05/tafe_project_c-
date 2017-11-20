using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Windows.Forms.DataVisualization.Charting;



namespace Task2_Console
{
    public partial class Result : Form
    {
        private int numberOfItemsToUse = -1;
        private string selection = null;


        public Result()
        {
            InitializeComponent();
            
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        void SystemEvents_UserPreferenceChanged(object sender,UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel = comboBox1.SelectedItem.ToString();
            
            selection = sel;
        }

      

     
        private void Result_Load(object sender, EventArgs e)
        {
            // Add data to the List
            comboBox1.Items.Add("LinkedList");
            comboBox1.Items.Add("HashTable");
            comboBox1.Items.Add("BinarySearch");
        }
       private void selectbtn_Click(object sender, EventArgs e)
        {
            string var;
            var = comboBox1.Text;
            MessageBox.Show(var);
        }

        private void numOfItems_TextChanged(object sender, EventArgs e)
        {
            string str = numOfItems.Text;
            if (str != null && str.Length > 0)
            {
                int items = Convert.ToInt32(str);
                numberOfItemsToUse = items;
                //Console.WriteLine("Number of items entered - " + items);
            }
            
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            double totalTimeTaken = 0.0;
            if (numberOfItemsToUse == -1)
            {
                MessageBox.Show("Please enter number of items to add... ");
            }
            else
            {
                if (selection == null)
                {
                    MessageBox.Show("Please select an option from Combo Box first... ");
                }
                else if (selection.Equals("LinkedList"))
                {
                    totalTimeTaken = Utility.computeLinkedListAddAndSearchTime(numberOfItemsToUse);
                    DisplayStatsTextBox.Text = totalTimeTaken.ToString() + "ms";
                    chart1.Series["LinkedList"].Points.AddY(totalTimeTaken);
                    chart1.DataBind();
                }
                else if (selection.Equals("HashTable"))
                {
                    totalTimeTaken = Utility.computeHashTableAddAndSearchTime(numberOfItemsToUse);
                    textBoxHash.Text = totalTimeTaken.ToString() + "ms";
                    chart1.Series["HashTable"].Points.AddY(totalTimeTaken);
                    chart1.DataBind();
                }
                else if (selection.Equals("BinarySearch"))
                {
                    totalTimeTaken = Utility.computeBinaryTreeAddAndSearchTime(numberOfItemsToUse);
                    textBoxBinary.Text = totalTimeTaken.ToString() + "ms";
                    chart1.Series["BinaryTree"].Points.AddY(totalTimeTaken);
                    chart1.DataBind();
                }
                
                Console.WriteLine("Total time taken in to add {0} items in {1} is = {2}ms", numberOfItemsToUse, selection, totalTimeTaken);
            }
         }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 232, 232); 
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //chart1.Series["Linked List"].Points.AddXY("lis", 33);
        }


       
    }
}
