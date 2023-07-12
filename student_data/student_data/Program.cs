namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentData studentData = new studentData();
            Console.WriteLine("enter the Ssn:-");
            studentData.setSsn(Console.ReadLine());
            Console.WriteLine("enter the name");
            studentData.setName(Console.ReadLine());
            Console.WriteLine("enter the age:-");
            studentData.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter the Address:-");
            studentData.setAddress(Console.ReadLine());

            Console.WriteLine($"ssn :-{studentData.getSsn()} \n name:- {studentData.getName()} \n age:- {studentData.getAge()} \n address:-{studentData.getAddress()}");

        }
    }
    class studentData
    {
        string name;
        string ssn;
        int age;
        string Address;
        public void setName(string Name) {
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
           Address = address ;
        }
        public string getName() { return name; }
        public string getSsn() { return ssn;}
        public int getAge() { return age;}
        public string getAddress() { return Address; }

        
    }
}