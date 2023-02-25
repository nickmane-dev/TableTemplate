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
    public partial class FormFlight : Form
    {
        public FormFlight()
        {
            InitializeComponent();
            FlightManager.loadData();
            updateDataGrid();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        public void updateDataGrid()
        {
            dg.Rows.Clear();

            string nameAirline_;
            string nameAirplane_;
            string when_;
            string where_;
            string from_;
            string passagesCount_;
            string typesClass_;
            string priceTicket_;
            string priceBaggage_;

            for (int i = 0; i < FlightManager.getFlightCount(); i++)
            {
                int rowId = dg.Rows.Add();
                DataGridViewRow d = dg.Rows[rowId];
                String[] v = FlightManager.getFlight(i);

                nameAirline_ = v[0];
                nameAirplane_ = v[1];
                when_ = v[2];
                where_ = v[3];
                from_ = v[4];
                passagesCount_ = v[5];
                typesClass_ = v[6];
                priceTicket_ = v[7];
                priceBaggage_ = v[8];

                d.Cells["dgNameAirline"].Value = nameAirline_;
                d.Cells["dgNameAirplane"].Value = nameAirplane_;
                d.Cells["dgWhen"].Value = when_;
                d.Cells["dgWhere"].Value = where_;
                d.Cells["dgFrom"].Value = from_;
                d.Cells["dgPassagesCount"].Value = passagesCount_;
                d.Cells["dgTypesClass"].Value = typesClass_;
                d.Cells["dgPriceTicket"].Value = priceTicket_;
                d.Cells["dgPriceBaggage"].Value = priceBaggage_;

            }
        }

        public void addFlight()
        {
            string nameAirline_         = nameAirline.Text;
            string nameAirplane_        = nameAirplane.Text;
            string when_                = when.Text;
            string where_               = where.Text;
            string from_                = from.Text;
            string passagesCount_       = passagesCount.Text;
            string typesClass_          = typesClass.Text;
            string priceTicket_         = priceTicket.Text;
            string priceBaggage_        = priceBaggage.Text;

            if (String.IsNullOrWhiteSpace(nameAirline_) || String.IsNullOrWhiteSpace(nameAirplane_) || String.IsNullOrWhiteSpace(where_) || String.IsNullOrWhiteSpace(when_)
                || String.IsNullOrWhiteSpace(from_) || String.IsNullOrWhiteSpace(passagesCount_) || String.IsNullOrWhiteSpace(typesClass_) || String.IsNullOrWhiteSpace(priceTicket_) ||
                String.IsNullOrWhiteSpace(priceBaggage_))
            {
                MessageBox.Show("Один или несколько строк не было заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FlightManager.addFlight(nameAirline_, nameAirplane_, when_, where_, from_, passagesCount_, typesClass_, priceTicket_, priceBaggage_);

            updateDataGrid();
        }
        public void deleteFlight()
        {
            if (dg.RowCount == 0) return;
            FlightManager.removeFlight(dg.CurrentCell.RowIndex);

            updateDataGrid();
        }



        public void saveDB()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFlight();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFlight();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FlightManager.saveData();
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

        private void FormFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }

        private void priceTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void priceBaggage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
