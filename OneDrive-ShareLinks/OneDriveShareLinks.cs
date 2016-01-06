using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OneDrive_ShareLinks
{
    public partial class OneDriveShareLinks : Form
    {
        public OneDriveShareLinks()
        {
            InitializeComponent();
        }
        /* 
         * Autor：Chias
         * Site:https://www.chias.me
         * Github:https://github.com/ChIaSg/OneDrive-ShareLinks
         * Created：20140831
         * Project:OneDrive-ShareLinks
         */
        private void Convert_link_Click(object sender, EventArgs e)
        {
            if (filename.Text =="")
            {
                MessageBox.Show("文件名可以为任意值，但不能为空！", "警告！");
            }
            else
            {
                try
                {
                    string resid = Regex.Match(olink.Text, "(?<=resid=).*?(?=&authkey)").Value;
                    string authkey = Regex.Match(olink.Text, "(?<=&).*?(?=&)").Value;
                    //string getLinkStr = getLink.Substring(getLink.IndexOf("redir?resid=") + 1, getLink.Length - getLink.IndexOf("redir?resid=") - 1);
                    HTTPS.Text = "https://storage.live.com/items/" + resid + "?" + filename.Text + "."  + type.Text + "&" + authkey;
                }
                catch
                {

                }
            }        
        }

        private void copyHttpsTEXT_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(HTTPS.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.chias.me/post-103");
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            filename.Text = "";
        }

        private void Stick2_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                olink.Text = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            type.Text = "";
        }
    }
}
