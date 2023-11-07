namespace P07.CompanyUsers
{
    class Company
    {
        public Company(string companyName)
        {
            CompanyName = companyName;
            EmployeeId = new List<string>();
        }

        public string CompanyName { get; set; }
        public List<string> EmployeeId { get; set; }

        public override string ToString()
        {
            string result = $"{CompanyName}\n";

            foreach (string id in EmployeeId)
            {
                result += $"-- {id}\n";
            }

            return result.Trim();


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companyMap = new Dictionary<string, Company>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                
                if (!companyMap.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companyMap.Add(companyName, company);
                    company.EmployeeId.Add(employeeId);
                }
                else
                {
                    Company company = companyMap[companyName];
                    if (!company.EmployeeId.Contains(employeeId))
                    {
                        company.EmployeeId.Add(employeeId);
                    }
                }
            }

            foreach (KeyValuePair<string, Company> kvp in companyMap)
            {
                Console.WriteLine($"{kvp.Value}");
            }
        }
    }


}