//    Linespectra - Program to create Linespectra-Grpahs of Atomic Spectra Lines
//    Copyright (C) 2012-2014 Dominik Schneider email@jaando.de

//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linespectra
{
    //Änderungen um update zu erzwingen
    public partial class Spektrallinien : Form
    {
        public Spektrallinien()
        {
            InitializeComponent();
            
        }

        public static Color einfaerben(double wellenlaenge)
        {
            int rot, grün, blau;
            int alpha = 255;

            if (wellenlaenge < 380)
                return Color.Black;
            else if (wellenlaenge < 440)
            {
                rot = (int)(255 * ( - (wellenlaenge - 440.0) / (440.0 - 380.0)));
                grün = 0;
                blau = 255;
                if (wellenlaenge < 420)
                {
                    alpha = (int)(255*(0.3 + 0.7 * (wellenlaenge - 380) / (420 - 380)));
                }

            }
            else if(wellenlaenge < 490)
            {
                rot = 0;
                grün = (int)(255 *(wellenlaenge - 440.0) / (490.0 - 440.0));
                blau = 255;
            }
            else if (wellenlaenge < 510)
            {
                rot = 0;
                grün = 255;
                blau = (int)(255* -(wellenlaenge - 510.0) / (510.0 - 490.0));
            }
            else if (wellenlaenge < 580)
            {
                rot = (int)(255 * (wellenlaenge - 510.0) / (580.0 - 510.0));
                grün = 255;
                blau = 0;
            }
            else if (wellenlaenge < 645)
            {
                rot = 255;
                grün = (int)(255*  -(wellenlaenge - 645.0) / (645.0 - 580.0));
                blau = 0;
            }
            else if (wellenlaenge < 781)
            {
                rot = 255;
                grün = 0;
                blau = 0;
                if (wellenlaenge > 700)
                {
                    alpha = (int)(255*((0.3 + 0.7 * (780 - wellenlaenge) / (780 - 700))));
                }
            }
            else
            {
                rot = 0;
                grün = 0;
                blau = 0;
            }



            //return Color.FromArgb(rot, grün, blau);
            return Color.FromArgb(alpha, rot, grün, blau);
        }
        
        public static Color einfaerben(double wellenlaenge, double intensitaet)
        {
            int rot, grün, blau;
            int alpha = 255;

            if (wellenlaenge < 380)
                return Color.Black;
            else if (wellenlaenge < 440)
            {
                rot = (int)(255 * (-(wellenlaenge - 440.0) / (440.0 - 380.0)));
                grün = 0;
                blau = 255;
               

            }
            else if (wellenlaenge < 490)
            {
                rot = 0;
                grün = (int)(255 * (wellenlaenge - 440.0) / (490.0 - 440.0));
                blau = 255;
            }
            else if (wellenlaenge < 510)
            {
                rot = 0;
                grün = 255;
                blau = (int)(255 * -(wellenlaenge - 510.0) / (510.0 - 490.0));
            }
            else if (wellenlaenge < 580)
            {
                rot = (int)(255 * (wellenlaenge - 510.0) / (580.0 - 510.0));
                grün = 255;
                blau = 0;
            }
            else if (wellenlaenge < 645)
            {
                rot = 255;
                grün = (int)(255 * -(wellenlaenge - 645.0) / (645.0 - 580.0));
                blau = 0;
            }
            else if (wellenlaenge < 781)
            {
                rot = 255;
                grün = 0;
                blau = 0;
                
            }
            else
            {
                rot = 0;
                grün = 0;
                blau = 0;
            }

            alpha = (int)(Math.Round(255 * intensitaet, 0));



            //return Color.FromArgb(rot, grün, blau);
            return Color.FromArgb(alpha, rot, grün, blau);
        }

        private void spektrum_kontinuierlich()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image Spectrum = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(Spectrum);
            Pen Linie = new Pen(myBrush);

            for (int i = 380; i < 781; i++)
            {
                myBrush.Color = einfaerben(i);
                gr.FillRectangle(myBrush, (i - 380), 0, 1, 100);
            }

            pictureBox1.Image = Spectrum;
            myBrush.Dispose();
        }

        private void Spektrum_Helium()
        {
            //Helium Spektrum

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image Spectrum = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(Spectrum);
            Pen Linie = new Pen(myBrush);

            Liniezeichnen(gr, myBrush, 389, false);
            Liniezeichnen(gr, myBrush, 396, false);
            Liniezeichnen(gr, myBrush, 403, false);
            Liniezeichnen(gr, myBrush, 412, false);
            Liniezeichnen(gr, myBrush, 414, false);
            Liniezeichnen(gr, myBrush, 438, false);
            Liniezeichnen(gr, myBrush, 447, false);
            Liniezeichnen(gr, myBrush, 471, false);
            Liniezeichnen(gr, myBrush, 492, false);
            Liniezeichnen(gr, myBrush, 502, false);
            Liniezeichnen(gr, myBrush, 588, false);
            Liniezeichnen(gr, myBrush, 668, false);
            Liniezeichnen(gr, myBrush, 707, false);

            pictureBox1.Image = Spectrum;
            myBrush.Dispose();
        }

        public static void Liniezeichnen(Graphics gr, SolidBrush myBrush, double wellenlaenge, bool HQ)
        {
            if (HQ)
            {
                myBrush.Color = einfaerben(wellenlaenge);
                gr.FillRectangle(myBrush, ((int)Math.Round(wellenlaenge*10,1) - 3800), 0, 1, 150);

            }
            else
            {
                myBrush.Color = einfaerben(wellenlaenge);
                gr.FillRectangle(myBrush, ((int)wellenlaenge - 380), 0, 1, 100);
            }
        }

        public static void Liniezeichnen(Graphics gr, SolidBrush myBrush, double wellenlaenge, bool HQ, double intensitaet)
        {
            if (HQ)
            {
                myBrush.Color = einfaerben(wellenlaenge,intensitaet);
                gr.FillRectangle(myBrush, ((int)Math.Round(wellenlaenge * 10, 1) - 3800), 0, 1, 150);

            }
            else
            {
                myBrush.Color = einfaerben(wellenlaenge, intensitaet);
                gr.FillRectangle(myBrush, ((int)wellenlaenge - 380), 0, 1, 100);
            }
        }
                
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Helium_beob()
        {
            //Helium Spektrum wie gesehen

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image Spectrum = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(Spectrum);
            Pen Linie = new Pen(myBrush);

            Liniezeichnen(gr, myBrush, 412, false);
            Liniezeichnen(gr, myBrush, 414, false);
            Liniezeichnen(gr, myBrush, 438, false);
            Liniezeichnen(gr, myBrush, 447, false);
            Liniezeichnen(gr, myBrush, 471, false);
            Liniezeichnen(gr, myBrush, 492, false);
            Liniezeichnen(gr, myBrush, 502, false);
            Liniezeichnen(gr, myBrush, 588, false);
            Liniezeichnen(gr, myBrush, 668, false);
            Liniezeichnen(gr, myBrush, 707, false);

            pictureBox1.Image = Spectrum;
            myBrush.Dispose();
        }

        private void importfunktion()
        {
            string line;
            bool auserhalbVisLicht = false;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image Spectrum = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(Spectrum);
            Pen Linie = new Pen(myBrush);

            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Pfad = openFileDialog1.FileName;

            System.IO.StreamReader file =
               new System.IO.StreamReader(Pfad);
            line = file.ReadLine();
            char[] Trennzeichen = { ';' };
            string[] Zahlteile = line.Split(Trennzeichen);
            double[] Wellenlaengen = new double[Zahlteile.Length];
            try
            {
                for (int i = 0; i < Zahlteile.Length; i++)
                {
                    Wellenlaengen[i] = Convert.ToDouble(Zahlteile[i]);
                    if (Wellenlaengen[i] < 380)
                    {
                        auserhalbVisLicht = true;
                    }
                    else if (Wellenlaengen[i] <= 780)
                    {
                        Liniezeichnen(gr, myBrush, Wellenlaengen[i], false);
                        auserhalbVisLicht = false;
                    }
                    else
                    {
                        auserhalbVisLicht = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Importieren oder Darstellen! \n Bitte Import-Datei überprüfen, Trennzeichen ';', Dezimaltrennzeichen ','", "Importfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            pictureBox1.Image = Spectrum;
            myBrush.Dispose();

            if (auserhalbVisLicht)
            {
                MessageBox.Show("Es wurden nur Wellenlängen zwischen \n 380nm und 780nm berücksichtigt!", "Sichtbares Licht", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void speicherfunktion()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPEG-Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap-Files (*.bmp)|*.bmp";
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {

                    string save = saveFileDialog1.FileName;
                    pictureBox1.Image.Save(@save, ImageFormat.Jpeg);
                }
                else
                {

                    string save = saveFileDialog1.FileName;
                    pictureBox1.Image.Save(@save, ImageFormat.Bmp);
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                importfunktion();
            }
            catch (Exception)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten, versuchen Sie es nochmal!");
            }

            
        }

        private void kontinuierlichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spektrum_kontinuierlich();
        }

        private void heliumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spektrum_Helium();
        }

        private void heliumbeobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helium_beob();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speicherfunktion();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2012-2014 D. Schneider \n Kontakt: email@jaando.de", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void höhereQualitätSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                bool auserhalbVisLicht = false;

                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                Image Spectrum = new Bitmap(4000, 150);
                Graphics gr = Graphics.FromImage(Spectrum);
                Pen Linie = new Pen(myBrush);

                string Pfad = string.Empty;

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    Pfad = openFileDialog1.FileName;

                System.IO.StreamReader file =
                   new System.IO.StreamReader(Pfad);
                line = file.ReadLine();
                char[] Trennzeichen = { ';' };
                string[] Zahlteile = line.Split(Trennzeichen);
                double[] Wellenlaengen = new double[Zahlteile.Length];
                try
                {
                    for (int i = 0; i < Zahlteile.Length; i++)
                    {
                        Wellenlaengen[i] = Convert.ToDouble(Zahlteile[i]);
                        if (Wellenlaengen[i] < 380)
                        {
                            auserhalbVisLicht = true;
                        }
                        else if (Wellenlaengen[i] <= 780)
                        {
                            Liniezeichnen(gr, myBrush, Wellenlaengen[i], true);
                            auserhalbVisLicht = false;
                        }
                        else
                        {
                            auserhalbVisLicht = true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim Importieren oder Darstellen! \n Bitte Import-Datei überprüfen, Trennzeichen ';', Dezimaltrennzeichen ','", "Importfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "JPEG-Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap-Files (*.bmp)|*.bmp";
                saveFileDialog1.RestoreDirectory = true;


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FilterIndex == 1)
                    {

                        string save = saveFileDialog1.FileName;
                        Spectrum.Save(@save, ImageFormat.Jpeg);

                    }
                    else
                    {

                        string save = saveFileDialog1.FileName;
                        Spectrum.Save(@save, ImageFormat.Bmp);
                    }
                }

                myBrush.Dispose();

                if (auserhalbVisLicht)
                {
                    MessageBox.Show("Es wurden nur Wellenlängen zwischen \n 380nm und 780nm berücksichtigt!", "Sichtbares Licht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten, versuchen Sie es nocheinmal!");
            }
        }

        private void importNISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
                NISTImport Importfenster = new NISTImport(false);

                Importfenster.ShowDialog();

                Importfenster.Dispose();
                //NISTImport();
            
            return;

        }

        /// <summary>
        /// Teste ob ',' oder '.' als Trennzeichen verwendet wurden, und ob 
        /// zu viele oder Leerzeichen Verwendet wurden. Konvertiert in ','-Notation, Standardwerte bei Fehlern.
        /// </summary>
        /// <param name="Eingabe">Eingabestring</param>
        /// <returns>Ausgabe in ','-Notation</returns>
        public static string decimal_sparator_test(string Eingabe)
        {
            string Ausgabe;
            if (!Eingabe.Contains("."))
            {
                char[] Trennzeichen = { '.' };
                string[] Zahlteile = Eingabe.Split(Trennzeichen);
                if (Zahlteile.Length > 2)
                {
                    //Fenster_text_titel("Zu viele Trennzeichen!", "Fehler!");
                    return "0";
                }
                return Eingabe;
            }
            else
            {
                char[] Trennzeichen = { '.' };
                string[] Zahlteile = Eingabe.Split(Trennzeichen);
                if (Zahlteile.Length > 2)
                {
                    //Fenster_text_titel("Zu viele Trennzeichen!", "Fehler!");
                    return "0";
                }

                Ausgabe = Zahlteile[0] + "," + Zahlteile[1];
                return Ausgabe;
            }

        }

        void NISTImport()
        {


            string line;

            string Pfad = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Pfad = openFileDialog1.FileName;

            System.IO.StreamReader file =
               new System.IO.StreamReader(Pfad);
            int zeilenzaehler = 0;

            //Anzahl Textzeilen ermitteln
            while ((line = file.ReadLine()) != null)
            {
                zeilenzaehler++;
            }

            //String-Array der Größe der Linienanzahl
            string[] lines = new string[zeilenzaehler + 1];

            file.Dispose();

            System.IO.StreamReader file2 =
               new System.IO.StreamReader(Pfad);

            zeilenzaehler = 1;

            //Zeilen einlesen und speichern
            while ((line = file2.ReadLine()) != null)
            {
                lines[zeilenzaehler] = line;
                zeilenzaehler++;
            }

            //2D-String-Array mit der Anzahl Zeilen und 16 Spalten (aus NIST-DB)
            string[,] text = new string[zeilenzaehler, 16];

            //Bestimmung der ersten Zeile mit Spaltenbeschriftungen -> Erste Zeile mit Werten zeilenzahlSpectrum+5
            int zeilenzahlSpectrum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string s = lines[i];
                if (s != null)
                {
                    if (s.Contains("Spectrum"))
                    {
                        zeilenzahlSpectrum = i;
                        break;
                    }
                }
            }

            //Bestimmung der Letzten Wertezeile -> Letzte Wertezeile = zeilenzahlQuerytime-3
            int zeilenzahlQuerytime = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string s = lines[i];
                if (s != null)
                {
                    if (s.Contains("Query time"))
                    {
                        zeilenzahlQuerytime = i;
                        break;
                    }
                }
            }

            //Werte in 2D-Array schreiben

            char[] Trennzeichen = { '|' };

            int fuenfer = 0;
            for (int i = zeilenzahlSpectrum + 5; i < zeilenzahlQuerytime - 2; i++)
            {

                string s = lines[i];
                if (s != null)
                {
                    string[] getrennteLine = s.Split(Trennzeichen);

                    int spaltenzaehler = 0;

                    if (fuenfer < 5)
                    {
                        foreach (string t in getrennteLine)
                        {
                            switch (spaltenzaehler)
                            {
                                case 0:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 1:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = decimal_sparator_test(t);
                                    spaltenzaehler++;
                                    break;
                                case 2:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = decimal_sparator_test(t);
                                    spaltenzaehler++;
                                    break;
                                case 3:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 4:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = decimal_sparator_test(t);
                                    spaltenzaehler++;
                                    break;
                                case 5:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 6:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 7:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 8:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 9:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 10:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 11:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 12:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 13:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 14:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 15:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;
                                case 16:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = t;
                                    spaltenzaehler++;
                                    break;

                            }

                            //spaltenzaehler++;

                        }
                        fuenfer++;
                    }
                    else
                    {
                        fuenfer = 0;
                    }

                }


            }


            bool auserhalbVisLicht = false;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image Spectrum = new Bitmap(3800, 150);
            Graphics gr = Graphics.FromImage(Spectrum);
            Pen Linie = new Pen(myBrush);


            for (int i = 0; i < zeilenzaehler; i++)
            {
                double wellenlaenge;
                try
                {
                    wellenlaenge = Convert.ToDouble(text[i, 1]);
                }
                catch (Exception)
                {
                    wellenlaenge = Convert.ToDouble(text[i, 2]);
                }
                if (wellenlaenge < 380)
                {
                    auserhalbVisLicht = true;
                }
                else if (wellenlaenge <= 780)
                {
                    Liniezeichnen(gr, myBrush, wellenlaenge, true);
                    auserhalbVisLicht = false;
                }
                else
                {
                    auserhalbVisLicht = true;
                }

            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPEG-Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap-Files (*.bmp)|*.bmp";
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {

                    string save = saveFileDialog1.FileName;
                    Spectrum.Save(@save, ImageFormat.Jpeg);

                }
                else
                {

                    string save = saveFileDialog1.FileName;
                    Spectrum.Save(@save, ImageFormat.Bmp);
                }
            }

            myBrush.Dispose();
            return;
        }

        private void nISTDatenbankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NISTImport Importfenster = new NISTImport(true);

            Importfenster.ShowDialog();

            Importfenster.Dispose();
        }
    }
}
