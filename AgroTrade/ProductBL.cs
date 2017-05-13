using System.Linq;

namespace AgroTrade
{
    internal class ProductBL
    {
        public string Validate(Product p)
        {
            string res;

            if (CheckName(p.FarmerName) && CheckPhoneNumber(p.ContactNo))
            {
                res = "Product Added Successfully";
            }
            else
            {
                res = "Data is invalid";
            }

            return res;
        }

        private bool CheckName(string farmerName)
        {
            bool isNameValid = false;

            if (farmerName.All(char.IsLetter))
            {
                isNameValid = true;
            }

            return isNameValid;
        }

        private bool CheckPhoneNumber(int phone)
        {
            bool isValidPhone = false;

            if (phone.ToString().Length == 10)
            {
                isValidPhone = true;
            }

            return isValidPhone;
        }
    }
}