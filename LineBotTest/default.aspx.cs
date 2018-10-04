using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBotTest
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "/Cv9TTLZNxtKnu2u4XRu4FE5BWCkKgFiE+1m8mTozh+3setnZifem2hRnl/QrALPjcZGhbp15l7M0+S2r5nxcbuRSu1x6B0z+kjTjMt1gncdYYWMwVH5nt6QVrtIuSHcrvNVGR3mLqHljjLbw3yq2wdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U69c838bd1e906c51b8c680f13d2dacba";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}