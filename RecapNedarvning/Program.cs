using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    class Program
    {
        static void Main(string[] args)
        {


            var bilListe = new List<Bil>();
            bilListe.Add(new Dieselbil(5000, 2014, "Ford","DB 22331", 20, 30));
            bilListe.Add(new Dieselbil(15000, 2015,"Ford", "DB 24331", 28, 40));
            bilListe.Add(new Dieselbil(280000, 2015, "Fiat", "DB 92331", 17, 50));
            bilListe.Add(new Dieselbil(35000, 2016, "BMW", "DB 32111", 12, 70, false));
            bilListe.Add(new Dieselbil(81400, 2012, "VW", "DB 77231", 17, 60, false));

            bilListe.Add(new BenzinBil(30000, 2016, "Fiat", "BB 21131", 15, 40));
            bilListe.Add(new BenzinBil(150000, 2014, "Seat", "BB 23569", 17, 30));
            bilListe.Add(new BenzinBil(39000, 2015, "Audi", "BB 21444", 12, 80));
            bilListe.Add(new BenzinBil(400000, 2016, "Ford", "BB 23331", 11, 50));
            bilListe.Add(new BenzinBil(120000, 2016, "BMW", "BB 19931", 48, 25));

            bilListe.Add(new ElBil(200000, 2015, "VW", "EB 11111", 10, 50));
            bilListe.Add(new ElBil(200000, 2015, "Nissan", "ELBIL", 13, 50));
            bilListe.Add(new ElBil(200000, 2015, "Tesla", "1", 9, 30));
            bilListe.Add(new ElBil(200000, 2016, "Renault", "EB 2", 12, 30));
            bilListe.Add(new ElBil(200000, 2016, "Ellert", "EB 31233", 16, 20));


            int tæller =0;

            foreach (var bil in bilListe)
            {
                tæller++;
                Console.WriteLine("Bil nr : " + tæller);
                if (bil is Dieselbil)
                {
                    var dBil = bil as Dieselbil;
                    Console.WriteLine("Det er en dieselbil");
                    Console.WriteLine($"--{dBil.ToString()}" );
                }
                else if (bil is BenzinBil)
                {
                    var bBil = bil as BenzinBil;
                    Console.WriteLine("Det er en benzinbil");
                    Console.WriteLine($"--{bBil.ToString()} ");
                }
                else if (bil is ElBil)
                {
                    var eBil = bil as ElBil;
                    Console.WriteLine("Det er en elbil");
                    Console.WriteLine($"--{eBil.ToString()}");
                }

                if (bil is IElMotor)
                {
                    var elMotor = bil as IElMotor;
                    Console.WriteLine("Bilen har Elmotor");
                    Console.WriteLine("Ladetiden er : " + elMotor.LadeTid());
                }
                Console.WriteLine("--------------");

            }

            Console.ReadLine();
        }
    }
}
