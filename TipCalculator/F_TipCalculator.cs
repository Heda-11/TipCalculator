using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        public TipCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //Setting Default Culture and Date According to it
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-Us");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-Us");
            var date1 = DateTime.Now;
            string date = date1.ToShortDateString();
            lbl_CDate.Text = date;

        }


        private void Calculate_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                double Tip_Per_Person = 0;
                double Total_Per_Person = 0;
                double Bill = Convert.ToDouble(Txt_BillAmount.Text);
                double Tip_Percentage = Convert.ToDouble(this.Txt_TipPercentage.Text);
                int Total_People = Convert.ToInt32(NUD_Diners.Value);
                if (Total_People >= 1)
                {
                    //Calculating Tip and Total Per Person 
                    if (Bill >= 0 && Tip_Percentage >= 0)
                    {
                        Tip_Per_Person = Math.Round(GetTipPerPerson(Bill, Tip_Percentage, Total_People), 2);
                        Total_Per_Person = Math.Round((Bill / Total_People) + Tip_Per_Person, 2);
                        //Converting Double to currency format
                        lbl_TipPerPerson.Text = Tip_Per_Person.ToString("C");
                        lbl_TotalPerPerson.Text = Total_Per_Person.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Bill Amount or Tip Percentage Cant be Less Than Zero(0)");

                    }
                    
                }
                else
                {
                    MessageBox.Show("Sorry The Number Of Diners cant be less than 1");
                }
            }
            catch (FormatException )
            {
                MessageBox.Show("Please Enter a Valid Amount");
            }
            catch (Exception z)
            {

                MessageBox.Show(z + "/n Sorry ,Something Went Wrong");
            }
        }
        Double GetTipPerPerson(Double Bill, Double Tip_Percentage, Double People)
        {
            double TipPerPerson = ((Bill * Tip_Percentage) / 100) / People;
            return TipPerPerson;
        }
        public bool isActive=false;
        private void DarkMode_BTN_Click(object sender, EventArgs e)
        {
            //Checking Current Mode
            if (isActive == false)
            {
                isActive = DarkMode_ON();
            }
            else 
                isActive=DarkMode_OFF();
        }
        bool DarkMode_ON() {
            //Design for the 'DarkMode'
            this.BackColor = Color.FromArgb(30,30,30);
            Calculate_BTN.BackColor = Color.FromArgb(18, 18, 18);
            Calculate_BTN.ForeColor = Color.FromArgb(245, 245, 245);
            Clear_BTN.BackColor = Color.FromArgb(18, 18, 18);
            Clear_BTN.ForeColor = Color.FromArgb(245, 245, 245);
            Txt_BillAmount.BackColor = Color.FromArgb(18, 18, 18);
            Txt_BillAmount.ForeColor = Color.FromArgb(245, 245, 245);
            Txt_TipPercentage.BackColor = Color.FromArgb(18, 18, 18);
            Txt_TipPercentage.ForeColor = Color.FromArgb(245, 245, 245);
            NUD_Diners.BackColor = Color.FromArgb(18, 18, 18);
            NUD_Diners.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_TipPerPerson.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_TotalPerPerson.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_BillAmount.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_TipPercent.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_Diners.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_Total.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_TTip.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_Lang.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_Heading.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_CDate.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_Date.ForeColor = Color.FromArgb(245, 245, 245);
            DarkMode_BTN.Image = Properties.Resources.DarkMode;
            DarkMode_BTN.Text = "";
            return true;

        }
        bool DarkMode_OFF() {
            //Design for the 'LightMode'
            this.BackColor = Color.FromArgb(230, 230, 230);
            Calculate_BTN.BackColor = Color.FromArgb(245, 245, 245);
            Calculate_BTN.ForeColor = Color.FromArgb(18, 18, 18);
            Clear_BTN.BackColor = Color.FromArgb(245, 245, 245);
            Clear_BTN.ForeColor = Color.FromArgb(18, 18, 18);
            Txt_BillAmount.BackColor = Color.FromArgb(245, 245, 245);
            Txt_BillAmount.ForeColor = Color.FromArgb(18, 18, 18);
            Txt_TipPercentage.BackColor = Color.FromArgb(245, 245, 245);
            Txt_TipPercentage.ForeColor = Color.FromArgb(18, 18, 18);
            NUD_Diners.BackColor = Color.FromArgb(245, 245, 245);
            NUD_Diners.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_TipPerPerson.ForeColor = Color.FromArgb(245, 245, 245);
            lbl_TipPerPerson.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_TotalPerPerson.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_BillAmount.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_TipPercent.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_Diners.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_Total.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_TTip.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_Lang.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_Heading.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_CDate.ForeColor = Color.FromArgb(18, 18, 18);
            lbl_Date.ForeColor = Color.FromArgb(18, 18, 18);
            DarkMode_BTN.Image = Properties.Resources.LightMode;
            return false;
        }

        private void Languages_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changing Language and Culture according to user Input
            try
            {
                switch (CB_Languages.SelectedIndex)
                {
                    case 0:
                        CultureInfo info = new CultureInfo("en-Us");
                        Thread.CurrentThread.CurrentCulture = info;
                        Thread.CurrentThread.CurrentUICulture = info;
                        break;
                    case 1:
                        info = new CultureInfo("hi-In");
                        Thread.CurrentThread.CurrentCulture = info;
                        Thread.CurrentThread.CurrentUICulture = info;
                        break;
                    case 2:
                        info = new CultureInfo("fr-FR");
                        Thread.CurrentThread.CurrentCulture = info;
                        Thread.CurrentThread.CurrentUICulture = info;
                        break;
                    case 3:
                        info = new CultureInfo("ru");
                        Thread.CurrentThread.CurrentCulture = info;
                        Thread.CurrentThread.CurrentUICulture = info;
                        break;

                }
                this.Controls.Clear();
                InitializeComponent();
                var date1 = DateTime.Now;
                string date = date1.ToShortDateString();
                lbl_CDate.Text = date;
            }
            catch (Exception )
            {
                MessageBox.Show("Sorry, Something Went Wrong,Please Contact Us.");
            }
            
           }

        private void Clear_BTN_Click(object sender, EventArgs e)
        {
            //Clearing all the Input and Output Fields
            Txt_BillAmount.Clear();
            Txt_TipPercentage.Clear();
            NUD_Diners.Value = 0;
            lbl_TotalPerPerson.Text = "";
            lbl_TipPerPerson.Text = "";
        }
    }
}
