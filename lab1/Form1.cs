using MaterialSkin.Controls;
using System.Collections;

namespace lab1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadListBox(numbers);
        }

        public int[] numbers = { 1, 56, 34, 789, 43, 72, 6, 78, 34, 65, 4, 1, 4, 6, 86, 54, 34, 67 };

        public int[] BubbleSort(int[] numbers)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }
            return numbers;
        }

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
            DigitsListBox.Clear();
            numbers = BubbleSort(numbers);
            LoadListBox(numbers);
        }
    }
}
