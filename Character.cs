
namespace GameDev
{
    class Character
    {
        public string Department { get; private set; }
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public int Points { get; private set; }

        public Character(string department)
        {
            Department = department;
            Health = 100;
            Energy = 100;
            Points = 0;
        }

        public void Battle(Character opponent)
        {
            // Battle logic here
        }

        public void Upgrade()
        {
            // Upgrade logic here
        }
    }
}