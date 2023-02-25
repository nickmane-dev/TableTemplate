using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_App.Manager;

namespace Airport_App
{
    public partial class Form1 : Form
    {
        public void initializeDesign()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            btn1.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.BorderSize = 0;
            regTicket.Parent = backround;
            label1.Parent = backround;

        }

        public Form1()
        {
            InitializeComponent();
            initializeDesign();
            permission.loading();
        }

        public void openPersonalForm()
        {
            FormPersonal f = new FormPersonal();
            f.Show();
        }
        public void openFlightForm()
        {
            FormFlight f = new FormFlight();
            f.Show();
        }

        public void openPassengerForm()
        {
            FormPassenger f = new FormPassenger();
            f.Show();
        }
        public void openRegisterTicket()
        {
            FormRegisterTicket f = new FormRegisterTicket();
            f.Show();
        }

        public bool verification()
        {
            if (mainForm.formEnable) { return false; }

            mainForm.formEnable = true;
            return true;
        }

        public void quit()
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!permission.passenger.Contains(permission.group))
            {
                authPanel.BackColor = Color.Brown;
                MessageBox.Show("Недостаточно прав", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authPanel.BackColor = Color.White;
                return;
            }
            if (!verification()) return;
            openPassengerForm();
        }

        private void btn3_Click(object sender, EventArgs e)
        {            
            if (!permission.personal.Contains(permission.group))
            {
                authPanel.BackColor = Color.Brown;
                MessageBox.Show("Недостаточно прав", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authPanel.BackColor = Color.White;
                return;
            }
            if (!verification()) return;
            openPersonalForm();
        }



        private void regTicket_Click(object sender, EventArgs e)
        {
            
            if (!permission.passenger.Contains(permission.group))
            {
                authPanel.BackColor = Color.Brown;
                MessageBox.Show("Недостаточно прав", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authPanel.BackColor = Color.White;
                return;
            }
            if (!verification()) return;
            openRegisterTicket();
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (!permission.flight.Contains(permission.group))
            {
                authPanel.BackColor = Color.Brown;
                MessageBox.Show("Недостаточно прав", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authPanel.BackColor = Color.White;
                return;
            }            
            if (!verification()) return;
            openFlightForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FlightManager.startup();
            PersonalManager.startup();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void auth_Click(object sender, EventArgs e)
        {
            string _group = PersonalManager.getGroup(name.Text, surname.Text, password.Text);

            if (_group == null)
            {
                MessageBox.Show("Неверный логин, или пароль","Ошибка входа",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            permission.group = _group;
            authPanel.Visible = false;
            MessageBox.Show("Вы были авторизированны под группой " + permission.group, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    public static class mainForm
    {
        public static bool formEnable = false;


    }

    public static class permission
    {
        public static string group = "root";
        public static List<string> flight = new List<string>();
        public static List<string> passenger = new List<string>();
        public static List<string> personal = new List<string>();

        public static void loading()
        {
            flight.Add("root");
            flight.Add("Отдел рейсов");
            flight.Add("Администратор");

            passenger.Add("root");
            passenger.Add("Регистратор");
            passenger.Add("Администратор");

            personal.Add("root");
            personal.Add("Отдел кадров");
            personal.Add("Администратор");

        }
    }
}
