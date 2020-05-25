using System;

namespace ComboSkills.Skills.Skill_Implementation
{
    public class SkillOne : Skill
    {
        public SkillOne(double damage, string name) : base(damage, name) { }
        
        protected override void DoThisAttack()
        {
            Console.WriteLine($"Use (1){SkillName}: {attackMessage}");
        }
    }
}
