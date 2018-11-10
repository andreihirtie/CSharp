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
        // missing -- parse name for invalid characters 
        //         -- validate age until valid value entered
        //         -- validate yes/no marriage 
        //         -- 
        // rewrite BankRegister
        /*
        BankRegister MainRegister = new BankRegister();

        Console.WriteLine("Please enter client's first name:");
        var first_name = Console.ReadLine();
        Console.WriteLine("Please enter client's last name:");
        var last_name = Console.ReadLine();

        Client TH = new Client();
        TH.ClientName = input;

            Console.WriteLine("Please provide client age:");
            input = Console.ReadLine();

            if ( !(int.TryParse(input, out int Age)))
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
        };

            Console.WriteLine($"Our new client is {TH.ClientName} age {TH.ClientAge} married status: {TH.ClientMarriageStatus}");
            Console.Write("\n");

            Console.WriteLine($"Total number of customers so far: {MainRegister.ReturnRegister}"); */
        enum Main_exec
        {
            quit,
            add_client,
            remove_client,
            see_client_list,
        };

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("You are in the main menu. Please select an option: ");
                Console.WriteLine("\t1. Add new client.");
                Console.WriteLine("\t2. Remove client.");
                Console.WriteLine("\t3. See list of clients.");
                Console.WriteLine("\t4. Quit program.");
                Console.Write("\t Your option: ");

                if (!UInt16.TryParse(Console.ReadLine(), out UInt16 _current_state))
                    Console.WriteLine(" Please enter a valid option from 1 - 4.");

                switch (_current_state)
                {
                    case (UInt16)Main_exec.quit:
                        {
                            string answer;
                            Console.Write("Are you sure you want to quit? Yes/No: ");
                            answer = Console.ReadLine();
                            if (answer.ToUpper() == "YES" || answer.ToUpper() == "Y")
                                return;
                            else
                                continue;
                        }

                    case (UInt16)Main_exec.add_client:
                        {

                        }

                }
            }
        }
    }
}

