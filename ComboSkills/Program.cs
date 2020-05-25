using ComboSkills.Enums;
using ComboSkills.Factories;
using ComboSkills.Skills;
using System;
using System.Collections.Generic;

namespace ComboSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            var skills = new List<Skill>();
            skills.Add(SkillFactory.CreateSkill(SkillType.SkillOne));
            skills.Add(SkillFactory.CreateSkill(SkillType.SkillTwo));
            skills.Add(SkillFactory.CreateSkill(SkillType.SkillThree));
            skills.Add(SkillFactory.CreateSkill(SkillType.SkillFour));

            Console.WriteLine($"There is {skills.Count} starting skills:");
            foreach (var skill in skills)
            {
                Console.WriteLine(skill.SkillName); 
            }

            CombineFactory.Combine(CombineType.SliceAndDice, skills);
            CombineFactory.Combine(CombineType.DiceAndFinish, skills);

            Console.WriteLine($"\nAfter combine there is {skills.Count} skills:\n");

            foreach(var skill in skills)
            {
                for (int i = 0; i < 5; i++) 
                {
                    skill.DoAttack();
                }
                Console.WriteLine();
            }
        }
    }
}
