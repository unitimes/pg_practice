using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<PhoneData> phoneList;

        public PhoneBook()
        {
            phoneList = new List<PhoneData>();
        }
        public void AddDatas(string book)
        {
            phoneList = new List<PhoneData>();
            book = book.Replace("\t", "");
            MessageBox.Show(book);
            string[] textLines = book.Split(new string[] {"\r\n"}, StringSplitOptions.None);
            foreach (string line in textLines)
            {
                string[] phoneDatas = line.Split(new string[] { "||" }, StringSplitOptions.None);
                if(phoneDatas.Length == 3)
                    Add(phoneDatas[1], phoneDatas[2], phoneDatas[0]);
            }
        }

        public void Add(string name, string phone, string group)
        {
            PhoneData p = new PhoneData(name, phone, group);
            phoneList.Add(p);
        }

        public PhoneData FindPeople(string name)
        {
            foreach (PhoneData p in phoneList)
            {
                if(p.name == name)
                    return p;
            }
            return null;
        }

        public string GetAllData()
        {
            string ret = "";
            foreach (PhoneData p in phoneList)
            {
                ret += string.Format("{0}\t||{1, 2}\t||{2}\r\n", p.group, p.name, p.phone);
            }
            return ret;
        }
    }
    public class PhoneData
    {
        public string name;
        public string phone;
        public string group;

        public PhoneData()
        {
            name = "John Doe";
            phone = "010-1234-5678";
            group = "None";
        }

        public PhoneData(string name, string phone, string group)
        {
            this.name = name;
            this.phone = phone;
            this.group = group;
        }
    }
}
