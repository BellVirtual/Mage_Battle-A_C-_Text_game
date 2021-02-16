using System;
using System.Data;
using System.Text;
namespace Mage_Battle
{
    class Mage
    {
        public string name;
        public string type;
        public string pmove;
        public string dmove;
        public string imove;
        public int intl;
        public int pwr;
        public int def;
        public int hp;
        public string ptext;
        public string dtext;
        public string itext;

        static void Main(string[] args)
        {
            Console.Write("Choose your magic type(a)Fire (b)Water (c)Earth: ");
            string ch = Console.ReadLine();
            Mage ply = choice(ch);
            Console.WriteLine(ply.name);


            int randenum;
            Random rande = new Random();
            randenum = rande.Next(1, 4);
            Mage op = rand(randenum);

            Console.WriteLine("A " + op.name + " has come to chalange you!");
            while ((op.hp > 0) || (ply.hp > 0))
            {
                Console.WriteLine("Opponent: " + op.hp + " Hp, " + op.def + " Def, " + op.intl + " intl, " + op.pwr + " Pwr");
                Console.WriteLine("You: " + ply.hp + " Hp, " + ply.def + " Def, " + ply.intl + " intl, " + ply.pwr + " Pwr");
                Console.WriteLine("Make your move(a)" + ply.pmove + " (b)" + ply.dmove + " (c)" + ply.imove + " :");
                string move = Console.ReadLine();
                if (move == "a")
                {
                    Console.WriteLine("You:" + ply.ptext);
                    int dice;
                    dice = rande.Next(1, 11);
                    int dice2;
                    dice2 = rande.Next(1, 11);
                    if (dice + ply.intl > dice2 + op.def)
                    {
                        int dmg = ply.pwr / 3;
                        op.hp -= dmg;

                        Console.WriteLine("The magic hit your opponent for " + dmg + " damage.");
                        Console.WriteLine("Your Opponent now has " + op.hp + (" health left."));




                    }
                    if (dice + ply.intl <= dice2 + op.def)
                    {
                        Console.WriteLine("You missed!");
                        ply.intl -= 2;
                        Console.WriteLine("In there frustion their intelegence dropped by 2 they now have " + op.intl + " intelegence.");


                    }
                }
                
                if (move == "b")
                {
                        Console.WriteLine("You:" + ply.dtext);
                        int magic = ply.intl / 3;
                        ply.def += magic;
                        Console.WriteLine("The " + ply.name + " now has " + ply.def + " defense.");



                }
                if (move == "c")
                {
                        Console.WriteLine("You:" + ply.itext);
                        int magic = ply.intl / 3;
                        ply.intl += magic;
                        Console.WriteLine("The gods must be kind the " + ply.name + " now has " + ply.intl + " intelegence.");
                        op.def -= 2;
                        Console.WriteLine("The " + op.name + " is unerved, they now have " + op.def + " defense.");




                }









                 int bot;
                 bot = rande.Next(1, 4);
                    if (bot == 1)
                    {
                        Console.WriteLine("Opponent:"  + op.ptext);
                        int dice3;
                        dice3 = rande.Next(1, 11);
                        int dice4;
                        dice4 = rande.Next(1, 11);
                        
                        if (dice3 + op.intl > dice4 + ply.def)
                        {

                             int dmg = op.pwr / 3;
                            ply.hp -= dmg;

                            Console.WriteLine("The magic hit you for " + dmg + " damage.");
                            Console.WriteLine("You now have " + ply.hp + (" health left."));




                        }
                        if (dice3 + op.intl <= dice4 + ply.def)
                        {
                            Console.WriteLine("Your opponent missed");
                            op.intl -= 2;
                            Console.WriteLine("In there frustion their intelegence dropped by 2 they now have " + op.intl + " intelegence.");







                        }
                    }
                    if (bot == 2) 
                    {
                        Console.WriteLine("Opponent:" + op.dtext);
                        int magic = op.intl / 3;
                        op.def += magic;
                        Console.WriteLine("The " + op.name + "now has " + op.def + " defense.");

                    }
                    if (bot == 3)
                    {
                        Console.WriteLine("Opponent:" + op.itext);
                        int magic = op.intl / 3;
                        op.def += magic;
                        Console.WriteLine("The gods must be kind the " + op.name + " now has " + op.intl + " intelegence.");
                        ply.def -= 2;
                        Console.WriteLine("The " + ply.name + " is unerved, they now have " + ply.def + " defense.");


                    }



                
                
                if (ply.def < 0)
                {
                    ply.def = 0;
                }
                if (op.def < 0)
                {
                    op.def = 0;
                }
                if (ply.intl < 0)
                {
                    ply.intl = 0;
                }
                if (op.intl < 0)
                {
                    op.intl = 0;
                }
            }
            if (ply.hp < 0)
            {
                Console.WriteLine("You Win!");
            }
            if (op.hp < 0)
            {
                Console.WriteLine("You lost :(");
            }
        }
            static Mage choice(string entry)
            {
                string name = " ";
                string type = " ";
                int intl = 0;
                int pwr = 0;
                int def = 0;
                int hp = 0;
                string pmove = " ";
                string dmove = " ";
                string imove = " ";
                string ptext = " ";
                string dtext = " ";
                string itext = " ";


                switch (entry)
                {

                    case "a":
                        name = "Fire Mage";
                        type = "Fire";
                        intl = 5;
                        pwr = 9;
                        def = 3;
                        hp = 20;
                        pmove = "Spontanius Combustion";
                        dmove = "Ring of fire";
                        imove = "Meditate on the sun";
                        ptext = "The air in front of the mage explodes into fire!";
                        dtext = "A ring of fire devolps the user.";
                        itext = "The Mage applies sunscrean and begins to sunbath in order to gain power from the sun.;";

                        break;
                    case "b":
                        name = "Water Mage";
                        type = "Water";
                        intl = 9;
                        pwr = 6;
                        def = 5;
                        hp = 20;
                        pmove = "Water Cannon";
                        dmove = "Ice Sheild";
                        imove = "Rain Dance";
                        ptext = "The Mage shoots out a jet of water from their hand.";
                        dtext = "The Mage creates a shield of ice around them.";
                        itext = "The Mage begins to do a rain dance and rain begins to fall from the sky";
                        break;
                    case "c":
                        name = "Earth mage";
                        type = "Earth";
                        intl = 3;
                        pwr = 6;
                        def = 7;
                        hp = 20;
                        pmove = "Earth Punch";
                        dmove = "Obsidian Armour";
                        imove = "Tree Hug";
                        ptext = "The Mage turns his fist into stone and atacks";
                        dtext = "The Mage creates armour of obsidian over their skin";
                        itext = "The mage finds the nearest tree and begins hugging it to gain Mother Natures Favor";
                        break;
                    default:
                        name = "invalid";
                        type = "invalid";
                        intl = 0;
                        def = 0;
                        pwr = 0;
                        intl = 0;
                        hp = 0;
                        pmove = " ";
                        dmove = " ";
                        imove = " ";
                        ptext = " ";
                        dtext = " ";
                        itext = " ";
                        break;


                }
                Mage fakemage = new Mage();
                fakemage.name = name;
                fakemage.type = type;
                fakemage.intl = intl;
                fakemage.pwr = pwr;
                fakemage.def = def;
                fakemage.hp = hp;
                fakemage.pmove = pmove;
                fakemage.dmove = dmove;
                fakemage.imove = imove;
                fakemage.ptext = ptext;
                fakemage.dtext = dtext;
                fakemage.itext = itext;


                return fakemage;

            }
            static Mage rand(int num)
            {
                string name = " ";
                string type = " ";
                int intl = 0;
                int pwr = 0;
                int def = 0;
                int hp = 0;
                string pmove = " ";
                string dmove = " ";
                string imove = " ";
                string ptext = " ";
                string dtext = " ";
                string itext = " ";



                switch (num)
                {

                    case 1:
                        name = "Fire Mage";
                        type = "Fire";
                        intl = 5;
                        pwr = 9;
                        def = 3;
                        hp = 20;
                        pmove = "Spontanius Combustion";
                        dmove = "Ring of fire";
                        imove = "Meditate on the sun";
                        ptext = "The air in front of the mage explodes into fire!";
                        dtext = "A ring of fire devolps the user.";
                        itext = "The Mage applies sunscrean and begins to sunbath in order to gain power from the sun.;";

                        break;
                    case 2:
                        name = "Water Mage";
                        type = "Water";
                        intl = 9;
                        pwr = 6;
                        def = 5;
                        hp = 20;
                        pmove = "Water Cannon";
                        dmove = "Ice Sheild";
                        imove = "Rain Dance";
                        ptext = "The Mage shoots out a jet of water from their hand.";
                        dtext = "The Mage creates a shield of ice around them.";
                        itext = "The Mage begins to do a rain dance and rain begins to fall from the sky";
                        break;
                    case 3:
                        name = "Earth mage";
                        type = "Earth";
                        intl = 3;
                        pwr = 6;
                        def = 7;
                        hp = 20;
                        pmove = "Earth Punch";
                        dmove = "Obsidian Armour";
                        imove = "Tree Hug";
                        ptext = "The Mage turns his fist into stone and atacks";
                        dtext = "The Mage creates armour of obsidian over their skin";
                        itext = "The mage finds the nearest tree and begins hugging it to gain Mother Natures Favor";
                        break;
                    default:
                        name = "invalid";
                        type = "invalid";
                        intl = 0;
                        def = 0;
                        pwr = 0;
                        intl = 0;
                        hp = 0;
                        pmove = " ";
                        dmove = " ";
                        imove = " ";
                        ptext = " ";
                        dtext = " ";
                        itext = " ";
                        break;


                }
                Mage fakemage = new Mage();
                fakemage.name = name;
                fakemage.type = type;
                fakemage.intl = intl;
                fakemage.pwr = pwr;
                fakemage.def = def;
                fakemage.hp = hp;
                fakemage.pmove = pmove;
                fakemage.dmove = dmove;
                fakemage.imove = imove;
                fakemage.ptext = ptext;
                fakemage.dtext = dtext;
                fakemage.itext = itext;


                return fakemage;
            }
        
    }
}
