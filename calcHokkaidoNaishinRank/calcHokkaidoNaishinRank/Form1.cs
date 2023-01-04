using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcHokkaidoNaishinRank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnableComboBox1.Items.Add("1");
            EnableComboBox1.Items.Add("2");
            EnableComboBox1.Items.Add("3");
            EnableComboBox1.Items.Add("4");
            EnableComboBox1.Items.Add("5");
            EnableComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox1.SelectedIndex = 4;
            EnableComboBox2.Items.Add("1");
            EnableComboBox2.Items.Add("2");
            EnableComboBox2.Items.Add("3");
            EnableComboBox2.Items.Add("4");
            EnableComboBox2.Items.Add("5");
            EnableComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox2.SelectedIndex = 4;
            EnableComboBox3.Items.Add("1");
            EnableComboBox3.Items.Add("2");
            EnableComboBox3.Items.Add("3");
            EnableComboBox3.Items.Add("4");
            EnableComboBox3.Items.Add("5");
            EnableComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox3.SelectedIndex = 4;
            EnableComboBox4.Items.Add("1");
            EnableComboBox4.Items.Add("2");
            EnableComboBox4.Items.Add("3");
            EnableComboBox4.Items.Add("4");
            EnableComboBox4.Items.Add("5");
            EnableComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox4.SelectedIndex = 4;
            EnableComboBox5.Items.Add("1");
            EnableComboBox5.Items.Add("2");
            EnableComboBox5.Items.Add("3");
            EnableComboBox5.Items.Add("4");
            EnableComboBox5.Items.Add("5");
            EnableComboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox5.SelectedIndex = 4;
            EnableComboBox6.Items.Add("1");
            EnableComboBox6.Items.Add("2");
            EnableComboBox6.Items.Add("3");
            EnableComboBox6.Items.Add("4");
            EnableComboBox6.Items.Add("5");
            EnableComboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox6.SelectedIndex = 4;
            EnableComboBox7.Items.Add("1");
            EnableComboBox7.Items.Add("2");
            EnableComboBox7.Items.Add("3");
            EnableComboBox7.Items.Add("4");
            EnableComboBox7.Items.Add("5");
            EnableComboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox7.SelectedIndex = 4;
            EnableComboBox8.Items.Add("1");
            EnableComboBox8.Items.Add("2");
            EnableComboBox8.Items.Add("3");
            EnableComboBox8.Items.Add("4");
            EnableComboBox8.Items.Add("5");
            EnableComboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox8.SelectedIndex = 4;
            EnableComboBox9.Items.Add("1");
            EnableComboBox9.Items.Add("2");
            EnableComboBox9.Items.Add("3");
            EnableComboBox9.Items.Add("4");
            EnableComboBox9.Items.Add("5");
            EnableComboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox9.SelectedIndex = 4;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 4;
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 4;
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");
            comboBox3.Items.Add("5");
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.SelectedIndex = 4;
            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");
            comboBox4.Items.Add("4");
            comboBox4.Items.Add("5");
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.SelectedIndex = 4;
            comboBox5.Items.Add("1");
            comboBox5.Items.Add("2");
            comboBox5.Items.Add("3");
            comboBox5.Items.Add("4");
            comboBox5.Items.Add("5");
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.SelectedIndex = 4;
            comboBox6.Items.Add("1");
            comboBox6.Items.Add("2");
            comboBox6.Items.Add("3");
            comboBox6.Items.Add("4");
            comboBox6.Items.Add("5");
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.SelectedIndex = 4;
            comboBox7.Items.Add("1");
            comboBox7.Items.Add("2");
            comboBox7.Items.Add("3");
            comboBox7.Items.Add("4");
            comboBox7.Items.Add("5");
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.SelectedIndex = 4;
            comboBox8.Items.Add("1");
            comboBox8.Items.Add("2");
            comboBox8.Items.Add("3");
            comboBox8.Items.Add("4");
            comboBox8.Items.Add("5");
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.SelectedIndex = 4;
            comboBox9.Items.Add("1");
            comboBox9.Items.Add("2");
            comboBox9.Items.Add("3");
            comboBox9.Items.Add("4");
            comboBox9.Items.Add("5");
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.SelectedIndex = 4;
            comboBox31.Items.Add("1");
            comboBox31.Items.Add("2");
            comboBox31.Items.Add("3");
            comboBox31.Items.Add("4");
            comboBox31.Items.Add("5");
            comboBox31.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox31.SelectedIndex = 4;
            comboBox32.Items.Add("1");
            comboBox32.Items.Add("2");
            comboBox32.Items.Add("3");
            comboBox32.Items.Add("4");
            comboBox32.Items.Add("5");
            comboBox32.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox32.SelectedIndex = 4;
            comboBox33.Items.Add("1");
            comboBox33.Items.Add("2");
            comboBox33.Items.Add("3");
            comboBox33.Items.Add("4");
            comboBox33.Items.Add("5");
            comboBox33.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox33.SelectedIndex = 4;
            comboBox34.Items.Add("1");
            comboBox34.Items.Add("2");
            comboBox34.Items.Add("3");
            comboBox34.Items.Add("4");
            comboBox34.Items.Add("5");
            comboBox34.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox34.SelectedIndex = 4;
            comboBox35.Items.Add("1");
            comboBox35.Items.Add("2");
            comboBox35.Items.Add("3");
            comboBox35.Items.Add("4");
            comboBox35.Items.Add("5");
            comboBox35.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox35.SelectedIndex = 4;
            comboBox36.Items.Add("1");
            comboBox36.Items.Add("2");
            comboBox36.Items.Add("3");
            comboBox36.Items.Add("4");
            comboBox36.Items.Add("5");
            comboBox36.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox36.SelectedIndex = 4;
            comboBox37.Items.Add("1");
            comboBox37.Items.Add("2");
            comboBox37.Items.Add("3");
            comboBox37.Items.Add("4");
            comboBox37.Items.Add("5");
            comboBox37.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox37.SelectedIndex = 4;
            comboBox38.Items.Add("1");
            comboBox38.Items.Add("2");
            comboBox38.Items.Add("3");
            comboBox38.Items.Add("4");
            comboBox38.Items.Add("5");
            comboBox38.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox38.SelectedIndex = 4;
            comboBox39.Items.Add("1");
            comboBox39.Items.Add("2");
            comboBox39.Items.Add("3");
            comboBox39.Items.Add("4");
            comboBox39.Items.Add("5");
            comboBox39.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox39.SelectedIndex = 4;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        // 学年の定数
        public const int FIRST = 1;
        public const int SECOND = 2;
        public const int THIRD = 3;

        // 学年設定の保持
        private int grade = FIRST;


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstGrade_Click(object sender, EventArgs e)
        {
            grade = FIRST;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void secondGrade_Click(object sender, EventArgs e)
        {
            grade = SECOND;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void thirdGrade_Click(object sender, EventArgs e)
        {
            grade= THIRD;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // 内申点の合計を保持
            int naishin = 0;
            
            // 1年生の評価を配列化
            string[] firstNaishin = {
                EnableComboBox1.SelectedItem.ToString(),
                EnableComboBox2.SelectedItem.ToString(),
                EnableComboBox3.SelectedItem.ToString(),
                EnableComboBox4.SelectedItem.ToString(),
                EnableComboBox5.SelectedItem.ToString(),
                EnableComboBox6.SelectedItem.ToString(),
                EnableComboBox7.SelectedItem.ToString(),
                EnableComboBox8.SelectedItem.ToString(),
                EnableComboBox9.SelectedItem.ToString()
            };
            
             // 2年生の評価を配列化
             string[] secondNaishin = {
                 comboBox1.SelectedItem.ToString(),
                 comboBox2.SelectedItem.ToString(),
                 comboBox3.SelectedItem.ToString(),
                 comboBox4.SelectedItem.ToString(),
                 comboBox5.SelectedItem.ToString(),
                 comboBox6.SelectedItem.ToString(),
                 comboBox7.SelectedItem.ToString(),
                 comboBox8.SelectedItem.ToString(),
                 comboBox9.SelectedItem.ToString()
             };
             
            // 3年生の評価を配列化
            string[] thirdNaishin = {
                comboBox31.SelectedItem.ToString(),
                comboBox32.SelectedItem.ToString(),
                comboBox33.SelectedItem.ToString(),
                comboBox34.SelectedItem.ToString(),
                comboBox35.SelectedItem.ToString(),
                comboBox36.SelectedItem.ToString(),
                comboBox37.SelectedItem.ToString(),
                comboBox38.SelectedItem.ToString(),
                comboBox39.SelectedItem.ToString()
            };
            
            // 内申点の計算
            switch (grade)
            {
                case FIRST:
                    naishin += baseSummary(firstNaishin) * 7;
                    break;
                case SECOND:
                    naishin += baseSummary(firstNaishin) * 2;
                    naishin += baseSummary(secondNaishin) * 5;
                    break;
                default:
                    naishin += baseSummary(firstNaishin) * 2;
                    naishin += baseSummary(secondNaishin) * 2;
                    naishin += baseSummary(thirdNaishin) * 3;
                    break;
            }
            
            // メッセージ出力
            MessageBox.Show("内申点は、" + naishin + "点。\n" + "ランクは" + rankSummary(naishin) + "です。"); 
        }

        // 内申点ベース計算
        private int baseSummary(string[] subject)
        {
            int basePoint = 0;
            for (int i = 0; i < subject.Length; i++)
            {
                basePoint += Int32.Parse(subject[i]);
            }
            return basePoint;
        }

        // ランク算出
        private string rankSummary(int naishin)
        {
            string rank;
            if(naishin > 295)
            {
                rank = "A";
            }
            else if(naishin > 275)
            {
                rank = "B";
            }
            else if(naishin > 255)
            {
                rank = "C";
            }
            else if(naishin > 235)
            {
                rank = "D";
            }
            else if(naishin > 215)
            {
                rank = "E";
            }
            else if(naishin > 195)
            {
                rank = "F";
            }
            else if(naishin > 175)
            {
                rank = "G";
            }
            else if(naishin > 155)
            {
                rank = "H";
            }
            else if(naishin > 135)
            {
                rank = "I";
            }
            else if(naishin > 115)
            {
                rank = "J";
            }
            else if(naishin > 95)
            {
                rank = "K";
            }
            else if(naishin > 75)
            {
                rank = "L";
            }
            else
            {
                rank = "M";
            }
            return rank;
        }
    }
}
