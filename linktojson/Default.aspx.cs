using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linktojson
{
    public class Products
        {
        public string ID { get; set; }
        public string TITLE { get; set; }
        public string UNIT_PRICE { get; set; }
        public string EXPIRE { get; set; }
        public string MANUFACTURE { get; set; }
        public string STOCK { get; set; }


    }
    public partial class _Default : Page
    {
        List<Dictionary<string, object>> rows;
        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Server.MapPath("Product.json"));
            string json = reader.ReadToEnd();
            rows = serializer.Deserialize<List<Dictionary<string, object>>>(json);
            reader.Close();
            if(!IsPostBack)
            {
                main.Text = serializer.Serialize(rows);
                LoadGridView();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtid.Text);
            row.Add("P_TITLE", txttitle.Text);
            row.Add("P_UNIT_PRICE", txtunit.Text);
            row.Add("P_EXPIRE", txtexpire.Text);
            row.Add("P_MANUFACTURE", txtmanu.Text);
            row.Add("P_STOCK", txtstock.Text);
            rows.Add(row);
            main.Text = serializer.Serialize(rows);
            LoadGridView();



        }
        private void LoadGridView()
        {
            var data = rows.Select(x => new Products
            {

                ID = x["P_ID"].ToString(),
                TITLE = x["P_TITLE"].ToString(),
                UNIT_PRICE = x["UNIT_PRICE"].ToString(),
                EXPIRE = x["P_EXPIRE"].ToString(),
                MANUFACTURE = x["P_MANUFACTURE"].ToString(),
                STOCK = x["P_STOCK"].ToString()
              
            })
            ;
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtid.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));

            row.Add("P_TITLE", txttitle.Text);
            row.Add("P_UNIT_PRICE", txtunit.Text);
            row.Add("P_EXPIRE", txtexpire.Text);
            row.Add("P_MANUFACTURE", txtmanu.Text);
            row.Add("P_STOCK", txtstock.Text);
            main.Text = serializer.Serialize(rows);
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtid.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            txttitle.Text = row["P_TITLE"].ToString();
            txtunit.Text = row["P_UNIT_PRICE"].ToString();
            txtexpire.Text = row["P_EXPIRE"].ToString();
            txtmanu.Text = row["P_MANUFACTURE"].ToString();
            txtstock.Text = row["P_STOCK"].ToString();

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter myFile = new System.IO.StreamWriter(Server.MapPath("Product.json"));
            if(!main.Text.Equals(""))
            {
                myFile.WriteLine(main.Text);
            }
            myFile.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtid.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            rows.Remove(row);
            main.Text = serializer.Serialize(rows);
            LoadGridView();

        }
    }
}