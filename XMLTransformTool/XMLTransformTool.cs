using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLTransformTool
{
    public partial class XMLTransformTool : Form
    {
        public XMLTransformTool()
        {
            InitializeComponent();
            // example schema
            textBox_Schema.Text = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><VoidInvoice xmlns=\"urn:GEINV:eInvoiceMessage:C0701:3.1\"><VoidInvoiceNumber></VoidInvoiceNumber><InvoiceDate></InvoiceDate><BuyerId></BuyerId><SellerId></SellerId><VoidDate></VoidDate><VoidTime></VoidTime><VoidReason>註銷開立發票</VoidReason><Remark></Remark></VoidInvoice>";

            // example data
            textBox_Data.Text = "[{\"VoidInvoiceNumber\":\"AA0000001\",\"InvoiceDate\":20210304,\"BuyerId\":\"CustomerA\",\"SellerId\":\"CompanyB\",\"VoidDate\":20210304,\"VoidTime\":\"16:48:35\"},{\"VoidInvoiceNumber\":\"AA0000002\",\"InvoiceDate\":20210304,\"BuyerId\":\"CustomerC\",\"SellerId\":\"CompanyD\",\"VoidDate\":20210304,\"VoidTime\":\"16:48:35\"}]";
        }

        private void button_Excute_Click(object sender, EventArgs e)
        {
            try
            {
                #region Field Validation
                if (string.IsNullOrWhiteSpace(textBox_Schema.Text))
                {
                    textBox_Message.AppendText($"Schema is Empty{Environment.NewLine}");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_Data.Text))
                {
                    textBox_Message.AppendText($"Data is Empty{Environment.NewLine}");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_Path.Text))
                {
                    textBox_Message.AppendText($"Path is Empty{Environment.NewLine}");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_Extension.Text))
                {
                    textBox_Message.AppendText($"Extension is Empty{Environment.NewLine}");
                    return;
                }
                if (!comboBox_FilesNameRule.Enabled)
                {
                    textBox_Message.AppendText($"FilesNameRule is Empty{Environment.NewLine}");
                    return;
                }
                #endregion

                // trans data json to dictionary list
                var ds = JsonConvert.DeserializeObject<List<Dictionary<string, dynamic>>>(textBox_Data.Text);

                // process each dictionary
                foreach (var d in ds)
                {
                    WriteFile(d);
                }
                textBox_Message.AppendText($"Success{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                textBox_Message.AppendText($"{ex.Message}{Environment.NewLine}");
            }
        }


        private void WriteFile(Dictionary<string, dynamic> dic)
        {
            // insert value to xml
            var doc = XDocument.Parse(textBox_Schema.Text);
            foreach (var elm in doc.Descendants())
            {
                if (dic.TryGetValue(elm.Name.LocalName, out dynamic val))
                {
                    elm.SetValue(val);
                }
            }

            var path = textBox_Path.Text;

            // valid item selected 
            if (!dic.TryGetValue(comboBox_FilesNameRule.SelectedItem.ToString(), out dynamic name))
            {
                textBox_Message.AppendText($"Selected FilesNameRule in Data is Empty{Environment.NewLine}");
                return;
            }
            var extension = $".{textBox_Extension.Text.Trim('.')}";
            var filePath = Path.Combine(path, name + extension);

            // create and write
            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(doc.ToString());
                sw.Close();
            }
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            // choose path
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox_Schema_TextChanged(object sender, EventArgs e)
        {
            // vaild schema
            if (string.IsNullOrWhiteSpace(textBox_Schema.Text))
            {
                comboBox_FilesNameRule.Enabled = false;
                comboBox_FilesNameRule.SelectedItem = null;
                return;
            }

            // refresh when text changed
            comboBox_FilesNameRule_Refresh();
        }

        private void comboBox_FilesNameRule_Refresh()
        {
            try
            {
                // unlock and remove old item
                comboBox_FilesNameRule.Enabled = true;
                comboBox_FilesNameRule.Items.Clear();

                // add more items from schema
                var doc = XDocument.Parse(textBox_Schema.Text);
                foreach (var elm in doc.Descendants())
                {
                    comboBox_FilesNameRule.Items.Add(elm.Name.LocalName);
                }

                // set first item to selected
                comboBox_FilesNameRule.SelectedItem = comboBox_FilesNameRule.Items[0];
            }
            catch
            {
                // locked when schema error
                comboBox_FilesNameRule.Enabled = false;
                comboBox_FilesNameRule.SelectedItem = null;
            }
        }
    }
}
