using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CardList;
//using DocumentFormat.OpenXml.Packaging;
using System.Xml;

namespace CardGen
{
    public partial class Form1 : Form
    {
        int drawCardCount;
        public Form1()
        {
            InitializeComponent();
            drawCardCount = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawCardCount = 0;
            string CardIndex = "";


            CardDeck cards = new CardDeck();
            string drawCards = "";
            try
            {
                string temp1 ="DEAL=> "+ " "+ Card1.SelectedItem.ToString() + " " + Card2.SelectedItem.ToString() + " " + Card3.SelectedItem.ToString() + " " + Card4.SelectedItem.ToString() + " " +
                              Card5.SelectedItem.ToString()+"  "+"DRAW=>"+" ";
                CardIndex = Card1.SelectedIndex.ToString() + " " + Card2.SelectedIndex.ToString() + " " + Card3.SelectedIndex.ToString() + " " + Card4.SelectedIndex.ToString() + " " +
                              Card5.SelectedIndex.ToString() + " ";

                if (Card6.Enabled == true)
                {
                    drawCardCount++;
                    drawCards += Card6.SelectedItem.ToString() + " ";
                    CardIndex += Card6.SelectedIndex.ToString() + " ";
                }
                if (Card7.Enabled == true)
                {
                    drawCardCount++;
                    drawCards += Card7.SelectedItem.ToString() + " ";
                    CardIndex += Card7.SelectedIndex.ToString() + " ";
                }
                if (Card8.Enabled == true)
                {
                    drawCardCount++;
                    drawCards += Card8.SelectedItem.ToString() + " ";
                    CardIndex += Card8.SelectedIndex.ToString() + " ";
                }
                if (Card9.Enabled == true)
                {
                    drawCardCount++;
                    drawCards += Card9.SelectedItem.ToString() + " ";
                    CardIndex += Card9.SelectedIndex.ToString() + " ";
                }
                if (Card10.Enabled == true)
                {
                    drawCardCount++;
                    drawCards += Card10.SelectedItem.ToString() + " ";
                    CardIndex += Card10.SelectedIndex.ToString() + " ";
                }

                string CardRank = temp1 + " " + drawCards;


                // string temp3 = CardDeck.getCardindex(temp2, cards);
                if (((Paytable)listBox1.SelectedItem).BonusAward != null)
                {
                    // Output.Text += processindex(CardRank, drawCardCount, CardIndex) + " " + ((Paytable)listBox1.SelectedItem).Hand + "..." + "Pays " + ((Paytable)listBox1.SelectedItem).Award + " " + " Bonus " + ((Paytable)listBox1.SelectedItem).BonusAward + "\r\n";
                    Output.AppendText(processindex(CardRank, drawCardCount, CardIndex) + " " + ((Paytable)listBox1.SelectedItem).Hand + "..." + "Pays " + ((Paytable)listBox1.SelectedItem).Award + " " + " Bonus " + ((Paytable)listBox1.SelectedItem).BonusAward + "\r\n");
                }
                else
                {
                   // Output.Text += processindex(CardRank, drawCardCount, CardIndex) + " " + ((Paytable)listBox1.SelectedItem).Hand + "..." + "Pays " + ((Paytable)listBox1.SelectedItem).Award + "\r\n";
                    
                    Output.AppendText(processindex(CardRank, drawCardCount, CardIndex) + " " + ((Paytable)listBox1.SelectedItem).Hand + "..." + "Pays " + ((Paytable)listBox1.SelectedItem).Award + "\r\n");
                }
            } 


            catch (NullReferenceException)
            {

                MessageBox.Show("Please check that each card is selected and paytable is imported.");

            }

        }
        public string processindex(string cardRank, int drawCount, string index)
        {
            string temp = " ";
            if (drawCount == 4)
            {
                temp = "holdone" + " " + index + " #  " + cardRank;

            }
            else if (drawCount == 3)
            {
                temp = "holdtwo" + " " + index + " #  " + cardRank;

            }
            else if (drawCount == 2)
            {
                temp = "holdthree" + " " + index + " #  " + cardRank;

            }
            else if (drawCount == 1)
                temp = "holdfour" + " " + index + " #  " + cardRank;
            else if (drawCount==5)
                temp = "nohold" + " " + index + " #  " + cardRank;
            else
                temp= "holdfive" + " " + index + " #  " + cardRank;

            return temp;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            SaveFileDialog NewFile = new SaveFileDialog();
            if (NewFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter cardstosave1 = new StreamWriter(File.Create(NewFile.FileName));
                cardstosave1.Write("set height 0" + "\r\n" +
                                    "b breakpfilename_:**" + "\r\n" +
                                    "c" + "\r\n" +
                                    "shell clear" + "\r\n" +

                                    "printf " + "\""+" Use this function to verify all patterns-- > verify_patterns" + "\"" + "\r\n" +
                                    "printf " + "\""+"\\n"+"\""+ "\r\n" + "\r\n" +
                                    "define holdone" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c" + "\r\n" +
                                    "set outcomes[0]=$arg5" + "\r\n" +
                                    "set outcomes[1]=$arg6" + "\r\n" +
                                    "set outcomes[2]=$arg7" + "\r\n" +
                                    "set outcomes[3]=$arg8" + "\r\n" +
                                    "c" + "\r\n" +
                                    "end" + "\r\n" + "\r\n" +
                                    "define holdtwo" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c" + "\r\n" +
                                    "set outcomes[0]=$arg5" + "\r\n" +
                                    "set outcomes[1]=$arg6" + "\r\n" +
                                    "set outcomes[2]=$arg7" + "\r\n" +
                                    "c"+"\r\n"+
                                    "end" + "\r\n" + "\r\n" +
                                    "define holdthree" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c" + "\r\n" +
                                    "set outcomes[0]=$arg5" + "\r\n" +
                                    "set outcomes[1]=$arg6" + "\r\n" + "\r\n" +
                                    "c" + "\r\n" +
                                    "end"+"\r\n"+"\r\n"+
                                    "define holdfour" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c"+"\r\n"+
                                    "set outcomes[0]=$arg5" + "\r\n" +
                                    "c"+"\r\n"+
                                    "end" + "\r\n" + "\r\n" +
                                    "define nohold" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c" + "\r\n" +
                                    "set outcomes[0]=$arg5" + "\r\n" +
                                    "set outcomes[1]=$arg6" + "\r\n" +
                                    "set outcomes[2]=$arg7" + "\r\n" +
                                    "set outcomes[3]=$arg8" + "\r\n" +
                                    "set outcomes[4]=$arg9" + "\r\n" +
                                    "c" + "\r\n" +
                                    "end" + "\r\n" + "\r\n"+
                                    "define holdfive" + "\r\n" +
                                    "set outcomes[0]=$arg0" + "\r\n" +
                                    "set outcomes[1]=$arg1" + "\r\n" +
                                    "set outcomes[2]=$arg2" + "\r\n" +
                                    "set outcomes[3]=$arg3" + "\r\n" +
                                    "set outcomes[4]=$arg4" + "\r\n" +
                                    "c" + "\r\n"+
                                    "end" + "\r\n" + "\r\n"


                                    );
                cardstosave1.Write("define verify_patterns" + "\r\n");
                cardstosave1.Write(Output.Text);
                cardstosave1.Write("end" + "\r\n");
               
                cardstosave1.Dispose();
            }
        }


        private void Output_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Card1.ClearSelected();
            Card2.ClearSelected();
            Card3.ClearSelected();
            Card4.ClearSelected();
            Card5.ClearSelected();
            Card6.ClearSelected();
            Card7.ClearSelected();
            Card8.ClearSelected();
            Card9.ClearSelected();
            Card10.ClearSelected();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CardDeck cards = new CardDeck();
            try
            {
                string temp1 = DUcard1.SelectedItem.ToString() + " " + DUcard2.SelectedItem.ToString() + " " + DUcard3.SelectedItem.ToString() + " " + DUcard4.SelectedItem.ToString() + " " +
                              DUcard5.SelectedItem.ToString();

                string temp2 = CardDeck.getCardindex(temp1, cards);
                DU_Output.Text += "set_5out " + temp2 + "     #      " + temp1 + "\r\n";
            }


            catch (NullReferenceException)
            {

                MessageBox.Show("Please check that each card is selected.");

            }

        }

        private void DU_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DU_Output.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog NewFile = new SaveFileDialog();
            if (NewFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter cardstosave1 = new StreamWriter(File.Create(NewFile.FileName));
                cardstosave1.Write(DU_Output.Text);
                cardstosave1.Dispose();
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                Card7.Enabled = false;
            else Card7.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                Card6.Enabled = false;
            else Card6.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                Card8.Enabled = false;
            else Card8.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                Card9.Enabled = false;
            else Card9.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                Card10.Enabled = false;
            else Card10.Enabled = true;
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<Paytable> mainDefinition = new List<Paytable>();
            textBox1.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "xml file|*.xml";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                XmlDocument paytable = new XmlDocument();
                paytable.Load(openFile.FileName);
                XmlElement element = paytable.DocumentElement;
                XmlNodeList weightlist = element.GetElementsByTagName("CombinationGroup");
               // XmlNodeList FinalList = RemoveDuplicate(weightlist[0]);
                foreach (XmlNode node in weightlist[0])
                {
                
                   
                        if (node.Attributes["bonusaward"] != null)
                        {

                            mainDefinition.Add(new Paytable(node.Attributes["award"].Value, node.Attributes["id"].Value, node.Attributes["bonusaward"].Value));
                            textBox1.Text += node.Attributes["id"].Value + " " + node.Attributes["award"].Value + " " + node.Attributes["bonusaward"].Value + " " + "\r\n";
                        }
                        else if ((node.PreviousSibling.Attributes["id"].Value != node.Attributes["id"].Value))
                        {
                            mainDefinition.Add(new Paytable(node.Attributes["award"].Value, node.Attributes["id"].Value));
                            textBox1.Text += node.Attributes["id"].Value + " " + node.Attributes["award"].Value + " " + "\r\n";
                        }
                        }
                    
                
                listBox1.DataSource = mainDefinition;
                listBox1.DisplayMember = "Hand";
               

            }
           
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Paytable
    {
        private string award;
        private string hand;
        private string bonusAward;
 public Paytable(string a, string h, string b)
        {

            award = a;
            hand = h;
            bonusAward = b;

        }
 public Paytable(string a, string h)
        {

            award = a;
            hand = h;
            

        }
        public string Award
        {

            get
            {
                return award;
            }
        }
public string Hand
        {

            get
            {
                return hand;
            }
        }
 public string BonusAward
        {

            get
            {
                return bonusAward;
            }
        }

    }



}
