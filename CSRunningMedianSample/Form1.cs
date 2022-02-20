using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSRunningMedianSample
{
    public partial class Form1 : Form
    {

        List<double> sourceList = new List<double>();
        List<double> medianList = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }

        public void AllMedian()
        {
            double[] tempList = new double[5];
            int iMin;
            int iMax;

            for (int i = 0; i <= sourceList.Count - 1; i++)
            {
                iMin = (i < 2) ? 0 : i - 2;
                iMax = (i > sourceList.Count - 3) ? sourceList.Count - 1 : i + 2;

                int k = 0;
                for (int j = iMin; j <= iMax; j++)
                {
                    tempList[k] = sourceList[j];
                    k += 1;
                }
                Quicksort(tempList, 0, 4);
                medianList.Add(tempList[2]);
            }
        }

        public void MiddleMedian()
        {
            medianList.Add(sourceList[0]);
            medianList.Add(sourceList[1]);

            double[] tempList = new double[5];
            for (double i = 2; i <= sourceList.Count - 3; i++)
            {
                int k = 0;
                for (int j = (int)(i - 2); j <= i + 2; j++)
                {
                    tempList[k] = sourceList[j];
                    k += 1;
                }
                Quicksort(tempList, 0, 4);
                medianList.Add(tempList[2]);
            }

            medianList.Add(sourceList[sourceList.Count - 2]);
            medianList.Add(sourceList[sourceList.Count - 1]);
        }

        public void Quicksort(double[] list, int min, int max)
        {
            Random random_number = new Random();
            double med_value;
            int hi;
            int lo;
            int i;

            if (min >= max)
                return;

            i = random_number.Next(min, max + 1);
            med_value = list[i];

            list[i] = list[min];

            lo = min;
            hi = max;
            do
            {
                while (list[hi] >= med_value)
                {
                    hi = hi - 1;
                    if (hi <= lo)
                        break;
                }

                if (hi <= lo)
                {
                    list[lo] = med_value;
                    break;
                }

                list[lo] = list[hi];
                lo = lo + 1;
                while (list[lo] < med_value)
                {
                    lo = lo + 1;
                    if (lo >= hi)
                        break;
                }

                if (lo >= hi)
                {
                    lo = hi;
                    list[hi] = med_value;
                    break;
                }

                list[hi] = list[lo];
            }
            while (true);

            Quicksort(list, min, lo - 1);
            Quicksort(list, lo + 1, max);
        }

        public void DisplayResults()
        {
            ListBox2.BeginUpdate();
            foreach (double value in medianList)
                ListBox2.Items.Add(value);
            ListBox2.EndUpdate();
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            medianList.Clear();
            ListBox2.Items.Clear();

            if (sourceList.Count == 0)
            {

                foreach (double tInt in ListBox1.Items)
                {
                        sourceList.Add(tInt);
                }
            }

            if (ListBox1.Items.Count > 0)
            {
                if (RadioButton1.Checked)
                    MiddleMedian();
                else
                    AllMedian();
            }
            else
                return;

            DisplayResults();
            sourceList.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(Double.Parse(TextBox1.Text));
            TextBox1.Text = String.Empty; 
        }
    }
}
