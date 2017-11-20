using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Task3
{
    public partial class graph : Form
    {
        private int numberOfItemsToUse = -1;
       // private string totalTimeTaken = null;
        private string selection = null;

        public graph()
        {
            InitializeComponent();
        }

        private void graph_Load(object sender, EventArgs e)
        {
            fillChat();
            comboBox1.Items.Add("LinkedList");
            comboBox1.Items.Add("BinarySearch");
            comboBox1.Items.Add("HashTable");
            // Data arrays.
            //string[] seriesArray = { "Cats", "Dogs" };
            //int[] pointsArray = { 1, 2 };

            //// Set palette.
            //this.chart1.Palette = ChartColorPalette.SeaGreen;

            //// Set title.
            //this.chart1.Titles.Add("Pets");

            //// Add series.
            //for (int i = 0; i < seriesArray.Length; i++)
            //{
            //    // Add series.
            //    Series series = this.chart1.Series.Add(seriesArray[i]);

            //    // Add point.
            //    series.Points.Add(pointsArray[i]);
            //}
        }

        private void fillChat()
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Linked List"].Points.AddXY("lis",33);
            /*Random rdn = new Random();
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
                    //totalTimeTaken = Utility.computeLinkedListAddAndSearchTime(numberOfItemsToUse);
                    chart1.Series["Linked List"].Points.AddXY
                             (rdn.Next(0, 10), rdn.Next(0, 10));
                }
                else if (selection.Equals("BinarySearch"))
                {
                    //totalTimeTaken = Utility.computeBinaryTreeAddAndSearchTime(numberOfItemsToUse);
                    chart1.Series["Binary Search"].Points.AddXY
                                (rdn.Next(0, 10), rdn.Next(0, 10));
                }
                else if (selection.Equals("HashTable"))
                {
                    //totalTimeTaken = Utility.computeHashTableAddAndSearchTime(numberOfItemsToUse);
                    chart1.Series["Hash Table"].Points.AddXY
                               (rdn.Next(0, 10), rdn.Next(0, 10));
                }

                Console.WriteLine("Total time taken in to add {0} items in {1} is = {2}", numberOfItemsToUse, selection);*/
               // DisplayStatsTextBox.Text = totalTimeTaken.ToString();
            }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
            
           


        }

}
