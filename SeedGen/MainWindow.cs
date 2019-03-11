using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace SeedGen
{
    public partial class MainWindow : Form
    {
        public MainWindow(String[] args)
        {
            InitializeComponent();

            minHashValues = new long[maxStrLength + 1];
            for (int strLength = 0; strLength <= maxStrLength; strLength++)
                minHashValues[strLength] = Pow(31, strLength) / (31 - 1) * minChar;

            maxHashValues = new long[maxStrLength + 1];
            for (int strLength = 0; strLength <= maxStrLength; strLength++)
                maxHashValues[strLength] = Pow(31, strLength) / (31 - 1) * maxChar;

            if (args.Length > 0)
            {
                String cutie = args[0];
                if (cutie == "force")
                {
                    trackBar.Maximum = 64;
                }
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            seedLengthText.Text = "Seed Length: " + trackBar.Value;
        }

        private void s2n_CheckedChanged(object sender, EventArgs e)
        {
            if (s2n.Checked) {
                parameters.Visible = false;
                outputBox.Text = "";
                outputBox.Enabled = true;
            } else {
                parameters.Visible = true;
                outputBox.Text = "N/A";
                outputBox.Enabled = false;
            }
        }

        private void n2s_CheckedChanged(object sender, EventArgs e)
        {
            if (n2s.Checked)
            {
                parameters.Visible = true;
                outputBox.Text = "N/A";
                outputBox.Enabled = false;
            }
            else
            {
                parameters.Visible = false;
                outputBox.Text = "";
                outputBox.Enabled = true;
            }
        }

        private void s2s_CheckedChanged(object sender, EventArgs e)
        {
            if (s2s.Checked)
            {
                parameters.Visible = true;
                outputBox.Text = "N/A";
                outputBox.Enabled = false;
            }
            else
            {
                parameters.Visible = false;
                outputBox.Text = "";
                outputBox.Enabled = true;
            }
        }

        public void buttonGen_Click(object sender, EventArgs e)
        {
            if (!s2n.Checked)
            {
                string tempseed = seedBox.Text;
                long seedlong;
                int seed;

                if (s2s.Checked)
                {
                    tempseed = "" + javahash(tempseed);
                }

                if (Int32.TryParse(tempseed, out seed))
                {
                    MessageBox.Show("This might take a little while, are you sure you want to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult a = MessageBox.Show("not so fast! this can take a long time and can take up large amounts of disk space!", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (a == DialogResult.OK)
                    {
                        buttonGen.Enabled = false;
                        buttonGen.Text = "Generating";
                        GuessHash(seed, trackBar.Value);
                        MessageBox.Show("Generated to output.txt", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonGen.Text = "Generate";
                        buttonGen.Enabled = true;
                    }
                }
                else
                {
                    if (Int64.TryParse(tempseed, out seedlong))
                    {
                        MessageBox.Show("Error 2: The selected seed appears to be a 64-bit signed integer, which is not supported: " + seedlong, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error 1: This doesn't appear to be a valid 32-bit or 64-bit signed integer: " + seedlong, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else if (s2n.Checked)
            {
                string seedstr = seedBox.Text;
                outputBox.Text = ""+javahash(seedstr);
            }
            else
            {
                MessageBox.Show("Error 0: This shouldn't ever appear, something terrible happened.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        const int minChar = 32;

        const int maxChar = 126;

        // limit maxStrLength to make sure that max hash value does not exceed long.MaxValue (2^63 - 1)
        const int maxStrLength = 12;

        static long[] minHashValues;

        static long[] maxHashValues;

        static void GuessHash(int hash, int maxLength = 256)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var timeLimit = new TimeSpan(0, 15, 0);

            if (maxLength > maxStrLength)
                maxLength = maxStrLength;

            long currentHash = (uint)hash;
            long step = 1L << 32;

            const int bufferSize = 32 * 1024;
            using (var writer = new StreamWriter("output.txt", false, new UTF8Encoding(false), bufferSize))
            {
                for (int strLength = 0; strLength <= maxLength; strLength++)
                {
                    long maxHash = maxHashValues[strLength];
                    if (currentHash > maxHash)
                        continue;

                    long minHash = minHashValues[strLength];
                    while (currentHash < minHash)
                        currentHash += step;

                    while ((currentHash <= maxHash) && (sw.Elapsed < timeLimit))
                    {
                        GuessLongHash(writer, currentHash, new char[strLength], strLength - 1);
                        currentHash += step;
                    }
                }
            }
        }

        static void GuessLongHash(System.IO.StreamWriter writer, long hash, char[] chars, int charPos)
        {
            if (hash <= maxChar)
            {
                char ch = (char)hash;
                if (ch >= minChar)
                {
                    chars[charPos] = ch;
                    writer.WriteLine(new string(chars));
                }
                return;
            }

            char c = (char)(hash % 31);
            while (c < minChar)
                c += (char)31;

            while (c <= maxChar)
            {
                chars[charPos] = c;
                GuessLongHash(writer, (hash - c) / 31, chars, charPos - 1);

                c += (char)31;
            }
        }

        static long Pow(int value, int exponent)
        {
            long result = 1;
            for (int i = 0; i < exponent; i++)
                result *= value;
            return result;
        }

        static int javahash(string str)
        {
            int h = 0;
            foreach (char c in str)
            {
                h = (31 * h + (int)c);
            }
            return h; // TODO: write it, nerd
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            Process.Start("https://yello.ooo/projects/seedgen");
        }
    }
}

