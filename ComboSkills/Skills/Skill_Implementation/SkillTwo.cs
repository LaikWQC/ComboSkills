using System;

namespace ComboSkills.Skills.Skill_Implementation
{
    public class SkillTwo : ComboSkill
    {
        public SkillTwo(double damage, string name) : base(damage, name) { }

        protected override void DoThisAttack()
        {
            Console.WriteLine($"Use (2){SkillName}: {attackMessage}");
        }
    }
}
