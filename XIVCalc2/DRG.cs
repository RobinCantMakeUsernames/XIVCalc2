using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVCalc2
{
    class DRG 
    {
        public bool Positional { get; }
        public static double DoT(double duration, double initial, double tick)
        {
            double tickAmount = duration / 3;
            return initial + tick * tickAmount;
        }

        //GCDs
        public double TrueThrust { get; }
        public double VorpalThrust { get; }
        public double Disembowel { get; }
        public double HeavensThrust { get; }
        public double ChaoticSpring { get; }
        public double FangAndClaw { get; }
        public double WheelingThrust { get; }

        //oGCDs
        public double HighJump { get; }
        public double SpineShatterDive { get; }
        public double DragonFireDive { get; }
        public double MirageDive { get; }
        public double Gierskogel { get; }
        public double Nastrond { get; }
        public double StarDiver { get; }
        public double WyrmwindThrust { get; }

        //buffs
        public double LanceCharge { get; }
        public double DragonSight { get; }
        //public double BattleLitany { get; }
        public double PowerSurge { get; }
        public double EnhancedFCWT { get; }

        //constructor
        public DRG()
        {
            bool positional = true;
            Positional = positional;

            //GCDs
            double trueThrust = 230;
            double vorpalThrust = 280;
            double disembowel = 250;
            double heavensThrust = 480;
            double chaoticSpringInitial = 260;
            if (positional == true)
            { chaoticSpringInitial = 300; }
            double chaoticSpringDuration = 24;
            double chaoticSpringTick = 45;
            double chaoticSpring = DoT(chaoticSpringDuration, chaoticSpringInitial, chaoticSpringTick);
            double fangAndClaw = 260;
            if (positional == true)
            { fangAndClaw = 300; }
            double wheelingThrust = 260;
            if (positional == true)
            { wheelingThrust = 300; }

            //oGCDs
            double highJump = 400;
            double spineShatterDive = 250;
            double dragonFireDive = 300;
            double mirageDive = 200;
            double gierskogel = 260;
            double nastrond = 360;
            double starDiver = 620;
            double wyrmWindThrust = 420;

            //buffs
            double lanceCharge = 1.1;
            double dragonSight = 1.1;
            //double battleLitany = dont try it;
            double powerSurge = 1.1;
            double enhancedFCWT = 110;


            TrueThrust = trueThrust;
            VorpalThrust = vorpalThrust;
            Disembowel = disembowel;
            HeavensThrust = heavensThrust;
            ChaoticSpring = chaoticSpring;
            FangAndClaw = fangAndClaw;
            WheelingThrust = wheelingThrust;
            HighJump = highJump;
            SpineShatterDive = spineShatterDive;
            DragonFireDive = dragonFireDive;
            MirageDive = mirageDive;
            Gierskogel = gierskogel;
            Nastrond = nastrond;
            StarDiver = starDiver;
            WyrmwindThrust = wyrmWindThrust;
            LanceCharge = lanceCharge;
            DragonSight = dragonSight;
            //BattleLitany = battleLitany;
            PowerSurge = powerSurge;
            EnhancedFCWT = enhancedFCWT;
        }
    }
}
