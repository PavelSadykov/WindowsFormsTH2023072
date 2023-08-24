using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTH2023072
{
    public partial class Form1 : Form
    {
        private  List<Control> selectedControls = new List<Control>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание и размещение элементов управления
            Button button1 = new Button();
            button1.Text = "Button 1";
            button1.Location = new System.Drawing.Point(20, 20);
            button1.Click += Control_Click;
            Controls.Add(button1);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(20, 60);
            textBox1.TextChanged += Control_TextChanged;
            Controls.Add(textBox1);

            CheckBox checkBox1 = new CheckBox();
            checkBox1.Text = "CheckBox 1";
            checkBox1.Location = new System.Drawing.Point(20, 100);
            checkBox1.CheckedChanged += Control_CheckedChanged_1;
            Controls.Add(checkBox1);

            RadioButton radioButton1 = new RadioButton();
            radioButton1.Text = "RadioButton 1";
            radioButton1.Location = new System.Drawing.Point(20, 140);
            radioButton1.CheckedChanged += Control_CheckedChanged;
            Controls.Add(radioButton1);

            // Перенос на вторую колонку
            int secondColumnX = 400;

            Button button2 = new Button();
            button2.Text = "Button 2";
            button2.Location = new System.Drawing.Point(secondColumnX, 20);
            button2.Click += Control_Click;
            Controls.Add(button2);

            TextBox textBox2 = new TextBox();
            textBox2.Location = new System.Drawing.Point(secondColumnX, 60);
            textBox2.TextChanged += Control_TextChanged;
            Controls.Add(textBox2);

            CheckBox checkBox2 = new CheckBox();
            checkBox2.Text = "CheckBox 2";
            checkBox2.Location = new System.Drawing.Point(secondColumnX, 100);
            checkBox2.CheckedChanged += Control_CheckedChanged_1;
            Controls.Add(checkBox2);

            RadioButton radioButton2 = new RadioButton();
            radioButton2.Text = "RadioButton 2";
            radioButton2.Location = new System.Drawing.Point(secondColumnX, 140);
            radioButton2.CheckedChanged += Control_CheckedChanged;
            Controls.Add(radioButton2);

            // Чек-бокс для выбранных элементов
            CheckBox selectedCheckBox = new CheckBox();
            selectedCheckBox.Text = "Показать выбранные элементы";
            selectedCheckBox.Location = new System.Drawing.Point(700, 20);
            selectedCheckBox.CheckedChanged += SelectedCheckBox_CheckedChanged;
            Controls.Add(selectedCheckBox);
        }
        
       
        private void Control_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                selectedControls.Add(control);
            }
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                selectedControls.Add(control);
            }
        }

        private void Control_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Control control &&  control is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    selectedControls.Add(control);
                }
                else 
                {
                    selectedControls.Remove(control);
                }
            }
           
        }
        private void Control_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender is Control control && control is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    selectedControls.Add(control);
                }
                else
                {
                    selectedControls.Remove(control);
                }
            }

        }


        private void SelectedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            string selectedControlsText = "Выбранные элементы: ";
            if (sender is CheckBox checkBox)
            {
              
                foreach (Control control in selectedControls)
                {
                    selectedControlsText += control.Text + ", ";
                }
                selectedControlsText = selectedControlsText.TrimEnd(' ', ',');
                MessageBox.Show(selectedControlsText);
            }
           
        }

    }
}