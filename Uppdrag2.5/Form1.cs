using System;
using System.Windows.Forms;

namespace Uppdrag2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()

        {
            panelWellcomeSubmenu.Visible = false;
            panelBuySubmenu.Visible = false;
            panelSellSubmenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelWellcomeSubmenu.Visible == true)
                panelWellcomeSubmenu.Visible = false;
            if (panelBuySubmenu.Visible == true)
                panelBuySubmenu.Visible = false;
            if (panelSellSubmenu.Visible == true)
                panelSellSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnWellcomeSubmenu_Click(object sender, EventArgs e)
        {
            showSubmenu(panelWellcomeSubmenu);
        }

        #region WellcomeSubMenu
        private void Wellcomebtn1_Click(object sender, EventArgs e)
        {
            openBackForm(new Form2());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Wellcomebtn2_Click(object sender, EventArgs e)
        {
            openBackForm(new Form5());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Wellcomebtn3_Click(object sender, EventArgs e)
        {
            openBackForm(new Form6());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }
        #endregion
        private void BuySubmenu_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBuySubmenu);
        }
        #region BookingSubMenu

        private void Buybtn1_Click(object sender, EventArgs e)
        {
            openBackForm(new Resmal());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Buybtn2_Click(object sender, EventArgs e)
        {
            openBackForm(new Restips());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Buybtn3_Click(object sender, EventArgs e)
        {
            openBackForm(new Form3());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Buybtn4_Click(object sender, EventArgs e)
        {
            openBackForm(new Covid());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }
        #endregion
        private void SellSubmenubtn_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSellSubmenu);
        }
        #region ThemeSubMenu
        private void Sellbtn1_Click(object sender, EventArgs e)
        {
            openBackForm(new All_Inclusive());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }

        private void Sellbtn2_Click(object sender, EventArgs e)
        {
            openBackForm(new Storstad());
            //..
            //Enter codes
            //..
            hideSubMenu();
        }
        #endregion



        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //Click to exit program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelTopForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBackForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openBackForm(Form backForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = backForm;
            backForm.TopLevel = false;
            backForm.FormBorderStyle = FormBorderStyle.None;
            backForm.Dock = DockStyle.Fill;
            panelBackForm.Controls.Add(backForm);
            panelBackForm.Tag = backForm;
            backForm.BringToFront();
            backForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
