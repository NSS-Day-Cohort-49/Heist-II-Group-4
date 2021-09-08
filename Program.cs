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
        }
    }
}
