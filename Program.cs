using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PR_kedua
{
    class Ban
    {
        public string merk;

        public Ban(string Merk)
        {
            this.merk = Merk;
        }
    }

    class Michelin : Ban
    {
        public Michelin() : base("Michelin")
        {
        }
    }

    class Bridgestone : Ban
    {
        public Bridgestone(): base("Bridgestone")
        {
        }
    }

    class Mobil
    {
        public string merk;
        public string tipe;
        public Ban ban;

        public Mobil(string merk, string tipe, Ban ban)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.ban = ban;
        }
        public virtual void NyalakanMesin()
        {
            Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} menyala");
        }

        public virtual void MatikanMesin()
        {
            Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} mati");
        }
    }

    class Toyota : Mobil
    {
        public Toyota(string tipe, Ban ban) : base("Toyota", tipe, ban)
        {
        }
    }

    class Daihatsu : Mobil
    {
        public Daihatsu(string tipe, Ban ban) : base("Daihatsu", tipe, ban)
        {
        }
    }

    class Honda : Mobil
    {
        public Honda(string tipe, Ban ban) : base("Honda", tipe, ban)
        {
        }
    }

    class Agya : Toyota
    {
        public Agya(Ban ban) : base("Agya", ban)
        {
        }
    }

    class Avanza : Toyota
    {
        public Avanza(Ban ban) : base("Avanza", ban)
        {
        }

        public void NyalakanLampu()
        {
            Console.WriteLine($"Lampu mobil {this.merk} bertipe {this.tipe} menyala");
        }
    }

    class Innova : Toyota
    {
        public Innova(Ban ban) : base("Innova", ban)
        {
        }
    }

    class Ayla : Daihatsu
    {
        public Ayla(Ban ban) : base("Ayla", ban)
        {
        }
    }

    class Xenia : Daihatsu
    {
        public Xenia(Ban ban) : base("Xenia", ban)
        {
        }
    }

    class Brio : Honda
    {
        public Brio(Ban ban) : base("Brio", ban)
        {
        }
    }

    class Civic : Honda
    {
        public Civic(Ban ban) : base("Civic", ban)
        {
        }

        public void VtecKickedIn()
        {
            Console.WriteLine($"Ngeeeng Wooosh!!!");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Ban ban1 = new Michelin();
            Mobil mobil1 = new Agya(ban1);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();

            Ban ban2 = new Bridgestone();
            Mobil mobil2 = new Avanza(ban2);
            ((Avanza)mobil2).NyalakanLampu();

            Console.WriteLine(" ");
            Console.WriteLine(mobil1.ban);

            Civic civic1 = new Civic(ban2);
            civic1.VtecKickedIn();

            Honda honda1 = civic1;
            ((Civic)honda1).VtecKickedIn();

        }
    }
}

