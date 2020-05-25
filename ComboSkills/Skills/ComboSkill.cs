using System.Collections.Generic;

namespace ComboSkills.Skills
{
    public abstract class ComboSkill : Skill
    {
        public ComboSkill(double damage, string name) : base(damage, name) 
        {
            currentSkill = this;
            firstSkill = this;
            nextSkill = this;

            FirstSkillName = SkillName;
            LastSkillName = SkillName;
        }

        protected ComboSkill currentSkill { get; set; }
        protected ComboSkill firstSkill { get; set; }
        protected ComboSkill nextSkill { get; set; }
        public string FirstSkillName { get; set; }
        public string LastSkillName { get; set; }

        public void Combine(ComboSkill skill, List<Skill> list)
        {
            skill.nextSkill = firstSkill;

            currentSkill = skill.currentSkill;
            firstSkill = skill.firstSkill;
            nextSkill = firstSkill;            

            FirstSkillName = skill.FirstSkillName;

            list.Remove(skill);
        }

        public override void DoAttack()
        {
            currentSkill.DoThisAttack();
            currentSkill = currentSkill.nextSkill;
        }
    }
}
