using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottoGUI
{
    public partial class Form1 : Form
    {
        int[,] jatek = new int[60, 6];
        string[] fajlbol = File.ReadAllLines("lotto52.txt");//összes sor beolvasása egy tömbbe
        int[] szamokdb = new int[100];
        int sorokszama = 0;
        int i, j, k;
        private void adatokbetoltese()
        {
            sorokszama = 0;
            for ( k = 0; k < fajlbol.Count(); k++)
            {
                string[] egysordarabolva = fajlbol[k].Split(' ');
                for ( i = 0; i < 5; i++)
                {
                    jatek[sorokszama, i] = Convert.ToInt32(egysordarabolva[i]);
                }
                sorokszama++;
            }
            for ( i = 0; i < sorokszama; i++)
            {
                for ( j = 0; j < 5; j++)
                {
                    szamokdb[jatek[i, j]]++;//az adott szám hányszor volt kihúzva
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] primszamok = new int[100];
            int db = 0;
            for (i = 2; i <= 90; i++)
            {
                bool primszam = true;
                for (j = 2; j < i&&primszam; j++)
                {
                    if (i % j == 0) primszam = false;
                }
                if (primszam)
                {
                    primszamok[db] = i;
                    listBox2.Items.Add(primszamok[db]);
                    db++;
                }
            }
            /*for (i = 0; i < primszamok.Count()&&primszamok[i]!=0; i++)
            {
                if (szamokdb[primszamok[i]] == 0) listBox2.Items.Add(primszamok[i]);
            }*/
            for (i = 1; i < 91; i++)
            {
                if (szamokdb[i] == 0) listBox2.Items.Add(i);
            }
        }

        public Form1()
        {
            InitializeComponent();
            adatokbetoltese();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*10. A „10. feladat” feliratú gombra kattintáskor határozza meg az állomány adatai alapján, hogy az egyes 
            számokat hányszor húzták ki a vizsgált évben. Az eredményt írja ki a gomb felett lévő listába következő 
            formában: a lista minden eleme 2 szám legyen, melyből az első a húzott szám legyen, a második elem 
            pedig az az érték legyen, ahányszor a számot kihúzták!*/
            for ( i = 1; i < 91; i++)
            {
                listBox1.Items.Add(i + " " + szamokdb[i]);
            }
            
        }
    }
}
