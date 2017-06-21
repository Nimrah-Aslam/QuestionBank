using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //protected void Button4_Click(object sender, EventArgs e)
    //{
    //    //MCQQuestion d = new MCQQuestion();
    //    //d._item = TextBox1.Text;
    //    //if (Session["data"] != null)
    //    //lst = Session["data"] as List<MCQOption>;
    //    //lst.Add(d);
    //    //Session["data"] = lst;
    //    Label1.Text = TextBox1.Text;
    //    Button1.Visible = false;
    //    Button4.Visible = false;
    //    TextBox1.Visible = false;
    //    Button2.Visible = true;
    //    TextBox2.Visible = true;
    //    CheckBox2.Visible = true;
    //    Button3.Visible = true;

    //}

    protected void Button2_Click(object sender, EventArgs e)
    {
      //  Button2.Visible = false;
    }

   
   

    protected void Button1_Click2(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value == "1")
            Response.Redirect("MCQ.aspx");


        if (RadioButtonList1.SelectedItem.Value =="2" )
            Response.Redirect("blanks.aspx");

    }
}