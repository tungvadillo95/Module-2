using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneManager
{
    public class PhoneBook : Phone
    {
        public Contact[] PhoneList = new Contact[3];
        public PhoneBook()
        {
            PhoneList[0] = new Contact()
            {
                Name = "Gerrard",
                PhoneNumber = "888888"
            };
            PhoneList[1] = new Contact()
            {
                Name = "Torres",
                PhoneNumber = "999999"
            };
            PhoneList[2] = new Contact()
            {
                Name = "Suarez",
                PhoneNumber = "777777"
            };
        }
        private int FindName(string name, out string phoneNumber)
        {
            for (int i = 0; i < PhoneList.Length; i++)
            {
                if (PhoneList[i].Name.ToUpper() == name.ToUpper())
                {
                    phoneNumber = PhoneList[i].PhoneNumber;
                    return i;
                }
            }
            phoneNumber = "";
            return -1;
        }
        //private Contact FindContact(string name)
        //{
        //    foreach(var contact in PhoneList)
        //    {
        //        if (contact.Name== name)
        //        {
        //            return contact;
        //        }
        //    }
        //    return new Contact();
        //}
        public void Show()
        {
            foreach (var contact in PhoneList)
            {
                Console.WriteLine(contact.ToString());
            }
        }
        public override void InsertPhone(string name, string phone)
        {
            var pos = FindName(name, out string phoneNumber);
            if (pos == -1)
            {
                var contact = new Contact()
                {
                    Name = name,
                    PhoneNumber = phone
                };
                Array.Resize(ref PhoneList, PhoneList.Length + 1);
                PhoneList[PhoneList.Length - 1] = contact;
            }
            else
            {
                if (PhoneList[pos].PhoneNumber != phone)
                {
                    PhoneList[pos].PhoneNumber += $" , {phone}";
                }
            }
        }

        public override void RemovePhone(string name)
        {
            var pos = FindName(name, out string phoneNumber);
            if (pos != -1)
            {
                for (int i = pos; i < PhoneList.Length - 1; i++)
                {
                    PhoneList[i] = PhoneList[i + 1];
                }
                Array.Resize(ref PhoneList, PhoneList.Length - 1);
            }
        }

        public override void SearchPhone(string name)
        {
            int check = 0;
            for (int i = 0; i < PhoneList.Length; i++)
            {
                if (PhoneList[i].Name.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine(PhoneList[i].ToString());
                    check++;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Contact name does not exist!");
            }
        }


        public override void Sort()
        {
            Console.WriteLine("Sorry! Currently updated.");
        }

        public override void UpdatePhone(string name, string newphone)
        {
            var pos = FindName(name, out string phoneNumber);
            if (pos != -1)
            {
                PhoneList[pos].PhoneNumber = newphone;
            }
        }
    }
}
