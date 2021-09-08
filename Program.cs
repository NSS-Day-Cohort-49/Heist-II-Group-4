using System;
using System.Collections.Generic;

namespace HeistTeamFour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Hacker()
                {
                    Name = "Holly 'The Code Machine' Hacker",
                    SkillLevel = 37,
                    PercentageCut = 8
                },
                new Hacker()
                {
                    Name = "Ian",
                    SkillLevel = 100,
                    PercentageCut = 12
                },
                new LockSpecialist()
                {
                    Name = "Joe Shepherd",
                    SkillLevel = 71,
                    PercentageCut = 15
                },
                new LockSpecialist()
                {
                    Name = "Avery 'I'm not so' Noble",
                    SkillLevel = 60,
                    PercentageCut = 12
                },
                new Muscle()
                {
                    Name = "Liftin' Luke Madrazo",
                    SkillLevel = 65,
                    PercentageCut = 18
                }
            };
            Console.WriteLine($"Rolodex Total: {rolodex.Count}");
            Console.WriteLine("Enter a new crew member's name:");
            var teamMemberName = Console.ReadLine();
            Console.WriteLine($"Select a specialty for {teamMemberName}:");
            Console.WriteLine("1. Hacker (Disables alarms)");
            Console.WriteLine("2. Muscle (Disarms guards)");
            Console.WriteLine("3. Lock Specialist (cracks vault)");
            var teamMemberSpecialty = Console.ReadLine();
            var newTeamMember;
            
            switch (int.Parse(teamMemberSpecialty))
            {
                case 1: 
                    newTeamMember = new Hacker() {Name = $"{teamMemberName}"};
                    break;
                case 2: 
                    newTeamMember = new Muscle() {Name = $"{teamMemberName}"};
                    break;
                case 3: 
                    newTeamMember = new LockSpecialist() {Name = $"{teamMemberName}"};
                    break;
                default: 
                    Console.WriteLine("Please enter a number between 1 and 3!");
                    break;
            }
            Console.WriteLine($"{newTeamMember.Name}");
            // Console.WriteLine($"Select a  for {teamMemberName}:");
        }
    }
}
