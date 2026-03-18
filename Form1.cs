using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string grade = GetSelectedGrade();
            string subject = comboBoxSubject.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(grade) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            string data = $"{name},{grade},{subject}\n";

            try
            {
                File.WriteAllText("sam3.txt", data);
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string data = File.ReadAllText("sam3.txt");
                MessageBox.Show("Данные:\n" + data);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл sam3.txt не найден.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            comboBoxSubject.SelectedIndex = -1;
        }

        private string GetSelectedGrade()
        {
            if (radioButton9.Checked) return "9";
            if (radioButton10.Checked) return "10";
            if (radioButton11.Checked) return "11";
            return null; 
        }
    }
}