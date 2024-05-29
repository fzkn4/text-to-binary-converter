using System.Collections;
using System.ComponentModel;
using System.Xml.Schema;

namespace text_to_binary
{
    public partial class Form1 : Form
    {
        Dictionary<char, string> map = new Dictionary<char, string>();

        public Form1()
        {
            InitializeComponent();
            from.Items.Add("Capital Text");
            from.Items.Add("Binary");
            to.Items.Add("Capital Text");
            to.Items.Add("Binary");

            from.Text = "Capital Text";
            to.Text = "Binary";

            //map
            map.Add('A', "01000001");
            map.Add('B', "01000010");
            map.Add('C', "01000011");
            map.Add('D', "01000100");
            map.Add('E', "01000101");
            map.Add('F', "01000110");
            map.Add('G', "01000111");
            map.Add('H', "01001000");
            map.Add('I', "01001001");
            map.Add('J', "01001010");
            map.Add('K', "01001011");
            map.Add('L', "01001100");
            map.Add('M', "01001101");
            map.Add('N', "01001110");
            map.Add('O', "01001111");
            map.Add('P', "01010000");
            map.Add('Q', "01010001");
            map.Add('R', "01010010");
            map.Add('S', "01010011");
            map.Add('T', "01010100");
            map.Add('U', "01010101");
            map.Add('V', "01010110");
            map.Add('W', "01010111");
            map.Add('X', "01011000");
            map.Add('Y', "01011001");
            map.Add('Z', "01011010");



        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            displayOutput(from.Text, to.Text);
            copy.Enabled = true;
        }

        private void displayOutput(string fValue, string tValue)
        {
            string carry = "";

            if (fValue == "" || tValue == "")
            {
                MessageBox.Show("Please select type of conversion.");
                input.Clear();
            }
            else if (input.Text.Length == 0)
            {
                carry = "";
            }
            else if (fValue == "Capital Text" && tValue == "Binary")
            {
                for (int i = 0; i < input.Text.Length; i++)
                {
                    carry += findValueOrKey(input.Text[i].ToString(), "textBin").ToString();
                    carry += " ";
                }
            }
            else if (fValue == "Binary" && tValue == "Capital Text")
            {
                ArrayList arr = new ArrayList();

                for (int i = 0; i < input.Text.Length; i+=9)
                {
                    string bin = "";
                    int j = i, counter = 0;
                    while (j < input.Text.Length && counter < 8)
                    {
                        
                        bin += input.Text[j].ToString();
                        j++;
                        counter++;
                    }
                    arr.Add(bin);
                }
                foreach (string b in arr)
                {
                    carry += findValueOrKey(b, "binText").ToString();
                    carry += " ";
                }
            }
            output.Text = carry;

        }
        private string findValueOrKey(string search, string type)
        {
            if (type == "textBin")
            {
                foreach (KeyValuePair<char, string> pair in map)
                {
                    if (pair.Key == Convert.ToChar(search))
                    {
                        return pair.Value;
                    }
                }
            }else if (type == "binText")
            {
                foreach (KeyValuePair<char, string> pair in map)
                {
                    if (pair.Value == search)
                    {
                        return pair.Key.ToString();
                    }
                }
            }
            
            return "";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(output.Text.Trim(' '));
            copy.Enabled = false;
        }
    }
}
