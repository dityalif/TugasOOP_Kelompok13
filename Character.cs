namespace GameDev
{
    class Character
    {
        public string Department { get; private set; }
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public int Points { get; private set; }
        public Dictionary<string, int> Skills { get; private set; }

        public Character(string department)
        {
            Department = department;
            Health = 100;
            Energy = 100;
            Points = 0;
            Skills = new Dictionary<string, int>();
        }

        public void Battle(Character opponent)
        {
            // Battle logic here
        }

        public void AddSkill(string skillName)
        {
            if (!Skills.ContainsKey(skillName))
            {
                Skills[skillName] = 1; // Initial skill level
            }
        }

        public void Attack(Character opponent)
        {
            // Basic attack logic
            int damage = 10; // Example damage value
            opponent.Health -= damage;
        }

        public void UpgradeSkill(string skillName)
        {
            if (Skills.ContainsKey(skillName))
            {
                Skills[skillName]++;
            }
        }

        public void Upgrade()
        {
            // Upgrade logic here
            Health += 10;
            Energy += 10;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Points: {Points}");
            Console.WriteLine("Skills:");
            foreach (var skill in Skills)
            {
                Console.WriteLine($"- {skill.Key}: Level {skill.Value}");
            }
        }
    }
}