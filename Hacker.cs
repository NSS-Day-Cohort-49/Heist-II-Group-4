using System;

namespace HeistTeamFour
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Specialty { get; } = "Hacker"; 

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= 50;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security 50 points");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}