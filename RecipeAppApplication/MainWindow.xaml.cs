using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Xml.Linq;
using System.Web;
using System.Collections.ObjectModel;
using System.Deployment.Internal;
// Troelsen, A.Japikse, P. 2021.Pro c# 9 with. Net5. 10th ed. USA: West Chester.
//C# Tutorial - Full Course for Beginners- Mike. youtube video, added by Graffe acadamy.
//[Online]. Available at:https://www.youtube.com/watch?v=GhQdlIFylQ8&t=3163s 
namespace RecipeAppApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Recipe> Recipe { get; set; }
        private Recipe selectedRecipe;
        private object RecipeListBox;
        //private object IngredientTextBox;      
        private object Display;
        private object txtIngredients;
        private object lstDisplay;

        public string[] ItemSource { get; private set; }

        //String [] comboBox = {"150kl", "250kl", "350kl", "450kl","550kl", "650kl", "750kl", "850kl", "950kl", "1000kl" };

        public MainWindow()
        {
            InitializeComponent();
            Recipe = new ObservableCollection<Recipe>();
            dgvRecipe.ItemsSource = Recipe;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay=(txtIngredient.Text + "\t" + txtFoodGroups.Text +"\t" + ToString());
            txtIngredient.Clear(); 
            txtFoodGroups.Clear();

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Recipe recipe = (Recipe)RecipeListBox;
            selectedRecipe = recipe;

            if (selectedRecipe != null)
            {
                
                //namespace IngredientsListBox.Items { };
                //namespace FoodGroupTextBox.Items{  };
            }

        }
        private void combobox()
        { 
            String[] cmbcalories = { "150kl", "250kl", "350kl", "450kl", "550kl", "650kl", "750kl", "850kl", "950kl", "1000kl" };
            lstDisplay = cmbcalories.ToArray();
            ItemSource = cmbcalories;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgvRecipe.Items.Add("calories");
            dgvRecipe.Items.Add("Ingredients");
            dgvRecipe.Items.Add("FoodGroups");
            dgvRecipe.Items.Clear();
            dgvRecipe.Items.Clear();
            dgvRecipe.Items.Clear();
        }
    }
}