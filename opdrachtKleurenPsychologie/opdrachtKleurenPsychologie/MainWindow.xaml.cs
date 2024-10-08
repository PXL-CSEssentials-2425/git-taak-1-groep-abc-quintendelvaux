﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace opdrachtKleurenPsychologie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void yellowImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void greenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        }

        private void blueImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void redImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            collorcodeTextbox.Text = "#FF0000";
            infoTextbox.Text = "Rood is de kleur van warmte";
        }

        private void yellowImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            collorcodeTextbox.Text = "#FFFF00";
            infoTextbox.Text = "Geel is de kleur van levenslust";
        }

        private void blueImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            collorcodeTextbox.Text = "#0000FF";
            infoTextbox.Text = "Blauw is de kleur van intelligentie";
        }

        private void greenImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            collorcodeTextbox.Text = "#008000";
            infoTextbox.Text = "Groen is de kleur van genezing";
        }
    }
    
}