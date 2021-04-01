using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HttpBrowserCapabilities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Web.HttpBrowserCapabilities browser = Request.Browser;

        StringBuilder info = new StringBuilder();
        info.Append("<ul>");
        info.Append(String.Format("<li>名稱：{0}</li>",browser.Browser));
        info.Append(String.Format("<li>版本：{0}</li>", browser.Version));
        info.Append(String.Format("<li>用戶端使用的平台名稱：{0}</li>", browser.Platform));
        info.Append(String.Format("<li>安裝用戶端上的.NET Framework版本：{0}</li>", browser.ClrVersion));
        info.Append(String.Format("<li>是否為win16架構電腦：{0}</li>", browser.Win16));
        info.Append(String.Format("<li>是否為win32架構電腦：{0}</li>", browser.Win32));
        info.Append(String.Format("<li>是否支援Cookies：{0}</li>", browser.Cookies));
        info.Append(String.Format("<li>JScriptVersion版本：{0}</li>", browser.JScriptVersion));

        Label1.Text = "瀏覽器相關資訊：" + info.ToString();
    }
}