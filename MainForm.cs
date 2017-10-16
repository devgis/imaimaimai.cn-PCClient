using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using immmclient.cn.imaimaimai.www;
using System.Net;
using System.IO;

namespace immmclient
{
    public partial class MainForm : Form
    {
        int currentpage = 1;
        int pagesize = 100;
        cn.imaimaimai.www.immm client = new cn.imaimaimai.www.immm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            currentpage = 1;
            dgvList.Rows.Clear();
            var list= client.SearchCouponRS(tbWords.Text, currentpage, pagesize);
            if (list != null && list.Length > 0)
            {
                foreach (var item in list)
                {
                    int index = dgvList.Rows.Add();
                    dgvList.Rows[index].Cells["itemid"].Value = item.num_iid;
                    dgvList.Rows[index].Cells["couponurl"].Value = item.coupon_click_url;
                    dgvList.Rows[index].Cells["cName"].Value = item.title;
                    dgvList.Rows[index].Cells["ShopName"].Value = item.shop_title;
                    dgvList.Rows[index].Cells["Coupon"].Value = item.coupon_info;
                    dgvList.Rows[index].Cells["citemurl"].Value = item.item_url;
                    dgvList.Rows[index].Cells["colbuy"].Value = "领券购买";
                    dgvList.Rows[index].Cells["cInfo"].Value = "查看详情";
                    

                }
            }
        }



        private void dgvList_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll && (e.NewValue + dgvList.DisplayedRowCount(false) == dgvList.Rows.Count))//垂直滚动条滚动到底部，数据为加载完，则再次加载
            {
        
                if (this.Cursor != null)
                {
                    //设置当前光标为忙碌状态
                    this.Cursor = Cursors.WaitCursor;
                    currentpage +=1;
                    var list = client.SearchCouponRS(tbWords.Text, currentpage, pagesize);
                    if (list != null && list.Length > 0)
                    {
                        foreach (var item in list)
                        {
                            int index = dgvList.Rows.Add();
                            dgvList.Rows[index].Cells["itemid"].Value = item.num_iid;
                            dgvList.Rows[index].Cells["couponurl"].Value = item.coupon_click_url;
                            dgvList.Rows[index].Cells["citemurl"].Value = item.item_url;
                            dgvList.Rows[index].Cells["cName"].Value = item.title;
                            dgvList.Rows[index].Cells["ShopName"].Value = item.shop_title;
                            dgvList.Rows[index].Cells["Coupon"].Value = item.coupon_info;
                            dgvList.Rows[index].Cells["colbuy"].Value = "领券购买";
                            dgvList.Rows[index].Cells["cInfo"].Value = "查看详情";
                        }
                    }
                    //try
                    //{
                    //    //填充记录集到数据
                    //    this.FillRecordToDataTable(this.m_Fields);
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}

                    //设置当前光标为正常状态
                    this.Cursor = Cursors.Default;
                }
            }
        }
        private string currentcpurl = string.Empty;
        private string itemurl = string.Empty;

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            else
            {
                currentcpurl = dgvList.Rows[e.RowIndex].Cells["couponurl"].Value.ToString();
                itemurl = dgvList.Rows[e.RowIndex].Cells["citemurl"].Value.ToString();
                
                if (dgvList.Columns[e.ColumnIndex].Name.Equals("colbuy"))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(currentcpurl);  
                    }
                    catch
                    { }
                }
                else if (dgvList.Columns[e.ColumnIndex].Name.Equals("cInfo"))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(itemurl);
                    }
                    catch
                    { }
                }
                else
                {
                    string id = dgvList.Rows[e.RowIndex].Cells["itemid"].Value.ToString();
                    string title = dgvList.Rows[e.RowIndex].Cells["cName"].Value.ToString();
                    string shopname = dgvList.Rows[e.RowIndex].Cells["ShopName"].Value.ToString();
                    string cpinfo = dgvList.Rows[e.RowIndex].Cells["Coupon"].Value.ToString();
                    NTbkItem[] items = null;
                    try
                    {
                        items = client.GetItemDetail(id);
                    }
                    catch
                    { }
                    if (items != null && items.Length > 0)
                    {
                        var item = items[0];
                        if (item != null)
                        {
                            tbDesc.Text = string.Format("[{0}]{1}-{2}", shopname, item.title, cpinfo);
                            string imageurl = item.pict_url;
                            LoadImage(imageurl);
                        }
                    }

                }
                
            }
        }

        private void LoadImage(string url)
        {
            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //request.Method = "GET";
                //request.ContentType = "application/x-www-form-urlencoded";
                //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:5.0.1) Gecko/20100101 Firefox/5.0.1";
                //request.Accept = "image/webp,*/*;q=0.8";
                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //Stream stream = response.GetResponseStream();
                //string WebContent = new StreamReader(stream, System.Text.Encoding.UTF8).ReadToEnd();
                ////验证码请求
                //request = (HttpWebRequest)WebRequest.Create(url);
                //request.Method = "GET";
                //request.ContentType = "application/x-www-form-urlencoded";
                //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:5.0.1) Gecko/20100101 Firefox/5.0.1";
                //request.Accept = "image/webp,*/*;q=0.8";
                ////request.CookieContainer = lCC;//!Very Important.!!!
                //response = (HttpWebResponse)request.GetResponse();
                ////response.Cookies = lCC.GetCookies(request.RequestUri);
                //stream = response.GetResponseStream();
                pMain.Image = Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream());


            }
            catch
            { }
        }

        private void btWeb_Click(object sender, EventArgs e)
        {
            WXWeb frmWXWeb = new WXWeb();
            frmWXWeb.ShowDialog();
        }

        private void btWebImaimai_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.imaimaimai.cn");  
        }


        private void btShowInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(itemurl);
        }

        private void btGetCoupon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(currentcpurl);
        }
    }
}
