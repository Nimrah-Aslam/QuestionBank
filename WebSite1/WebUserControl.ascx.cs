using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//public class MCQOption
//{
//    public string option;
//    public string chk;
//    public string _option
//    {
//        get
//        {
//            return option;
//        }
//        set
//        {
//            option = value;
//        }
//    }
//    public string _chk
//    {
//        get
//        {
//            return chk;
//        }
//        set
//        {
//            chk = value;
//        }
//    }
//}



//public class MCQQuestion
//{

//    public string qstate;
//    public List<MCQOption> lst = new List<MCQOption>();

//    public string _qstate
//    {
//        get
//        {
//            return qstate;
//        }

//        set
//        {
//            qstate = value;
//        }
//    }
//    public List<MCQOption> _lst
//    {
//        get
//        {
//            return lst;
//        }
//        set
//        {
//            lst = value;
//        }
//    }
//}
public partial class WebUserControl : System.Web.UI.UserControl
{
    //  Button b3;
   // Button b4;
   // Button b5;
    Label l2;
    Label l3;
   // TextBox t1;
 //   TextBox t2;
    CheckBox c1;
   // CheckBox c2;
    
  //  List<MCQQuestion> lst2 = new List<MCQQuestion>();
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            var DataItem = e.Item.DataItem;
            //Button b1 = e.Item.FindControl("Button1") as Button;
            //Label l1 = e.Item.FindControl("Label1") as Label;
            //Button b2 = e.Item.FindControl("Button2") as Button;
            //  b3 = e.Item.FindControl("Button3") as Button;
           // b4 = e.Item.FindControl("Button4") as Button;
            //b5 = e.Item.FindControl("Button5") as Button;
            l2 = e.Item.FindControl("Label2") as Label;
            l3 = e.Item.FindControl("Label3") as Label;
            //  t1 = e.Item.FindControl("TextBox1") as TextBox;
            //  t2 = e.Item.FindControl("TextBox2") as TextBox;
            c1 = e.Item.FindControl("CheckBox1") as CheckBox;
            //   label1.Visible = false;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Button1.Visible = true;
            Button2.Visible = false;
            TextBox1.Visible = false;
            Label1.Visible = false;
            Button3.Visible = false;
            Panel1.Visible = false;
            Panel1.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Button5.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Visible = false;
        TextBox1.Visible = true;
        Button2.Visible = true;
        Panel2.Visible = false;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        QBANKEntities db = new QBANKEntities();
        Question Q = new Question();
        Q.ques = TextBox1.Text;
        db.Questions.Add(Q);
        db.SaveChanges();
        int ID = Q.id;
        ViewState["data"] = ID;
        if (TextBox1.Text != null)
        {
            Label1.Text = TextBox1.Text;
            Button1.Visible = false;
            Button2.Visible = false;
            TextBox1.Visible = false;
            Label1.Visible = true;
            Button3.Visible = true;
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox2.Visible = true;
        Panel2.Visible = true;
        Button5.Visible = true;
    }

    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        //     b4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        QBANKEntities db = new QBANKEntities();
        MCQopt op = new MCQopt();
        op.opt = TextBox2.Text;
        if (CheckBox3.Checked)
        {
            op.correct = true;
        }
        else
        {
            op.correct =false;
        }
        int ID = (int)(ViewState["data"]);
        op.Oid = ID;
        db.MCQopts.Add(op);
        db.SaveChanges();
       // ViewState["data"] = ID;
        //Repeater1.DataSource = op._lst;
        //Repeater1.DataBind();
       Panel1.Visible = true;


        //l2.Visible = true;
        //l2.Text = TextBox2.Text;

        // t2.Visible = false;
        //b4.Visible = false;
        //c1.Visible = false;
        //l2.Visible = true;
        //b5.Visible = true;

    }


    protected void Button5_Click1(object sender, EventArgs e)
    {
    //    if (Session["data"] != null)
    //        lst2 = Session["data"] as List<MCQQuestion>;
    //    lst2.Add(m);
    //    Session["data"] = lst2;
    //    Repeater1.DataSource = lst2;
    //    Repeater1.DataBind();
    //    Button1.Visible = true;
        Button3.Visible = false;
     //   TextBox1.Visible = false;
        Label1.Visible = true;
        Button2.Visible = false;
        Button1.Visible = true;
        TextBox2.Visible = false;
        //    c1.Visible = false;
        Panel1.Visible = true;
        Panel2.Visible = false;
       // l2.Visible = true;
      //  Button4.Visible = false;
        Button5.Visible = false;

    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}
