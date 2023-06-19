using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    /* by Fenix Kanat.
     * This Class is the logical part of the application. 
     * Methods to add, delete guests as well as calculating fee and costs per added guests etc.
     */
    class PartyManager
    {
        private double costPerPerson; 
        private double feePerPerson;
        private string[] guestList; 

        public double CostPerPerson
        {
            get { return costPerPerson; }
            set { costPerPerson = value; }
        }

        public double FeePerPerson
        {
            get { return feePerPerson; }
            set { feePerPerson = value; }
        }

        public int GetNumOfGuests()
        {
            return NumOfGuests();
        }

        // give the guest list array with the maximum number of guests
        public PartyManager(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests]; 
        }

        // Create the full name by using first and last name, Find the first vacant position in the guest list array
        // Add the guest to the guest list at the vacant position
        // Return true to indicate successful addition of the guest
        public bool AddNewGuest(string firstName, string lastName)
        {
            string fullName = FullName(firstName, lastName);
            int vacantPos = FindVacantPos(); 

            if (vacantPos != -1)
            {
                guestList[vacantPos] = fullName; 
                return true; 
            }

            return false; 
        }

        // Calculate the total cost by multiplying the cost per person with the number of guests
        public double CalcTotalCost()
        {
            return costPerPerson * NumOfGuests(); 
        }

        // Calculate the total fee by multiplying the fee per person with the number of guests
        public double CalcTotalFee()
        {
            return feePerPerson * NumOfGuests(); 
        }


        // Check if the index is within the range of the guest list array
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < guestList.Length; 
        }

        // Remove the guest name at the specified index
        // Move the remaining guest names one step to the left
        // Return true to indicate successful deletion of the guest
        // Return false if the index is out of range
        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                guestList[index] = null; 
                MoveElementsOneStepToLeft(index);
                return true; 
            }

            return false; 
        }

        // Find the first vacant position (where the guest name is null or empty)
        // Return the index of the vacant position
        // Return -1 if no vacant position is found
        private int FindVacantPos()
        {
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i])) 
                    return i;
            }

            return -1; 
        }

        
        private string FullName(string firstName, string lastName)
        {
            return lastName + ", " + firstName; 
        }

        public string[] GetGuestList()
        {
            return guestList; 
        }

        // Return the guest name at the specified index if it is valid
        // Return null if the index is out of range
        public string GetItemAt(int index)
        {
            if (CheckIndex(index))
                return guestList[index]; 

            return null; 
        }

        // Move each element one step to the left starting from the specified index
        // Set the last element of the guest list to null to clear the previous last element
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < guestList.Length - 1; i++)
            {
                guestList[i] = guestList[i + 1]; 
            }

            guestList[guestList.Length - 1] = null; 
        }

        // Count the number of non-null and non-empty guest names in the guest list array
        // Return the count as the number of guests
        private int NumOfGuests()
        {
            int count = 0;

            foreach (string guest in guestList)
            {
                if (!string.IsNullOrEmpty(guest)) 
                    count++;
            }

            return count; 
        }
    }
}
