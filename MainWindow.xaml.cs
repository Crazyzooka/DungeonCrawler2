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
using DungeonCrawl2.Data.Game.Map;

namespace DungeonCrawl2
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public class Person
      {
         private string nameValue;
         public string Name
         {
            get
            {
               return nameValue;
            }
            set
            {
               nameValue = value;
            }
         }
         private double ageValue;
         public double Age
         {
            get
            {
               return ageValue;
            }
            set
            {
               if (value != ageValue)
               {
                  ageValue = value;
               }
            }
         }

         private object dataValue;
         public object Data
         {
            get
            {
               return dataValue;
            }
            set
            {
               if (value != dataValue)
               {
                  dataValue = value;
               }
            }
         }
      }

      Person person = new Person
      {
         Name = "Salman",
         Age = 26,
         Data = 5.0f
      };

      public MainWindow()
      {
         InitializeComponent();
         this.DataContext = person;
      }
   }
}
