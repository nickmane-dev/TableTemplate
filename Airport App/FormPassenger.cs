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
    public partial class FormPassenger : Form
    {
        public FormPassenger()
        {
            InitializeComponent();
            PassengerManager.loadData();
            updateDataGrid();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        public void updateDataGrid()
        {
            dg.Rows.Clear();

            string name_;
            string surname_;
            string patronymic_;
            string hbd_;
            string number_;
            string passportSeria_;
            string passage_;
            string typeClass_;
            string baggage_;
            string numFlight_;

            for (int i = 0; i < PassengerManager.getPassengerCount(); i++)
            {
                int rowId = dg.Rows.Add();
                DataGridViewRow d = dg.Rows[rowId];
                String[] v = PassengerManager.getPassenger(i);

                name_           = v[0];
                surname_        = v[1];
                patronymic_     = v[2];
                hbd_            = v[3];
                number_         = v[4];
                passportSeria_  = v[5];
                passage_        = v[6];
                typeClass_      = v[7];
                baggage_        = v[8];
                numFlight_      = v[9];

                d.Cells["dgName"].Value             = name_;
                d.Cells["dgSurname"].Value          = surname_;
                d.Cells["dgPatronymic"].Value       = patronymic_;
                d.Cells["dgHbd"].Value              = hbd_;
                d.Cells["dgNumber"].Value           = number_;
                d.Cells["dgPassportSeria"].Value    = passportSeria_;
                d.Cells["dgPassage"].Value          = passage_;
                d.Cells["dgTypeClass"].Value        = typeClass_;
                d.Cells["dgBaggage"].Value          = baggage_;
                d.Cells["dgNumFlight"].Value        = numFlight_;

            }
        }

        public void saveData ()
        {
            dg.RowCount = PassengerManager.getPassengerCount();
            PassengerManager.clearList();

            for (int i = 0; i < dg.RowCount; i++)
            {                
                DataGridViewRow d = dg.Rows[i];

                PassengerManager.addPassenger(d.Cells["dgName"].Value.ToString(), d.Cells["dgSurname"].Value.ToString(), d.Cells["dgPatronymic"].Value.ToString(), d.Cells["dgHbd"].Value.ToString(), 
                    d.Cells["dgNumber"].Value.ToString(), d.Cells["dgPassportSeria"].Value.ToString(),
                    d.Cells["dgPassage"].Value.ToString(), d.Cells["dgTypeClass"].Value.ToString(), d.Cells["dgBaggage"].Value.ToString(), d.Cells["dgNumFlight"].Value.ToString());

            }
        }

        /*public void addHuman()
        {
            string name_ = name.Text;
            string surname_ = surname.Text;
            string patronymic_ = patronymic.Text;
            string hbd_ = hbd.Text;
            string jobTitle_ = jobTitle.Text;
            string password_ = password.Text;

            if (String.IsNullOrWhiteSpace(name_) || String.IsNullOrWhiteSpace(surname_) || String.IsNullOrWhiteSpace(patronymic_) || String.IsNullOrWhiteSpace(hbd_) || String.IsNullOrWhiteSpace(jobTitle_))
            {
                MessageBox.Show("Один или несколько строк не было заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PassengerManager.addPassenger(name_, surname_, patronymic_, hbd_, jobTitle_, password_);

            updateDataGrid();
        }*/
        public void deleteHuman()
        {
            if (dg.RowCount == 0) return;
            PassengerManager.removePassenger(dg.CurrentCell.RowIndex);

            updateDataGrid();
        }



        public void saveDB()
        {
            saveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //addHuman();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteHuman();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDB();
        }
        public void closeForm()
        {
            mainForm.formEnable = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                closeForm();
                this.Close();
            }
        }

        private void FormPassenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }
    }
}
