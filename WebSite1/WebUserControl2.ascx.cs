using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl2 : System.Web.UI.UserControl
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        Button2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        Button2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        QBANKEntities db = new QBANKEntities();
        Question FB = new Question();
        FB.ques = TextBox1.Text;
        db.Questions.Add(FB);
        db.SaveChanges();
        int ID = FB.id;
       // ViewState["data"] = ID;

        FIB f = new FIB();
        f.Fid = ID;
        f.Answer = TextBox2.Text;
        db.FIBs.Add(f);
        db.SaveChanges();
        //int id = (int)(ViewState["data"]);
        //f.Fid = id;
        //ViewState["data"] = ID;
        Label1.Text = FB.ques;
        Label2.Text = f.Answer;
        //if (Session["data"] != null)
        //lst3= Session["data"] as List<FIB>;
        //Session["data"] = f;
        //
        //lst3.Add(f);

        // Session["data"] = lst3;
        TextBox1.Text = "";
        TextBox2.Text=  "";
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = false;
        Label4.Visible = false;
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        Button2.Visible = false;
    }
}