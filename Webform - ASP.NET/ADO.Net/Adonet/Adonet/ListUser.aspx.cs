using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adonet
{
    /// <summary>
    /// Class List User 
    /// </summary>
    /// <seealso cref="System.Web.UI.Page" />
    public partial class ListUser : System.Web.UI.Page
    {
        String cn = @"Data Source=TRANBADAT\SQLEXPRESS;Initial Catalog=Adonet;Integrated Security=True";
        SqlConnection con;

        SqlDataAdapter da;

        SqlCommand cmd;
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the PreRender event of the Page control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            LoadData();
        }
        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            con = new SqlConnection(cn);
            con.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM [dbo].[USER]");
            DataTable ds = new DataTable();
            cmd = new SqlCommand(sb.ToString(), con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataTable();
            da.Fill(ds);
            con.Close();
            GridViewUser.DataSource = ds;
            GridViewUser.DataBind();
            DataListUser.DataSource = ds;
            DataListUser.DataBind();
        }
        /// <summary>
        /// Handles the RowCancelingEdit event of the GridViewUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="GridViewEditEventArgs"/> instance containing the event data.</param>
        protected void GridViewUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUser.EditIndex = e.NewEditIndex;
            // TODO: if don't load data again => problem?

        }
        /// <summary>
        /// Handles the RowCancelingEdit event of the GridViewUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="GridViewCancelEditEventArgs"/> instance containing the event data.</param>
        protected void GridViewUser_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUser.EditIndex = -1;

        }
        /// <summary>
        /// Handles the RowUpdating event of the GridViewUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="GridViewUpdateEventArgs"/> instance containing the event data.</param>
        protected void GridViewUser_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridViewUser.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridViewUser.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            TextBox textName = (TextBox)row.Cells[1].Controls[0];
            TextBox texTBirth = (TextBox)row.Cells[2].Controls[0];
            TextBox textPlace = (TextBox)row.Cells[3].Controls[0];
            GridViewUser.EditIndex = -1;

            con = new SqlConnection(cn);
            con.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [dbo].[USER] SET NAME='" + textName.Text + "',BIRTH_DAY='" + texTBirth.Text + "',BIRTH_PLACE='" + textPlace.Text + "'WHERE ID='" + userid + "'");
            cmd = new SqlCommand(sb.ToString(), con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void DataListUser_EditCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            DataListUser.EditItemIndex = e.Item.ItemIndex;

        }
        protected void DataListUser_CancelCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            DataListUser.EditItemIndex = -1;
        }
        protected void DataListUser_UpdateCommand(object sender, DataListCommandEventArgs e)
        {
            int userid = -1;
            Label lblID = (Label)DataListUser.Items[e.Item.ItemIndex].FindControl("lblID_Edit");
            TextBox txtName = (TextBox)DataListUser.Items[e.Item.ItemIndex].FindControl("txtName");
            TextBox txtBirthday = (TextBox)DataListUser.Items[e.Item.ItemIndex].FindControl("txtBirthday");
            TextBox txtBirthPlace = (TextBox)DataListUser.Items[e.Item.ItemIndex].FindControl("txtBirthPlace");

            if (lblID != null)
            {
                userid = Convert.ToInt32(lblID.Text);
            }

            if ((lblID != null) & (txtName != null) & (txtBirthday != null) & (txtBirthPlace != null))
            {
                con = new SqlConnection(cn);
                con.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE [dbo].[USER] SET NAME='" + txtName.Text + "',BIRTH_DAY='" + txtBirthday.Text + "',BIRTH_PLACE='" + txtBirthPlace.Text + "'WHERE ID='" + userid + "'");
                cmd = new SqlCommand(sb.ToString(), con);
                cmd.ExecuteNonQuery();
                con.Close();
                DataListUser.EditItemIndex = -1;
            }
        }
    }
}