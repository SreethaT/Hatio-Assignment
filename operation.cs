using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for operation
/// </summary>
public class operation
{
   connection cn = new connection();


    public operation()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void staffreg()
    {
        cn.copen();
        //SqlCommand cmd = new SqlCommand("",cn.con);
        cn.cclose();
    }
    public DataSet logincheckup(string uname, string password)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("logincheckup", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", uname);
        cmd.Parameters.AddWithValue("@password", password);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        cn.cclose();
        return ds;

    }
    //public void studentreg(data a)
    //{
    //    cn.copen();
    //    SqlCommand cmd = new SqlCommand("studentreg", cn.con);
    //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //    cmd.Parameters.AddWithValue("@regno", a.regno);
    //    cmd.Parameters.AddWithValue("@name", a.name);
    //    cmd.Parameters.AddWithValue("@gender", a.gender);
    //    cmd.Parameters.AddWithValue("@address", a.address);
    //    cmd.Parameters.AddWithValue("@mobile", a.mobile);
    //    cmd.Parameters.AddWithValue("@pmobile", a.pmobile);
    //    cmd.Parameters.AddWithValue("@email", a.email);
    //    cmd.Parameters.AddWithValue("@acadyear", a.ayear);

    //    cmd.Parameters.AddWithValue("@joincource", a.jcourse);

    //    cmd.Parameters.AddWithValue("@uname", a.uname);
    //    cmd.Parameters.AddWithValue("@parent", a.parent);
    //    cmd.Parameters.AddWithValue("@school", a.school);
    //    cmd.ExecuteNonQuery();
    //    cn.cclose();


    //}
    public void studlogin(string uname, string password, string type, string status)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("studlogin", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@uname", uname);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.ExecuteNonQuery();
        cn.cclose();
    }
    //public void staffregister(data a)
    //{
    //    cn.copen();
    //    SqlCommand cmd = new SqlCommand("staffregister", cn.con);
    //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //    cmd.Parameters.AddWithValue("@id", a.regno);
    //    cmd.Parameters.AddWithValue("@name", a.name);
    //    cmd.Parameters.AddWithValue("@gender", a.gender);
    //    cmd.Parameters.AddWithValue("@paddress", a.paddress);
    //    cmd.Parameters.AddWithValue("@raddress", a.raddress);
    //    cmd.Parameters.AddWithValue("@mobile", a.mobile);
    //    cmd.Parameters.AddWithValue("@email", a.email);
    //    cmd.Parameters.AddWithValue("@department", a.department);
    //    cmd.Parameters.AddWithValue("@joindate", a.joindate);
    //    cmd.Parameters.AddWithValue("@assignwork", a.assignwork);
    //    cmd.Parameters.AddWithValue("@qualification", a.qualification);
    //    cmd.Parameters.AddWithValue("@typestaff", a.typestaff);
    //    cmd.Parameters.AddWithValue("@remark", a.remark);
    //    cmd.Parameters.AddWithValue("@uname", a.uname);
    //    cmd.Parameters.AddWithValue("@school", a.school);
    //    cmd.ExecuteNonQuery();
    //    cn.cclose();


    //}
    public DataSet staffapprove(string status)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("staffapprove", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@status", status);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        cn.cclose();
        return ds;
    }
    public DataSet staffselect(int id)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("staffselect", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@id", id);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        cn.cclose(); return ds;
    }
    public void approved(string status, int id)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("approved", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();

        cn.cclose();

    }
    public void loginupdate(string uname)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("loginupdate", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@uname", uname);
        cmd.ExecuteNonQuery();
        cn.cclose();



    }
    public DataSet unamecheck(string uname)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand("unamecheck", cn.con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@uname", uname);
        DataSet ds = new DataSet();
        adp.Fill(ds);


        cn.cclose();
        return ds;
    }
    public void iud(string s)
    {
        cn.copen();
        SqlCommand cmd = new SqlCommand(s, cn.con);
        cmd.ExecuteNonQuery();
        cn.cclose();
    }
    public DataSet selectall(string s)
    {
        cn.copen();
        SqlDataAdapter adp = new SqlDataAdapter(s, cn.con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        cn.cclose();
        return ds;
    }

}