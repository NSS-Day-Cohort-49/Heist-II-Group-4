using System;
using System.Collections.Generic;
using System.Linq;

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
            while(true)
            {
                Console.WriteLine("Enter a new crew member's name:");
                string teamMemberName = Console.ReadLine();
                if (teamMemberName == "")
                {
                    break;
                }
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
                int teamMemberSkillLevel = 0;
                while(teamMemberSkillLevel == 0)
                {
                    try
                    {
                        teamMemberSkillLevel = int.Parse(Console.ReadLine());
                        if (teamMemberSkillLevel < 1 || teamMemberSkillLevel > 100)
                        {
                            Console.WriteLine("You must enter a value between 1 and 100:");
                            teamMemberSkillLevel = 0;
                        }
                    }
                    catch (FormatException)
                    {   
                        Console.WriteLine("You must enter a value between 1 and 100:");
                    }
                }

                Console.WriteLine("Please choose a percentage of the take");
                int teamMemberPercentage = 0;
                while(teamMemberPercentage == 0)
                {
                    try
                    {
                        teamMemberPercentage = int.Parse(Console.ReadLine());
                        if (teamMemberPercentage < 1 || teamMemberPercentage > 100)
                        {
                            Console.WriteLine("You must enter a value between 1 and 100:");
                            teamMemberPercentage = 0;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You must enter a value between 1 and 100:");
                    }
                }

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
            Random random = new Random();
            Bank BankofAmerica = new Bank() 
            {AlarmScore = random.Next(0, 101), 
            VaultScore = random.Next(0, 101), 
            SecurityGuardScore = random.Next(0, 101), 
            CashOnHand = random.Next(50000, 1000000)
            };
            Console.WriteLine($"AlarmScore for new Bank: {BankofAmerica.AlarmScore}");
            Console.WriteLine($"VaultScore for new Bank: {BankofAmerica.VaultScore}");
            Console.WriteLine($"SecurityGuardScore for new Bank: {BankofAmerica.SecurityGuardScore}");
            Console.WriteLine($"CashOnHand for new Bank: {BankofAmerica.CashOnHand}");
            ReconReport(BankofAmerica);

            void ReconReport(Bank bank)
            {
                
                List<int> bankProperties = new List<int>
                {
                    bank.AlarmScore,
                    bank.VaultScore,
                    bank.SecurityGuardScore
                };

                if(bankProperties.Max() == bank.AlarmScore)
                {
                    Console.WriteLine("The AlarmScore is the most secure!");
                }
                else if (bankProperties.Max() == bank.VaultScore)
                {
                    Console.WriteLine("The VaultScore is the most secure!");
                }
                else 
                {
                    Console.WriteLine("The SecurityGuardScore is the most secure!");
                }

                
                if(bankProperties.Min() == bank.AlarmScore)
                {
                    Console.WriteLine("The AlarmScore is the least secure!");
                }
                else if (bankProperties.Min() == bank.VaultScore)
                {
                    Console.WriteLine("The VaultScore is the least secure!");
                }
                else 
                {
                    Console.WriteLine("The SecurityGuardScore is the least secure!");
                }

            }


        }
    }
}
