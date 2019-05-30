using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace pathfinder3
{

    public partial class Form1 : Form
    {
        int storSet1 = 0;
        int storName1 = 0;
        int storSet2 = 0;
        int storName2 = 0;
        int storSet3 = 0;
        int storName3 = 0;
        int storSet4 = 0;
        int storName4 = 0;
        int storSet5 = 0;
        int storName5 = 0;
        int storSet6 = 0;
        int storName6 = 0;
        int Die4 = 1;
        int Die6 = 1;
        int Die8 = 1;
        int Die10 = 1;
        int Die12 = 1;
        int Die20 = 1;
        int Add4 = 0;
        int Add6 = 0;
        int Add8 = 0;
        int Add10 = 0;
        int Add12 = 0;
        int Add20 = 0;
        int modd = 0;
        int turn = 30;
        int result = 0;
        int ad4 = 0;
        int dd4 = 0;
        int ad6 = 0;
        int dd6 = 0;
        int ad8 = 0;
        int dd8 = 0;
        int ad10 = 0;
        int dd10 = 0;
        int ad12 = 0;
        int dd12 = 0;
        int ad20 = 0;
        int dd20 = 0;
        int d4 = 0;
        int d6 = 0;
        int d8 = 0;
        int d10 = 0;
        int d12 = 0;
        int d20 = 0;
        int player = 1;
        int startclick = 0;
        int begincheck = 0;
        string activechar = "";
        Random rand = new Random();




        public Form1()
        {
            InitializeComponent();

            cmbSet.Items.Add("Wrath of the Righteous");
            cmbSet.Items.Add("Skull and Shackles");
            cmbSet.Items.Add("Rise of the Runelords");
            cmbSet.Items.Add("Sorcerer Class Deck");
            cmbSet.Items.Add("Rogue Class Deck");
            cmbSet.Items.Add("Custom Creations");
            cmbSet.SelectedItem = "Wrath of the Righteous";
            lblTurn.Text = turn.ToString();


        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Populate();


            cmbName.SelectedIndex = 0;
            txtd4.Text = Die4.ToString();
            txtd6.Text = Die6.ToString();
            txtd8.Text = Die8.ToString();
            txtd10.Text = Die10.ToString();
            txtd12.Text = Die12.ToString();
            txtd20.Text = Die20.ToString();
            txta4.Text = Add4.ToString();
            txta6.Text = Add6.ToString();
            txta8.Text = Add8.ToString();
            txta10.Text = Add10.ToString();
            txta12.Text = Add12.ToString();
            txta20.Text = Add20.ToString();




        }

        private void Populate()
        {
            cmbName.Items.Clear();

            string commString = null;

            switch (cmbSet.Text)
            {
                case "Wrath of the Righteous":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'WOR'";
                        break;
                    }
                case "Skull and Shackles":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'SAS'";
                        break;
                    }
                case "Rise of the Runelords":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'ROR'";
                        break;
                    }
                case "Sorcerer Class Deck":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'SORCD'";
                        break;
                    }
                case "Rogue Class Deck":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'ROGCD'";
                        break;
                    }
                case "Custom Creations":
                    {
                        commString = "SELECT * FROM Chars WHERE [BaseSet] = 'CUST'";
                        break;
                    }
            }
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\chars.mdf;Integrated Security=True;");
            SqlCommand comm = new SqlCommand(commString, conn);
            conn.Open();
            SqlDataReader read = comm.ExecuteReader();


            while (read.Read())
            {
                cmbName.Items.Add(new character
                    (read.GetValue(1).ToString(),
                    read.GetValue(2).ToString(),
                    read.GetValue(3).ToString(),
                    read.GetValue(4).ToString(),
                    read.GetValue(5).ToString(),
                    Convert.ToInt32(read.GetValue(6)),
                    Convert.ToInt32(read.GetValue(7)),
                    Convert.ToInt32(read.GetValue(8)),
                    Convert.ToInt32(read.GetValue(9)),
                    Convert.ToInt32(read.GetValue(10)),
                    Convert.ToInt32(read.GetValue(11)),
                    read.GetValue(12).ToString(),
                    Convert.ToInt32(read.GetValue(13)),
                    Convert.ToInt32(read.GetValue(14)),
                    Convert.ToInt32(read.GetValue(15)),
                    Convert.ToInt32(read.GetValue(16)),
                    Convert.ToInt32(read.GetValue(17)),
                    Convert.ToInt32(read.GetValue(18)),
                    Convert.ToInt32(read.GetValue(19)),
                    read.GetValue(20).ToString(),
                    read.GetValue(23).ToString(),
                    read.GetValue(26).ToString(),
                    read.GetValue(29).ToString(),
                    read.GetValue(32).ToString(),
                    Convert.ToInt32(read.GetValue(21)),
                    Convert.ToInt32(read.GetValue(24)),
                    Convert.ToInt32(read.GetValue(27)),
                    Convert.ToInt32(read.GetValue(30)),
                    Convert.ToInt32(read.GetValue(33)),
                    read.GetValue(22).ToString(),
                    read.GetValue(25).ToString(),
                    read.GetValue(28).ToString(),
                    read.GetValue(31).ToString(),
                    read.GetValue(34).ToString()
                    ));
            }
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {

                turn = 30;
                lblTurn.Text = turn.ToString();
                startclick = 0;
                begincheck = 0;
                btnNext.Text = "START";
                player = 1;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;

                if (lblName.Text != "Name")
            {
                if (lblP1.Text == "Party 1")
                {
                    lblP1.Text = lblName.Text + " (" + lblSet.Text + ")";
                    storSet1 = cmbSet.SelectedIndex;
                    storName1 = cmbName.SelectedIndex;

                }
                else
                {
                    if (lblP2.Text == "Party 2")
                    {
                        lblP2.Text = lblName.Text + " (" + lblSet.Text + ")";
                        storSet2 = cmbSet.SelectedIndex;
                        storName2 = cmbName.SelectedIndex;
                    }
                    else
                    {
                        if (lblP3.Text == "Party 3")
                        {
                            lblP3.Text = lblName.Text + " (" + lblSet.Text + ")";
                            storSet3 = cmbSet.SelectedIndex;
                            storName3 = cmbName.SelectedIndex;
                        }
                        else
                        {
                            if (lblP4.Text == "Party 4")
                            {
                                lblP4.Text = lblName.Text + " (" + lblSet.Text + ")";
                                storSet4 = cmbSet.SelectedIndex;
                                storName4 = cmbName.SelectedIndex;
                            }
                            else
                            {
                                if (lblP5.Text == "Party 5")
                                {
                                    lblP5.Text = lblName.Text + " (" + lblSet.Text + ")";
                                    storSet5 = cmbSet.SelectedIndex;
                                    storName5 = cmbName.SelectedIndex;
                                }
                                else
                                {
                                    if (lblP6.Text == "Party 6")
                                    {
                                        lblP6.Text = lblName.Text + " (" + lblSet.Text + ")";
                                        storSet6 = cmbSet.SelectedIndex;
                                        storName6 = cmbName.SelectedIndex;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Party Is Full");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            turn = 30;
            lblTurn.Text = turn.ToString();
            startclick = 0;
            begincheck = 0;
            btnNext.Text = "START";
            player = 1;
            lblP1.ForeColor = Color.Black;
            lblP2.ForeColor = Color.Black;
            lblP3.ForeColor = Color.Black;
            lblP4.ForeColor = Color.Black;
            lblP5.ForeColor = Color.Black;
            lblP6.ForeColor = Color.Black;

            lblP1.Text = "Party 1";
            lblP2.Text = "Party 2";
            lblP3.Text = "Party 3";
            lblP4.Text = "Party 4";
            lblP5.Text = "Party 5";
            lblP6.Text = "Party 6";
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            character MyCharacter = (character)cmbName.SelectedItem;
            lblName.Text = MyCharacter.Name;
            lblSet.Text = MyCharacter.Set;
            lblGender.Text = MyCharacter.Gender;
            lblRace.Text = MyCharacter.Race;
            lblJob.Text = MyCharacter.Job;
            lblWeapon.Text = MyCharacter.Weapon.ToString();
            lblSpell.Text = MyCharacter.Spell.ToString();
            lblArmor.Text = MyCharacter.Armor.ToString();
            lblItem.Text = MyCharacter.Item.ToString();
            lblAlly.Text = MyCharacter.Ally.ToString();
            lblBlessing.Text = MyCharacter.Blessing.ToString();
            lblFave.Text = MyCharacter.Fave;
            lblStr.Text = "D" + MyCharacter.Str.ToString();
            lblDex.Text = "D" + MyCharacter.Dex.ToString();
            lblCon.Text = "D" + MyCharacter.Con.ToString();
            lblInt.Text = "D" + MyCharacter.Int.ToString();
            lblWis.Text = "D" + MyCharacter.Wis.ToString();
            lblCha.Text = "D" + MyCharacter.Cha.ToString();
            lblHand.Text = MyCharacter.Hand.ToString();
            btnS1.Text = MyCharacter.Skill1;
            btnS2.Text = MyCharacter.Skill2;
            btnS3.Text = MyCharacter.Skill3;
            btnS4.Text = MyCharacter.Skill4;
            btnS5.Text = MyCharacter.Skill5;

            if (MyCharacter.SkA1 == 0)
            {
                lblDie1.Text = "";
            }
            else
            {
                lblDie1.Text = "+ " + MyCharacter.SkA1.ToString();
            }

            if (MyCharacter.SkA2 == 0)
            {
                lblDie2.Text = "";
            }
            else
            {
                lblDie2.Text = "+ " + MyCharacter.SkA2.ToString();
            }

            if (MyCharacter.SkA3 == 0)
            {
                lblDie3.Text = "";
            }
            else
            {
                lblDie3.Text = "+ " + MyCharacter.SkA3.ToString();
            }

            if (MyCharacter.SkA4 == 0)
            {
                lblDie4.Text = "";
            }
            else
            {
                lblDie4.Text = "+ " + MyCharacter.SkA4.ToString();
            }

            if (MyCharacter.SkA5 == 0)
            {
                lblDie5.Text = "";
            }
            else
            {
                lblDie5.Text = "+ " + MyCharacter.SkA5.ToString();
            }


            if (MyCharacter.SkL1 == null)
            {
                lblBas1.Text = "";
            }
            else
            {
                lblBas1.Text = MyCharacter.SkL1;
            }

            if (MyCharacter.SkL2 == null)
            {
                lblBas2.Text = "";
            }
            else
            {
                lblBas2.Text = MyCharacter.SkL2;
            }

            if (MyCharacter.SkL3 == null)
            {
                lblBas3.Text = "";
            }
            else
            {
                lblBas3.Text = MyCharacter.SkL3;
            }

            if (MyCharacter.SkL4 == null)
            {
                lblBas4.Text = "";
            }
            else
            {
                lblBas4.Text = MyCharacter.SkL4;
            }

            if (MyCharacter.SkL5 == null)
            {
                lblBas5.Text = "";
            }
            else
            {
                lblBas5.Text = MyCharacter.SkL5;
            }
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            if (lblP1.Text != "Party 1")
            {

                cmbSet.SelectedIndex = storSet1;
                cmbName.SelectedIndex = storName1;
                player = 1;
                lblP1.ForeColor = Color.Red;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;


            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            if (lblP2.Text != "Party 2")
            {
                cmbSet.SelectedIndex = storSet2;
                cmbName.SelectedIndex = storName2;
                player = 2;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Red;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            if (lblP3.Text != "Party 3")
            {
                cmbSet.SelectedIndex = storSet3;
                cmbName.SelectedIndex = storName3;
                player = 3;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Red;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            if (lblP4.Text != "Party 4")
            {
                cmbSet.SelectedIndex = storSet4;
                cmbName.SelectedIndex = storName4;
                player = 4;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Red;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            if (lblP5.Text != "Party 5")
            {
                cmbSet.SelectedIndex = storSet5;
                cmbName.SelectedIndex = storName5;
                player = 5;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Red;
                lblP6.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
            if (lblP6.Text != "Party 6")
            {
                cmbSet.SelectedIndex = storSet6;
                cmbName.SelectedIndex = storName6;
                player = 6;
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Please Choose A Character First");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblP1.Text == "Party 1")
            {
                MessageBox.Show("The Party Must Have Atleast One Member.");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files | *.txt";
                sfd.DefaultExt = "txt";
                sfd.ShowDialog();
                string filename = sfd.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);


                file.WriteLine(storSet1.ToString());
                file.WriteLine(storName1.ToString());

                if (lblP2.Text == "Party 2")
                {
                    file.WriteLine("999");
                    file.WriteLine("999");
                }
                else
                {
                    file.WriteLine(storSet2.ToString());
                    file.WriteLine(storName2.ToString());
                }

                if (lblP3.Text == "Party 3")
                {
                    file.WriteLine("999");
                    file.WriteLine("999");
                }
                else
                {
                    file.WriteLine(storSet3.ToString());
                    file.WriteLine(storName3.ToString());
                }

                if (lblP4.Text == "Party 4")
                {
                    file.WriteLine("999");
                    file.WriteLine("999");
                }
                else
                {
                    file.WriteLine(storSet4.ToString());
                    file.WriteLine(storName4.ToString());
                }

                if (lblP5.Text == "Party 5")
                {
                    file.WriteLine("999");
                    file.WriteLine("999");
                }
                else
                {
                    file.WriteLine(storSet5.ToString());
                    file.WriteLine(storName5.ToString());
                }

                if (lblP6.Text == "Party 6")
                {
                    file.WriteLine("999");
                    file.WriteLine("999");
                }
                else
                {
                    file.WriteLine(storSet6.ToString());
                    file.WriteLine(storName6.ToString());
                }

                file.Close();


            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            turn = 30;
            lblTurn.Text = turn.ToString();
            startclick = 0;
            begincheck = 0;
            btnNext.Text = "START";
            player = 1;
            lblP1.ForeColor = Color.Black;
            lblP2.ForeColor = Color.Black;
            lblP3.ForeColor = Color.Black;
            lblP4.ForeColor = Color.Black;
            lblP5.ForeColor = Color.Black;
            lblP6.ForeColor = Color.Black;


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files | *.txt";
            ofd.ShowDialog();
            string filename = ofd.FileName;


            System.IO.StreamReader file = new System.IO.StreamReader(filename);


            storSet1 = Convert.ToInt32(file.ReadLine());
            storName1 = Convert.ToInt32(file.ReadLine());
            storSet2 = Convert.ToInt32(file.ReadLine());
            storName2 = Convert.ToInt32(file.ReadLine());
            storSet3 = Convert.ToInt32(file.ReadLine());
            storName3 = Convert.ToInt32(file.ReadLine());
            storSet4 = Convert.ToInt32(file.ReadLine());
            storName4 = Convert.ToInt32(file.ReadLine());
            storSet5 = Convert.ToInt32(file.ReadLine());
            storName5 = Convert.ToInt32(file.ReadLine());
            storSet6 = Convert.ToInt32(file.ReadLine());
            storName6 = Convert.ToInt32(file.ReadLine());
            cmbSet.SelectedIndex = storSet1;
            cmbName.SelectedIndex = storName1;
            lblP1.Text = lblName.Text + " (" + lblSet.Text + ")";


            if (storSet2 == 999)
            {
                cmbSet.SelectedIndex = 0;
                cmbName.SelectedIndex = 0;
                lblP2.Text = "Party 2";
            }
            else
            {
                cmbSet.SelectedIndex = storSet2;
                cmbName.SelectedIndex = storName2;
                lblP2.Text = lblName.Text + " (" + lblSet.Text + ")";
            }

            if (storSet3 == 999)
            {
                cmbSet.SelectedIndex = 0;
                cmbName.SelectedIndex = 0;
                lblP3.Text = "Party 3";
            }
            else
            {
                cmbSet.SelectedIndex = storSet3;
                cmbName.SelectedIndex = storName3;
                lblP3.Text = lblName.Text + " (" + lblSet.Text + ")";
            }

            if (storSet4 == 999)
            {
                cmbSet.SelectedIndex = 0;
                cmbName.SelectedIndex = 0;
                lblP4.Text = "Party 4";
            }
            else
            {
                cmbSet.SelectedIndex = storSet4;
                cmbName.SelectedIndex = storName4;
                lblP4.Text = lblName.Text + " (" + lblSet.Text + ")";
            }

            if (storSet5 == 999)
            {
                cmbSet.SelectedIndex = 0;
                cmbName.SelectedIndex = 0;
                lblP5.Text = "Party 5";
            }
            else
            {
                cmbSet.SelectedIndex = storSet5;
                cmbName.SelectedIndex = storName5;
                lblP5.Text = lblName.Text + " (" + lblSet.Text + ")";
            }

            if (storSet6 == 999)
            {
                cmbSet.SelectedIndex = 0;
                cmbName.SelectedIndex = 0;
                lblP6.Text = "Party 6";
            }
            else
            {
                cmbSet.SelectedIndex = storSet6;
                cmbName.SelectedIndex = storName6;
                lblP6.Text = lblName.Text + " (" + lblSet.Text + ")";
            }


            file.Close();
        }

        private void btnStr_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblStr.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnDex_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblDex.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblCon.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblInt.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblWis.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            DieClear();
            switch (lblCha.Text)
            {
                case "D4":
                    {
                        chkd4.Checked = true;
                        break;
                    }
                case "D6":
                    {
                        chkd6.Checked = true;
                        break;
                    }
                case "D8":
                    {
                        chkd8.Checked = true;
                        break;
                    }
                case "D10":
                    {
                        chkd10.Checked = true;
                        break;
                    }
                case "D12":
                    {
                        chkd12.Checked = true;
                        break;
                    }

            }
        }

        private void btnClearDice_Click(object sender, EventArgs e)
        {
            chkd4.Checked = false;
            chkd6.Checked = false;
            chkd8.Checked = false;
            chkd10.Checked = false;
            chkd12.Checked = false;
            chkd20.Checked = false;
            Die4 = 1;
            Die6 = 1;
            Die8 = 1;
            Die10 = 1;
            Die12 = 1;
            Die20 = 1;
            Add4 = 0;
            Add6 = 0;
            Add8 = 0;
            Add10 = 0;
            Add12 = 0;
            Add20 = 0;
            txtd4.Text = Die4.ToString();
            txtd6.Text = Die6.ToString();
            txtd8.Text = Die8.ToString();
            txtd10.Text = Die10.ToString();
            txtd12.Text = Die12.ToString();
            txtd20.Text = Die20.ToString();
            txta4.Text = Add4.ToString();
            txta6.Text = Add6.ToString();
            txta8.Text = Add8.ToString();
            txta10.Text = Add10.ToString();
            txta12.Text = Add12.ToString();
            txta20.Text = Add20.ToString();
            lblResult.Text = "00";
            lbl4res.Text = "00";
            lbl6res.Text = "00";
            lbl8res.Text = "00";
            lbl10res.Text = "00";
            lbl12res.Text = "00";
            lbl20res.Text = "00";
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string die1 = lblDie1.Text;
            modd = 1;
            skillDie(die1);
        }

        private void skillDie(string die1)
        {
            DieClear();
            Label labelmod = lblBas1;
            switch(modd)
            {
                case 1:
                    labelmod = lblBas1;
                    break;
                case 2:
                    labelmod = lblBas2;
                    break;
                case 3:
                    labelmod = lblBas3;
                    break;
                case 4:
                    labelmod = lblBas4;
                    break;
                case 5:
                    labelmod = lblBas5;
                    break;
            }
            
            switch (labelmod.Text)
            {

                case "Str":
                    {
                        switch (lblStr.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }

                case "Dex":
                    {
                        switch (lblDex.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }

                case "Con":
                    {
                        switch (lblCon.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }
                case "Int":
                    {
                        switch (lblInt.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }

                case "Wis":
                    {
                        switch (lblWis.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }

                case "Cha":
                    {
                        switch (lblCha.Text)
                        {
                            case "D4":
                                {
                                    chkd4.Checked = true;
                                    txta4.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D6":
                                {
                                    chkd6.Checked = true;
                                    txta6.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D8":
                                {
                                    chkd8.Checked = true;

                                    txta8.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D10":
                                {
                                    chkd10.Checked = true;

                                    txta10.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }
                            case "D12":
                                {
                                    chkd12.Checked = true;

                                    txta12.Text = die1.Substring(die1.Length - 1, 1);
                                    break;
                                }

                        }
                        break;
                    }
            }
        }

        private void DieClear()
        {
            chkd4.Checked = false;
            chkd6.Checked = false;
            chkd8.Checked = false;
            chkd10.Checked = false;
            chkd12.Checked = false;
            chkd20.Checked = false;
            txtd4.Text = Die4.ToString();
            txtd6.Text = Die6.ToString();
            txtd8.Text = Die8.ToString();
            txtd10.Text = Die10.ToString();
            txtd12.Text = Die12.ToString();
            txtd20.Text = Die20.ToString();
            txta4.Text = Add4.ToString();
            txta6.Text = Add6.ToString();
            txta8.Text = Add8.ToString();
            txta10.Text = Add10.ToString();
            txta12.Text = Add12.ToString();
            txta20.Text = Add20.ToString();
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string die1 = lblDie2.Text;
            modd = 2;
            skillDie(die1);
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            string die1 = lblDie3.Text;
            modd = 3;
            skillDie(die1);
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            string die1 = lblDie4.Text;
            modd = 4;
            skillDie(die1);
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            string die1 = lblDie5.Text;
            modd = 5;
            skillDie(die1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            turn = turn + 1;
            lblTurn.Text = turn.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            turn = turn - 1;
            lblTurn.Text = turn.ToString();
            if (turn <= 0)
            {
                
                turn = 0;
                lblTurn.Text = turn.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            turn = turn - 1;
            
            if (startclick == 0)
            {
                startclick = 1;
                btnNext.Text = "NEXT";
                turn = 30;
                lblTurn.Text = turn.ToString();
                if (player == 1)
                    if (lblP1.Text == "Party 1")
                    {
                        MessageBox.Show("Please make a party to begin");
                        startclick = 0;
                        begincheck = 0;
                        btnNext.Text = "START";
                        player = 1;
                        lblP1.ForeColor = Color.Black;
                        lblP2.ForeColor = Color.Black;
                        lblP3.ForeColor = Color.Black;
                        lblP4.ForeColor = Color.Black;
                        lblP5.ForeColor = Color.Black;
                        lblP6.ForeColor = Color.Black;
                        return;
                    }
                    else
                    {
                        btnP1.PerformClick();
                        player = 1;
                        activechar = lblP1.Text;
                        lblP1.ForeColor = Color.Red;
                        lblP2.ForeColor = Color.Black;
                        lblP3.ForeColor = Color.Black;
                        lblP4.ForeColor = Color.Black;
                        lblP5.ForeColor = Color.Black;
                        lblP6.ForeColor = Color.Black;
                        begincheck = 1;
                        return;
                    }

            }
            
            lblTurn.Text = turn.ToString();

            if (player == 1 && begincheck == 1)
            {
               

                if (lblP2.Text == "Party 2")
                {
                    btnP1.PerformClick();
                    player = 1;
                    activechar = lblP1.Text;
                    lblP1.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
                else
                {
                    btnP2.PerformClick();
                    player = 2;
                    activechar = lblP2.Text;
                    lblP2.ForeColor = Color.Red;
                    lblP1.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
            }
            else if (player == 2)
                if (lblP3.Text == "Party 3")
                {
                    btnP1.PerformClick();
                    player = 1;
                    activechar = lblP1.Text;
                    lblP1.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
                else
                {
                    btnP3.PerformClick();
                    player = 3;
                    activechar = lblP3.Text;
                    lblP3.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP1.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
            else if (player == 3)
                if (lblP4.Text == "Party 4")
                {
                    btnP1.PerformClick();
                    player = 1;
                    activechar = lblP1.Text;
                    lblP1.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
                else
                {
                    btnP4.PerformClick();
                    player = 4;
                    activechar = lblP4.Text;
                    lblP4.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP1.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
            else if (player == 4)
                if (lblP5.Text == "Party 5")
                {
                    btnP1.PerformClick();
                    player = 1;
                    activechar = lblP1.Text;
                    lblP1.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
                else
                {
                    btnP5.PerformClick();
                    player = 5;
                    activechar = lblP5.Text;
                    lblP5.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP1.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
            else if (player == 5)
                if (lblP6.Text == "Party 6")
                {
                    btnP1.PerformClick();
                    player = 1;
                    activechar = lblP1.Text;
                    lblP1.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP6.ForeColor = Color.Black;
                }
                else
                {
                    btnP6.PerformClick();
                    player = 6;
                    activechar = lblP6.Text;
                    lblP6.ForeColor = Color.Red;
                    lblP2.ForeColor = Color.Black;
                    lblP3.ForeColor = Color.Black;
                    lblP4.ForeColor = Color.Black;
                    lblP5.ForeColor = Color.Black;
                    lblP1.ForeColor = Color.Black;
                }
            else if (player == 6)
            {
                btnP1.PerformClick();
                player = 1;
                activechar = lblP1.Text;
                lblP1.ForeColor = Color.Red;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;
            }

            if (turn < 0)
            {
                MessageBox.Show("The Game is Over.");
                turn = 30;
                lblTurn.Text = turn.ToString();
                startclick = 0;
                begincheck = 0;
                player = 1;
                activechar = lblP1.Text;
                btnNext.Text = "START";
                lblP1.ForeColor = Color.Black;
                lblP2.ForeColor = Color.Black;
                lblP3.ForeColor = Color.Black;
                lblP4.ForeColor = Color.Black;
                lblP5.ForeColor = Color.Black;
                lblP6.ForeColor = Color.Black;
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("log.txt", true);


            file.WriteLine("Turns Left: " + turn);
            file.WriteLine("Character: " + activechar);
            file.WriteLine("");
            file.Close();
            

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            dd4 = int.Parse(txtd4.Text);
            dd6 = int.Parse(txtd6.Text);
            dd8 = int.Parse(txtd8.Text);
            dd10 = int.Parse(txtd10.Text);
            dd12 = int.Parse(txtd12.Text);
            dd20 = int.Parse(txtd20.Text);
            int td4 = 0;
            int td6 = 0;
            int td8 = 0;
            int td10 = 0;
            int td12 = 0;
            int td20 = 0;
            int rd4 = 0;
            int rd6 = 0;
            int rd8 = 0;
            int rd10 = 0;
            int rd12 = 0;
            int rd20 = 0;

            if (chkd4.Checked)
            {
                for (int i = 1; i <= dd4; i++)
                {
                    d4 = rand.Next(1, 5);
                    td4 = td4 + d4;
                }
                ad4 = int.Parse(txta4.Text);
                rd4 = td4 + ad4;
            }
            else
            {
                rd4 = 0;
            }

            if (chkd6.Checked)
            {
                for (int i = 1; i <= dd6; i++)
                {
                    d6 = rand.Next(1, 7);
                    td6 = td6 + d6;
                }
                ad6 = int.Parse(txta6.Text);
                rd6 = td6 + ad6;
            }
            else
            {
                rd6 = 0;
            }

            if (chkd8.Checked)
            {
                for (int i = 1; i <= dd8; i++)
                {
                    d8 = rand.Next(1, 9);
                    td8 = td8 + d8;
                }
                ad8 = int.Parse(txta8.Text);
                rd8 = td8 + ad8;
            }
            else
            {
                rd8 = 0;
            }

            if (chkd10.Checked)
            {
                for (int i = 1; i <= dd10; i++)
                {
                    d10 = rand.Next(1, 11);
                    td10 = td10 + d10;
                }
                ad10 = int.Parse(txta10.Text);
                rd10 = td10 + ad10;
            }
            else
            {
                rd10 = 0;
            }

            if (chkd12.Checked)
            {
                for (int i = 1; i <= dd12; i++)
                {
                    d12 = rand.Next(1, 13);
                    td12 = td12 + d12;
                }
                ad12 = int.Parse(txta12.Text);
                rd12 = td12 + ad12;
            }
            else
            {
                rd12 = 0;
            }

            if (chkd20.Checked)
            {
                for (int i = 1; i <= dd20; i++)
                {
                    d20 = rand.Next(1, 21);
                    td20 = td20 + d20;
                }
                ad20 = int.Parse(txta20.Text);
                rd20 = td20 + ad20;
            }
            else
            {
                rd20 = 0;
            }


            result = rd4 + rd6 + rd8 + rd10 + rd12 + rd20;
            lbl4res.Text = rd4.ToString();
            lbl6res.Text = rd6.ToString();
            lbl8res.Text = rd8.ToString();
            lbl10res.Text = rd10.ToString();
            lbl12res.Text = rd12.ToString();
            lbl20res.Text = rd20.ToString();
            lblResult.Text = result.ToString();
        }
    }
}
