using System;

namespace ComboSkills.Skills.Skill_Implementation
{
    public class SkillFour : ComboSkill
    {
        public SkillFour(double damage, string name) : base(damage, name) { }

        protected override void DoThisAttack()
        {
            Console.WriteLine($"Use (4){SkillName}: {attackMessage}");
        }
    }
}
