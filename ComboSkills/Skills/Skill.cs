namespace ComboSkills.Skills
{
    public abstract class Skill
    {
        public Skill(double damage, string name)
        {
            this.damage = damage;
            SkillName = name;
        }

        protected double damage;
        protected string attackMessage => $"do {damage} points of damage.";

        public string SkillName { get; }

        public virtual void DoAttack()
        {
            DoThisAttack();
        }

        protected abstract void DoThisAttack();

        public override string ToString()
        {
            return SkillName;
        }
    }
}
