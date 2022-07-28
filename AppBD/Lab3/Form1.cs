using System;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FbConnection fbcon;
        public void Form1_Load(object sender, EventArgs e)
        {
            FbConnectionStringBuilder fbconnectionstring = new FbConnectionStringBuilder();
            fbconnectionstring.Charset = "NONE";
            fbconnectionstring.UserID = "SYSDBA";
            fbconnectionstring.Password = "masterkey";
            fbconnectionstring.Database = "C:\\Users\\Redempty\\Desktop\\firebirdBD\\LAB3_DB.FDB";
            fbconnectionstring.DataSource = "localhost";
            fbconnectionstring.Pooling = false;

            fbcon = new FbConnection(fbconnectionstring.ToString());
            fbcon.Open();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bUILDING_NUMBERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bUILDING_NUMBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ACCEPTED_ORDER". При необходимости она может быть перемещена или удалена.
            this.aCCEPTED_ORDERTableAdapter.Fill(this.dataSet1.ACCEPTED_ORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.PASSENGER". При необходимости она может быть перемещена или удалена.
            this.pASSENGERTableAdapter.Fill(this.dataSet1.PASSENGER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.WOFKING_SHIFT". При необходимости она может быть перемещена или удалена.
            this.wOFKING_SHIFTTableAdapter.Fill(this.dataSet1.WOFKING_SHIFT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.PERMIT_FROM_RPGMU". При необходимости она может быть перемещена или удалена.
            this.pERMIT_FROM_RPGMUTableAdapter.Fill(this.dataSet1.PERMIT_FROM_RPGMU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DRIVER". При необходимости она может быть перемещена или удалена.
            this.dRIVERTableAdapter.Fill(this.dataSet1.DRIVER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CAR". При необходимости она может быть перемещена или удалена.
            this.cARTableAdapter.Fill(this.dataSet1.CAR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CAB_COMPANY". При необходимости она может быть перемещена или удалена.
            this.cAB_COMPANYTableAdapter.Fill(this.dataSet1.CAB_COMPANY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.BUILDING_NUMBER". При необходимости она может быть перемещена или удалена.
            this.bUILDING_NUMBERTableAdapter.Fill(this.dataSet1.BUILDING_NUMBER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cAB_COMPANYTableAdapter.Update(dataSet1.CAB_COMPANY);
            dRIVERTableAdapter.Update(dataSet1.DRIVER);
            cARTableAdapter.Update(dataSet1.CAR);
            pERMIT_FROM_RPGMUTableAdapter.Update(dataSet1.PERMIT_FROM_RPGMU);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aCCEPTED_ORDERTableAdapter.Update(dataSet1.ACCEPTED_ORDER);
            bUILDING_NUMBERTableAdapter.Update(dataSet1.BUILDING_NUMBER);
            pASSENGERTableAdapter.Update(dataSet1.PASSENGER);
            wOFKING_SHIFTTableAdapter.Update(dataSet1.WOFKING_SHIFT);
        }
    }
}

