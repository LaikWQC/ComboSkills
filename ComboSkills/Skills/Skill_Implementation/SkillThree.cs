using System;

namespace ComboSkills.Skills.Skill_Implementation
{
    public class SkillThree : ComboSkill
    {
        public SkillThree(double damage, string name) : base(damage, name) { }

        protected override void AttackAction()
        {
            Console.WriteLine($"Use (3){SkillName}: {attackMessage}");
        }
    }
}
