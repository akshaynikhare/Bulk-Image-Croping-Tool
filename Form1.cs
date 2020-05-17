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
using System.Drawing.Imaging;

namespace BulkImageCroping
{
    public partial class Form1 : Form
    {

        enum anchor {Top_Left,Top_Right,Bottom_Left,Botttom_Right,Center_Center};
        public Form1()
        {
            InitializeComponent();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in addFileDialog.FileNames)
                {
                    if (File.Exists(file))
                    {
                        inputListBox.Items.Add(file);
                    }
                    if (inputListBox.Items.Count > 1)
                    {
                        cropBtn.Enabled=true;
                    }
                }

            }
            updateUI();
        }

        private void InputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (Bitmap ff = new Bitmap(inputListBox.SelectedItem.ToString())) {
                trackBar1.Value = priview.Width * 100 / ff.Width;
            }
          
            priview.DocumentText=sethtmlimg(inputListBox.SelectedItem.ToString());
            updateUI();
        }

        private string sethtmlimg(string v)
        {
            string html = @"<html><head><style>" +
                            "html, body {height: 100%;  margin: 0;}" +
                            ".full-height { height: 100%;  background: yellow; background-image:url(\"file:///" + v.Replace("\"", "/") + "\") }" +
                            "</style></head><body>" +
                            "<div class=\"full-height\" id=\"full-height\">" +
                             "image url : " + "\"file:///" + v.Replace("\"", "/") + "\"" +
                            "</div></body></html>";

            return html ;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            if (inputListBox.SelectedIndex > -1) { 
                       priview.Document.Body.Style = "zoom:"+ trackBar1.Value + "%;";
            }

        }

        private void ShowImageRepet_Click(object sender, EventArgs e)
        {
            if (showImageRepet.Checked)
            {
                priview.Document.GetElementById("full-height").Style = "background-repeat: no-repeat;";
                priview.Document.Body.Style = "zoom:" + trackBar1.Value + "%;";
            }
            else
            {
                priview.Document.GetElementById("full-height").Style = "background-repeat: repeat;";
                priview.Document.Body.Style = "zoom:" + trackBar1.Value + "%;";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> lst= Enum.GetNames(typeof(anchor)).ToList();
            foreach( var a in lst)
            {
                config.Items.Add(a);
            }

            config.SelectedItem=anchor.Center_Center.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            inputListBox.Items.Remove(inputListBox.SelectedItem);
            updateUI();

        }

        private void updateUI()
        {
            if (inputListBox.SelectedIndex > -1)
            {
                RemoveButton.Enabled = true;
            }else
            {
                RemoveButton.Enabled = false;

            }

            if(inputListBox.Items.Count > 0)
            {
                RemoveAllButton.Enabled = true;
                cropBtn.Enabled = true;
            }
            else
            {
                RemoveAllButton.Enabled = false;
                cropBtn.Enabled = true;
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            inputListBox.Items.Clear();
            updateUI();
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {
           


            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               
                    progressBar.Visible = true;
                    this.Enabled = false;

                    for (int i = 0; i < inputListBox.Items.Count; i++)
                    {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName((string)inputListBox.Items[i])))
                    {
                        MessageBox.Show("The file exist. Overwritting. \n " + folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName((string)inputListBox.Items[i]));
                    }




                    using (Bitmap ol = new Bitmap((string)inputListBox.Items[i])) {
                        using (Bitmap nl = new Bitmap(Int32.Parse(W.Text), Int32.Parse(H.Text)))
                        {

                 


                    switch (config.SelectedItem)
                    {
                        //Top_Left,Top_Right,Bottom_Left,Botttom_Right,Center_Center
                        default:
                            for (var x = 0; x < nl.Width; x++)
                            {
                                for (var y = 0; y < nl.Height; y++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(x, y));
                                }
                            }

                            break;
                        case "Top_Left":
                            for (var x = 0; x < nl.Width; x++)
                            {
                                for (var y = 0; y < nl.Height; y++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(x, y));
                                }
                            }

                            break;
                        case "Top_Right":
                            for (int x = 0, m = (ol.Width - nl.Width); x < nl.Width; x++, m++)
                            {
                                for (int y = 0; y < nl.Height; y++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(m, y));
                                }
                            }

                            break;
                        case "Bottom_Left":
                            for (var x = 0; x < nl.Width; x++)
                            {
                                for (int y = 0, n = (ol.Height - nl.Height); y < nl.Height; y++, n++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(x, n));
                                }
                            }
                            break;
                        case "Botttom_Right":
                            for (int x = 0, m = (ol.Width - nl.Width); x < nl.Width; x++, m++)
                            {
                                for (int y = 0, n = (ol.Height - nl.Height); y < nl.Height; y++, n++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(m, n));
                                }
                            }

                            break;
                        case "Center_Center":
                            for (int x = 0, m = (ol.Width - nl.Width) / 2; x < nl.Width; x++, m++)
                            {
                                for (int y = 0, n = (ol.Height - nl.Height) / 2; y < nl.Height; y++, n++)
                                {
                                    nl.SetPixel(x, y, ol.GetPixel(m, n));
                                }
                            }

                            break;
                            }
                         nl.Save(folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName((string)inputListBox.Items[i]), ImageFormat.Jpeg);
                           // priview.Navigate(folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName((string)inputListBox.Items[i]));
                        //close using
                        }
                    }
                    progressBar.Value = (int)(((i + 1) / (double)inputListBox.Items.Count) * 100);
                    }

                    this.Enabled = true;
                    progressBar.Visible = false;
                System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath);
                inputListBox.Items.Clear();
            }


            updateUI();
            
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/akshaynikhare");
        }
    }
}
