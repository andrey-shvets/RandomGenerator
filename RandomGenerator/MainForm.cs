using System;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class MainForm : Form
    {
        private int[,] numbers;
        private Label[,] labels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            int height = (int)heightNumericUpDown.Value;
            int width = (int)widthNumericUpDown.Value;

            int firstLimit = (int)firstNumericUpDown.Value;
            int secondLimit = (int)secondNumericUpDown.Value;

            int min = Math.Min(firstLimit, secondLimit);
            int max = Math.Max(firstLimit, secondLimit);
            
            numbers = new int[height, width];
            Random random = new Random((int)DateTime.Now.Ticks);

            for (var i = 0; i < height; i++)
                for (var j = 0; j < width; j++)
                    numbers[i, j] = random.Next(min, max);

            CreateLabels(numbers);
        }

        private void CreateLabels(int[,] numbers)
        {

            if (labels != null)
            {
                var labelsHeight = labels.GetLength(0);
                var labelsWidth = labels.GetLength(1);
                for (var i = 0; i < labelsHeight; i++)
                    for (var j = 0; j < labelsWidth; j++)
                        labels[i, j].Dispose();
            }
            
            var height = numbers.GetLength(0);
            var width = numbers.GetLength(1);

            labels = new Label[height, width];

            for (var i = 0; i < height; i++)
                for (var j = 0; j < width; j++)
                {
                    labels[i, j] = new Label();
                    labels[i, j].Text = numbers[i, j].ToString();
                    labels[i, j].SetBounds(5 + (i + 1) * 27, 5 + (j + 1) * 17, 25, 15);
                    numbersGroupBox.Controls.Add(labels[i, j]);
                }

        }

        private void lessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lessCheckBox.Checked)
                moreCheckBox.Checked = false;
        }

        private void moreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moreCheckBox.Checked)
                lessCheckBox.Checked = false;
        }
        
        private void filterButton_Click(object sender, EventArgs e)
        {
            if (numbers == null)
                return;

            var height = numbers.GetLength(0);
            var width = numbers.GetLength(1);

            for (var i = 0; i < height; i++)
                for (var j = 0; j < width; j++)
                        labels[i, j].Visible = IsInvalidNumber(numbers[i, j]);
        }

        private bool IsInvalidNumber(int number)
        {
            if (lessCheckBox.Checked && number >= 50)
                return false;

            if (moreCheckBox.Checked && number <= 70)
                return false;

            if (dividedByTenCheckBox.Checked && number % 10 != 0)
                return false;

            return true;
        }
    }
}
