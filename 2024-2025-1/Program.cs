#region 6. Feladat
//6. feladat
var tanulas = new int[][] 
{
    new int[] { 10,20,0,10,140,30,60},
    new int[] { 70,100,10,20,50,40,50},
    new int[] { 90,110,30,40,50,40,20},
    new int[] { 0,120,100,60,50,0,110}
};

//Írassuk ki az adatokat táblázatosan
for (int het = 0; het<4; het++) {
    for (int nap = 0; nap<7; nap++) {
        Console.Write(tanulas[het][nap] + " ");
    }
    Console.WriteLine();
}

//Írassuk ki egy bekért hétszámot, s megkapott hétre elvégzi az összegzést!
Console.Write("Adj meg egy hétszámot (1-4):");
var hetszamszoveg = Console.ReadLine();
Console.WriteLine("Ezt a számot adtad meg:" + hetszamszoveg);
var hetszam = Convert.ToInt32(hetszamszoveg);
var osszeg = 0;
for (int i = 0; i < 7; i++) {
    osszeg = osszeg + tanulas[hetszam-1][i];
}
Console.WriteLine("Azon a héten ennyit tanultál:" + osszeg);

//Kérjünk be egy napnevet,s a megkapott napra kiszámolja az átlagos pontszámot!
Console.Write("Adj meg egy napot:");
var napszam = 0;
var napszamszoveg = Console.ReadLine();
if (napszamszoveg == "hétfő") napszam = 0;
if (napszamszoveg == "kedd") napszam = 1;
// és így tovább
Console.WriteLine("Ezt a napot adtad meg:" + napszamszoveg);
int osszes = 0;
double atlag = 0;
for (int i = 0; i < 4; i++) {
    osszes = osszes + tanulas[i][napszam];
}
atlag = osszes / 4.0;
Console.WriteLine("Ez az adott napon a pontátlag:" + atlag);

//Írassuk ki, hogy hánya olyan nap volt, amikor nem tanult!
int db = 0;
for(int i = 0; i<4;i++)
{
    for(int j = 0; j<7; j++)
    {
        if(tanulas[i][j] == 0)
        {
            db++;
        }
    }
}
Console.WriteLine($"{db} napon nem tanultál.");

//Írassuk ki, hogy melyik héten olvasott legtöbbet!
var legtobb = 0;
int index = 0;
for (int i = 0; i < 4; i++) {
    var osszpontegyheten = 0;
    for(int j = 0; j < 7 ;j++){
        osszpontegyheten = osszpontegyheten + tanulas[i][j];
    }
    if (osszpontegyheten > legtobb ) {
        legtobb = osszpontegyheten;
        index = i;
    }
}
Console.WriteLine("Ennyit tanultál a legtöbbet egy héten:" + legtobb);
Console.WriteLine("Ezen a héten olvastál a legtöbbet:" + index);
#endregion

#region 7. feladat
static bool osszeadasEllenorzese(int a, int b, int eredmeny)
{
    if(a+b==eredmeny)
    {
        return true;
    }
    else{
        return false;
    }
}


bool jo = osszeadasEllenorzese(2,3,5);

static void henger(int sugar, int magassag, out double terfogat, out double felszin) {
    terfogat = sugar * sugar * Math.PI * magassag;
    felszin = sugar * sugar * Math.PI * 2 + 2 * sugar * Math.PI * magassag;
}

static VisszateresiErtek hengerSzep(int sugar, int magassag) {
    double terfogat = sugar * sugar * Math.PI * magassag;
    double felszin = sugar * sugar * Math.PI * 2 + 2 * sugar * Math.PI * magassag;
    return new VisszateresiErtek(terfogat, felszin);
}

static (double, double) hengerMegSzebb(int sugar, int magassag) {
    double terfogat = sugar * sugar * Math.PI * magassag;
    double felszin = sugar * sugar * Math.PI * 2 + 2 * sugar * Math.PI * magassag;
    return (terfogat, felszin);
}

double t1;
double f1;
// henger(2,4,out t1, out f1);
// Console.WriteLine(t1 + " " + f1);
(t1, f1) = hengerMegSzebb(2,4);
Console.WriteLine(t1 + " " + f1);
#endregion

public class VisszateresiErtek {
    public VisszateresiErtek(double terfogat, double felszin)
    {
        this.terfogat = terfogat;
        this.felszin = felszin;
    }
    public double terfogat;
    public double felszin;
}
