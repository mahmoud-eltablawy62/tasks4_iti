namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of student");
            int n = int.Parse(Console.ReadLine());
            studentData[] studentData = new studentData[n];
            for (int i = 0; i < n; i++)
            {
                studentData[i] = new studentData();
                Console.WriteLine($"enter the data of student {i + 1}");

                Console.WriteLine("enter the Ssn:-");
                studentData[i].setSsn(Console.ReadLine());

                Console.WriteLine("enter the name:-");
                studentData[i].setName(Console.ReadLine());

                Console.WriteLine("enter the Address:-");
                studentData[i].setAddress(Console.ReadLine());

                Console.WriteLine("enter the Age:-");
                studentData[i].setAge(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"data of sudent {i + 1}");
                Console.WriteLine($"name==> {studentData[i].getName()} \nSsn==> {studentData[i].getSsn()} \nAge==>{studentData[i].getAge()}\naddress==>{studentData[i].getAddress()} ");
            }
        }
    }

    class studentData
    {
        string name;
        string ssn;
        int age;
        string Address;
        public void setName(string Name)
        {
            name = Name;
        }
        public void setSsn(string Ssn)
        {
            ssn = Ssn;
        }
        public void setAge(int Age)
        {
            age = Age;
        }
        public void setAddress(string address)
        {
            Address = address;
        }
        public string getName() { return name; }
        public string getSsn() { return ssn; }
        public int getAge() { return age; }
        public string getAddress() { return Address; }


    }
}