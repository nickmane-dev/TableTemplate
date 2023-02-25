using System;
using System.Windows.Forms;
using Airport_App.Manager;

namespace Airport_App
{
    public partial class FormRegisterTicket : Form
    {
        public FormRegisterTicket()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        public void addPassenger ()
        {
            if (String.IsNullOrWhiteSpace(name.Text) ||  String.IsNullOrWhiteSpace(surname.Text) ||
                String.IsNullOrWhiteSpace(patronymic.Text) || String.IsNullOrWhiteSpace(hbd.Text) ||
                String.IsNullOrWhiteSpace(number.Text) || String.IsNullOrWhiteSpace(passportSeria.Text) ||
                String.IsNullOrWhiteSpace(passage.Text) || String.IsNullOrWhiteSpace(typeClass.Text) ||
                String.IsNullOrWhiteSpace(baggage.Text) || String.IsNullOrWhiteSpace(airline.Text) )
            {
                MessageBox.Show("Одно из полей не было заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            PassengerManager.addPassenger
                (name.Text, surname.Text, 
                patronymic.Text, hbd.Text, 
                number.Text, passportSeria.Text, 
                passage.Text, typeClass.Text, 
                baggage.Checked ? "Есть" : "Нету", 
                airline.Text.Split('_')[0]);

            PassengerManager.saveData();

        }

        public void closeForm ()
        {
            mainForm.formEnable = false;
        }

        private void airplane_DropDown(object sender, EventArgs e)
        {
            airline.Items.Clear();
            for (int i = 0; i < FlightManager.getFlightCount(); i++)
            {
                if (FlightManager.getFlight(i)[3].ToLower() == where.Text.ToLower())
                {
                    if (FlightManager.getFlight(i)[2] == dateTimePicker1.Text)
                    {
                        airline.Items.Add(i + "_" + FlightManager.getFlight(i)[0] + " | " + (int.Parse(FlightManager.getFlight(i)[7])) + "₽");
                    }
                }
            }
        }

        private void typeClass_DropDown(object sender, EventArgs e)
        {
            try
            {
                typeClass.Items.Clear();

                String[] v = FlightManager.getFlight(int.Parse(airline.Text.Split('_')[0]))[6].Split(',');
                for (int j = 0; j < v.Length; j++)
                {
                    typeClass.Items.Add(v[j]);
                }
            } catch
            {
                MessageBox.Show("Выберите сначало авикомпанию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void airline_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sum1 = int.Parse(airline.Text.Split('|')[1].Replace("₽", "").Replace(" ", ""));
                int sum2 = int.Parse(FlightManager.getFlight(int.Parse(airline.Text.Split('_')[0]))[8]);
                if (baggage.Checked)
                {
                    label9.Text = "Стоимость полёта: " + (sum1 + sum2) + "₽ (" + sum1 + " + " + sum2 + ") ";
                }
                else
                {
                    label9.Text = "Стоимость полёта: " + sum1 + "₽";
                }
            }
            catch
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int sum1 = int.Parse(airline.Text.Split('|')[1].Replace("₽", "").Replace(" ", ""));
                int sum2 = int.Parse(FlightManager.getFlight(int.Parse(airline.Text.Split('_')[0]))[8]);
                if (baggage.Checked)
                {
                    label9.Text = "Стоимость полёта: " + (sum1 + sum2) + "₽ (" + sum1 + " + " + sum2 + ") ";
                }
                else
                {
                    label9.Text = "Стоимость полёта: " + sum1 + "₽";
                }
            } catch
            {

            }
        }

        private void FormRegisterTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            closeForm();
            this.Close();
        }

        private void where_DropDown(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addPassenger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Clear();
            surname.Clear();
            patronymic.Clear();
            passportSeria.Clear();
            number.Clear();
            baggage.Checked = false;
            where.Text = "";
            airline.Text = "";
            passage.Text = "";
            typeClass.Text = "";
        }
    }
}
