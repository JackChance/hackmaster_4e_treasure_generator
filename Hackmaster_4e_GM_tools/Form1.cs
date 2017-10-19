using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hackmaster_4e_GM_tools
{

    public partial class TreasureForm : Form
    {
        static readonly Random die = new Random();
        public TreasureForm()
        {
            InitializeComponent();
        }
        private void aplusbtn_Click(object sender, EventArgs e)
        {
            atbx.CountUp();
        }

        private void aminusbtn_Click(object sender, EventArgs e)
        {
            atbx.CountDown();
        }

        private void bplusbtn_Click(object sender, EventArgs e)
        {
            btbx.CountUp();
        }

        private void bminusbtn_Click(object sender, EventArgs e)
        {
            btbx.CountDown();
        }

        private void cplusbtn_Click(object sender, EventArgs e)
        {
            ctbx.CountUp();
        }

        private void dplusbtn_Click(object sender, EventArgs e)
        {
            dtbx.CountUp();
        }

        private void eplusbtn_Click(object sender, EventArgs e)
        {
            etbx.CountUp();
        }

        private void fplusbtn_Click(object sender, EventArgs e)
        {
            ftbx.CountUp();
        }

        private void gplusbtn_Click(object sender, EventArgs e)
        {
            gtbx.CountUp();
        }

        private void hplusbtn_Click(object sender, EventArgs e)
        {
            htbx.CountUp();
        }

        private void iplusbtn_Click(object sender, EventArgs e)
        {
            itbx.CountUp();
        }

        private void cminusbtn_Click(object sender, EventArgs e)
        {
            ctbx.CountDown();
        }

        private void dminusbtn_Click(object sender, EventArgs e)
        {
            dtbx.CountDown();
        }

        private void eminusbtn_Click(object sender, EventArgs e)
        {
            etbx.CountDown();
        }

        private void fminusbtn_Click(object sender, EventArgs e)
        {
            ftbx.CountDown();
        }

        private void gminusbtn_Click(object sender, EventArgs e)
        {
            gtbx.CountDown();
        }

        private void hminusbtn_Click(object sender, EventArgs e)
        {
            htbx.CountDown();
        }

        private void iminusbtn_Click(object sender, EventArgs e)
        {
            itbx.CountDown();
        }

        private void jplusbtn_Click(object sender, EventArgs e)
        {
            jtbx.CountUp();
        }

        private void jminusbtn_Click(object sender, EventArgs e)
        {
            jtbx.CountDown();
        }

        private void kpluxbtn_Click(object sender, EventArgs e)
        {
            ktbx.CountUp();
        }

        private void lpluxbtn_Click(object sender, EventArgs e)
        {
            ltbx.CountUp();
        }

        private void mpluxbtn_Click(object sender, EventArgs e)
        {
            mtbx.CountUp();
        }

        private void npluxbtn_Click(object sender, EventArgs e)
        {
            ntbx.CountUp();
        }

        private void oplusbtn_Click(object sender, EventArgs e)
        {
            otbx.CountUp();
        }

        private void pplusbtn_Click(object sender, EventArgs e)
        {
            ptbx.CountUp();
        }

        private void qplusbtn_Click(object sender, EventArgs e)
        {
            qtbx.CountUp();
        }

        private void rplusbtn_Click(object sender, EventArgs e)
        {
            rtbx.CountUp();
        }

        private void splusbtn_Click(object sender, EventArgs e)
        {
            stbx.CountUp();
        }

        private void tplusbtn_Click(object sender, EventArgs e)
        {
            ttbx.CountUp();
        }

        private void uplusbtn_Click(object sender, EventArgs e)
        {
            utbx.CountUp();
        }

        private void vplusbtn_Click(object sender, EventArgs e)
        {
            vtbx.CountUp();
        }

        private void wplusbtn_Click(object sender, EventArgs e)
        {
            wtbx.CountUp();
        }

        private void xplusbtn_Click(object sender, EventArgs e)
        {
            xtbx.CountUp();
        }

        private void yplusbtn_Click(object sender, EventArgs e)
        {
            ytbx.CountUp();
        }

        private void zplusbtn_Click(object sender, EventArgs e)
        {
            ztbx.CountUp();
        }

        private void kminusbtn_Click(object sender, EventArgs e)
        {
            ktbx.CountDown();
        }

        private void lminusbtn_Click(object sender, EventArgs e)
        {
            ltbx.CountDown();
        }

        private void mminusbtn_Click(object sender, EventArgs e)
        {
            mtbx.CountDown();
        }

        private void nminusbtn_Click(object sender, EventArgs e)
        {
            ntbx.CountDown();
        }

        private void ominusbtn_Click(object sender, EventArgs e)
        {
            otbx.CountDown();
        }

        private void pminusbtn_Click(object sender, EventArgs e)
        {
            ptbx.CountDown();
        }

        private void qminusbtn_Click(object sender, EventArgs e)
        {
            qtbx.CountDown();
        }

        private void rminusbtn_Click(object sender, EventArgs e)
        {
            rtbx.CountDown();
        }

        private void sminusbtn_Click(object sender, EventArgs e)
        {
            stbx.CountDown();
        }

        private void tminusbtn_Click(object sender, EventArgs e)
        {
            ttbx.CountDown();
        }

        private void uminusbtn_Click(object sender, EventArgs e)
        {
            utbx.CountDown();
        }

        private void vminusbtn_Click(object sender, EventArgs e)
        {
            vtbx.CountDown();
        }

        private void wminusbtn_Click(object sender, EventArgs e)
        {
            wtbx.CountDown();
        }

        private void xminusbtn_Click(object sender, EventArgs e)
        {
            xtbx.CountDown();
        }

        private void yminusbtn_Click(object sender, EventArgs e)
        {
            ytbx.CountDown();
        }

        private void zminusbtn_Click(object sender, EventArgs e)
        {
            ztbx.CountDown();
        }

        private void gemplusbtn_Click(object sender, EventArgs e)
        {
            gemtbx.CountUp();
        }

        private void artplusbtn_Click(object sender, EventArgs e)
        {
            arttbx.CountUp();
        }

        private void magicplusbtn_Click(object sender, EventArgs e)
        {
            magictbx.CountUp();
        }

        private void potionplusbtn_Click(object sender, EventArgs e)
        {
            potiontbx.CountUp();
        }

        private void weaponplusbtn_Click(object sender, EventArgs e)
        {
            weapontbx.CountUp();
        }

        private void armorplusbtn_Click(object sender, EventArgs e)
        {
            armortbx.CountUp();
        }

        private void scrollplusbtn_Click(object sender, EventArgs e)
        {
            scrolltbx.CountUp();
        }

        private void ringplusbtn_Click(object sender, EventArgs e)
        {
            ringtbx.CountUp();
        }

        private void rodplusbtn_Click(object sender, EventArgs e)
        {
            rodtbx.CountUp();
        }

        private void staveplusbtn_Click(object sender, EventArgs e)
        {
            stavetbx.CountUp();
        }

        private void wandplusbtn_Click(object sender, EventArgs e)
        {
            wandtbx.CountUp();
        }

        private void bookplusbtn_Click(object sender, EventArgs e)
        {
            booktbx.CountUp();
        }

        private void jewelplusbtn_Click(object sender, EventArgs e)
        {
            jeweltbx.CountUp();
        }

        private void cloakplusbtn_Click(object sender, EventArgs e)
        {
            cloaktbx.CountUp();
        }

        private void bootplusbtn_Click(object sender, EventArgs e)
        {
            boottbx.CountUp();
        }

        private void girdleplusbtn_Click(object sender, EventArgs e)
        {
            girdletbx.CountUp();
        }

        private void bagplusbtn_Click(object sender, EventArgs e)
        {
            bagtbx.CountUp();
        }

        private void dustplusbtn_Click(object sender, EventArgs e)
        {
            dusttbx.CountUp();
        }

        private void householdplusbtn_Click(object sender, EventArgs e)
        {
            householdtbx.CountUp();
        }

        private void musicalplusbtn_Click(object sender, EventArgs e)
        {
            musicaltbx.CountUp();
        }

        private void weirdplusbtn_Click(object sender, EventArgs e)
        {
            weirdtbx.CountUp();
        }

        private void artifactplusbtn_Click(object sender, EventArgs e)
        {
            artifacttbx.CountUp();
        }

        private void gemminusbtn_Click(object sender, EventArgs e)
        {
            gemtbx.CountDown();
        }

        private void artminusbtn_Click(object sender, EventArgs e)
        {
            arttbx.CountDown();
        }

        private void magicminusbtn_Click(object sender, EventArgs e)
        {
            magictbx.CountDown();
        }

        private void potionminusbtn_Click(object sender, EventArgs e)
        {
            potiontbx.CountDown();
        }

        private void weaponminusbtn_Click(object sender, EventArgs e)
        {
            weapontbx.CountDown();
        }

        private void armorminusbtn_Click(object sender, EventArgs e)
        {
            armortbx.CountDown();
        }

        private void scrollminusbtn_Click(object sender, EventArgs e)
        {
            scrolltbx.CountDown();
        }

        private void ringminusbtn_Click(object sender, EventArgs e)
        {
            ringtbx.CountDown();
        }

        private void rodminusbtn_Click(object sender, EventArgs e)
        {
            rodtbx.CountDown();
        }

        private void staveminusbtn_Click(object sender, EventArgs e)
        {
            stavetbx.CountDown();
        }

        private void wandminusbtn_Click(object sender, EventArgs e)
        {
            wandtbx.CountDown();
        }

        private void bookminusbtn_Click(object sender, EventArgs e)
        {
            booktbx.CountDown();
        }

        private void jewelminusbtn_Click(object sender, EventArgs e)
        {
            jeweltbx.CountDown();
        }

        private void cloakminusbtn_Click(object sender, EventArgs e)
        {
            cloaktbx.CountDown();
        }

        private void bootminusbtn_Click(object sender, EventArgs e)
        {
            boottbx.CountDown();
        }

        private void girdleminusbtn_Click(object sender, EventArgs e)
        {
            girdletbx.CountDown();
        }

        private void bagminusbtn_Click(object sender, EventArgs e)
        {
            bagtbx.CountDown();
        }

        private void dustminusbtn_Click(object sender, EventArgs e)
        {
            dusttbx.CountDown();
        }

        private void householdminusbtn_Click(object sender, EventArgs e)
        {
            householdtbx.CountDown();
        }

        private void musicalminusbtn_Click(object sender, EventArgs e)
        {
            musicaltbx.CountDown();
        }

        private void weirdminusbtn_Click(object sender, EventArgs e)
        {
            weirdtbx.CountDown();
        }

        private void artifactminusbtn_Click(object sender, EventArgs e)
        {
            artifacttbx.CountDown();
        }

        private void TreasureForm_Load(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            int roll;
            int gems = int.Parse(gemtbx.Text);
            int art = int.Parse(arttbx.Text);
            int magic = int.Parse(magictbx.Text);
            generaltreasurertb.Text = "";
            // Major treasure types
            int aclass = int.Parse(atbx.Text);
            for (int i = 0; i < aclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1,101);
                if (roll <= 60)
                {
                   Thread.Sleep(1);
                   gems += die.Next(10, 41);
                }

            }
            int bclass = int.Parse(btbx.Text);
            for (int i = 0; i < bclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 30)
                {
                    Thread.Sleep(1);
                    gems += die.Next(1, 9);
                }

            }
            int cclass = int.Parse(ctbx.Text);
            for (int i = 0; i < cclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 25)
                {
                    Thread.Sleep(1);
                    gems += die.Next(1, 7);
                }

            }
            int dclass = int.Parse(dtbx.Text);
            for (int i = 0; i < dclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 30)
                {
                    Thread.Sleep(1);
                    gems += die.Next(1, 11);
                }

            }
            int eclass = int.Parse(etbx.Text);
            for (int i = 0; i < eclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 15)
                {
                    Thread.Sleep(1);
                    gems += die.Next(1, 13);
                }

            }
            int fclass = int.Parse(ftbx.Text);
            for (int i = 0; i < fclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 20)
                {
                    Thread.Sleep(1);
                    gems += die.Next(2, 21);
                }

            }
            int gclass = int.Parse(gtbx.Text);
            for (int i = 0; i < gclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 30)
                {
                    Thread.Sleep(1);
                    gems += die.Next(3, 19);
                }

            }
            int hclass = int.Parse(htbx.Text);
            for (int i = 0; i < hclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 50)
                {
                    Thread.Sleep(1);
                    gems += die.Next(3, 31);
                }

            }
            int iclass = int.Parse(itbx.Text);
            for (int i = 0; i < iclass; i++)
            {
                //TODO: add non-gems
                Thread.Sleep(1);
                roll = die.Next(1, 101);
                if (roll <= 55)
                {
                    Thread.Sleep(1);
                    gems += die.Next(2, 13);
                }

            }
            for (int i = 0; i < gems; i++)
            {
                generaltreasurertb.Text += gemResult.next() + "\n";
            }
          }
    }
    public static class gemResult
    {
        static readonly Random die = new Random();
        // 6 is starting index
        static string[] values = { "1cp", "5cp", "1sp", "5sp", "1gp", "5gp", "10gp", "50gp", "100gp", "500gp", "1,000gp", "5,000gp", "10,000gp", "20,000gp", "40,000gp", "80,000gp", "160,000gp", "320,000gp", "640,000gp" };
        public static string next()
        {
            Thread.Sleep(1);
            int roll = die.Next(1, 101);
            int cur_val = 0;
            // 1-25 = val 6;
            // 26-50 = val 7;
            // 51-70 = val 8;
            // 71-90 = val 9;
            // 91-99 = val 10;
            // 100 = val 11;
            string description = "";
            if (roll <= 25)
            {
                cur_val = 6;
                roll = die.Next(1, 13);
                switch (roll)
                {
                    case 1:
                        description = "Azurite";
                        break;
                    case 2:
                        description = "Banded agate";
                        break;
                    case 3:
                        description = "Blue quartz";
                        break;
                    case 4:
                        description = "Eye agate";
                        break;
                    case 5:
                        description = "Hematite";
                        break;
                    case 6:
                        description = "Lapis Lazuli";
                        break;
                    case 7:
                        description = "Malachite";
                        break;
                    case 8:
                        description = "Moss agate";
                        break;
                    case 9:
                        description = "Obsidian";
                        break;
                    case 10:
                        description = "Rhodochrosite";
                        break;
                    case 11:
                        description = "Tiger Eye";
                        break;
                    case 12:
                        description = "Turquoise";
                        break;
                }
            }
            else if (roll > 25 && roll <= 50)
            {
                cur_val = 7;
                roll = die.Next(1, 13);
                switch (roll)
                {
                    case 1:
                        description = "Bloodstone";
                        break;
                    case 2:
                        description = "Carnelian";
                        break;
                    case 3:
                        description = "Chalcedony";
                        break;
                    case 4:
                        description = "Chrysoprase";
                        break;
                    case 5:
                        description = "Citrine";
                        break;
                    case 6:
                        description = "Jasper";
                        break;
                    case 7:
                        description = "Moonstone";
                        break;
                    case 8:
                        description = "Onyx";
                        break;
                    case 9:
                        description = "Rock crystal";
                        break;
                    case 10:
                        description = "Sardonyx";
                        break;
                    case 11:
                        description = "Smoky quartz";
                        break;
                    case 12:
                        description = "Star rose quartz";
                        break;
                }
            }
            else if (roll > 50 && roll <= 70)
            {
                cur_val = 8;
                roll = die.Next(1, 13);
                switch (roll)
                {
                    case 1:
                        description = "Amber";
                        break;
                    case 2:
                        description = "Alexandrite";
                        break;
                    case 3:
                        description = "Amethyst";
                        break;
                    case 4:
                        description = "Chrysoberyl";
                        break;
                    case 5:
                        description = "Coral";
                        break;
                    case 6:
                        description = "Red garnet";
                        break;
                    case 7:
                        description = "Jade";
                        break;
                    case 8:
                        description = "Jet";
                        break;
                    case 9:
                        description = "Pearl";
                        break;
                    case 10:
                        description = "Red spinel";
                        break;
                    case 11:
                        description = "Tourmaline";
                        break;
                    case 12:
                        description = "Zircon";
                        break;
                }
            }
            else if (roll > 70 && roll <= 90)
            {
                cur_val = 9;
                roll = die.Next(1, 7);
                switch (roll)
                {
                    case 1:
                        description = "Aquamarine";
                        break;
                    case 2:
                        description = "Violet garnet";
                        break;
                    case 3:
                        description = "Black pearl";
                        break;
                    case 4:
                        description = "Peridot";
                        break;
                    case 5:
                        description = "Deep blue spinel";
                        break;
                    case 6:
                        description = "Topaz";
                        break;
                }
            }
            else if (roll > 90 && roll <= 99)
            {
                cur_val = 10;
                roll = die.Next(1, 11);
                switch (roll)
                {
                    case 1:
                        description = "Black opal";
                        break;
                    case 2:
                        description = "Emerald";
                        break;
                    case 3:
                        description = "Fire opal";
                        break;
                    case 4:
                        description = "Purple garnet";
                        break;
                    case 5:
                        description = "Blue opal";
                        break;
                    case 6:
                        description = "Oriental amethyst";
                        break;
                    case 7:
                        description = "Oriental topaz";
                        break;
                    case 8:
                        description = "Sapphire";
                        break;
                    case 9:
                        description = "Star ruby";
                        break;
                    case 10:
                        description = "Star sapphire";
                        break;
                }
            }
            else if (roll == 100)
            {
                cur_val = 11;
                roll = die.Next(1, 7);
                switch (roll)
                {
                    case 1:
                        description = "Black Sapphire";
                        break;
                    case 2:
                        description = "Diamond";
                        break;
                    case 3:
                        description = "Jacinth";
                        break;
                    case 4:
                        description = "Oriental Emerald";
                        break;
                    case 5:
                        description = "Ruby";
                        break;
                    case 6:
                        description = "Dragon gut stone";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Roll found no catagory: " + roll.ToString());
            }
            //Size roll
            roll = die.Next(0,101);
            if (roll <= 5)
            {
                cur_val -= 3;
                description += ", Tiny(.01lb)";
            }
            else if (roll > 5 && roll <= 25)
            {
                cur_val -= 2;
                description += ", Very small(.05lb)";
            }
            else if (roll > 25 && roll <= 45)
            {
                cur_val -= 1;
                description += ", Small(.1lb)";
            }
            else if (roll > 45 && roll <= 65)
            {
                description += ", Average sized(.25lb)"; 
            }
            else if (roll > 65 && roll <= 85)
            {
                cur_val += 1;
                description += ", Large(.5lb)";
            }
            else if (roll > 85 && roll <= 90)
            {
                cur_val += 2;
                description += ", Very large(.75lb)";
            }
            else if (roll > 90 && roll <= 96)
            {
                cur_val += 3;
                description += ", Huge(1lb)";
            }
            else if (roll > 96 && roll <= 99)
            {
                cur_val += 4;
                description += ", Massive(2lb)";
            }
            else if (roll == 100)
            {
                cur_val += 5;
                description += ", Gargantuan(3lb)";
            }

            // Quality roll
            roll = die.Next(0, 101);
            if (roll <= 5)
            {
                cur_val -= 3;
                description += ", Badly flawed";
            }
            else if (roll > 5 && roll <= 25)
            {
                cur_val -= 2;
                description += ", Flawed";
            }
            else if (roll > 25 && roll <= 45)
            {
                cur_val -= 1;
                description += ", Minor inclusions";
            }
            else if (roll > 45 && roll <= 65)
            {
                description += ", Average quality";
            }
            else if (roll > 65 && roll <= 85)
            {
                cur_val += 1;
                description += ", Good quality";
            }
            else if (roll > 85 && roll <= 90)
            {
                cur_val += 2;
                description += ", Excellent quality";
            }
            else if (roll > 90 && roll <= 96)
            {
                cur_val += 3;
                description += ", Near perfect quality";
            }
            else if (roll > 96 && roll <= 99)
            {
                cur_val += 4;
                description += ", Perfect quality";
            }
            else if (roll == 100)
            {
                cur_val += 5;
                description += ", Flawless";
            }

            //Ensure range min/max enforced
            if (cur_val > values.Length)
            {
                cur_val = values.Length - 1;
            }
            if (cur_val < 0)
            {
                cur_val = 0;
            }
            return description + ". Value: " + values[cur_val];
        }
    }
    public static class TextBoxCrementor
    {
        public static void CountUp(this TextBox tbx)
        {
            int current_counter;
            if (int.TryParse(tbx.Text, out current_counter))
            {
                if (current_counter >= 0)
                {
                    tbx.Text = (current_counter + 1).ToString();
                }
                else
                {
                    tbx.Text = "0";
                }
            }
            else
            {
                tbx.Text = "1";
            }
        }
        public static void CountDown(this TextBox tbx)
        {
            int current_counter;
            if (int.TryParse(tbx.Text, out current_counter))
            {
                if (current_counter > 0)
                {
                    tbx.Text = (current_counter - 1).ToString();
                }
                else
                {
                    tbx.Text = "0";
                }
            }
            else
            {
                tbx.Text = "0";
            }
        }
    }
}
