
namespace TipCalculator
{
    partial class TipCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipCalculator));
            this.Txt_BillAmount = new System.Windows.Forms.TextBox();
            this.Txt_TipPercentage = new System.Windows.Forms.TextBox();
            this.NUD_Diners = new System.Windows.Forms.NumericUpDown();
            this.DarkMode_BTN = new System.Windows.Forms.Button();
            this.Calculate_BTN = new System.Windows.Forms.Button();
            this.lbl_BillAmount = new System.Windows.Forms.Label();
            this.lbl_TipPercent = new System.Windows.Forms.Label();
            this.lbl_Diners = new System.Windows.Forms.Label();
            this.lbl_TTip = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.CB_Languages = new System.Windows.Forms.ComboBox();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.lbl_Lang = new System.Windows.Forms.Label();
            this.lbl_TotalPerPerson = new System.Windows.Forms.Label();
            this.lbl_TipPerPerson = new System.Windows.Forms.Label();
            this.lbl_CDate = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Clear_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Diners)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_BillAmount
            // 
            resources.ApplyResources(this.Txt_BillAmount, "Txt_BillAmount");
            this.Txt_BillAmount.Name = "Txt_BillAmount";
            // 
            // Txt_TipPercentage
            // 
            resources.ApplyResources(this.Txt_TipPercentage, "Txt_TipPercentage");
            this.Txt_TipPercentage.Name = "Txt_TipPercentage";
            // 
            // NUD_Diners
            // 
            resources.ApplyResources(this.NUD_Diners, "NUD_Diners");
            this.NUD_Diners.Name = "NUD_Diners";
            // 
            // DarkMode_BTN
            // 
            resources.ApplyResources(this.DarkMode_BTN, "DarkMode_BTN");
            this.DarkMode_BTN.Name = "DarkMode_BTN";
            this.DarkMode_BTN.UseVisualStyleBackColor = true;
            this.DarkMode_BTN.Click += new System.EventHandler(this.DarkMode_BTN_Click);
            // 
            // Calculate_BTN
            // 
            resources.ApplyResources(this.Calculate_BTN, "Calculate_BTN");
            this.Calculate_BTN.Name = "Calculate_BTN";
            this.Calculate_BTN.UseVisualStyleBackColor = true;
            this.Calculate_BTN.Click += new System.EventHandler(this.Calculate_BTN_Click);
            // 
            // lbl_BillAmount
            // 
            resources.ApplyResources(this.lbl_BillAmount, "lbl_BillAmount");
            this.lbl_BillAmount.Name = "lbl_BillAmount";
            // 
            // lbl_TipPercent
            // 
            resources.ApplyResources(this.lbl_TipPercent, "lbl_TipPercent");
            this.lbl_TipPercent.Name = "lbl_TipPercent";
            // 
            // lbl_Diners
            // 
            resources.ApplyResources(this.lbl_Diners, "lbl_Diners");
            this.lbl_Diners.Name = "lbl_Diners";
            // 
            // lbl_TTip
            // 
            resources.ApplyResources(this.lbl_TTip, "lbl_TTip");
            this.lbl_TTip.Name = "lbl_TTip";
            // 
            // lbl_Total
            // 
            resources.ApplyResources(this.lbl_Total, "lbl_Total");
            this.lbl_Total.Name = "lbl_Total";
            // 
            // CB_Languages
            // 
            resources.ApplyResources(this.CB_Languages, "CB_Languages");
            this.CB_Languages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Languages.FormattingEnabled = true;
            this.CB_Languages.Items.AddRange(new object[] {
            resources.GetString("CB_Languages.Items"),
            resources.GetString("CB_Languages.Items1"),
            resources.GetString("CB_Languages.Items2"),
            resources.GetString("CB_Languages.Items3")});
            this.CB_Languages.Name = "CB_Languages";
            this.CB_Languages.SelectedIndexChanged += new System.EventHandler(this.Languages_CB_SelectedIndexChanged);
            // 
            // lbl_Heading
            // 
            resources.ApplyResources(this.lbl_Heading, "lbl_Heading");
            this.lbl_Heading.Name = "lbl_Heading";
            // 
            // lbl_Lang
            // 
            resources.ApplyResources(this.lbl_Lang, "lbl_Lang");
            this.lbl_Lang.Name = "lbl_Lang";
            // 
            // lbl_TotalPerPerson
            // 
            resources.ApplyResources(this.lbl_TotalPerPerson, "lbl_TotalPerPerson");
            this.lbl_TotalPerPerson.Name = "lbl_TotalPerPerson";
            // 
            // lbl_TipPerPerson
            // 
            resources.ApplyResources(this.lbl_TipPerPerson, "lbl_TipPerPerson");
            this.lbl_TipPerPerson.Name = "lbl_TipPerPerson";
            // 
            // lbl_CDate
            // 
            resources.ApplyResources(this.lbl_CDate, "lbl_CDate");
            this.lbl_CDate.Name = "lbl_CDate";
            // 
            // lbl_Date
            // 
            resources.ApplyResources(this.lbl_Date, "lbl_Date");
            this.lbl_Date.Name = "lbl_Date";
            // 
            // Clear_BTN
            // 
            resources.ApplyResources(this.Clear_BTN, "Clear_BTN");
            this.Clear_BTN.Name = "Clear_BTN";
            this.Clear_BTN.UseVisualStyleBackColor = true;
            this.Clear_BTN.Click += new System.EventHandler(this.Clear_BTN_Click);
            // 
            // TipCalculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Clear_BTN);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_CDate);
            this.Controls.Add(this.lbl_Lang);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.CB_Languages);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_TTip);
            this.Controls.Add(this.lbl_Diners);
            this.Controls.Add(this.lbl_TipPercent);
            this.Controls.Add(this.lbl_BillAmount);
            this.Controls.Add(this.Calculate_BTN);
            this.Controls.Add(this.DarkMode_BTN);
            this.Controls.Add(this.lbl_TotalPerPerson);
            this.Controls.Add(this.lbl_TipPerPerson);
            this.Controls.Add(this.NUD_Diners);
            this.Controls.Add(this.Txt_TipPercentage);
            this.Controls.Add(this.Txt_BillAmount);
            this.Name = "TipCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Diners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_BillAmount;
        private System.Windows.Forms.TextBox Txt_TipPercentage;
        private System.Windows.Forms.NumericUpDown NUD_Diners;
        private System.Windows.Forms.Button DarkMode_BTN;
        private System.Windows.Forms.Button Calculate_BTN;
        private System.Windows.Forms.Label lbl_BillAmount;
        private System.Windows.Forms.Label lbl_TipPercent;
        private System.Windows.Forms.Label lbl_Diners;
        private System.Windows.Forms.Label lbl_TTip;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ComboBox CB_Languages;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Label lbl_Lang;
        private System.Windows.Forms.Label lbl_TotalPerPerson;
        private System.Windows.Forms.Label lbl_TipPerPerson;
        private System.Windows.Forms.Label lbl_CDate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button Clear_BTN;
    }
}

