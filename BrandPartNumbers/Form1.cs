using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandPartNumbers
{
    public partial class Form1 : Form
    {
        // 2D array for the table   
        string[,] lookUpTable = new string[,]
        {
            {"PR214", "MR43T", "R43", "R43N", "R46N", "R46TS", "R46TX", "S46", "SR46E", "47L"}, // Brand A
            {"PR223", "RBL8", "RJ6", "RN4", "RN8", "RBL17Y", "RBL12-6", "J11", "XEJ8", "H12"}, // Brand C
            {"PR224", "14K22", "14K24", "14K30", "14K32", "14K33", "14K35", "14K38", "14K40", "14K44"} // Brand X
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string partNumber = PartNumberTextBox.Text.ToUpper();
            string brand = "";

            // Determining the brand based on the selected radio button
            if (BrandARadioButton.Checked)
            {
                brand = "Brand A";
            }
            else if (BrandCRadioButton.Checked)
            {
                brand = "Brand C";
            }
            else if (BrandXRadioButton.Checked) 
            {
                brand = "Brand X";
            }

            // Looking up the VB Auto part number
            if (!string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(partNumber))
            {
                int brandIndex = Array.IndexOf(new string[] { "Brand A", "Brand C", "Brand X" }, brand);
                if (brandIndex != -1) 
                {
                    int partIndex = -1;
                    for (int i = 0; i < lookUpTable.GetLength(1); i++) 
                    {
                        if (lookUpTable[brandIndex, i] == partNumber) 
                        {
                            partIndex = i;
                            break;
                        }
                    }
                    if (partIndex != -1) 
                    {
                        string vbAutoPartNumber = lookUpTable[brandIndex, 0];
                        MessageBox.Show($"The VB Auto part number is: {vbAutoPartNumber}", "VB Auto Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("Part number not found for the selected brand.", "VB Auto Center", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                MessageBox.Show("Please select a brand and enter a part number.", "VB Auto Center", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
