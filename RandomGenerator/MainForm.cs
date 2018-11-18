using System;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            int rows = (int)rowsNumericUpDown.Value;
            int columns = (int)columnsNumericUpDown.Value;

            int firstLimit = (int)firstNumericUpDown.Value;
            int secondLimit = (int)secondNumericUpDown.Value;

            int min = Math.Min(firstLimit, secondLimit);
            int max = Math.Max(firstLimit, secondLimit);

            CreateLabelsMatrix(rows, columns, min, max);
        }

        private void CreateLabelsMatrix(int rows, int columns, int min, int max)
        {
            numbersGroupBox.Controls.Clear(); // удаляем все лейблы из groupBox

            // создаем объект для генерации случайных чисел
            // http://plssite.ru/csharp/csharp_random_article.html
            Random random = new Random((int)DateTime.Now.Ticks); 

            // переменные для задания размера лейблов. Так просто удобнее.
            int labelWidth = 30;
            int labelHeight = 15;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    Label label = new Label(); //создаем новый лейбл, на данном этапе это просто объект в памяти и он нигде не отображается

                    // генерируем случайное число между min и max, в Text у лейбла можно записать только строку,
                    // метод ToString() переводит число (int) в тип string
                    //ToString буквально переводится "в строку"
                    label.Text = random.Next(min, max).ToString();

                    // c помощью SetBounds мы выставляем позицию и размер каждого лейбла
                    // размер у всех одинаковый 30x15 - чтоб влезло трехзначное число с минусом.
                    // а вот позиция высчитывается из i и j, каждый лейбл сдвигается на 30 и 15 соответсвенно 
                    // в зависимости от индексов. Таким образом лейблы будут расставлены внутри groupBox
                    label.SetBounds(10 + i * labelWidth, 15 + j * labelHeight, labelWidth, labelHeight);

                    //добавляем лейбл к контроллерам groupBox
                    // теперь эти лейблы будут отображаться в окне
                    numbersGroupBox.Controls.Add(label);
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
            // https://professorweb.ru/my/csharp/charp_theory/level3/3_16.php
            // https://www.youtube.com/watch?v=rx5qoGc_k5k
            //
            // foreach тут перебирает все лейблы, которые находятся в numbersGroupBox и делают с ними всякое.
            foreach (Label label in numbersGroupBox.Controls)
            {
                // из каждого лейбла мы достаем текст
                // мы туда записали число и считаем, что там ничего кроме числа не может быть, в противном случае вот так вот как в следующей стоке делать не совсем правильно
                // в метод Parse(...) для типа int передается строка. Если в строке число, то метод возвращает это число. Если нет, то случится страшное, пока вам это не важно.
                int number = int.Parse(label.Text);

                // IsInvalidNumber проверят подходит ли число под те условия, где выставлены галочки, если да, то возвращает true, если нет - false
                // если в свойство Visible для лейбла записать false то лейбл не будет отображаться.
                // соответсвенно, если число подходит под условия, то лебла будет отображаться, если нет - то лейбл спрячится.
                label.Visible = IsInvalidNumber(number);
            }
        }

        private bool IsInvalidNumber(int number)
        {
            // && - это логическое "и"
            // то есть если в checkBox "мерьше 50" стоит галочка И число больше либо равно 50, значит проверку число не прошло и мы возвращаем false 
            // если в этом checkBox нет галочки мы ничего не проверяем и идем дальше.
            // если есть, но число и вправду меньше 50 то мы опять же идем дальше по коду делать остальные проверки.
            if (lessCheckBox.Checked && number >= 50)
                return false;

            if (moreCheckBox.Checked && number <= 70)
                return false;

            // number % 10 - возвращает остаток от деления на 10
            // то есть "17 % 5 = 2"
            // если остаток 0, то число понятное дело делится на 10
            if (dividedByTenCheckBox.Checked && number % 10 != 0)
                return false;

            // если ни одна из проверок не провалилась возвращаем true 
            return true;
        }
    }
}
