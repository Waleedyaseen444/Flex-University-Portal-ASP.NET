
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// Other using directives

public partial class login : System.Web.UI.Page
{
    string connectionString = "Data Source=DESKTOP-O82UBQG\\SQLEXPRESS;Initial Catalog=FLEXNU;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
   



    protected void userRole_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void password_TextChanged(object sender, EventArgs e)
    {

    }

    protected void username_TextChanged(object sender, EventArgs e)
    {

    }
  
    protected void loginButton_Click(object sender, EventArgs e)
    {

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            
            string email = TextBox1.Text;
            string password = TextBox2.Text;

            int selectedUserRole = Convert.ToInt32(userRole.SelectedValue);

            Session["d1"] = email;


            string query = "SELECT Userr.UserID, UserRole.RoleID FROM Userr INNER JOIN UserRole ON Userr.UserID = UserRole.UserID WHERE Email = @Email AND Password = @Password AND RoleID = @RoleID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@RoleID", selectedUserRole);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int userID = reader.GetInt32(0);
                        int roleID = reader.GetInt32(1);

                        // Store the UserID and RoleID in session variables
                        Session["UserID"] = userID;
                        Session["RoleID"] = roleID;

                        switch (roleID)
                        {
                            case 1: // Academic Office
                                InsertAuditLog("Logging In", "Academic", email);
                                Response.Redirect("academicoffice.aspx");
                                break;
                            case 2: // Student
                                InsertAuditLog("Logging In", "Student", email);
                                Response.Redirect("student.aspx");
                                break;
                            case 3: // Faculty
                                InsertAuditLog("Logging In", "Faculty", email);
                                Response.Redirect("Faculty.aspx");
                                break;
                            default:
                             
                                break;
                        }
                    }
                }
                else
                {
        
                }
            }
        }
    }


    public void InsertAuditLog(string operationType, string tableName, string userId)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (var command = new SqlCommand("INSERT INTO AuditLog (OperationType, TableName, UserID, DateTime) VALUES (@OperationType, @TableName, @UserID, @DateTime)", connection))
            {
                command.Parameters.AddWithValue("@OperationType", operationType);
                command.Parameters.AddWithValue("@TableName", tableName);
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@DateTime", DateTime.UtcNow);

                command.ExecuteNonQuery();
            }
        }
    }
    
}









