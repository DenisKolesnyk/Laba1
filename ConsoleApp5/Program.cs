using System;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type Type1 = new Type("RT 11 24", "R", 100000, 12);
            Type Type2 = new Type("RT 11 24", "R", 50000, 10);
            Type Type3 = new Type("CGU 12K", "C", 17, 3);
            Console.WriteLine("Позначення     Тип    Номінал    Кількість");
            Console.WriteLine(Type1.Details());
            Console.WriteLine(Type2.Details());
            Console.WriteLine(Type3.Details());
        }
    }
    
    class Type
    {
        public string marking  { get; set; }

        public string type { get; set; }

        public float par { get; set; }

        public double number { get; set; }

        public Type(Type previousType)
        {
            marking = previousType.marking;
            type = previousType.type;
            par = previousType.par;
            number = previousType.number;
        }

        public Type (string Marking, string Type, float Par, double Number)
        {
            marking = Marking;
            type = Type;
            par = Par;
            number = Number;
        }

        public string Details()
        {
            return marking + "       " + type + "        " + par.ToString() + "              " + number.ToString();
        }
    }
}
