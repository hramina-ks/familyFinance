using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using newFields;

namespace familyFinance
{
    public partial class frmFinance : Form
    {
        public frmFinance()
        {
            InitializeComponent();
        }

        static string[] sIncomeArticles = new string[] { "Осн.доход.мужа\t", "Осн.доход.жены\t", "Доп.доход.мужа\t", "Доп.доход.жены\t", "Подарки\t\t", "Соц.выплаты\t" };
        static string[] sExpenseArticles = new string[] { "Еда\t\t", "Жилье\t\t", "Одежда\t\t", "Транспорт\t", "Связь\t\t", "Обучение\t", "Развлечения\t", "Путешествия\t", "Благотворительность", "Прочее\t\t", };
        /* Символ \t в строковых переменных обозначает абзац, он необходим, чтобы выровнять поля и сделать их визуально красивыми при выводе. В названии статей не должно быть пробелов! 
         * Это должны быть целые слова, потому что пробел будет служить нам разделителем при чтении из файла, чтобы отделять один элемент от другого */
        

        //Функция для строковой переменной
        string TextBoxLine(string sIncome, string sAllIncome, string sExpense, string sAllExpense, string sDifference)
        {
            string str = "";
            str = str + "Доходы:\r\n" + sIncome;
            str = str + "Общий доход: " + sAllIncome + "\r\n\r\n";
            str = str + "Расходы:\r\n" + sExpense;
            str = str + "Общий расход: " + sAllExpense + "\r\n\r\n";
            str = str + "В наличии: " + sDifference;
            return str;
        }

        Fields Income = new Fields(sIncomeArticles.Length + 1);
        Fields Expense = new Fields(sExpenseArticles.Length + 1);
        /*Передаем количество строк на одну больше, потому что кроме названия статей у нас есть еще первая строка, в которой будут дни*/

        private void frmFinance_Load(object sender, EventArgs e)
        {
            /*Вызываем методы, которые заполняют первые столбцы значениями из массивов sIncomeArticles и sExpenseArticles*/
            Income.SetFirstColumn(sIncomeArticles);
            Expense.SetFirstColumn(sExpenseArticles);

            /*Вызываем методы, которые заполняют первые строки значениями дней*/
            Income.SetDayNumbers();
            Expense.SetDayNumbers();

            /*Заполняем выпадающие списки элементами из массива Articles объектов Income и Expense*/
            for (int i = 0; i < Income.Rows - 1; i++)
                cmbIncomeArticles.Items.Add(Income.Articles[i + 1, 0]);
            for (int i = 0; i < Expense.Rows - 1; i++)
                cmbExpenseArticles.Items.Add(Expense.Articles[i + 1, 0]);

            /*Выводим в окно вывода начальные значения доходов и расходов, используя функцию TextBoxLine*/
            rtbOutput.Text = TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements()));
        }

        private void btnIncomeAdd_Click(object sender, EventArgs e)
        {
            //Проверка, что пользователь выбрал что-то из списка
            if (cmbIncomeArticles.SelectedIndex != -1)
            {
                //Проверка, что пользователь ввел значение в окно
                if (txtIncomeAdd.Text != "")
                {
                    //Проверка, что перезаписываемое значение не "-"
                    if (Income.Articles[(cmbIncomeArticles.SelectedIndex + 1), Convert.ToInt32(numIncomeDay.Value)] != "-")
                        Income.Articles[(cmbIncomeArticles.SelectedIndex + 1), Convert.ToInt32(numIncomeDay.Value)] = Convert.ToString(Convert.ToInt32(Income.Articles[(cmbIncomeArticles.SelectedIndex + 1), Convert.ToInt32(numIncomeDay.Value)]) + Convert.ToInt32(txtIncomeAdd.Text));
                    /*Обновляем значение поля массива Articles, прибавляя к нему значение из текстового поля. Номера элементов берем из выпадающего списка и списка дней месяца. 
                     Делаем явные конвертации типов, чтобы не возникало ошибок.*/
                    /*Если в массиве был "-", то просто записываем данные из поля*/
                    else
                        Income.Articles[(cmbIncomeArticles.SelectedIndex + 1), Convert.ToInt32(numIncomeDay.Value)] = txtIncomeAdd.Text;
                    /*Просто записываем значение из текстового поля в элемент массива Articles. Обновляем окно вывода данных, заново вызывая функцию*/
                    rtbOutput.Text = TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements()));
                    MessageBox.Show("Статья доходов добавлена");
                }

                else
                {
                    MessageBox.Show("Введите значение дохода");
                }
            }

            else
            {
                MessageBox.Show("Выберите статью дохода");
            }
        }

        private void btnExpenseAdd_Click(object sender, EventArgs e)
        {
            if (cmbExpenseArticles.SelectedIndex != -1)
            {
                if (txtExpenseAdd.Text != "")
                {
                    if (Expense.Articles[(cmbExpenseArticles.SelectedIndex + 1), Convert.ToInt32(numExpenseDay.Value)] != "-")
                        Expense.Articles[(cmbExpenseArticles.SelectedIndex + 1), Convert.ToInt32(numExpenseDay.Value)] = Convert.ToString(Convert.ToInt32(Expense.Articles[(cmbExpenseArticles.SelectedIndex + 1), Convert.ToInt32(numExpenseDay.Value)]) + Convert.ToInt32(txtExpenseAdd.Text));
                    else
                        Expense.Articles[(cmbExpenseArticles.SelectedIndex + 1), Convert.ToInt32(numExpenseDay.Value)] = txtExpenseAdd.Text;
                    rtbOutput.Text = TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements()));
                    MessageBox.Show("Статья расходов добавлена");
                }
                else
                    MessageBox.Show("Введите значение расхода");
            }
            else
                MessageBox.Show("Выберите статью расхода");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sSaveFile = "";
            saveFileDialog.ShowDialog();
            sSaveFile = saveFileDialog.FileName;
            if (sSaveFile != "")
            {
                FileStream fsFile = new FileStream(sSaveFile, FileMode.Create);
                StreamWriter fileWrite = new StreamWriter(fsFile);
                //Записываем данные в файл, вызывая функцию TextBoxLine
                fileWrite.Write(TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements())));
                fileWrite.Close();
                MessageBox.Show("Данные сохранены в файл");
            }
            else
            {
                MessageBox.Show("Файл для сохранения не выбран!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sLoadFile = "";
            openFileDialog.ShowDialog();
            sLoadFile = openFileDialog.FileName;
            if (sLoadFile != "")
            {
                //создаем объект для подключения к файлу
                FileStream fsFile = new FileStream(sLoadFile, FileMode.Open);
                try
                {
                    //создаем объект для чтения из файла
                    using (StreamReader fileRead = new StreamReader(fsFile))
                    {
                        string temp;
                        //читаем первую строку - "доходы" - нам не нужна
                        temp = fileRead.ReadLine();
                        //цикл прохода по всем строкам первого блока (Доходы)
                        for (int i = 0; i < Income.Rows; i++)
                        {
                            //переменная, в которой указан разделитель
                            string[] separator = new string[] { " " };
                            //временный массив, в который будет записываться строка целиком
                            string[] mas = new string[Income.Columns];
                            //записываем временный массив, отделяем переменные друг от друга по разделителю
                            mas = fileRead.ReadLine().Split(separator, StringSplitOptions.None);
                            /*Цикл записи данных из временного массива в массив Articles, так же перед записью убираем значения абзацев,
                             которые были во временном массиве*/
                            for (int j = 0; j < Income.Columns; j++)
                                Income.Articles[i, j] = mas[j].Trim(new char[] { '\t' });
                        }
                        //читаем лишнее (общий доход)
                        temp = fileRead.ReadLine();
                        //читаем лишнее (пустая строка)
                        temp = fileRead.ReadLine();
                        //читаем лишнее (расходы)
                        temp = fileRead.ReadLine();
                        //цикл прохода по всем строкам второго блока (Расходы)
                        for (int i = 0; i < Expense.Rows; i++)
                        {
                            string[] separator = new string[] { " " };
                            string[] mas = new string[Expense.Columns];
                            mas = fileRead.ReadLine().Split(separator, StringSplitOptions.None);
                            for (int j = 0; j < Expense.Columns; j++)
                                Expense.Articles[i, j] = mas[j].Trim(new char[] { '\t' });
                        }
                        fileRead.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не может быть прочитан");
                }
                /*Поскольку мы убирали значения абзацев, для красоты их надо вернуть.
                 Для этого мы просто заново перезаписываем первые колонки массивов, вызывая метод SetFirstColumn*/
                Income.SetFirstColumn(sIncomeArticles);
                Expense.SetFirstColumn(sExpenseArticles);
                //Обновляем данные в окне вывода, вызывая функцию TextBoxLine
                rtbOutput.Text = TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements()));
                MessageBox.Show("Данные загружены из файла");
            }
            else
            {
                MessageBox.Show("Файл для загрузки не выбран!");
            }
        }

        private void btnNew_Click (object sender, EventArgs e)
        {
            Income.Clear();
            Expense.Clear();
            rtbOutput.Text = TextBoxLine(Income.Output(), Convert.ToString(Income.SumOfElements()), Expense.Output(), Convert.ToString(Expense.SumOfElements()), Convert.ToString(Income.SumOfElements() - Expense.SumOfElements()));
        }
    }
}