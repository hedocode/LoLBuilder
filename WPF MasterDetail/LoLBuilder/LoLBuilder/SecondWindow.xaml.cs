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
using System.Windows.Shapes;
using Data;

namespace LoLBuilder
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        BuildListe bl { get; set; }
        Build b { get; set; } = new Build();
        Champion c { get; set; } = new Champion();
        Objet o1 { get; set; } = new Objet();
        Objet o2 { get; set; } = new Objet();
        Objet o3 { get; set; } = new Objet();
        Objet o4 { get; set; } = new Objet();
        Objet o5 { get; set; } = new Objet();
        Objet o6 { get; set; } = new Objet();
        String nom { get; set; } = new string(' ', 8);

        public SecondWindow(BuildListe build)
        {
            Resources.Add("build", build);
            bl = build;
            InitializeComponent();
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaxButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void ValidButton_Click(object sender, RoutedEventArgs e)
        {
            nom = titre.Text;
            c = ((Champion)Champ.SelectedItem);
            o1 = ((Objet)obj1.SelectedItem);
            o2 = ((Objet)obj2.SelectedItem);
            o3 = ((Objet)obj3.SelectedItem);
            o4 = ((Objet)obj4.SelectedItem);
            o5 = ((Objet)obj5.SelectedItem);
            o6 = ((Objet)obj6.SelectedItem);
            b.Nom = nom;
            b.Hero = c;
            b.Image = c.Image;
            b.Ajout(o1);
            b.Ajout(o2);
            b.Ajout(o3);
            b.Ajout(o4);
            b.Ajout(o5);
            b.Ajout(o6);
            bl.Builds.Add(b);
            this.DialogResult = true;
        }
    }
}
