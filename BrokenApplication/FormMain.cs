using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokenApplication
{
    public partial class FormMain : Form
    {
        // Const variables - these don't change
        private const int MIN_SEED = 1;
        private const int MAX_SEED = 100;

        // Numbers that will be used to calculate averag
        // Keep last generated in mind
        private Random random;
        private lastGenerated;

        // Private field with public accessor
        private decimal average;

        // Global multiplier
        private int multiplier = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Get a random value between min and max seed
            lastGenerated = random.Next(MIN_SEED, MAX_SEED);
            // Set last generated text
            setTxtLastGenerated(lastGenerated;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            // Parse/cast to int and add it to the listbox
            int parsed = int.Parse(txtNumber.Text);
            lbNumbers.Items.Add(parsed);
            // Calculate average
            calculateAverage();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            // Get all checked items in listbox
            foreach (var value in lbNumbers.CheckedItems.OfType<int>().ToList())
            {
                // Remove the actual item
                lbNumbers.Items.Remove();
            }
            // Calculate average afterwards
            calculateAverage();
        }

        private void calculateAverage()
        {
            // Calculate the average number of item values in listbox
            decimal total = 0;
            int itemAmount = lbNumbers.Items.Count;
            // Loop through all items in listbox
            foreach(int number in lbNumbers.Items)
            {
                total += number
            }
            // Calculate average
            // Combine with global multiplier
            average = total / itemAmount / multiplier;
            // Set the text to a textbox
            setTxtAverage(average);
        }

        private void setTxtLastGenerated(int lastGenerated)
        {
            // Cast to string to represent in textbox
            txtNumber.Text = lastGenerated.ToString;
        }

        private void setTxtAverage(decimal average)
        {
            // Cast to string to represent in textbox
            txtAverage.Text = average.ToString;
        }
    }
}
