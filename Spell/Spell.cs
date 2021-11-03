using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spell //six classes and four of them are in an inheritance hierarchy
                //the weather magicians in the guild and their spells
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[4];

            Storm storm = new Storm("wind", false, "Zul'rajas", "Shadow");
            Console.WriteLine(storm.Announce());

            Pupil pupil = new Pupil("Mezil-kree", "Icecrown");
            storms[0] = pupil.CastWindStorm();

            Mage mage = new Mage("Gul’dan", "Draenor");
            storms[1] = mage.CastRainStorm();

            Archmage archmage = new Archmage("Nielas Aran", "Stormwind");
            storms[2] = archmage.CastRainStorm();
            storms[3] = archmage.CastLightningStorm();

            for (int i = 0; i < storms.Length; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }
            Console.ReadLine();
        }
    }

    class Storm : Spell
    {
        public Storm(string essence, bool isStrong, string caster, string origin)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
            Origin = origin;
        }
        public override string Announce()
        {
            if (IsStrong == true)
            {
                return $"{Caster} from {Origin} cast a strong {Essence} storm!\n";
            }
            else
            {
                return $"{Caster} from {Origin} cast a weak {Essence} storm!\n";
            }
        }
    }
    class Pupil : Spell
    {
        public Pupil(string title, string origin)
        {
            Title = title;
            Origin = origin;
        }
        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind", false, Title, Origin);
            return storm;
        }
        public override string Announce()
        {
            if (IsStrong == true)
            {
                return $"{Caster} from {Origin} cast a strong {Essence} storm!\n";
            }
            else
            {
                return $"{Caster} from {Origin} cast a weak {Essence} storm!\n";
            }
        }
    }

    class Mage : Pupil
    {
        public Mage(string title, string origin) : base(title, origin)
        {
        }

        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, Title, Origin);
            return storm;
        }
    }

    class Archmage : Mage
    {
        public Archmage(string title, string origin) : base(title, origin)
        {
        }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", true, Title, Origin);
            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning", true, Title, Origin);
            return storm;
        }
    }
    abstract class Spell
    {
        public string Essence
        { get; protected set; }

        public bool IsStrong
        { get; protected set; }

        public string Caster
        { get; protected set; }

        public string Origin
        { get; protected set; }

        public string Title
        { get; protected set; }

        public abstract string Announce();
    }
}
