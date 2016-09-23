using EncryptionAlgorithms;
using LimitedEncryptions.Controllers;
using LimitedEncryptions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LimitedEncryptions.Views
{
    public partial class HillCipher : Form
    {
        private int plaintTextIndex = 0;
        private int plaintTextTotal = 0;

        private int keyIndex = 0;
        private int keyTotal = 0;

        private List<int[,]> keys = new List<int[,]>();

        public HillCipher()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (plaintTextIndex > 0) plaintTextIndex--;
            ReloadCounter();
            txtPlainText.Text = HillCipherController._plainTexts.ElementAt(plaintTextIndex);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (plaintTextIndex < plaintTextTotal - 1) plaintTextIndex++;
            ReloadCounter();
            txtPlainText.Text = HillCipherController._plainTexts.ElementAt(plaintTextIndex);
        }

        private void GetRamdonKeys()
        {
            keys = HillCipherController.GetNewKeys();
            txtKeys.Text = HillCipherController.KeyToString(keys[0]);
            keyTotal = keys.Count;
            ReloadCounter();
        }

        private void HillCipher_Load(object sender, EventArgs e)
        {
            txtDictionary.Text = HillCipherController.GetDictionnary();

            GetRamdonKeys();
            //keys = HillCipherController.GetNewKeys();
            plaintTextTotal = HillCipherController._plainTexts.Count;
            //keyTotal = keys.Count;
            ReloadCounter();
            txtPlainText.Text = HillCipherController._plainTexts.First();
            //txtKeys.Text = HillCipherController.KeyToString(keys[0]);

            btnGetAndExecuteNewSingleKey_Click(null, null);
            simpleButton7_Click(null, null);

        }

        private void ReloadCounter()
        {
            txtPlaintTextsCounter.Text = (plaintTextIndex + 1).ToString("00") + "\\" + plaintTextTotal.ToString("00");
            txtKeysCounter.Text = (keyIndex + 1).ToString("00") + "\\" + keyTotal.ToString("00");
        }

        private void btnGetAndExecuteNewSingleKey_Click(object sender, EventArgs e)
        {
            try
            {
                int size = new Random().Next(2, 7);
                int[,] ramdonKeys = HillCipherController.NewKey(size);

                txtKey.Text = HillCipherController.KeyToString(ramdonKeys) + '\n';

                txtInverseKey.Text = HillCipherController.KeyToInverseString(ramdonKeys) + '\n';

                txtCipherText.Text = ///"'" +
                new Hill(ramdonKeys).Encrypt(
                        HillCipherController.toPlainTextValidToKey(txtPlainText.Text, size)); ///+ "'";

                txtPlainTextDecrypt.Text = ///"'" +
                new Hill(ramdonKeys).Decrypt(
                        HillCipherController.toPlainTextValidToKey(txtCipherText.Text, ramdonKeys.GetLength(0))); ///+ "'";
            }
            catch (Exception)
            {
                MessageBox.Show("Bản rõ không hợp lệ", "Thực hiện bằng Khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (keyIndex > 0) keyIndex--;
            ReloadCounter();
            txtKeys.Text = HillCipherController.KeyToString(keys[keyIndex]);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (keyIndex < keyTotal - 1) keyIndex++;
            ReloadCounter();
            txtKeys.Text = HillCipherController.KeyToString(keys[keyIndex]);
        }

        private void btnExecuteSingleKey_Click(object sender, EventArgs e)
        {
            try
            {
                txtInverseKey.Text = HillCipherController.KeyToInverseString(keys[keyIndex]) + '\n';

                txtCipherText.Text = ///"'" +
                new Hill(keys[keyIndex]).Encrypt(
                        HillCipherController.toPlainTextValidToKey(txtPlainText.Text, keys[keyIndex].GetLength(0))); ///+ "'";

                txtPlainTextDecrypt.Text = ///"'" +
                new Hill(keys[keyIndex]).Decrypt(
                        HillCipherController.toPlainTextValidToKey(txtCipherText.Text, keys[keyIndex].GetLength(0))); ///+ "'";
            }
            catch (Exception)
            {
                MessageBox.Show("Bản rõ không hợp lệ", "Thực hiện bằng Khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            List<StatisticResult> list
                = HillCipherController.GetListStatisticResult(HillCipherController._plainTexts, keys);

            /// Average Keys
            List<AverageStatisticResult> averageList
                = HillCipherController.GetListKeyAverageStatisticResult(HillCipherController._plainTexts, keys, list);

            /// Average Plain Texts
            List<AverageStatisticResult> averageTextList
                = HillCipherController.GetListPlainTextAverageStatisticResult(HillCipherController._plainTexts, keys, list);

            /// By Keys
            richTextBox1.Text = "";
            foreach (var item in averageList)
            {
                richTextBox1.Text += item.ToString() + '\n';
            }

            /// By Plain Texts
            richTextBox2.Text = "";
            foreach (var item in averageTextList)
            {
                richTextBox2.Text += item.ToString() + '\n';
            }

            /// Show by key chart
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Thống kê theo khóa");
            this.chart1.Series.Clear();

            long total = 0;
            Series series;
            foreach (var item in averageList)
            {
                series = chart1.Series.Add("Khóa " + (item.Key + 1).ToString());
                series.Points.Add(item.AverageTicks);
                total += item.AverageTicks;
            }
            series = chart1.Series.Add("Trung bình");
            series.Points.Add(total / averageList.Count);
            chart1.ResetAutoValues();

            /// Show by plaint text chart
            this.chart2.Titles.Clear();
            this.chart2.Titles.Add("Thống kê theo bản rõ");
            this.chart2.Series.Clear();

            total = 0;
            foreach (var item in averageTextList)
            {
                series = chart2.Series.Add("Bản rõ " + (item.Key + 1).ToString());
                series.Points.Add(item.AverageTicks);
                total += item.AverageTicks;
            }
            series = chart2.Series.Add("Trung bình");
            series.Points.Add(total / averageTextList.Count);
            chart2.ResetAutoValues();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            GetRamdonKeys();
        }

        private void btnExecuteCustom_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] customKey = HillCipherController.KeyStringToArrayKey(txtCustomKey.Text);
                txtInverseKey.Text = HillCipherController.KeyToInverseString(customKey) + '\n';

                MatrixClass customMatrix = new MatrixClass(customKey);
                if (customMatrix.Inverse().Equals(MatrixClass.NullMatrixClass(customKey.GetLength(0), customKey.GetLength(0))))
                {
                    MessageBox.Show("Khóa nhập vào không có ma trận nghịch đảo", "Thực hiện với khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ;
                }

                txtCipherText.Text = ///"'" +
                    new Hill(customKey).Encrypt(
                        HillCipherController.toPlainTextValidToKey(txtPlainText.Text, customKey.GetLength(0))); ///+ "'";

                txtPlainTextDecrypt.Text = ///"'" +
                    new Hill(customKey).Decrypt(
                        HillCipherController.toPlainTextValidToKey(txtCipherText.Text, customKey.GetLength(0))); ///+ "'";
            }
            catch (MatrixClassException)
            {
                MessageBox.Show("Khóa nhập vào không có ma trận nghịch đảo", "Thực hiện với khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ", "Thực hiện với khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadFile_click(object sender, EventArgs e)
        {
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPlainText.Text = File.ReadAllText(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mở file không thành công", "Mở file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
