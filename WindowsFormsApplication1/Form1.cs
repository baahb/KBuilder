using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int Stability;
        static int Economy;
        static int Loyalty;
        static int Unrest;
        static int Treasury;
        static int Consumption;
        static Random d20 = new Random();
        static int Rolld20;//d20.Next(1, 21);
        static Random d4 = new Random();
        static int Rolld4;
        static int kSize;
        static string StabCheckResults;

        //Leadership vars
        static string Ruler;
        static int rulerBonus;
        static string rulerLoy;
        static string rulerEco;
        static string rulerSta;

        static bool stab()
        {
            Rolld20 = d20.Next(1, 21);

            if (Rolld20 == 1)
            {
                if (Rolld20 + Stability - Unrest <= 15)
                {
                    Rolld4 = d4.Next(1, 5);
                    Unrest = Unrest + Rolld4;
                }
                else
                {
                    Rolld4 = 0;
                    Unrest++;
                }
                return false;
            }
            if (Rolld20 == 20 || Rolld20 + Stability - Unrest >= 20)
            {
                Unrest--;
                Rolld4 = 0;
                return true;
            }
            else if (Rolld20 + Stability - Unrest >= 15)
            {
                Unrest++;
                Rolld4 = 0;
                return false;
            }
            else
            {
                Rolld4 = d4.Next(1, 5);
                Unrest = Unrest + Rolld4;
                return false;
            }
        }
        public Form1()
        {
            string connectionString = null;
            SqlConnection connect;
            connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\r\r.mdf;Integrated Security=True;Connect Timeout=5";
            connect = new SqlConnection(connectionString);
            try
           {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "SELECT Unrest FROM KingdomStats WHERE KingdomID = 1";
                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    Unrest = (int)result[0];
                }
                
           }

           catch (Exception e)

           {

               Console.WriteLine(e.ToString());

           }

            
            /*XmlDocument Kstats = new XmlDocument();
            Kstats.Load("Kstats.xml");
            XmlNodeList statsFromXml = Kstats.SelectNodes("/KingdomStats");
            foreach (XmlNode Statmod in statsFromXml)
            {
                string strStability = Statmod["Stability"].InnerText;
                Stability = Convert.ToInt32(strStability);
                string strUnrest = Statmod["Unrest"].InnerText;
                Unrest = Convert.ToInt32(strUnrest);
                string strTreasury = Statmod["Treasury"].InnerText;
                Treasury = Convert.ToInt32(strTreasury);
                string strkSize = Statmod["KingdomSize"].InnerText;
                kSize = Convert.ToInt32(strkSize);
                string strConsumption = Statmod["Consumption"].InnerText;
                Consumption = Convert.ToInt32(strConsumption);
            }*/
            

            /*XmlDocument LStats = new XmlDocument();
            LStats.Load("Leadership.xml");
            XmlNodeList leadersFromXml = LStats.SelectNodes("/Leaders");
            foreach (XmlNode Leadmod in leadersFromXml)
            {
                Ruler = Leadmod["/Ruler/Name"].InnerText;
                string strRulerBonus = Leadmod["/Ruler/Bonus"].InnerText;
                rulerBonus = Convert.ToInt32(strRulerBonus);
                rulerLoy = Leadmod["/Ruler/Loyalty"].InnerText;
                rulerSta = Leadmod["/Ruler/Stability"].InnerText;
                rulerEco = Leadmod["/Ruler/Economy"].InnerText;
                
            }*/
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string thing = string.Format("Your Stability is {0}.\r\n Your Unrest is {1}.\r\n{2}", Stability, Unrest, Ruler);
            StabilityInfoBox.Text = thing;
            string thing2 = string.Format("You have {0} BP in your treasury. Your Consumption is {1}.", Treasury, Consumption);
            ConsumptionInfoBox.Text = thing2;

            StabilityTabControl.TabPages.Remove(sConsumptionTab);
            StabilityTabControl.TabPages.Remove(sUnrestTab);

            PrimaryTabControl.TabPages.Remove(PrimaryTabPageEdicts);
            EdictTabControl.TabPages.Remove(eLeadershipTab);
            EdictTabControl.TabPages.Remove(eHexesTab);
            EdictTabControl.TabPages.Remove(eTerrainTab);
            EdictTabControl.TabPages.Remove(eSettlementTab);
            EdictTabControl.TabPages.Remove(eArmyTab);
            EdictTabControl.TabPages.Remove(eEdictTab);

            PrimaryTabControl.TabPages.Remove(PrimaryTabPageIncome);
            PrimaryTabControl.TabPages.Remove(PrimaryTabPageEvents);
        }

        private void stabRollButton_Click(object sender, EventArgs e)
        {
            bool StabCheck = stab();

            if (Unrest < 0)
            {
                Unrest = 0;
            }

            if (StabCheck)
            {
                StabCheckResults = "Your Kingdom is stable, for now... Your unrest is at ";


            }
            else
            {
                StabCheckResults = "Your Kingdom is stable, but you've gained Unrest. Your unrest is at ";

            }

            if (Unrest >= 11)
            {
                StabCheckResults = "You must cede territory. Your unrest is at ";
            }

            if (Unrest == 20)
            {
                StabCheckResults = "Your Kingdom is in Chaos, no further actions can be taken. Your unrest is at ";
            }
            if (Rolld4 != 0)
            {
                PostStabilityUnrestInfo.Text = "Due to your low stability, you take gain " + Rolld4 + " (1d4) unrest.";
                PostStabilityUnrestInfo.Visible = true;
            }
            StabDiceRollText.Text = "Your dice landed on " + Rolld20 + ", for a total of " + (Rolld20 + Stability - Unrest) + ".";
            StabDiceRollText.Visible = true;
            PostRollStabilityInfoBox.Text = StabCheckResults + Unrest + ".";
            PostRollStabilityInfoBox.Visible = true;
            stabRollButton.Visible = false;
            XmlDocument Kstats = new XmlDocument();
            Kstats.Load("Kstats.xml");
            string strUnr = Convert.ToString(Unrest);
            XmlElement unrestnode = Kstats.SelectSingleNode("/KingdomStats/Unrest") as XmlElement;
            unrestnode.InnerText = strUnr;
            Kstats.Save("Kstats.xml");
            StabilityTabControl.TabPages.Add(sConsumptionTab);
            //ConsumptionInfoBox.Text = "You have " + Treasury + " BP in your treasury. Your Consumption is " + Consumption + ".";
        }

        private void consumptionPaymentButton_Click(object sender, EventArgs e)
        {
            Treasury = Treasury - Consumption;
            consumptionPaymentButton.Visible = false;
            PostConsumptionInfoBox.Text = "You now have " + Treasury + " in your treasury.";
            PostConsumptionInfoBox.Visible = true;
            if (Treasury < 0)
            {
                Unrest = Unrest + 2;
                PostConsumptionDebtNote.Text = "You don't have enough BP to pay for food. Unrest Increases by 2, to" + Unrest + ".";
                PostConsumptionDebtNote.Visible = true;
            }
            XmlDocument Kstats = new XmlDocument();
            Kstats.Load("Kstats.xml");
            string strUnr = Convert.ToString(Unrest);
            XmlElement unrestnode = Kstats.SelectSingleNode("/KingdomStats/Unrest") as XmlElement;
            unrestnode.InnerText = strUnr;
            Kstats.Save("Kstats.xml");
            string thing = string.Format("Do you wish to try to reduce your unrest?\r\n Your Unrest Modifier is {0}", Unrest);
            UnrestInfoBox.Text = thing;
            StabilityTabControl.TabPages.Add(sUnrestTab);
        }

        private void modifyUnrestButton_Click(object sender, EventArgs e)
        {
            PrimaryTabControl.TabPages.Add(PrimaryTabPageEdicts);
            EdictTabControl.TabPages.Add(eLeadershipTab);
        }

        private void sConsumptionTab_Click(object sender, EventArgs e)
        {

        }

        private void StabilityTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LeaderSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string leaderSelection = LeaderSelectBox.SelectedItem.ToString();
            if (leaderSelection == "Ruler")
            {
                LeaderNameField.Text = Ruler;
                LeaderBonusField.Text = rulerBonus.ToString();
            }
        }

        private void ChangeLeaderYesButton_Click(object sender, EventArgs e)
        {
            LeaderSelectBox.Visible = true;
            ChangeLeaderYesButton.Visible = false;
            ChangeLeaderNoButton.Visible = false;
            LeadershipRoleQuestion.Visible = true;
            LeaderShipYN.Visible = false;
            LeaderNameField.Visible = true;
            LeaderNameLabel.Visible = true;
            LeaderBonusLabel.Visible = true;
            LeaderBonusField.Visible = true;
        }

        private void ChangeLeaderNoButton_Click(object sender, EventArgs e)
        {
            EdictTabControl.TabPages.Add(eHexesTab);
        }
    }
}
