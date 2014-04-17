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
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Linespectra
{
    public partial class NISTImport : Form
    {
        public bool Datenbank = false;
        public NISTImport(bool Datenbank)
        {
            InitializeComponent();
            if (Datenbank)
            {
                chkDatenbank.Checked = true;
            }
        }

        private void cmdPfad_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Pfad = openFileDialog1.FileName;
            txtPfadOpen.Text = Pfad;
        }

        private void cmdBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEinlesen_Click(object sender, EventArgs e)
        {
            string Datenpfad = "";
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                try
                {
                    Datenpfad = Convert.ToString(ApplicationDeployment.CurrentDeployment.DataDirectory) + "\\";
                    //MessageBox.Show(Datenpfad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file. Error message: " + ex.Message);
                }
            }
            try
            {
                Auslesen_button(Datenpfad);
            }
            catch (Exception)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten, versuchen Sie es noch einmal!");
            }
        }


        /// <summary>
        /// Berechnet die Extremwerte eines 1D-Arrays
        /// </summary>
        /// <param name="werte">1D-Array</param>
        /// <returns>[minimalwert,maximalwert]</returns>
        double[] fktextremwerte(double[] werte)
        {
            double[] extremwert = new double[] { 0, 0 };

            int t_i = werte.GetLength(0);
            extremwert[0] = double.PositiveInfinity;
            extremwert[1] = double.NegativeInfinity;

            for (int i = 0; i < t_i; i++)
            {

                    if (werte[i] > extremwert[1])
                    {
                        extremwert[1] = werte[i];
                    }
                    if ((werte[i] < extremwert[0]) & (werte[i] != 0))
                    {
                        extremwert[0] = werte[i];
                    }
                
            }


            return extremwert;
        }

        private void Auslesen_button(string root)
        {
            string line, Pfad;
            if (chkDatenbank.Checked == false)
            {
                Pfad = txtPfadOpen.Text;
            }
            else
            {

                Pfad = root + "Data\\" + (cmbElement.SelectedIndex + 1) + " - " + cmbElement.SelectedItem + ".txt";
            }

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
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = Spektrallinien.decimal_sparator_test(t);
                                    spaltenzaehler++;
                                    break;
                                case 2:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = Spektrallinien.decimal_sparator_test(t);
                                    spaltenzaehler++;
                                    break;
                                case 3:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = Spektrallinien.decimal_sparator_test(Regex.Replace(t, "[^.0-9]", ""));
                                    spaltenzaehler++;
                                    break;
                                case 4:
                                    text[(i - zeilenzahlSpectrum - 5), spaltenzaehler] = Spektrallinien.decimal_sparator_test(t);
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

            //Bestimmung der Intensitätswerte, falls Option gewählt
            double[] extremwerte = new double[2];
            double[] intensitaetswerte = new double[zeilenzahlQuerytime];
            double nullwert = 1;

            if (ckbIntens.Checked)
            {
                try
                {
                for (int i = zeilenzahlSpectrum + 5; i < zeilenzahlQuerytime - 2; i++)
                {
                    double wellenlänge = 0;
                    try
                    {
                        wellenlänge = Convert.ToDouble(text[(i - zeilenzahlSpectrum - 5), 1]);
                    }
                    catch (Exception)
                    {
                        wellenlänge = Convert.ToDouble(text[(i - zeilenzahlSpectrum - 5), 2]);
                    }

                    if ((wellenlänge >= 380) && (780 < wellenlänge))
                    {
                        intensitaetswerte[i] = Math.Log10(Convert.ToDouble(text[(i - zeilenzahlSpectrum - 5), 3]));
                    }
                }

                extremwerte = fktextremwerte(intensitaetswerte);
                nullwert = Math.Log10(extremwerte[1]) - Math.Log10(extremwerte[0]);
                }
                catch (Exception)
                {

                }

            }



            //Zeichnen des Musters
            //Array um jede Linie mit maximaler Intensität zu zeichnen, speichert bereits genutzte Intensitäten
            //Der alpha Wert ergibt sich aus Log_10(Intensität)/(Log_10(Intensitätsmaximum) - Log_10(Intensitätsminimum))
            double[] Maximale_Intensitäten = new double[3801];
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
                    try
                    {
                    if (ckbIntens.Checked)
                    {
                        double alpha = (Math.Log10(Convert.ToDouble(text[i, 3])) / nullwert);
                        if (alpha > Maximale_Intensitäten[((int)(10 * Math.Round(wellenlaenge, 1))) - 3800])
                        {
                            Spektrallinien.Liniezeichnen(gr, myBrush, wellenlaenge, true, alpha);
                            Maximale_Intensitäten[((int)(10 * Math.Round(wellenlaenge, 1))) - 3800] = alpha;
                        }
                       
                    }
                    else
                    {
                        Spektrallinien.Liniezeichnen(gr, myBrush, wellenlaenge, true);
                        auserhalbVisLicht = false;
                    }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    auserhalbVisLicht = true;
                }

            }






            pictureBox1.Width = Spectrum.Width;
            pictureBox1.Image = Spectrum;
        }

        private void cmdSpeichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPEG-Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap-Files (*.bmp)|*.bmp";
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);
                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                    myEncoderParameters.Param[0] = myEncoderParameter;



                    string save = saveFileDialog1.FileName;
                    pictureBox1.Image.Save(@save,jgpEncoder, myEncoderParameters);

                }
                else
                {

                    string save = saveFileDialog1.FileName;
                    pictureBox1.Image.Save(@save, ImageFormat.Bmp);
                }
            }
        }

        private void chkDatenbank_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDatenbank.Checked)
            {
                txtPfadOpen.Enabled = false;
                cmdPfad.Enabled = false;
                cmbElement.Enabled = true;
            }
            else
            {
                txtPfadOpen.Enabled = true;
                cmdPfad.Enabled = true;
                cmbElement.Enabled = false;
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    
    }
}
