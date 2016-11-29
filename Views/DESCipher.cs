using LimitedEncryptions.Controllers;
using LimitedEncryptions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LimitedEncryptions.Views
{
    public partial class DESCipher : Form
    {
        #region Properties
        private List<string> keys = new List<string>();
        private List<string> plainTexts = new List<string>();

        private int plainTextIndex = 0;
        private int keyIndex = 0;

        private bool useHashing
        {
            get
            {
                if (rbtnHashingYes.Checked) return true;
                return false;
            }
        }

        private bool useDES
        {
            get
            {
                if (rbtnDES.Checked) return true;
                return false;
            }
        }

        private List<StatisticResult> ListStatisticResult { get; set; }
        private List<AverageStatisticResult> ListAverageKeyList { get; set; }
        private List<AverageStatisticResult> ListAveragePlainTextList { get; set; }

        #endregion

        public DESCipher()
        {
            InitializeComponent();
        }

        private void DESCipher_Load(object sender, EventArgs e)
        {
            GetRamdonKeys();
            GetPlainTexts();
            txtKey.Text = DESCipherController.GetNewKey(new Random());

            ReloadCounter();
            txtPlainText.Text = DESCipherController.plainTexts.First();

            btnStatistics_Click(null, null);
            btnStatistics_Click(null, null);
            ///new Thread(new ThreadStart(ThreadInit)).Start();
            btnExecuteSingleKey_Click(null, null);
        }

        private void ThreadInit()
        {
            btnStatistics_Click(null, null);
            btnStatistics_Click(null, null);
            btnExecuteSingleKey_Click(null, null);
        }

        private void GetPlainTexts()
        {
            plainTexts = DESCipherController.plainTexts;
        }

        private void GetRamdonKeys()
        {
            keys = DESCipherController.GetNewKeys();
            txtKeys.Text = keys[0];///DESCipherController.KeyToString(keys[0]);

            ReloadCounter();
        }

        private void btnGetRandomKeys_click(object sender, EventArgs e)
        {
            GetRamdonKeys();
        }

        private void ReloadCounter()
        {
            txtPlaintTextsCounter.Text = (plainTextIndex + 1).ToString("00") + "\\" + plainTexts.Count.ToString("00");
            txtKeysCounter.Text = (keyIndex + 1).ToString("00") + "\\" + keys.Count.ToString("00");
        }

        private void Execute(RichTextBox txtCipherText, RichTextBox txtPlainTextDecrypt, RichTextBox txtHashKey, string plainText, string Key)
        {
            try
            {
                txtCipherText.Text = DESCipherController.Encrypt(plainText, Key, useDES, useHashing);
                txtPlainTextDecrypt.Text = DESCipherController.Decrypt(txtCipherText.Text, Key, useDES, useHashing);

                if (useHashing) txtHashKey.Text = DESCipherController.HashingKey(Key);
                else txtHashKey.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không phù hợp", "Thực hiện mã hóa và giải mã kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ExecuteDecrypt(RichTextBox txtPlainText, RichTextBox txtCipherText, RichTextBox txtPlainTextDecrypt, RichTextBox txtHashKey, string cipherText, string Key)
        {
            try
            {
                txtPlainText.Text = DESCipherController.Decrypt(cipherText, Key, useDES, useHashing);
                txtPlainTextDecrypt.Text = DESCipherController.Decrypt(cipherText, Key, useDES, useHashing);

                if (useHashing) txtHashKey.Text = DESCipherController.HashingKey(Key);
                else txtHashKey.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không phù hợp", "Thực hiện giải mã và giải mã kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Navigation Buttons
        private void btnPreviousKey_Click(object sender, EventArgs e)
        {
            if (keyIndex > 0) keyIndex--;

            txtKeys.Text = keys[keyIndex];
            ReloadCounter();
        }

        private void btnNextKey_Click(object sender, EventArgs e)
        {
            if (keyIndex < keys.Count - 1) keyIndex++;

            txtKeys.Text = keys[keyIndex];
            ReloadCounter();
        }

        private void btnPreviousPlainText_Click(object sender, EventArgs e)
        {
            if (plainTextIndex > 0) plainTextIndex--;

            txtPlainText.Text = plainTexts[plainTextIndex];
            ReloadCounter();
        }

        private void btnNextPlainText_Click(object sender, EventArgs e)
        {
            if (plainTextIndex < plainTexts.Count - 1) plainTextIndex++;

            txtPlainText.Text = plainTexts[plainTextIndex];
            ReloadCounter();
        }
        #endregion

        #region Execute Buttons
        private void btnGetAndExecuteNewSingleKey_Click(object sender, EventArgs e)
        {
            try
            {
                txtKey.Text = DESCipherController.GetNewKey(new Random());

                Execute(txtCipherText, txtPlainTextDecrypt, txtHashKey, txtPlainText.Text, txtKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Khóa không hợp lệ", "Mã hóa và giải mã bằng mã ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExecuteSingleKey_Click(object sender, EventArgs e)
        {
            try
            {
                Execute(txtCipherText, txtPlainTextDecrypt, txtHashKey, txtPlainText.Text, txtKeys.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Khóa không hợp lệ", "Mã hóa và giải mã bằng mã ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExecuteCustomKey_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCustomKey.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khóa", "Mã hóa và giải mã bằng mã tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Execute(txtCipherText, txtPlainTextDecrypt, txtHashKey, txtPlainText.Text, txtCustomKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Khóa không hợp lệ", "Mã hóa và giải mã bằng mã tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion



        private void btnStatistics_Click(object sender, EventArgs e)
        {
            List<StatisticResult> list
               = DESCipherController.GetListStatisticResult(useDES, plainTexts, keys);

            this.ListStatisticResult = list;

            /// Average Keys
            List<AverageStatisticResult> averageList
                = DESCipherController.GetListKeyAverageStatisticResult(plainTexts, keys, list);

            this.ListAverageKeyList = averageList;

            /// Average Plain Texts
            List<AverageStatisticResult> averageTextList
                = DESCipherController.GetListPlainTextAverageStatisticResult(plainTexts, keys, list);

            this.ListAveragePlainTextList = averageTextList;

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

        private void btnOpenFile(object sender, EventArgs e)
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
                MessageBox.Show("Mở file không thành công", "Mở file bản rõ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOpenFileForCipherText_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCipherText.Text = File.ReadAllText(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mở file không thành công", "Mở file bản mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOpenCustomKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCustomKey.Text = File.ReadAllText(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mở file không thành công", "Mở file khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveFilePlainText_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtPlainText.Text);

                    MessageBox.Show("Lưu file  thành công", "Lưu file bản rõ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file không thành công", "Lưu file bản rõ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveFileCipherText_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtCipherText.Text);

                    MessageBox.Show("Lưu file thành công", "Lưu file bản mã", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file không thành công", "Lưu file bản mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveRandomKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtKeys.Text);

                    MessageBox.Show("Lưu file thành công", "Lưu file khóa bộ ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file không thành công", "Lưu file khóa bộ ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveRandomKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtKey.Text);

                    MessageBox.Show("Lưu file thành công", "Lưu file khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file không thành công", "Lưu file khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveCustomKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtCustomKey.Text);

                    MessageBox.Show("Lưu file thành công", "Lưu file khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file không thành công", "Lưu file khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveStatistics(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string Result = "Thống kê đầy đủ: " + "\r\n";

                    foreach (var item in this.ListStatisticResult)
                    {
                        Result += item.ToString() + "\r\n";
                    }

                    Result += "\r\n" + "Thống kê theo bản rõ: " + "\r\n";
                    foreach (var item in this.ListAveragePlainTextList)
                    {
                        Result += item.ToString() + "\r\n";
                    }

                    Result += "\r\n" + "Thống kê theo khóa: " + "\r\n";
                    foreach (var item in this.ListAverageKeyList)
                    {
                        Result += item.ToString() + "\r\n";
                    }

                    File.WriteAllText(saveFileDialog.FileName, Result);

                    MessageBox.Show("Xuất file thống kê thành công", "Xuất file thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xuất file thống kê không thành công", "Xuất file thống kê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Decrypt Buttons
        private void btnExecuteDecryptSingleKey_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteDecrypt(txtPlainText, txtCipherText, txtPlainTextDecrypt, txtHashKey, txtCipherText.Text, txtKeys.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Giải mã bằng bộ khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExecuteDecryptRandomKey_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteDecrypt(txtPlainText, txtCipherText, txtPlainTextDecrypt, txtHashKey, txtCipherText.Text, txtKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Giải mã bằng khóa ngẫu nhiên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExecuteDecryptCustomKey_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteDecrypt(txtPlainText, txtCipherText, txtPlainTextDecrypt, txtHashKey, txtCipherText.Text, txtCustomKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Giải mã bằng khóa tự nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void btnClearPlainText_Click(object sender, EventArgs e)
        {
            txtPlainText.Clear();
        }

        private void btnClearCipherText_Click(object sender, EventArgs e)
        {
            txtCipherText.Clear();
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            HillCipher hillCipher = new HillCipher();
            hillCipher.Show();
        }
    }
}
