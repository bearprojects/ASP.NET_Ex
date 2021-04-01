using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void dwnRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        dwnCity.Items.Clear();

        switch (dwnRegion.SelectedValue)
        {
            case "0":
                dwnCity.Items.Add(new ListItem("===請先選擇區域===", "0"));
                dwnCity.Enabled = false;
                break;

            case "1":
                dwnCity.Items.Add(new ListItem("===請選擇城市===", "0"));
                dwnCity.Items.Add(new ListItem("紐約", "1"));
                dwnCity.Items.Add(new ListItem("芝加哥", "2"));
                dwnCity.Items.Add(new ListItem("拉斯維加斯", "3"));
                dwnCity.Enabled = true;
                break;

            case "2":
                dwnCity.Items.Add(new ListItem("===請選擇城市===", "0"));
                dwnCity.Items.Add(new ListItem("北京", "1"));
                dwnCity.Items.Add(new ListItem("上海", "2"));
                dwnCity.Items.Add(new ListItem("香港", "3"));
                dwnCity.Enabled = true;
                break;

            case "3":
                dwnCity.Items.Add(new ListItem("===請選擇城市===", "0"));
                dwnCity.Items.Add(new ListItem("台北", "1"));
                dwnCity.Items.Add(new ListItem("台中", "2"));
                dwnCity.Items.Add(new ListItem("高雄", "3"));
                dwnCity.Enabled = true;
                break;
        }
    }

    protected void dwnCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dwnCity.SelectedValue != "0")
        {
            labMsg.Text = string.Format("您居住的地點為：{0}-{1}", dwnRegion.SelectedItem.Text, dwnCity.SelectedItem.Text);
        }
        else {
            labMsg.Text = "";
        }
    }
}