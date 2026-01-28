
using MaterialSkin.Controls;
using ClassLibrary;

namespace lab1Descending
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadListBox(numbers);
        }

        public int[] numbers = { 1, 56, 34, 789, 43, 72, 6, 78, 34, 65, 4, 1, 4, 6, 86, 54, 34, 67 };

    
        private void LoadListBox(int[] data)
        {
            DigitsListBox.Clear();

            foreach (int n in data)
            {
                DigitsListBox.AddItem(n.ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DescendingSort sorter = new DescendingSort();
            numbers = sorter.SortDescending(numbers);
            LoadListBox(numbers);
        }
    }
}
