using System;

namespace NameDB
{
    class BankRegister
    {
        private int total_number_of_customers = 0; // actual number of customers in int

        public int ReturnRegister
        {
            get { return total_number_of_customers; }
        }

        public string EditRegister
        {            
            set
            {
                if (value == "delete")
                    total_number_of_customers--;
                else if (value == "add")
                    total_number_of_customers++;
                else
                    Console.WriteLine("Invalid SAP command");
            }
        }
    }
    class Client
    {
        private string clientName;
        private int clientAge;
        private bool clientMarriageStatus;

        public string ClientName
        {
            get { return clientName; }

            set { clientName = value; }
        }

        public int ClientAge
        {
            get { return clientAge; }
            set
            {
                if (value >= 18)
                {
                    clientAge = value;
                }
            }
        }

        public bool ClientMarriageStatus
        {
            get { return clientMarriageStatus; }
            set { clientMarriageStatus = value; }
        }
    }
    class MainProgram
    {
        static void Main()
        {
            // missing -- parse name for invalid characters 
            //         -- validate age until valid value entered
            //         -- validate yes/no marriage 
            //         -- 
            // rewrite BankRegister

            BankRegister MainRegister = new BankRegister();

            Console.WriteLine("Please enter the new client name:");
            var input = Console.ReadLine();

            Client TH = new Client();
            TH.ClientName = input;

            Console.WriteLine("Please provide client age:");
            input = Console.ReadLine();   

            if ( ! (int.TryParse(input, out int Age)) )
            {
                Console.WriteLine("Please provide an actual age:");
            }
            else
            { 
                TH.ClientAge = int.Parse(input);
            }

            Console.WriteLine("Is client married? Yes / No ?");
            var married = Console.ReadLine().ToUpper();

            if (married == "YES")
            {
                TH.ClientMarriageStatus = true;
            }
            else if (married == "NO")
            {
                TH.ClientMarriageStatus = false;
            }
            else
                return;

            MainRegister.EditRegister = "add";

                /*
            Client TH = new Client
            {
                ClientAge = age,
                ClientMarriageStatus = true,
                ClientName = name
            };*/

            Console.WriteLine($"Our new client is {TH.ClientName} age {TH.ClientAge} married status: {TH.ClientMarriageStatus}");
            Console.Write("\n");

            Console.WriteLine($"Total number of customers so far: {MainRegister.ReturnRegister}");
        }
    }
}
