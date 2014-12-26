using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarutoCore.Game
{
    public class CharacterStats
    {
        //Base stats

        /// <summary>
        /// Increases P.ATK (1:1) and P.DEF
        /// </summary>
        public int Force { get; set; }

        /// <summary>
        /// Increases HP
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Increases Strategy.ATK  (1:1) and Strategy.DEF, Healing done (mainly used on supports and genjutsu users)
        /// </summary>
        public int Chakra { get; set; }

        /// <summary>
        /// Increases speed (1:1)
        /// </summary>
        public int Agility { get; set; }

        //primary stats

        /// <summary>
        /// Amount of health you have
        /// </summary>
        public int Hp { get; set; }

        /// <summary>
        /// Physical dmg done by Ninjutsu, Taijutsu and Great Jutsu characters
        /// </summary>
        public int PhysicAtk { get; set; }

        /// <summary>
        /// Reduces physical damage taken
        /// </summary>
        public int PhysicDef { get; set; }

        /// <summary>
        /// Determines your character speed (most useful in arena, as the player with bigger speed attacks first!)
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Extra damage(6 piece of set gives extra damage rate) (Shadow fang and higher ranks increase with 2% more each rank up) 
        /// </summary>
        public int DamageRate { get; set; }

        /// <summary>
        /// Reduces damage taken from strategy attacks (from support and genjutsu users)
        /// </summary>
        public int StrategyDef { get; set; }

        /// <summary>
        /// Damage done by genjutsu characters
        /// </summary>
        public int StrategyAtk { get; set; }

        //second stats

        /// <summary>
        /// Prevents enemy from dodging.
        /// </summary>
        public int HitRate { get; set; }

        /// <summary>
        /// Critical hits do 1.5 times(150%) the normal damage.
        /// </summary>
        public int CritRate { get; set; }

        /// <summary>
        /// Anti block; prevent from getting blocked.
        /// </summary>
        public int SAtkRate { get; set; }

        /// <summary>
        /// Punch rate is a modifier which gives you the 'extra rounds' enhancement. On the following round of combat,
        ///the ninja with the 'extra rounds' enhancement will attack with a attack depend on his fury (normal or ult) round following their initial attack.
        /// </summary>
        public int PunchRate { get; set; }

        /// <summary>
        /// Dodge attack = No damage taken and no rage(Fury*) gained by enemy. But if dodge ult hit with debuff, it land on you.
        /// </summary>
        public int DodgeRate { get; set; }

        /// <summary>
        /// Anti-critical, lowers the chances of being hit with crits.
        /// </summary>
        public int CounterRate { get; set; }

        /// <summary>
        /// Blocks attack = Less damage is taken and counters back(does damage back to attacker).
        /// </summary>
        public int BlockRate { get; set; }

        /// <summary>
        /// Aid is a modifier which has two separate, beneficial functions.
        ///The first function is it causes the ninjas to receive increases to beneficial spells, be they enhancements, or heals.
        ///The second function is that any damage taken by a ninja with 100% aid rate will be spread equally among the ninjas in the formation.
        ///The largest benefit of this is to spread damage that would be done solely to your assaulters to all ninjas, and will allow your healer to mitigate some damage through healing the vanguard.
        /// </summary>
        public int AidRate { get; set; }

        /// <summary>
        /// Increases amount cured. Total Cure = (DMG Rate+Recovery Rate)*Attack*FuryBonus*CritBonus(if proc)
        /// </summary>
        public int RecoveryRate { get; set; }

        /// <summary>
        /// *Fury is called Rage in the game.
        ///Whenever you have 100 points, your ninja will use their special ability.

        ///Each fury point above 100 = +0.25% base fury damage
        ///The stronger the growth rate is the more powerful the fury boost is
        ///Critical hits are calculated afterwards
        ///One crit from a ninja rewards him with 100 fury instead of 50
        ///Fury boost can crit also (45 bonus instead of 30 for Haku)
        ///You will not gain any fury point if your target dodged your normal attack.
        ///Example with Naruto (235% growth rate):
        ///Base damage:	20057 / 30086 critical
        ///100 fury:	47136 / 70704 critical
        ///110 fury:	48315 / 72473 critical
        ///130 fury:	50671 / 76007 critical
        ///180 fury:	56563 / 84845 critical
        ///195 fury:	58331 / 87496 critical
        /// </summary>
        public int Fury { get; set; }
    }
}

