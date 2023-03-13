namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ResidentList = new Dictionary<string, string>();
            Dictionary<string, int> UnitList = new Dictionary<string, int>();

            //Adding Employees
            ResidentList.Add("Ruth Smith", "101");
            ResidentList.Add("Dorothy Jones", "102");
            ResidentList.Add("Bob Taylor", "103");
            ResidentList.Add("Jerry Miller", "104");
            ResidentList.Add("Gary Anderson", "105");

            Console.WriteLine("Generic Retirement Home");
            Console.WriteLine();

            Console.WriteLine("Resident Names:");
            Dictionary<string, string>.KeyCollection keys = ResidentList.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("Resident Units");
            Dictionary<string, string>.ValueCollection values = ResidentList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("Resident Names and Units");
            foreach (KeyValuePair<string, string> kvp in ResidentList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
           
            ResidentList.Remove("Jerry Miller");

            Console.WriteLine("Jerry went home to live with family.");
            Console.WriteLine();

            Console.WriteLine("Revised Resident and Unit list:");
            foreach (KeyValuePair<string, string> kvp in ResidentList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
        }

    }
}