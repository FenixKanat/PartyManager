using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// The app needs to update after clicking create again

/* by Fenix Kanat. 
 * This class is used to connect the UI with the logical part, PartyManager.cs. 
 * It is also used to initialize the UI. 
 */


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private PartyManager partyManager; 

        private String firstName = String.Empty; 
        private String lastName = String.Empty; 
        private List<Label> guestLabels = new List<Label>(); 

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI(); 
        }

        private void InitializeGUI()
        {
            this.Text += " Fenix Kanat";
            NumOfGuests11.Text = string.Empty; 
            TotalCost11.Text = string.Empty; 
            TotalFee11.Text = string.Empty;
            Deficit11.Text = string.Empty; 
            LBoxShowGuestList.Text = string.Empty; 
            groupBox3.Enabled = false; // Disable the groupBox3 initially
        }


        // Read and check the maximum number of guests input
        private bool ReadMaxNumOfGuests()
        {
            int guests = 0;
            bool ok = int.TryParse(MaxNumOfGuests11.Text, out guests);

            if (!ok)
            {
                MessageBox.Show("Invalid number of guests");
            }

            return ok;
        }

        // Read and check the cost per person input
        private bool ReadCostPerPerson()
        {
            double cost = 0.0;
            bool ok = double.TryParse(CostPerPerson11.Text, out cost);

            if (!ok)
            {
                MessageBox.Show("Cost value is invalid");
            }

            return ok;
        }

        // Read and check the fee per person input
        private bool ReadFeePerPerson()
        {
            double fee = 0.0;
            bool ok = double.TryParse(FeePerPerson11.Text, out fee);

            if (!ok)
            {
                MessageBox.Show("Fee value is invalid");
            }

            return ok;
        }

        // Read and check the inputs for creating a new party
        private bool ReadInputNewParty()
        {
            bool guests = ReadMaxNumOfGuests();
            bool cost = ReadCostPerPerson();
            bool fee = ReadFeePerPerson();

            return guests && cost && fee;
        }


        // Read and check the guest information inputs
        private void ReadInputGuestInfo()
        {
            string firstName = FirstName11.Text.Trim();
            string lastName = LastName11.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter firstname");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter lastname");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FirstName11_TextChanged(object sender, EventArgs e)
        {

        }

        // Triggered when the "Create List" button is clicked
        // Check if the input for new party is valid, create a new PartyManager instance and  Set the cost and fee per person.
        private void Create_Click(object sender, EventArgs e)
        {
            if (ReadInputNewParty()) 
            {
                int maxNumOfGuests = int.Parse(MaxNumOfGuests11.Text);
                double costPerPerson = double.Parse(CostPerPerson11.Text);
                double feePerPerson = double.Parse(FeePerPerson11.Text);

                partyManager = new PartyManager(maxNumOfGuests); 
                partyManager.CostPerPerson = costPerPerson; 
                partyManager.FeePerPerson = feePerPerson; 

                MessageBox.Show("Party created successfully!");

                groupBox3.Enabled = true; // Enable the groupbox for inviting guests
            }
        }

        // Triggered when the "Add" button is clicked
        private void Add_Click(object sender, EventArgs e)
        {
            firstName = FirstName11.Text.Trim();
            lastName = LastName11.Text.Trim();

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                if (partyManager != null)
                {
                    if (partyManager.AddNewGuest(firstName, lastName))
                    {
                        int numOfGuests = partyManager.GetNumOfGuests();
                        double totalCost = partyManager.CalcTotalCost();
                        double totalFee = partyManager.CalcTotalFee();
                        double deficit = totalFee - totalCost;

                        UpdateGuestList();
                        NumOfGuests11.Text = numOfGuests.ToString();
                        TotalCost11.Text = totalCost.ToString();
                        TotalFee11.Text = totalFee.ToString();
                        Deficit11.Text = deficit.ToString();

                        MessageBox.Show("Guest added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No vacant position available.");
                    }
                }
                else
                {
                    MessageBox.Show("Please create a party first.");
                }
            }
        }

        // Update the guest list in the UI
        private void UpdateGuestList()
        {
            LBoxShowGuestList.Items.Clear();

            if (partyManager != null)
            {
                string[] guestList = partyManager.GetGuestList();

                foreach (string guest in guestList)
                {
                    if (!string.IsNullOrEmpty(guest))
                    {
                        string[] nameParts = guest.Split(',');
                        string formattedName = nameParts[0].Trim().ToUpper() + ", " + nameParts[1].Trim();

                        ListViewItem item = new ListViewItem(formattedName);
                        LBoxShowGuestList.Items.Add(item);
                    }
                }
            }
        }

        // Format the guest list for display
        private string FormatGuestList(string[] guestList)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string guest in guestList)
            {
                if (!string.IsNullOrEmpty(guest))
                {
                    string[] nameParts = guest.Split(',');
                    string formattedName = nameParts[0].Trim().ToUpper() + ", " + nameParts[1].Trim();
                    sb.AppendLine(formattedName);
                }
            }

            return sb.ToString().TrimEnd();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Delete button
        private void Delete_Click(object sender, EventArgs e)
        {
            if (LBoxShowGuestList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = LBoxShowGuestList.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (partyManager != null && partyManager.DeleteAt(selectedIndex))
                {
                    UpdateGuestList();

                    int numOfGuests = partyManager.GetNumOfGuests();
                    double totalCost = partyManager.CalcTotalCost();
                    double totalFee = partyManager.CalcTotalFee();
                    double deficit = totalFee - totalCost;

                    NumOfGuests11.Text = numOfGuests.ToString();
                    TotalCost11.Text = totalCost.ToString();
                    TotalFee11.Text = totalFee.ToString();
                    Deficit11.Text = deficit.ToString();

                    MessageBox.Show("Guest deleted successfully!");
                }
            }
        }

        private void LastName1_Click(object sender, EventArgs e)
        {

        }
    }
}
