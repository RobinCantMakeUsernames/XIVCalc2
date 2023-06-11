namespace XIVCalc2
{
    internal class Program : Jobs 
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            //pick a job
            //pick an ability
            //toggle personal buffs
            //toggle raid buffs
            //output damage


        }

        static void DamageCalc()
        {
            double damage = GetPotency() * GetBiS() * GetBuffs();
        }

        /*public int JobChoice()
        {
            return 0;
        }*/
        static double GetPotency()
        {
            //if choice = Dragoon get the potencies for Dragoon 

            return 0;
        }
        static double GetBiS()
        {
            //crit chance
            //crit damage
            //dhit
            //DET
            //Mainstat
            //Tenacity
            
            //return job.MainStat * job.DET * job.Tenacity;

            return 0;
        }
        static double GetBuffs()
        {
            return 0;
        }
        
        public string JobChoice { get; set; }
        static string JobSelect()
        {
            string choice = "a";
            //add a proper selection menu
            int input = GetInt(1, 19);
            switch (input)
            {
                case 1: 
                    choice = "Paladin";
                    break;
                case 2:
                    choice = "Warrior";
                    break;
                case 3:
                    choice = "Dark Knight";
                    break;
                case 4:
                    choice = "Gunbreaker";
                    break;
                case 5:
                    choice = "White Mage";
                    break;
                case 6:
                    choice = "Scholar";
                    break;
                case 7:
                    choice = "Astrologian";
                    break;
                case 8:
                    choice = "Sage";
                    break;
                case 9:
                    choice = "Monk";
                    break;
                case 10:
                    choice = "Dragoon";
                    DRG drg = new();
                    break;
                case 11:
                    choice = "Ninja";
                    break;
                case 12:
                    choice = "Samurai";
                    break;
                case 13:
                    choice = "Reaper";
                    break;
                case 14:
                    choice = "Bard";
                    break;
                case 15:
                    choice = "Machinist";
                    break;
                case 16:
                    choice = "Dancer"; 
                    break;
                case 17:
                    choice = "Black Mage";
                    break;
                case 18:
                    choice = "Summoner";
                    break;
                case 19:
                    choice = "Red Mage";
                    break;
            }
            JobChoice = choice;
            return choice;
        }
        static int GetInt()
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch
                { Console.WriteLine("Input must be a whole number.\n"); }
            }
        }
        static int GetInt(int low, int high)
        {
            while (true)
            {
                int num = GetInt();
                if (num >= low && high >= num)
                { return num; }
                else
                { Console.WriteLine("\nInput must be a whole number equal to or between " + low + " and " + high + "."); }
            }
        }
    }
}