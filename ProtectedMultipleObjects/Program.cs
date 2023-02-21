using System;

namespace ProtectedMultipleObjects
{
    // Base class
    class Club
    {
        protected string name;
        protected int membershipFee;
        protected int membershipCount;

        // Default constructor
        public Club()
        {
            name = "";
            membershipFee = 0;
            membershipCount = 0;
        }

        // Parameterized constructor
        public Club(string name, int membershipFee, int membershipCount)
        {
            this.name = name;
            this.membershipFee = membershipFee;
            this.membershipCount = membershipCount;
        }

        // Getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int MembershipFee
        {
            get { return membershipFee; }
            set { membershipFee = value; }
        }

        public int MembershipCount
        {
            get { return membershipCount; }
            set { membershipCount = value; }
        }

        // Virtual methods
        public virtual void Add()
        {
            Console.WriteLine("Adding a new club");
        }

        public virtual void Change()
        {
            Console.WriteLine("Changing an existing club");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Club Name: {name}");
            Console.WriteLine($"Membership Fee: {membershipFee}");
            Console.WriteLine($"Membership Count: {membershipCount}");
        }
    }

    // Derived class
    class GamingClub : Club
    {
        protected string game;
        protected string platform;

        // Default constructor
        public GamingClub() : base()
        {
            game = "";
            platform = "";
        }

        // Parameterized constructor
        public GamingClub(string name, int membershipFee, int membershipCount, string game, string platform) : base(name, membershipFee, membershipCount)
        {
            this.game = game;
            this.platform = platform;
        }

        // Getters and setters
        public string Game
        {
            get { return game; }
            set { game = value; }
        }

        public string Platform
        {
            get { return platform; }
            set { platform = value; }
        }

        // Override methods
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Adding a new gaming club");
        }

        public override void Change()
        {
            base.Change();
            Console.WriteLine("Changing an existing gaming club");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Game: {game}");
            Console.WriteLine($"Platform: {platform}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of base class objects
            Club[] clubs = new Club[3];

            // Create objects of base class and add them to the array
            Club club1 = new Club("The Club", 50, 100);
            clubs[0] = club1;

            Club club2 = new Club("Another Club", 75, 50);
            clubs[1] = club2;

            // Create an array of derived class objects
            GamingClub[] gamingClubs = new GamingClub[2];

            // Create objects of derived class and add them to the array
            GamingClub gamingClub1 = new GamingClub("The Gaming Club", 20, 200, "Minecraft", "PC");
            gamingClubs[0] = gamingClub1;

            GamingClub gamingClub2 = new GamingClub("Another Gaming Club", 25, 150, "Fortnite", "Xbox");
            gamingClubs[1] = gamingClub2;
            // Display menu and get user input
            string choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a club");
                Console.WriteLine("2. Change a club");
                Console.WriteLine("3. Display clubs");
                Console.WriteLine("4. Add a gaming club");
                Console.WriteLine("5. Change a gaming club");
                Console.WriteLine("6. Display gaming clubs");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add a new base class object
                        Club newClub = new Club();
                        newClub.Add();
                        Console.Write("Enter the club name: ");
                        newClub.Name = Console.ReadLine();
                        Console.Write("Enter the membership fee: ");
                        newClub.MembershipFee = int.Parse(Console.ReadLine());
                        Console.Write("Enter the membership count: ");
                        newClub.MembershipCount = int.Parse(Console.ReadLine());
                        clubs[2] = newClub;
                        Console.WriteLine("Club added successfully");
                        break;

                    case "2":
                        // Change an existing base class object
                        Console.Write("Enter the index of the club to change (0-2): ");
                        int clubIndex = int.Parse(Console.ReadLine());
                        if (clubIndex < 0 || clubIndex > 2 || clubs[clubIndex] == null)
                        {
                            Console.WriteLine("Invalid index or club does not exist");
                        }
                        else
                        {
                            clubs[clubIndex].Change();
                            Console.Write("Enter the new club name: ");
                            clubs[clubIndex].Name = Console.ReadLine();
                            Console.Write("Enter the new membership fee: ");
                            clubs[clubIndex].MembershipFee = int.Parse(Console.ReadLine());
                            Console.Write("Enter the new membership count: ");
                            clubs[clubIndex].MembershipCount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Club changed successfully");
                        }
                        break;

                    case "3":
                        // Display all base class objects
                        Console.WriteLine("All Clubs:");
                        for (int i = 0; i < 3; i++)
                        {
                            if (clubs[i] != null)
                            {
                                clubs[i].Display();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "4":
                        // Add a new derived class object
                        GamingClub newGamingClub = new GamingClub();
                        newGamingClub.Add();
                        Console.Write("Enter the gaming club name: ");
                        newGamingClub.Name = Console.ReadLine();
                        Console.Write("Enter the membership fee: ");
                        newGamingClub.MembershipFee = int.Parse(Console.ReadLine());
                        Console.Write("Enter the membership count: ");
                        newGamingClub.MembershipCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter the game: ");
                        newGamingClub.Game = Console.ReadLine();
                        Console.Write("Enter the platform: ");
                        newGamingClub.Platform = Console.ReadLine();
                        gamingClubs[2] = newGamingClub;
                        Console.WriteLine("Gaming club added successfully");
                        break;

                    case "5":
                        // Change an existing derived class object
                        Console.Write("Enter the index of the gaming club to change (0-1): ");
                        int gamingClubIndex = int.Parse(Console.ReadLine());
                        if (gamingClubIndex < 0 || gamingClubIndex > 1 || gamingClubs[gamingClubIndex] == null)
                        {
                            Console.WriteLine("Invalid index or gaming club does not exist");
                        }
                        else
                        {
                            gamingClubs[gamingClubIndex].Change();
                            Console.Write("Enter the new gaming club name: ");
                            gamingClubs[gamingClubIndex].Name = Console.ReadLine();
                            Console.Write("Enter the new membership fee: ");
                            gamingClubs[gamingClubIndex].MembershipFee = int.Parse(Console.ReadLine());
                            Console.Write("Enter the new membership count: ");
                            gamingClubs[gamingClubIndex].MembershipCount = int.Parse(Console.ReadLine());
                            Console.Write("Enter the new game: ");
                            gamingClubs[gamingClubIndex].Game = Console.ReadLine();
                            Console.Write("Enter the new platform: ");
                            gamingClubs[gamingClubIndex].Platform = Console.ReadLine();
                            Console.WriteLine("Gaming club changed successfully");
                        }
                        break;

                    case "6":
                        // Display all derived class objects
                        Console.WriteLine("All Gaming Clubs:");
                        for (int i = 0; i < 2; i++)
                        {
                            if (gamingClubs[i] != null)
                            {
                                gamingClubs[i].Display();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "7":
                        // Exit the program
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != "7");
        }
    }
}

