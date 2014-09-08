using System;
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
         * Site:http://www.chias.me
         * Github:https://github.com/ChIaSg/OneDrive-ShareLinks
         * Created：20140831
         * Project:OneDrive-ShareLinks
         */
        private void Convert_link_Click(object sender, EventArgs e)
        {
            if (olink.Text ==""|| type.Text =="") //判断公开链接和文件后缀是否为空，是则不采取任何措施，否则继续执行。
            {

            }
            else
            {
                if (filename.Text =="")
                {
                    try
                    {
                        string getLink = olink.Text;
                        string getLinkStr = getLink.Substring(getLink.IndexOf("=") + 1, getLink.Length - getLink.IndexOf("=") - 1);//截取“=”后面的字符串
                        slink.Text = "http://storage.live.com/items/" + getLinkStr + "?chias." + type.Text;//普通外链
                        HTTPS.Text = "https://storage.live.com/items/" + getLinkStr + "?chias." + type.Text;//加密外链
                    }
                    catch
                    {
                        linkLabel1.Text = "操作失误！需要帮助可点我到Chias的网站上求助。";
                    }
                }
                else
                {
                    try
                    {
                        string getLink = olink.Text;
                        string getLinkStr = getLink.Substring(getLink.IndexOf("=") + 1, getLink.Length - getLink.IndexOf("=") - 1);
                        slink.Text = "http://storage.live.com/items/" + getLinkStr + "?" + filename.Text + "." + type.Text;
                        HTTPS.Text = "https://storage.live.com/items/" + getLinkStr + "?" + filename.Text + "." + type.Text;
                    }
                    catch
                    {
                        linkLabel1.Text = "操作失误！需要帮助可点我到Chias的网站上求助。";
                    }
                }
                
            }   
        }

        private void copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(slink.Text);//复制文本信息到剪贴板
        }

        private void copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(HTTPS.Text);//复制文本信息到剪贴板
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.chias.me");//用默认浏览器打开作者网站。
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            filename.Text = "";
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            olink.Text = "";
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            type.Text = "";
        }
    }
}
