using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using Data;

namespace LoLBuilder
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                this.WindowState = System.Windows.WindowState.Normal;
                this.Top = 0;
                this.DragMove();
            }
            else
            {
                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            ((BuildListe)Resources["BuildList"]).Sauvegarde();
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

        private void Add_Build(object sender, RoutedEventArgs e)
        {
            Window n = new SecondWindow(((BuildListe) Resources["BuildList"]));
            n.ShowDialog();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ChampsListBox != null && ItemsListBox != null)
            {
                ChampsListBox.Visibility = Visibility.Hidden;
                ChampDetail.Visibility = Visibility.Hidden;
                ItemsListBox.Visibility = Visibility.Hidden;
                ItemDetail.Visibility = Visibility.Hidden;
                BuildListBox.Visibility = Visibility.Visible;
                BuildDetail.Visibility = Visibility.Visible;
                AddBuildButton.IsEnabled = true;
            }
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (ChampsListBox != null && ItemsListBox != null)
            {
                ChampsListBox.Visibility = Visibility.Visible;
                ChampDetail.Visibility = Visibility.Visible;
                ItemsListBox.Visibility = Visibility.Hidden;
                ItemDetail.Visibility = Visibility.Hidden;
                BuildListBox.Visibility = Visibility.Hidden;
                BuildDetail.Visibility = Visibility.Hidden;
                AddBuildButton.IsEnabled = false;
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (ChampsListBox != null && ItemsListBox != null)
            {
                ChampsListBox.Visibility = Visibility.Hidden;
                ChampDetail.Visibility = Visibility.Hidden;
                ItemsListBox.Visibility = Visibility.Visible;
                ItemDetail.Visibility = Visibility.Visible;
                BuildListBox.Visibility = Visibility.Hidden;
                BuildDetail.Visibility = Visibility.Hidden;
                AddBuildButton.IsEnabled = false;
            }
        }

        private void TriButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            string propertyName = "";
            System.ComponentModel.ListSortDirection sortDirection = System.ComponentModel.ListSortDirection.Ascending;

            switch (b.Name)
            {
                case "mButtonTriAlpha":
                    propertyName = "Nom";
                    sortDirection = System.ComponentModel.ListSortDirection.Ascending;
                    break;
                case "mButtonTriAhpla":
                    propertyName = "Nom";
                    sortDirection = System.ComponentModel.ListSortDirection.Descending;
                    break;
                case "mButtonTriPrix":
                    propertyName = "Prix";
                    sortDirection = System.ComponentModel.ListSortDirection.Ascending;
                    break;
                case "mButtonTriXirp":
                    propertyName = "Prix";
                    sortDirection = System.ComponentModel.ListSortDirection.Descending;
                    break;

            }
            ItemsListBox.Items.SortDescriptions.Clear();
            ItemsListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(propertyName, sortDirection));
            ChampsListBox.Items.SortDescriptions.Clear();
            ChampsListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(propertyName, sortDirection));
            BuildListBox.Items.SortDescriptions.Clear();
            BuildListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(propertyName, sortDirection));
        }

        private void DeleteBuild_Click(object sender, RoutedEventArgs e)
        {
            ((BuildListe)Resources["BuildList"]).Builds.Remove((Build)BuildListBox.SelectedItem);
        }
    }
}
