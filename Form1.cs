using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Basic_Window : Form
    {
        Point p;
        public Basic_Window()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(14);
        }
        //Basic_Window
        private void Basic_Window_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        private void Basic_Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        //Basic_buttons
        private void X_Button_MouseEnter(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.Fixed3D;
            X_Button.BackColor = Color.Thistle;
        }
        private void X_Button_MouseLeave(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.FixedSingle;
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Buttons
        private void Zakaz_Click(object sender, EventArgs e)
        {
            if (Radeon_comboBox.SelectedIndex != -1 || Nvidia_comboBox.SelectedIndex != -1 ||
                Amd_comboBox.SelectedIndex != -1 || Intel_comboBox.SelectedIndex != -1)
            {
                Radeon_comboBox.Visible = false;
                Nvidia_comboBox.Visible = false;
                Intel_comboBox.Visible = false;
                Amd_comboBox.Visible = false;
                dateTimePicker1.Visible = true;
                label1.Text = "Дата доставки\nи\nСпособ оплаты";
                Back_button.Visible = true;
                Card_button.Visible = true;
                Nal_button.Visible = true;
                Name_user.Visible = true;
                phone.Visible = true;
                Zakaz.Text = "Оформить заказ";
                BackgroundImage = Properties.Resources._015;
            }
            else
                MessageBox.Show("Товар не выбран.");            
        }
        private void Zakaz_MouseDown(object sender, MouseEventArgs e)
        {
            if (Nal_button.Checked || Card_button.Checked)
            {
                if (phone.Text != "Телефон" && Name_user.Text != "Имя")
                {
                    string[] tovar1;
                    string[] tovar2;
                    string pokupka = "";
                    int sum = 0;

                    if (Amd_comboBox.SelectedIndex != -1)
                    {
                        tovar1 = Amd_comboBox.Text.Split();
                        pokupka += tovar1[0];
                        sum += Convert.ToInt32(tovar1[1].Trim('$'));
                    }
                    else if (Intel_comboBox.SelectedIndex != -1)
                    {
                        tovar1 = Intel_comboBox.Text.Split();
                        pokupka += tovar1[0];
                        sum += Convert.ToInt32(tovar1[1].Trim('$'));
                    }
                    if (Radeon_comboBox.SelectedIndex != -1)
                    {
                        tovar2 = Radeon_comboBox.Text.Split();
                        if (pokupka.Length > 0) pokupka += '\n';
                        pokupka += tovar2[0];
                        sum += Convert.ToInt32(tovar2[1].Trim('$'));
                    }
                    else if (Nvidia_comboBox.SelectedIndex != -1)
                    {
                        tovar2 = Nvidia_comboBox.Text.Split();
                        if (pokupka.Length > 0) pokupka += '\n';
                        pokupka += tovar2[0];
                        sum += Convert.ToInt32(tovar2[1].Trim('$'));
                    }




                    MessageBox.Show("Имя клиента: " + Name_user.Text + "\nТелефон клиента:" + phone.Text +
                        "\nДата доставки: " + dateTimePicker1.Text +
                        "\n~~~~~~~~~~~~~~~~~~\nСписок товаров:\n" + pokupka +
                        "\n~~~~~~~~~~~~~~~~~~\nСумма покупки: " + sum + '$');
                }
                else
                    MessageBox.Show("Нужно заполнить Имя и Телефон");
            }
            else
                if (Zakaz.Text == "Оформить заказ")
                MessageBox.Show("Способ оплаты не выбран.");
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            Radeon_comboBox.Visible = true;
            Nvidia_comboBox.Visible = true;
            Intel_comboBox.Visible = true;
            Amd_comboBox.Visible = true;
            dateTimePicker1.Visible = false;
            label1.Text = "Выбор железа";
            Back_button.Visible = false;
            Card_button.Visible = false;
            Nal_button.Visible = false;
            Name_user.Visible = false;
            phone.Visible = false;
            Nal_button.Checked = false;
            Card_button.Checked = false;
            Nal_button.ForeColor = Color.WhiteSmoke;
            Card_button.ForeColor = Color.WhiteSmoke;
            phone.Text = "Телефон";
            Name_user.Text = "Имя";
            phone.ForeColor = Color.Gray;
            Name_user.ForeColor = Color.Gray;
            Zakaz.Text = "Вперед";
        }
        private void Nal_button_MouseEnter(object sender, EventArgs e)
        {
            Nal_button.ForeColor = Color.GreenYellow;
        }
        private void Nal_button_MouseLeave(object sender, EventArgs e)
        {
            if(!Nal_button.Checked)Nal_button.ForeColor = Color.WhiteSmoke;
        }
        private void Card_button_MouseEnter(object sender, EventArgs e)
        {
            Card_button.ForeColor = Color.GreenYellow;
        }
        private void Card_button_MouseLeave(object sender, EventArgs e)
        {
            if(!Card_button.Checked)Card_button.ForeColor = Color.WhiteSmoke;            
        }
        private void Nal_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Card_button.Checked) Card_button.ForeColor = Color.WhiteSmoke;
        }
        private void Card_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Nal_button.Checked) Nal_button.ForeColor = Color.WhiteSmoke;
        }

        //Comboboxes
        private void Intel_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Amd_comboBox.Text != "Amd")
            {
                Amd_comboBox.SelectedIndex = -1;
                Amd_comboBox.Text = "Amd";
            }           
        }
        private void Amd_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Intel_comboBox.Text != "Intel")
            {
                Intel_comboBox.SelectedIndex = -1;
                Intel_comboBox.Text = "Intel";
            }           
        }
        private void Radeon_comboBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Nvidia_comboBox.Text != "Nvidia")
            {
                Nvidia_comboBox.SelectedIndex = -1;
                Nvidia_comboBox.Text = "Nvidia";
            }
        }
        private void Nvidia_comboBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Radeon_comboBox.Text != "Radeon")
            {
                Radeon_comboBox.SelectedIndex = -1;
                Radeon_comboBox.Text = "Radeon";
            }
        }
        private void Amd_comboBox_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.завантаження;
        }
        private void Intel_comboBox_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources._13th_Gen_Intel_Core_1;
        }
        private void Radeon_comboBox_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.rade;
        }
        private void Nvidia_comboBox_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.gf_30_series_kit_gtmk_3080ti_2c50_p_2x;
        }

        //TextBoxes
        private void Name_MouseDown(object sender, MouseEventArgs e)
        {
            if (Name_user.Text == "Имя")
            {
                Name_user.Text = "";
                Name_user.ForeColor = Color.Black;
            }
        }
        private void phone_MouseDown(object sender, MouseEventArgs e)
        {
            if (phone.Text == "Телефон")
            {
                phone.Text = "";
                phone.ForeColor = Color.Black;
            }           
        }
        private void Name_user_Leave(object sender, EventArgs e)
        {
            if (Name_user.Text.Length == 0)
            {
                Name_user.Text = "Имя";
                Name_user.ForeColor = Color.Gray;
            }
        }
        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text.Length == 0)
            {
                phone.Text = "Телефон";
                phone.ForeColor = Color.Gray;
            }
        }
        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text != "Телефон")
            {
                for (int i = 0; i < phone.Text.Length; i++)
                    if (!char.IsDigit(phone.Text[i]) && phone.Text[0] != '+')
                    {
                        MessageBox.Show("Только цифры доступны для телефона.");
                        phone.Text = "";
                        break;
                    }
            }
        }   
    }
}