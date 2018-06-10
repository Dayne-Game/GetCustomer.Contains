namespace coding
{
    public class Customer
    {
        public string FName {get; set;}
        public string LName {get; set;}
        public string Phone {get; set;}

        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        public string GetCustomer()
        {
            return $"{FName}\t{LName}\t{Phone}";
        }
    }
}
