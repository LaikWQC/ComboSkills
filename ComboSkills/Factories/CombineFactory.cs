using System.Collections.Generic;
using System.Linq;
using ComboSkills.Skills;
using ComboSkills.Enums;

namespace ComboSkills.Factories
{
    public static class CombineFactory
    {
        public static void Combine(string first, string next, List<Skill> list)
        {
            var comboList = list.Select(x => x as ComboSkill).Where(x => x != null).ToList();

            var comboFirst = comboList.FirstOrDefault(x => x.LastSkillName == first);
            if (comboFirst == null) return;

            var comboSecond = comboList.FirstOrDefault(x => x.FirstSkillName == next);
            if (comboSecond == null) return;

            comboSecond.Combine(comboFirst, list);
        }

        public static void Combine(Skill first, Skill next, List<Skill> list)
        {
            Combine(first.SkillName, next.SkillName, list);
        }

        /// <summary>
        /// Индекс начинается с 1
        /// </summary>
        public static void Combine(int first, int next, List<Skill> list)
        {
            if (first > list.Count || next > list.Count) return;
            Combine(list[--first].SkillName, list[--next].SkillName, list);
        }

        public static void Combine(CombineType type, List<Skill> list)
        {
            switch(type)
            {
                case CombineType.SliceAndDice:
                    Combine("Slice", "Dice", list);
                    break;
                case CombineType.DiceAndFinish:
                    Combine("Dice", "And finish this!", list);
                    break;
            }
        }
    }
}
