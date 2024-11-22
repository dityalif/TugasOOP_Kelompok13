namespace GameDev
{
    class Enemy
    {
        public string Department { get; private set; }
        public string Username { get; private set; }
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public int Points { get; private set; }
        public Dictionary<string, int> Skills { get; private set; }

        public Enemy(string department, string username)
        {
            Department = department;
            Username = username;
            Health = 100;
            Energy = 100;
            Points = 0;
            Skills = new Dictionary<string, int>();
        }

        public void Battle(Enemy opponent)
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

        public void Attack(Enemy opponent)
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
            Console.WriteLine($"Username: {Username}");
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