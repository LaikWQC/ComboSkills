using ComboSkills.Enums;
using ComboSkills.Skills;
using ComboSkills.Skills.Skill_Implementation;

namespace ComboSkills.Factories
{
    public static class SkillFactory
    {
        public static Skill CreateSkill(SkillType type)
        {
            switch(type)
            {
                case SkillType.SkillOne:
                    return new SkillOne(12, "BowAttack");
                case SkillType.SkillTwo:
                    return new SkillTwo(10, "Slice");
                case SkillType.SkillThree:
                    return new SkillThree(15, "Dice");
                case SkillType.SkillFour:
                    return new SkillFour(20, "And finish this!");
                default:
                    return null;
            }
        }
    }
}
