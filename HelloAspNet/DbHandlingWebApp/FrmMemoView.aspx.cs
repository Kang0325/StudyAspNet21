using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DbHandlingWebApp
{
    public partial class FrmMemoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다");
                Response.End();
            }
            else
            {
                var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                using (var conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand("ViewMemo", conn); // 첫번째 파라미터만 변경
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt32(Request["Num"]));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        LblNum.Text = Request["Num"];
                        LblName.Text = Request["Name"].ToString();
                        LblEmail.Text = Request["Email"].ToString();
                        LblTitle.Text = Request["Title"].ToString();
                        LblPostDate.Text = Request["PostDate"].ToString();
                        LblPostIP.Text = Request["PostIP"].ToString();
                    }

                    reader.Close();
                }
            }
        }
    }
}