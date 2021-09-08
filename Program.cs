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

            int teamMemberSpecialty = int.Parse(Console.ReadLine());
            while(teamMemberSpecialty != 1 && teamMemberSpecialty != 2 && teamMemberSpecialty != 3)
            {
                Console.WriteLine("You must enter a selection between 1 - 3");
                teamMemberSpecialty = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {teamMemberName}'s Skill Level between 1 - 100");
            int teamMemberSkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose a percentage of the take");
            int teamMemberPercentage = int.Parse(Console.ReadLine());

            IRobber newTeamMember = CreateTeamMember(teamMemberSpecialty);
            rolodex.Add(newTeamMember);
            IRobber CreateTeamMember(int classChoice)
            {
                
                if (classChoice == 1)
                {
                    Hacker teamMember = new Hacker() 
                    {Name = teamMemberName, SkillLevel = teamMemberSkillLevel, PercentageCut = teamMemberPercentage};
                    return teamMember;
                }
                if (classChoice == 2)
                {
                    Muscle teamMember = new Muscle() 
                    {Name = teamMemberName, SkillLevel = teamMemberSkillLevel, PercentageCut = teamMemberPercentage};
                    return teamMember;
                }
                else
                {
                    LockSpecialist teamMember = new LockSpecialist() 
                    {Name = teamMemberName, SkillLevel = teamMemberSkillLevel, PercentageCut = teamMemberPercentage};
                    return teamMember;
                }
            }
        }
    }
}
