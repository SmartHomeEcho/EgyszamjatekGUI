using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace EgyszamjatekGUI
{
    
    public partial class Form1 : Form
    {
        private static List<jatek> adatok = new List<jatek>();
        int tippekszama = 0;
        class jatek
        {
            public string nev;
            public int tipp1;
            public int tipp2;
            public int tipp3;
            public int tipp4;
            public jatek(string nev, int tipp1, int tipp2, int tipp3, int tipp4)
            {
                this.nev = nev;
                this.tipp1 = Convert.ToInt32(tipp1);
                this.tipp2 = Convert.ToInt32(tipp2);
                this.tipp3 = Convert.ToInt32(tipp3);
                this.tipp4 = Convert.ToInt32(tipp4);
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Kattint a fájl beolvasása gombra az adatok betöltéséhez","Információ!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        //Fájl beolvasásához Kattintásra megvizsgálom, hogy beolvastam e. Ha igen akkor üzenettel megáll, ha nem akkor továbbmegy
        //Beolvasom az Egyszámjáték2 txt-t persze try catch-el és hozzáadom a DataGridView-hoz is amiben előre készítettem 5 oszlopot
        // a megfelelő nevekkel
        private void FajlBeolvasas_Click(object sender, EventArgs e)
        {
            if (adatok.Count != 0)
            {
                MessageBox.Show("Egyszer már beolvastad!");
            }
            else
            {
                try
                {
                    StreamReader olvas = new StreamReader("egyszamjatek2.txt", Encoding.Default);

                    while (!olvas.EndOfStream)
                    {
                        string sor = olvas.ReadLine();
                        string[] sorelemek = sor.Split(' ');
                        adatok.Add(new jatek(sorelemek[0], Convert.ToInt32(sorelemek[1]), Convert.ToInt32(sorelemek[2]), Convert.ToInt32(sorelemek[3]), Convert.ToInt32(sorelemek[4])));
                        dataGridView1.Rows.Add(sorelemek[0], sorelemek[1], sorelemek[2], sorelemek[3], sorelemek[4]);    
                    }
                    olvas.Close();
                    
                    
                    MessageBox.Show($"A beolvasás megtörtént {adatok.Count} játékos van");
                    

                }
                //ha nem sikrült a beolvasás!
                catch (Exception)
                {
                    MessageBox.Show("A beolvasás nem sikerült, hiányzik a fájl!", "FIGYELMEZTETÉS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Csináltam egy menü gombot amely kattintásra lekicsinyíti a panelt, majd újra kattintásra az eredeti méretre helyezi
        //Elhelyeztem egy animátort amit kattintásra meghívok.
        //Az oldalso panel alatt található egy másik panel amire tettem egy "Készítő" labelt.
        //Felirat Start függvényt lentebb megtekintheted, amikor kattintasz a menüre és a menü a megfeleő méretbe kerül elindítja
        //a Felirat_Start fügvényt és elkezdődik a Label animációja.
        private void menu_Click(object sender, EventArgs e)
        {
            if (OldalsoPanel.Width == 20)
            {
                OldalsoPanel.Width = 175;
                OldalsoPanel.Visible = false;
                PanelAnimator.ShowSync(OldalsoPanel);
                Keszitő.Visible = false;
                Felirat_Stop();

            }
            else
            {
                OldalsoPanel.Visible = false;
                OldalsoPanel.Width = 20;
                PanelAnimator.ShowSync(OldalsoPanel);
                Keszitő.Visible = true;
                Felirat_Start();
                

            }
        }
        //Itt elhelyeztem egy Készítő_Timer nevű Timert amely segítségével egyesével tölti be a Készítő betüit a Timerben property-ben beállított
        //idő alatt. Megj: Timer elhelyezése után kétszer kell rákattintani, hogy bele tudd írni a fügvényt.
        int counter = 0;
        int length = 0;
        string txt;
        private void KeszitoTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > length)
            {
                counter = 0;
                Keszitő.Text = "";
            }
            else
            {
                Keszitő.Text = txt.Substring(0, counter);
                if (Keszitő.ForeColor == Color.Black)
                {
                    Keszitő.ForeColor = Color.Red;
                }
                else
                {
                    Keszitő.ForeColor = Color.Black;
                }
            }

        }
        //A fent már említett Készítő label animálóhoz tartozó indító és megállító fügvény.
        private void Felirat_Start()
        {
            txt = Keszitő.Text;
            length = txt.Length;
            Keszitő.Text = "";
            KeszitoTimer.Start();
        }
        private void Felirat_Stop()
        {
            txt = Keszitő.Text;
            length = txt.Length;
            Keszitő.Text = "By: Ádám Roland";
            KeszitoTimer.Stop();
        }
        //Egy sima bezárás
        private void BezarasGomb_Click(object sender, EventArgs e)
        {
            DialogResult kilepes = MessageBox.Show("Valóban ki szeretnél lépni az alkalmazásból?", "Kilépés az alkalmazásból", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kilepes == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
                
        
        
        private void JatekosHozzaadasa_Click(object sender, EventArgs e)
        {
            //A játékos hozzáadása click, Egy sorba kiolvasom a textboxot,-benne vane?, ha benne van, texbox nulláz,üzenet..

            string MegadottNev = JatekosNeve.Text;
            bool bennevan = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (MegadottNev == adatok[i].nev)
                {
                    bennevan = true;
                }
            }
            if (bennevan == true)
            {
                MessageBox.Show("Van már ilyen nevű játékos", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MegadottNev = null;
                JatekosTipp.Text = null;

            }
            // és ha tippek száma(ez nem a textbox, ez a label) nem négy akkor textbox töröl.
            else if (tippekszama != 4)
            {
                MessageBox.Show("A tippek száma nem megfelelő");
                JatekosTipp.Text = null;
            }
            //és ha jatekos neve textbox üres akkor is üzenet
            else if (JatekosNeve.Text=="")
            {
                MessageBox.Show("Nem adtál meg nevet!");
            }
            //különben a bevitt adatokat sorbeolvas, splittel, listához add, beleír az egyszámjáték2.txt-be, fontos a true
            //mivel így engedélyezed, hogy hozzáírjon
            //utána üzenet és textboxok nullázása
            else
            {
                string sorbeolvas = (MegadottNev + " " + JatekosTipp.Text);
                string[] darabolo = sorbeolvas.Split(' ');
                adatok.Add(new jatek(darabolo[0], Convert.ToInt32(darabolo[1]), Convert.ToInt32(darabolo[2]), Convert.ToInt32(darabolo[3]), Convert.ToInt32(darabolo[4])));
                dataGridView1.Rows.Add(darabolo[0], darabolo[1], darabolo[2], darabolo[3], darabolo[4]);
                StreamWriter iro = new StreamWriter("egyszamjatek2.txt", true);
                iro.WriteLine(sorbeolvas);
                iro.Close(); MessageBox.Show("Az állomány bővítése sikeres volt", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                JatekosNeve.Text = null;
                JatekosTipp.Text = null;
            }
            
        }
        //itt nincs mit magyarázni
        private void JatekosTippTextChange(object sender, EventArgs e)
        {
            string tipp = JatekosTipp.Text;
            string[] darabolo = tipp.Split(' ');
            tippekszama = darabolo.Length;
            TippekSzama.Text = ($"{tippekszama} db");
        }

        //elhelyeztem egy toolTip-et, majd a textbox-ra kattintásra felugrik.
        private void InformacioClick(object sender, EventArgs e)
        {
            toolTip1.Show("Add meg a játékos nevét! Már a listában lévő nevet nem tudsz megadni! Próbáld ki!", JatekosNeve);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Blue;
            toolTip1.BackColor = Color.Yellow;
        }

        private void JatekosTippjeiClick(object sender, EventArgs e)
        {
            toolTip1.Show("Adj meg 4 tippet szóközzel elválasztva", JatekosTipp);
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        // Ez egy label animációs függvény. A labelek alapból feketék és fehérre változnak (target color) itt is használtam Timert.
        public int[] targetColor = { 255, 255, 255 };
        public int[] fadeRGB = new int[3];
        private void LabelAnimacio_Timer_Tick(object sender, EventArgs e)
        {
            FadeIn();
        }
        public void FadeIn()
        {
            fadeRGB[0] = EgyszamJatek.ForeColor.R;
            fadeRGB[1] = EgyszamJatek.ForeColor.G;
            fadeRGB[2] = EgyszamJatek.ForeColor.B;
            if (fadeRGB[0] > targetColor[0])
            {
                fadeRGB[0]--;
            }
            else if (fadeRGB[0] < targetColor[0])
            {
                fadeRGB[0]++;
            }
            if (fadeRGB[1] > targetColor[1])
            {
                fadeRGB[1]--;
            }
            else if (fadeRGB[1] < targetColor[1])
            {
                fadeRGB[1]++;
            }
            if (fadeRGB[2] > targetColor[2])
            {
                fadeRGB[2]--;
            }
            else if (fadeRGB[2] < targetColor[2])
            {
                fadeRGB[2]++;
            }
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
            {
                LabelAnimacio_Timer.Stop();
            }
            EgyszamJatek.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            FajlBeolvasas.Textcolor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            JatekosHozzaadasa.Textcolor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            JatekosN.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            JatekosT.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            TippekSzama.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }

        private void JatekosNeve_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
