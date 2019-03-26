using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    class Names
    {
        // Our corpus of first names. These are the 100 most common boys and girls names in England and Wales during 2017
        // See https://www.ons.gov.uk/peoplepopulationandcommunity/birthsdeathsandmarriages/livebirths/bulletins/babynamesenglandandwales/2017
        private static String[] firstnames = {"Abigail","Adam","Aisha","Albert","Albie","Alex","Alexander","Alfie","Alice","Amber","Amelia","Amelie","Anna","Annabelle","Arabella","Archie","Aria","Arlo","Arthur","Aurora","Austin","Ava","Beatrice","Bella","Benjamin","Blake","Bobby","Bonnie","Caleb","Carter","Charles","Charlie","Charlotte","Chloe","Clara","Daisy","Daniel","Darcey","Darcie","Darcy","David","Dexter","Dylan","Edith","Edward","Eleanor","Elijah","Eliza","Elizabeth","Ella","Ellie","Elliot","Elliott","Ellis","Elsie","Emilia","Emily","Emma","Erin","Esme","Ethan","Eva","Evelyn","Evie","Ezra","Felix","Finley","Finn","Florence","Francesca","Frankie","Freddie","Frederick","Freya","Gabriel","George","Georgia","Grace","Gracie","Hallie","Hannah","Harley","Harper","Harriet","Harrison","Harry","Harvey","Heidi","Henry","Holly","Hugo","Hunter","Ibrahim","Imogen","Iris","Isaac","Isabella","Isabelle","Isla","Ivy","Jack","Jackson","Jacob","Jake","James","Jasmine","Jaxon","Jayden","Jenson","Jesse","Jessica","Joseph","Joshua","Jude","Julia","Kai","Layla","Leah","Leo","Leon","Lewis","Liam","Lilly","Lily","Logan","Lola","Lottie","Louie","Louis","Luca","Lucas","Lucy","Luke","Luna","Lyla","Maisie","Maria","Martha","Maryam","Mason","Matilda","Matthew","Max","Maya","Megan","Mia","Michael","Mila","Millie","Mohammad","Mohammed","Molly","Muhammad","Nancy","Nathan","Noah","Oliver","Olivia","Ollie","Orla","Oscar","Penelope","Phoebe","Poppy","Ralph","Reggie","Reuben","Riley","Robyn","Roman","Ronnie","Rory","Rose","Rosie","Ruby","Ryan","Samuel","Sara","Scarlett","Sebastian","Sienna","Sofia","Sophia","Sophie","Stanley","Summer","Teddy","Thea","Theo","Theodore","Thomas","Toby","Tommy","Tyler","Victoria","Violet","William","Willow","Zachary","Zara"};

        // Our corpus of last names. These are the 100 most common surnames in the UK
        // See https://www.rootschat.com/forum/index.php?topic=239340.0
        private static String[] lastnames = { "Smith", "Jones", "Williams", "Taylor", "Brown", "Davies", "Evans", "Wilson", "Thomas", "Johnson", "Roberts", "Robinson", "Thompson", "Wright", "Walker", "White", "Edwards", "Hughes", "Green", "Hall", "Lewis", "Harris", "Clarke", "Patel", "Jackson", "Wood", "Turner", "Martin", "Cooper", "Hill", "Ward", "Morris", "Moore", "Clark", "Lee", "King", "Baker", "Harrison", "Morgan", "Allen", "James", "Scott", "Phillips", "Watson", "Davis", "Parker", "Price", "Bennett", "Young", "Griffiths", "Mitchell", "Kelly", "Cook", "Carter", "Richardson", "Bailey", "Collins", "Bell", "Shaw", "Murphy", "Miller", "Cox", "Richards", "Khan", "Marshall", "Anderson", "Simpson", "Ellis", "Adams", "Singh", "Begum", "Wilkinson", "Foster", "Chapman", "Powell", "Webb", "Rogers", "Gray", "Mason", "Ali", "Hunt", "Hussain", "Campbell", "Matthews", "Owen", "Palmer", "Holmes", "Mills", "Barnes", "Knight", "Lloyd", "Butler", "Russell", "Barker", "Fisher", "Stevens", "Jenkins", "Murray", "Dixon", "Harvey" };

        // Create our random generator
        private Random random;

        public Names(int seed = 0)
        {
            random = new Random(seed);
        }

        public String Generate() { 
            // Generate a new name
            String first = Names.firstnames[random.Next(0,Names.firstnames.Length)];
            String last = Names.lastnames[random.Next(0, Names.lastnames.Length)];

            // Return the name
            return first + " " + last;
        }
    }
}
