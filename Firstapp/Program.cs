using System;
using System.Linq;
using System.Threading;

class Torony
{
    private int[] kezdoallapot;
    private int[] celallapot ;
    public Torony(int[] kezdo, int[] cel)
    {
        this.kezdoallapot = kezdo;
        this.celallapot = cel;
    }

    public bool celteszt(int[] allapot)
    {   
        return allapot.SequenceEqual(celallapot);
    }
    public void rakovetkezo()
    {
        bool LOOP = true;
        while (LOOP)
        {
            if (this.kezdoallapot.SequenceEqual(this.celallapot))
            {
                Console.WriteLine("A celallapot elerve: "+string.Join(",", this.kezdoallapot) +" "+string.Join(", ",this.celallapot));
                LOOP = false;
            }
            else
            {
                
                if (this.kezdoallapot[0] < this.kezdoallapot[1])
                {
                    Console.WriteLine("csocs");
                    int novekvonek = 0;    
                    for (int i = 0; i < this.kezdoallapot.Length-1; i++)
                    {
                        novekvonek++;
                        if (this.kezdoallapot[i] > this.kezdoallapot[i+1])
                        {
                            break;
                        }
                    }
                    int []tmp = new int[novekvonek];
                    for (int i = 0; i < novekvonek; i++)
                    {
                        tmp[i] = this.kezdoallapot[i];
                    }
                    Array.Reverse(tmp);
                    for (int i = 0; i < novekvonek; i++)
                    {
                        this.kezdoallapot[i] = tmp[i];
                    }
                    Console.WriteLine(string.Join(", ", this.kezdoallapot));
                    //Thread.Sleep(500);

                }
                else
                {
                    Console.WriteLine("kutya");
                    int csokkenonek = 0;
                    for (int i = 0; i < this.kezdoallapot.Length-1; i++)
                    {
                        csokkenonek++;
                        if (this.kezdoallapot[i] < this.kezdoallapot[i + 1])
                        {
                           
                            break;
                        }
                        else
                        {
                             if (this.kezdoallapot.SequenceEqual(new int[] { 8,7,6,5,4,3,2,1 }))
                            {
                                //this.kezdoallapot[0] == 8 && this.kezdoallapot[1] == 7 && this.kezdoallapot[2] == 6 && this.kezdoallapot[3] == 5 && this.kezdoallapot[4] == 4 && this.kezdoallapot[5] == 3 && this.kezdoallapot[6] == 2 && this.kezdoallapot[7] == 1
                                Console.WriteLine("vege");
                                Array.Reverse(this.kezdoallapot);
                                Console.WriteLine(string.Join(", ", this.kezdoallapot));
                                LOOP = false;
                                return;
                            }
                        }

                    }
                     int []tmp = new int[csokkenonek];
                    for (int i = 0; i < csokkenonek; i++)
                    {
                        tmp[i] = this.kezdoallapot[i];
                    }
                    Array.Reverse(tmp);
                     for (int i = 0; i < csokkenonek; i++)
                    {
                        this.kezdoallapot[i] = tmp[i];
                    }
                    int []tmp2 = new int[csokkenonek+1];
                    for (int i = 0; i < csokkenonek+1; i++)
                    {
                            tmp2[i] = this.kezdoallapot[i];

                    }
                    Array.Reverse(tmp2);
                    for (int i = 0; i < csokkenonek+1; i++)
                    {
                            this.kezdoallapot[i] = tmp2[i];

                    }
                    Console.WriteLine(string.Join(", ", this.kezdoallapot));
                    //Thread.Sleep(500);
                }
                
            }

        }
    }


}

class Program
{
    static void Main(string[] args)
    {
        int[] kezdo = {6,7,3,2,8,5,4,1};
        int[] cel = {1,2,3,4,5,6,7,8};
        Console.WriteLine($"Kezdo allapot: "+string.Join(", ",kezdo)+" Celallapot: "+string.Join(", ",cel));
        Torony tower = new Torony(kezdo,cel);
        tower.rakovetkezo();

    }

}

    