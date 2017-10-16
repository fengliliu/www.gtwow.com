using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using common;

public partial class control_header : System.Web.UI.UserControl
{
    //参数定义
    protected DataTable dt = new DataTable();
    protected string navList = string.Empty();
    #region 入口函数：直接获取
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            dt = sqlHelper.ExecuteDataTable("select * from class1", new SqlParameter[] { });
            
        }

    }
    #endregion
}