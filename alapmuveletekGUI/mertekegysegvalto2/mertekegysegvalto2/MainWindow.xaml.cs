using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mertekegysegvalto2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbido1.SelectedIndex = 0;
            cbido2.SelectedIndex = 0;
            cbhossz1.SelectedIndex = 0;
            cbhossz2.SelectedIndex = 0;
            cbtomeg1.SelectedIndex = 0;
            cbtomeg2.SelectedIndex = 0;
            cbur1.SelectedIndex = 0;
            cbur2.SelectedIndex = 0;
        }

        private void btido_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double mp = 0, eredmeny = 0, beirtszam;
                beirtszam = Convert.ToDouble(tbidoertek.Text);
                if (beirtszam < 0)
                    MessageBox.Show("Negatív számnak nincs értelme!!!");
                else
                {
                    int idovalaszt1 = cbido1.SelectedIndex;
                    switch (idovalaszt1)
                    {
                        case 0: mp = beirtszam; break;
                        case 1: mp = beirtszam * 60; break;
                        case 2: mp = beirtszam * 60*60; break;
                        case 3: mp = beirtszam * 60*60*24; break;
                        case 4: mp = beirtszam * 60*60*24*7; break;
                    }
                    int idovalaszt2 = cbido2.SelectedIndex;
                    switch (idovalaszt2)
                    {
                        case 0: eredmeny = mp; break;
                        case 1: eredmeny = mp / 60; break;
                        case 2: eredmeny = mp / 60 / 60; break;
                        case 3: eredmeny = mp / 60 / 60 / 24; break;
                        case 4: eredmeny = mp / 60 / 60 / 24 / 7; break;
                    }
                    ComboBoxItem cbido1Item1 = (ComboBoxItem)cbido1.SelectedItem;
                    string mibol = cbido1Item1.Content.ToString();
                    ComboBoxItem cbido2Item2 = (ComboBoxItem)cbido2.SelectedItem;
                    string mibe = cbido2Item2.Content.ToString();
                    lbidoeredmeny.Content = "Eredmény: " + beirtszam + " " + mibol + " " + eredmeny.ToString() + " " + mibe;
                }
            }
            catch
            {
                MessageBox.Show("Add meg a számot!!!");
            }
        }

        private void bthossz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double mm = 0, eredmeny = 0, beirtszam;
                beirtszam = Convert.ToDouble(tbhosszertek.Text);
                if (beirtszam < 0)
                    MessageBox.Show("Negatív számnak nincs értelme!!!");
                else
                {
                    int hosszvalaszt1 = cbhossz1.SelectedIndex;
                    switch (hosszvalaszt1)
                    {
                        case 0: mm = beirtszam; break;
                        case 1: mm = beirtszam * 10; break;
                        case 2: mm = beirtszam * 100; break;
                        case 3: mm = beirtszam * 1000; break;
                        case 4: mm = beirtszam * 1000 * 1000; break;
                    }
                    int idovalaszt2 = cbido2.SelectedIndex;
                    switch (idovalaszt2)
                    {
                        case 0: eredmeny = mm; break;
                        case 1: eredmeny = mm / 10; break;
                        case 2: eredmeny = mm / 100; break;
                        case 3: eredmeny = mm / 1000; break;
                        case 4: eredmeny = mm / 1000 / 1000; break;
                    }
                    ComboBoxItem cbhossz1Item1 = (ComboBoxItem)cbhossz1.SelectedItem;
                    string mibol = cbhossz1Item1.Content.ToString();
                    ComboBoxItem cbhossz2Item2 = (ComboBoxItem)cbhossz2.SelectedItem;
                    string mibe = cbhossz2Item2.Content.ToString();
                    lbhosszeredmeny.Content = "Eredmény: " + beirtszam + " " + mibol + " " + eredmeny.ToString() + " " + mibe;
                }
            }
            catch
            {
                MessageBox.Show("Add meg a számot!!!");
            }
        }

        private void bttomeg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double mg = 0, eredmeny = 0, beirtszam;
                beirtszam = Convert.ToDouble(tbtomegertek.Text);
                if (beirtszam < 0)
                    MessageBox.Show("Negatív számnak nincs értelme!!!");
                else
                {
                    int tomegvalaszt1 = cbtomeg1.SelectedIndex;
                    switch (tomegvalaszt1)
                    {
                        case 0: mg = beirtszam; break;
                        case 1: mg = beirtszam * 1000; break;
                        case 2: mg = beirtszam * 1000 * 10; break;
                        case 3: mg = beirtszam * 1000 * 10 * 100; break;
                        case 4: mg = beirtszam * 1000 * 10 * 100 * 1000; break;
                    }
                    int tomegvalaszt2 = cbtomeg2.SelectedIndex;
                    switch (tomegvalaszt2)
                    {
                        case 0: eredmeny = mg; break;
                        case 1: eredmeny = mg / 1000; break;
                        case 2: eredmeny = mg / 1000 / 10; break;
                        case 3: eredmeny = mg / 1000 / 10 / 100; break;
                        case 4: eredmeny = mg / 1000 / 10 / 100 / 1000; break;
                    }
                    ComboBoxItem cbtomeg1Item1 = (ComboBoxItem)cbtomeg1.SelectedItem;
                    string mibol = cbtomeg1Item1.Content.ToString();
                    ComboBoxItem cbtomeg2Item2 = (ComboBoxItem)cbtomeg2.SelectedItem;
                    string mibe = cbtomeg2Item2.Content.ToString();
                    lbtomegeredmeny.Content = "Eredmény: " + beirtszam + " " + mibol + " " + eredmeny.ToString() + " " + mibe;
                }
            }
            catch
            {
                MessageBox.Show("Add meg a számot!!!");
            }
        }

        private void btur_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ml = 0, eredmeny = 0, beirtszam;
                beirtszam = Convert.ToDouble(tburertek.Text);
                if (beirtszam < 0)
                    MessageBox.Show("Negatív számnak nincs értelme!!!");
                else
                {
                    int urvalaszt1 = cbur1.SelectedIndex;
                    switch (urvalaszt1)
                    {
                        case 0: ml = beirtszam; break;
                        case 1: ml = beirtszam * 10; break;
                        case 2: ml = beirtszam * 100; break;
                        case 3: ml = beirtszam * 100 * 10; break;
                        case 4: ml = beirtszam * 100 * 10 * 100; break;
                    }
                    int urvalaszt2 = cbur2.SelectedIndex;
                    switch (urvalaszt2)
                    {
                        case 0: eredmeny = ml; break;
                        case 1: eredmeny = ml / 10; break;
                        case 2: eredmeny = ml / 100; break;
                        case 3: eredmeny = ml / 100 / 10; break;
                        case 4: eredmeny = ml / 100 / 10 / 100 / 1000; break;
                    }
                    ComboBoxItem cbur1Item1 = (ComboBoxItem)cbur1.SelectedItem;
                    string mibol = cbur1Item1.Content.ToString();
                    ComboBoxItem cbur2Item2 = (ComboBoxItem)cbur2.SelectedItem;
                    string mibe = cbur2Item2.Content.ToString();
                    lbureredmeny.Content = "Eredmény: " + beirtszam + " " + mibol + " " + eredmeny.ToString() + " " + mibe;
                }
            }
            catch
            {
                MessageBox.Show("Add meg a számot!!!");
            }
        }
    }
}
