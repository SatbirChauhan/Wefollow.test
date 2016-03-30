using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace nsfollow
{
    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
    public interface intpln

    {
        Int32 p_plncod
        {
            get;
            set;
        }
        String p_plnnam
        {
            get;
            set;
        }
        String p_plndsc
        {
            get;
            set;
        }
        Int32 p_plnnoe
        {
            get;
            set;
        }
        float p_plnprc
        {
            get;
            set;
        }
    }
    public interface intcmp
    {
        Int32 p_cmpcod
        {
            get;
            set;
        }
        String p_cmpnam
        {
            get;
            set;
        }
        String p_cmpcat
        {
            get;
            set;
        }
        String p_cmpdsc
        {
            get;
            set;
        }
        String p_cmplog
        {
            get;
            set;
        }
        String p_cmpurl
        {
            get;
            set;
        }
    }
    public interface intcmppln
    {
        Int32 p_cmpplncod
        {
            get;
            set;
        }
        DateTime p_cmpplndat
        {
            get;
            set;
        }
        Int32 p_cmpplncmpcod
        {
            get;
            set;
        }
        Int32 p_cmpplnplncod
        {
            get;
            set;
        }
       
    }
    public interface intemp
    {
        Int32 p_empcod
        {
            get;
            set;
        }
        String p_empnam
        {
            get;
            set;

        }
        String p_empjobtit
        {
            get;
            set;
        }
        String p_emppic
        {
            get;
            set;
        }
        Int32 p_empusrcod
        {
            get;
            set;
        }
    }
    public interface intusr
    {
        Int32 p_usrcod
        {
            get;
            set;
        }
        String p_usreml
        {
            get;
            set;

        }
        String p_usrpwd
        {
            get;
            set;
        }
        Int32 p_usrcmpcod
        {
            get;
            set;
        }
        Char p_usrrol
        {
            get;
            set;
        }
        DateTime p_usrcrtdat
        {
            get;
            set;
        }
    }
    public interface intfol
    {
        Int32 p_folcod
        {
            get;
            set;
        }
        Int32 p_folempcod
        {
            get;
            set;
        }
        Int32 p_folfolempcod
        {
            get;
            set;
        }
    }
    public interface intupd
    {
        Int32 p_updcod
        {
            get;
            set;
        }
        DateTime p_upddat
        {
            get;
            set;
        }
        Int32 p_updempcod
        {
            get;
            set;
        }
        String p_upddsc
        {
            get;
            set;
        }
        String p_updfil
        {
            get;
            set;
        }
    }
    public interface intgrp
    {
        Int32 p_grpcod { get; set; }
        String p_grpnam { get; set; }
        String p_grpdsc { get; set; }
        DateTime p_grpcrtdat { get; set; }
        Int32 p_grpownempcod { get; set; }
    }
    public interface intgrpmem
    {
        Int32 p_grpmemcod { get; set; }
        Int32 p_grpmemgrpcod { get; set; }
        Int32 p_grpmemempcod { get; set; }
    }
    public interface intdoc
    {
        Int32 p_doccod
        {
            get;
            set;
        }
        String p_doctit
        {
            get;
            set;
        }
        String p_docdsc
        {
            get;
            set;
        }
        Int32 p_docgrpcod
        {
            get;
            set;
        }
        String p_docdwnfil
        {
            get;
            set;
        }
    }
    public class clsplnprp : intpln
    {
        private Int32 plncod, plnnoe;
        private String plnnam, plndsc;
        private float plnprc;
        public int p_plncod
        {
            get
            {
                return plncod;
            }
            set
            {
                plncod = value;
            }
        }

        public string p_plnnam
        {
            get
            {
                return plnnam;
            }
            set
            {
                plnnam = value;
            }
        }

        public string p_plndsc
        {
            get
            {
                return plndsc;
            }
            set
            {
                plndsc = value;
            }
        }

        public int p_plnnoe
        {
            get
            {
                return plnnoe;
            }
            set
            {
                plnnoe = value;
            }
        }

        public float p_plnprc
        {
            get
            {
                return plnprc;
            }
            set
            {
                plnprc = value;
            }
        }
    }
    public class clscmpprp : intcmp
    {
        private Int32 cmpcod;
        private String cmpnam, cmpcat, cmpdsc, cmplog, cmpurl;
        public int p_cmpcod
        {
            get
            {
                return cmpcod;
            }
            set
            {
                cmpcod = value;
            }
        }

        public string p_cmpnam
        {
            get
            {
                return cmpnam;
            }
            set
            {
                cmpnam = value;
            }
        }

        public string p_cmpcat
        {
            get
            {
                return cmpcat;
            }
            set
            {
                cmpcat = value;
            }
        }

        public string p_cmpdsc
        {
            get
            {
                return cmpdsc;
            }
            set
            {
                cmpdsc = value;
            }
        }

        public string p_cmplog
        {
            get
            {
                return cmplog;
            }
            set
            {
                cmplog = value;
            }
        }

        public string p_cmpurl
        {
            get
            {
                return cmpurl;
            }
            set
            {
                cmpurl = value;
            }
        }
    }
    public class clscmpplnprp : intcmppln
    {
        private Int32 cmpplncod, cmpplncmpcod, cmpplnplncod;
        private DateTime cmpplndat;
        public int p_cmpplncod
        {
            get
            {
                return cmpplncod;
            }
            set
            {
                cmpplncod = value;
            }
        }

        public DateTime p_cmpplndat
        {
            get
            {
                return cmpplndat;
            }
            set
            {
                cmpplndat = value;
            }
        }

        public int p_cmpplncmpcod
        {
            get
            {
                return cmpplncmpcod;
            }
            set
            {
                cmpplncmpcod = value;
            }
        }

        public int p_cmpplnplncod
        {
            get
            {
                return cmpplnplncod;
            }
            set
            {
                cmpplnplncod = value;
            }
        }
    }
    public class clsempprp : intemp
    {
        private Int32 empcod, empusrcod;
        private String empnam, empjobtit, emppic; 
        public int p_empcod
        {
            get
            {
                return empcod;
            }
            set
            {
                empcod = value;
            }
        }

        public string p_empnam
        {
            get
            {
                return empnam;
            }
            set
            {
                empnam = value;
            }
        }

        public string p_empjobtit
        {
            get
            {
                return empjobtit;
            }
            set
            {
                empjobtit = value;
            }
        }

        public string p_emppic
        {
            get
            {
                return emppic;
            }
            set
            {
                emppic = value;
            }
        }

        public int p_empusrcod
        {
            get
            {
                return empusrcod;
            }
            set
            {
                empusrcod = value;
            }
        }
    }
    public class clsusrprp : intusr
    {
        private Int32 usrcod, usrcmpcod;
       private String usreml, usrpwd;
       private Char usrrol;
       private DateTime usrcrtdat;
        public int p_usrcod
        {
            get
            {
                return usrcod;
            }
            set
            {
                usrcod = value;
            }
        }

        public string p_usreml
        {
            get
            {
                return usreml;
            }
            set
            {
                usreml = value;
            }
        }

        public string p_usrpwd
        {
            get
            {
                return usrpwd;
            }
            set
            {
                usrpwd = value;
            }
        }

        public int p_usrcmpcod
        {
            get
            {
                return usrcmpcod;
            }
            set
            {
                usrcmpcod = value;
            }
        }

        public char p_usrrol
        {
            get
            {
                return usrrol;
            }
            set
            {
                usrrol = value;
            }
        }

        public DateTime p_usrcrtdat
        {
            get
            {
                return usrcrtdat;
            }
            set
            {
                usrcrtdat = value;
            }
        }
    }
    public class clsfolprp : intfol
    {
        private Int32 folcod, folempcod, folfolempcod;
        public int p_folcod
        {
            get
            {
                return folcod;
            }
            set
            {
                folcod = value;
            }
        }

        public int p_folempcod
        {
            get
            {
                return folempcod;
            }
            set
            {
                folempcod = value;
            }
        }

        public int p_folfolempcod
        {
            get
            {
                return folfolempcod;
            }
            set
            {
                folfolempcod = value;
            }
        }
    }
    public class clsupdprp : intupd
    {
        private Int32 updcod, updempcod;
        private String upddsc, updfil;
        private DateTime upddat;
        public int p_updcod
        {
            get
            {
                return updcod;
            }
            set
            {
                updcod = value;
            }
        }

        public DateTime p_upddat
        {
            get
            {
                return upddat;
            }
            set
            {
                upddat = value;
            }
        }

        public int p_updempcod
        {
            get
            {
                return updempcod;
            }
            set
            {
                updempcod = value;
            }
        }

        public string p_upddsc
        {
            get
            {
                return upddsc;
            }
            set
            {
                upddsc = value;
            }
        }

        public string p_updfil
        {
            get
            {
                return updfil;
            }
            set
            {
                updfil = value;
            }
        }
    }
    public class clsgrpprp : intgrp
    {
        private Int32 grpcod, grpownempcod;
        private String grpnam, grpdsc;
        private DateTime grpcrtdat;
        public int p_grpcod
        {
            get
            {
                return grpcod;
            }
            set
            {
                grpcod = value;
            }
        }

        public string p_grpnam
        {
            get
            {
                return grpnam;
            }
            set
            {
                grpnam = value;
            }
            
        }

        public String p_grpdsc
        {
            get
            {
                return grpdsc;
            }
            set
            {
                grpdsc = value;
            }
        }

        public DateTime p_grpcrtdat
        {
            get
            {
                return grpcrtdat;
            }
            set
            {
                grpcrtdat = value;
            }
        }

        public int p_grpownempcod
        {
            get
            {
                return grpownempcod;
            }
            set
            {
                grpownempcod = value;
            }
        }
    }
    public class clsgrpmemprp : intgrpmem
    {
        private Int32 grpmemcod, grpmemgrpcod, grpmemempcod;
        public int p_grpmemcod
        {
            get
            {
                return grpmemcod;
            }
            set
            {
                grpmemcod = value;
            }
        }

        public int p_grpmemgrpcod
        {
            get
            {
                return grpmemgrpcod;

            }

            set
            {
                grpmemgrpcod = value;
            }
        }

        public int p_grpmemempcod
        {
            get
            {
                return grpmemempcod;
            }
            set
            {
                grpmemempcod = value;
            }
        }
    }
    public class clsdocprp : intdoc
    {
        private Int32 doccod, docgrpcod;
        private String doctit, docdsc, docdwnfil;
        public int p_doccod
        {
            get
            {
                return doccod;
            }
            set
            {
                doccod = value;
            }
        }

        public string p_doctit
        {
            get
            {
                return doctit;
            }
            set
            {
                doctit = value;
            }

        }

        public string p_docdsc
        {
            get
            {
                return docdsc;
            }
            set
            {
                docdsc = value;
            }
        }

        public int p_docgrpcod
        {
            get
            {
                return docgrpcod;
            }
            set
            {
                docgrpcod = value;
            }
        }

        public string p_docdwnfil
        {
            get
            {
                return docdwnfil;
            }
            set
            {
                docdwnfil = value;
            }
        }
    }

    public class clspln : clscon
    {
        
        public void savepln_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inspln",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plnnam", SqlDbType.VarChar, 100).Value = p.p_plnnam;
            cmd.Parameters.Add("@plndsc", SqlDbType.VarChar, 100).Value = p.p_plndsc;
            cmd.Parameters.Add("@plnnoe", SqlDbType.Int).Value = p.p_plnnoe;
            cmd.Parameters.Add("@plnprc", SqlDbType.Float).Value = p.p_plnprc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updpln_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = p.p_plncod;
            cmd.Parameters.Add("@plnnam", SqlDbType.VarChar, 100).Value = p.p_plnnam;
            cmd.Parameters.Add("@plndsc", SqlDbType.VarChar, 100).Value = p.p_plndsc;
            cmd.Parameters.Add("@plnnoe", SqlDbType.Int).Value = p.p_plnnoe;
            cmd.Parameters.Add("@plnprc", SqlDbType.Float).Value = p.p_plnprc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delpln_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delpln",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = p.p_plncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsplnprp> disppln_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("disppln",con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsplnprp> obj = new List<clsplnprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsplnprp k = new clsplnprp();
                k.p_plncod = Convert.ToInt32(dr[0]);
                k.p_plnnam = dr[1].ToString();
                k.p_plndsc = dr[2].ToString();
                k.p_plnnoe = Convert.ToInt32(dr[3]);
                k.p_plnprc = Convert.ToSingle(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsplnprp> findpln_rec(Int32 plncod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = plncod;
            List<clsplnprp> obj = new List<clsplnprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsplnprp k = new clsplnprp();
                k.p_plncod = Convert.ToInt32(dr[0]);
                k.p_plnnam = dr[1].ToString();
                k.p_plndsc = dr[2].ToString();
                k.p_plnnoe = Convert.ToInt32(dr[3]);
                k.p_plnprc = Convert.ToSingle(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
      

    }
    public class clscmp : clscon
    {
        public Int32 savecmp_rec(clscmpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inscmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpnam", SqlDbType.VarChar, 100).Value = p.p_cmpnam;
            cmd.Parameters.Add("@cmpcat", SqlDbType.VarChar, 100).Value = p.p_cmpcat;
            cmd.Parameters.Add("@cmpdsc", SqlDbType.VarChar, 1000).Value = p.p_cmpdsc;
            cmd.Parameters.Add("@cmplog", SqlDbType.VarChar, 50).Value = p.p_cmplog;
            cmd.Parameters.Add("@cmpurl", SqlDbType.VarChar, 100).Value = p.p_cmpurl;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void updcmp_rec(clscmpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpcod", SqlDbType.Int).Value = p.p_cmpcod;
            cmd.Parameters.Add("@cmpnam", SqlDbType.VarChar, 100).Value = p.p_cmpnam;
            cmd.Parameters.Add("@cmpcat", SqlDbType.VarChar, 100).Value = p.p_cmpcat;
            cmd.Parameters.Add("@cmpdsc", SqlDbType.VarChar, 1000).Value = p.p_cmpdsc;
            cmd.Parameters.Add("@cmplog", SqlDbType.VarChar,50).Value = p.p_cmplog;
            cmd.Parameters.Add("@cmpurl", SqlDbType.VarChar,100).Value = p.p_cmpurl;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delcmp_rec(clscmpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpcod", SqlDbType.Int).Value = p.p_cmpcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscmpprp> dispcmp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispcmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clscmpprp> obj = new List<clscmpprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscmpprp k = new clscmpprp();
                k.p_cmpcod = Convert.ToInt32(dr[0]);
                k.p_cmpnam = dr[1].ToString();
                k.p_cmpcat = dr[2].ToString();
                k.p_cmpdsc =dr[3].ToString();
                k.p_cmplog = dr[4].ToString();
                k.p_cmpurl = dr[5].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clscmpprp> findcmp_rec(Int32 cmpcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findcmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clscmpprp> obj = new List<clscmpprp>();
            SqlDataReader dr = cmd.ExecuteReader();
           if(dr.HasRows)
            {
                dr.Read();
                clscmpprp k = new clscmpprp();
                k.p_cmpcod = Convert.ToInt32(dr[0]);
                k.p_cmpnam = dr[1].ToString();
                k.p_cmpcat = dr[2].ToString();
                k.p_cmpdsc = dr[3].ToString();
                k.p_cmplog = dr[4].ToString();
                k.p_cmpurl = dr[5].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

    }
    public class clscmppln : clscon
    {
        public int chkpln(Int32 cmpcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("chkpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpcod", SqlDbType.Int).Value = cmpcod;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void savecmppln_rec(clscmpplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inscmppln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpplndat", SqlDbType.DateTime).Value = p.p_cmpplndat;
            cmd.Parameters.Add("@cmpplncmpcod", SqlDbType.Int).Value = p.p_cmpplncmpcod;
            cmd.Parameters.Add("@cmpplnplncod", SqlDbType.Int).Value = p.p_cmpplnplncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updcmppln_rec(clscmpplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcmppln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpplncod", SqlDbType.Int).Value = p.p_cmpplncod;
            cmd.Parameters.Add("@cmpplndat", SqlDbType.DateTime).Value = p.p_cmpplndat;
            cmd.Parameters.Add("@cmpplncmpcod", SqlDbType.Int).Value = p.p_cmpplncmpcod;
            cmd.Parameters.Add("@cmpplnplncod", SqlDbType.Int).Value = p.p_cmpplnplncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delcmppln_rec(clscmpplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcmppln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpplncod", SqlDbType.Int).Value = p.p_cmpplncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscmpplnprp> dispcmppln_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispcmppln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clscmpplnprp> obj = new List<clscmpplnprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscmpplnprp k = new clscmpplnprp();
                k.p_cmpplncod = Convert.ToInt32(dr[0]);
                k.p_cmpplndat = Convert.ToDateTime(dr[1]);
                k.p_cmpplncmpcod = Convert.ToInt32(dr[2]);
                k.p_cmpplnplncod = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clscmpplnprp> findcmppln_rec(Int32 cmpplncod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findcmppln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cmpplncod", SqlDbType.Int).Value = cmpplncod;
            List<clscmpplnprp> obj = new List<clscmpplnprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clscmpplnprp k = new clscmpplnprp();
                k.p_cmpplncod = Convert.ToInt32(dr[0]);
                k.p_cmpplndat = Convert.ToDateTime(dr[1]);
                k.p_cmpplncmpcod = Convert.ToInt32(dr[2]);
                k.p_cmpplnplncod = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

    }
    public class clsemp : clscon
    {
        public DataSet srcempfol(Int32 cmpcod, String strsrc,Int32 empcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcempfol", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@cmpcod", SqlDbType.Int).Value = cmpcod;
            adp.SelectCommand.Parameters.Add("@srcstr", SqlDbType.VarChar, 50).Value = strsrc;
            adp.SelectCommand.Parameters.Add("@empcod", SqlDbType.Int).Value = empcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet srcemp(Int32 cmpcod,String strsrc)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcemp",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@cmpcod", SqlDbType.Int).Value = cmpcod;
            adp.SelectCommand.Parameters.Add("@srcstr", SqlDbType.VarChar,50).Value = strsrc;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public void saveemp_rec(clsempprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empnam", SqlDbType.VarChar,100).Value = p.p_empnam;
            cmd.Parameters.Add("@empjobtit", SqlDbType.VarChar,100).Value = p.p_empjobtit;
            cmd.Parameters.Add("@emppic", SqlDbType.VarChar,50).Value = p.p_emppic;
            cmd.Parameters.Add("@empusrcod", SqlDbType.Int).Value = p.p_empusrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updemp_rec(clsempprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empcod", SqlDbType.Int).Value = p.p_empcod;
            cmd.Parameters.Add("@empnam", SqlDbType.VarChar, 100).Value = p.p_empnam;
            cmd.Parameters.Add("@empjobtit", SqlDbType.VarChar, 100).Value = p.p_empjobtit;
            cmd.Parameters.Add("@emppic", SqlDbType.VarChar, 50).Value = p.p_emppic;
            cmd.Parameters.Add("@empusrcod", SqlDbType.Int).Value = p.p_empusrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delemp_rec(clsempprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empcod", SqlDbType.Int).Value = p.p_empcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsempprp> dispemp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsempprp> obj = new List<clsempprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsempprp k = new clsempprp();
                k.p_empcod = Convert.ToInt32(dr[0]);
                k.p_empnam = dr[1].ToString();
                k.p_empjobtit = dr[2].ToString();
                k.p_emppic = dr[3].ToString();
                k.p_empusrcod = Convert.ToInt32(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public DataSet srcempforgrp(Int32 cmpcod,String srcstr,Int32 grpcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcempforgrp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@cmpcod", SqlDbType.Int).Value = cmpcod;
            adp.SelectCommand.Parameters.Add("@srcstr", SqlDbType.VarChar, 50).Value = srcstr;
            adp.SelectCommand.Parameters.Add("@grpcod", SqlDbType.Int).Value = grpcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;    
        }
        public List<clsempprp> findemp_rec(Int32 empcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empcod", SqlDbType.Int).Value = empcod;
            List<clsempprp> obj = new List<clsempprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                clsempprp k = new clsempprp();
                k.p_empcod = Convert.ToInt32(dr[0]);
                k.p_empnam = dr[1].ToString();
                k.p_empjobtit = dr[2].ToString();
                k.p_emppic = dr[3].ToString();
                k.p_empusrcod = Convert.ToInt32(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsusr : clscon
    {
        public Int32 chgpwd(Int32 usrcod, String oldpwd, String newpwd, char sts)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("chgpwd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            cmd.Parameters.Add("@oldpwd", SqlDbType.VarChar, 50).Value = oldpwd;
            cmd.Parameters.Add("@newpwd", SqlDbType.VarChar, 50).Value = newpwd;
            cmd.Parameters.Add("@sts", SqlDbType.Char, 1).Value = sts;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;

        }
        public Char logincheck(string eml, string pwd, out Int32 cmpcod, out Int32 empcod,out Int32 ucod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 50).Value = eml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = pwd;
            cmd.Parameters.Add("@rol", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@cmpcod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@empcod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ucod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            char rol;
            rol = Convert.ToChar(cmd.Parameters["@rol"].Value);
            cmpcod = Convert.ToInt32(cmd.Parameters["@cmpcod"].Value);
            empcod = Convert.ToInt32(cmd.Parameters["@empcod"].Value);
            ucod = Convert.ToInt32(cmd.Parameters["@ucod"].Value);
            cmd.Dispose();
            con.Close();
            return rol;
        }
        public Int32 saveusr_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.p_usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.p_usrpwd;
            cmd.Parameters.Add("@usrcmpcod", SqlDbType.Int).Value = p.p_usrcmpcod;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char,1).Value = p.p_usrrol;
            cmd.Parameters.Add("@usrcrtdat", SqlDbType.DateTime).Value = p.p_usrcrtdat;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void updusr_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.p_usrcod;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.p_usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.p_usrpwd;
            cmd.Parameters.Add("@usrcmpcod", SqlDbType.Int).Value = p.p_usrcmpcod;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char, 1).Value = p.p_usrrol;
            cmd.Parameters.Add("@usrcrtdat", SqlDbType.DateTime).Value = p.p_usrcrtdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delusr_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.p_usrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsusrprp> dispusr_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsusrprp> obj = new List<clsusrprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsusrprp k = new clsusrprp();
                k.p_usrcod = Convert.ToInt32(dr[0]);
                k.p_usreml = dr[1].ToString();
                k.p_usrpwd = dr[2].ToString();
                k.p_usrcmpcod = Convert.ToInt32(dr[3]);
                k.p_usrrol = Convert.ToChar(dr[4]);
                k.p_usrcrtdat = Convert.ToDateTime(dr[5]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsusrprp> findusr_rec(Int32 usrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            List<clsusrprp> obj = new List<clsusrprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsusrprp k = new clsusrprp();
                k.p_usrcod = Convert.ToInt32(dr[0]);
                k.p_usreml = dr[1].ToString();
                k.p_usrpwd = dr[2].ToString();
                k.p_usrcmpcod = Convert.ToInt32(dr[3]);
                k.p_usrrol = Convert.ToChar(dr[4]);
                k.p_usrcrtdat = Convert.ToDateTime(dr[5]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsfol : clscon
    {
        public void savefol_rec(clsfolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insfol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@folempcod", SqlDbType.Int).Value = p.p_folempcod;
            cmd.Parameters.Add("@folfolempcod", SqlDbType.Int).Value = p.p_folfolempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updfol_rec(clsfolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updfol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@folcod", SqlDbType.Int).Value = p.p_folcod;
            cmd.Parameters.Add("@folempcod", SqlDbType.Int).Value = p.p_folempcod;
            cmd.Parameters.Add("@folfolempcod", SqlDbType.Int).Value = p.p_folfolempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delfol_rec(clsfolprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delfol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@folempcod", SqlDbType.Int).Value = p.p_folempcod;
            cmd.Parameters.Add("@folfolempcod", SqlDbType.Int).Value = p.p_folfolempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsfolprp> dispfol_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispfol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsfolprp> obj = new List<clsfolprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsfolprp k = new clsfolprp();
                k.p_folcod = Convert.ToInt32(dr[0]);
                k.p_folempcod = Convert.ToInt32(dr[1]);
                k.p_folfolempcod = Convert.ToInt32(dr[2]);                
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsfolprp> findfol_rec(Int32 folcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findfol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsfolprp> obj = new List<clsfolprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsfolprp k = new clsfolprp();
                k.p_folcod = Convert.ToInt32(dr[0]);
                k.p_folempcod = Convert.ToInt32(dr[1]);
                k.p_folfolempcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsupd : clscon
    {
        public DataSet dspupd(Int32 empcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspupd",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("empcod", SqlDbType.Int).Value = empcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public int saveupd_rec(clsupdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insupd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@updcod", SqlDbType.Int).Value = p.p_updcod;
            cmd.Parameters.Add("@upddat", SqlDbType.DateTime).Value = p.p_upddat;
            cmd.Parameters.Add("@updempcod", SqlDbType.Int).Value = p.p_updempcod;
            cmd.Parameters.Add("@upddsc", SqlDbType.VarChar, 3000).Value = p.p_upddsc;
            cmd.Parameters.Add("@updfil", SqlDbType.VarChar, 50).Value = p.p_updfil;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void updupd_rec(clsupdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updupd", con);            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@updcod", SqlDbType.Int).Value = p.p_updcod;
            cmd.Parameters.Add("@upddat", SqlDbType.DateTime).Value = p.p_upddat;
            cmd.Parameters.Add("@updempcod", SqlDbType.Int).Value = p.p_updempcod;
            cmd.Parameters.Add("@upddsc", SqlDbType.VarChar, 3000).Value = p.p_upddsc;
            cmd.Parameters.Add("@updfil", SqlDbType.VarChar, 50).Value = p.p_updfil;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delupd_rec(clsupdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delupd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@updcod", SqlDbType.Int).Value = p.p_updcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsupdprp> dispupd_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispupd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsupdprp> obj = new List<clsupdprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsupdprp k = new clsupdprp();
                k.p_updcod = Convert.ToInt32(dr[0]);
                k.p_upddat = Convert.ToDateTime(dr[1]);
                k.p_updempcod = Convert.ToInt32(dr[2]);
                k.p_upddsc = dr[3].ToString();
                k.p_updfil = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsupdprp> findfol_rec(Int32 updcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispupd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@updcod", SqlDbType.Int).Value = updcod;
            List<clsupdprp> obj = new List<clsupdprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsupdprp k = new clsupdprp();
                k.p_updcod = Convert.ToInt32(dr[0]);
                k.p_upddat = Convert.ToDateTime(dr[1]);
                k.p_updempcod = Convert.ToInt32(dr[2]);
                k.p_upddsc = dr[3].ToString();
                k.p_updfil = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsgrp : clscon
    {
        public DataSet dspgrps(Int32 empcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspgrps", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@empcod", SqlDbType.Int).Value = empcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public void savegrp_rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpnam", SqlDbType.VarChar,100).Value = p.p_grpnam;
            cmd.Parameters.Add("@grpdsc", SqlDbType.VarChar,2000).Value = p.p_grpdsc;
            cmd.Parameters.Add("@grpcrtdat", SqlDbType.DateTime).Value = p.p_grpcrtdat;
            cmd.Parameters.Add("@grpownempcod", SqlDbType.Int).Value = p.p_grpownempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updgrp_rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = p.p_grpcod;
            cmd.Parameters.Add("@grpnam", SqlDbType.VarChar, 100).Value = p.p_grpnam;
            cmd.Parameters.Add("@grpdsc", SqlDbType.VarChar, 2000).Value = p.p_grpdsc;
            cmd.Parameters.Add("@grpcrtdat", SqlDbType.DateTime).Value = p.p_grpcrtdat;
            cmd.Parameters.Add("@grpownempcod", SqlDbType.Int).Value = p.p_grpownempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delgrp_rec(clsgrpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = p.p_grpcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsgrpprp> dispgrp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsgrpprp> obj = new List<clsgrpprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsgrpprp k = new clsgrpprp();
                k.p_grpcod = Convert.ToInt32(dr[0]);
                k.p_grpnam = dr[1].ToString();
                k.p_grpdsc = dr[2].ToString();
                k.p_grpcrtdat = Convert.ToDateTime(dr[3]);
                k.p_grpownempcod = Convert.ToInt32(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsgrpprp> findgrp_rec(Int32 grpcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findgrp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = grpcod;
            List<clsgrpprp> obj = new List<clsgrpprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsgrpprp k = new clsgrpprp();
                k.p_grpcod = Convert.ToInt32(dr[0]);
                k.p_grpnam = dr[1].ToString();
                k.p_grpdsc = dr[2].ToString();
                k.p_grpcrtdat = Convert.ToDateTime(dr[3]);
                k.p_grpownempcod = Convert.ToInt32(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsgrpmem : clscon
    {
        public DataSet dspgrpmem(Int32 grpcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspgrpmem", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@grpcod", SqlDbType.Int).Value = grpcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public void savegrpmem_rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpmemgrpcod", SqlDbType.Int).Value = p.p_grpmemgrpcod;
            cmd.Parameters.Add("@grpmemempcod", SqlDbType.Int).Value = p.p_grpmemempcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void updgrpmem_rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = p.p_grpmemcod;
            cmd.Parameters.Add("@grpmemgrpcod", SqlDbType.Int).Value = p.p_grpmemgrpcod;
            cmd.Parameters.Add("@grpmemempcod", SqlDbType.Int).Value = p.p_grpmemempcod; 
            cmd.Dispose();
            con.Close();
        }
        public void delgrpmem_rec(clsgrpmemprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = p.p_grpmemcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsgrpmemprp> dispgrpmem_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsgrpmemprp> obj = new List<clsgrpmemprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsgrpmemprp k = new clsgrpmemprp();
                k.p_grpmemcod = Convert.ToInt32(dr[0]);
                k.p_grpmemgrpcod = Convert.ToInt32(dr[1]);
                k.p_grpmemempcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsgrpmemprp> findgrpmem_rec(Int32 grpmemcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispgrpmem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpmemcod", SqlDbType.Int).Value = grpmemcod;
            List<clsgrpmemprp> obj = new List<clsgrpmemprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsgrpmemprp k = new clsgrpmemprp();
                k.p_grpmemcod = Convert.ToInt32(dr[0]);
                k.p_grpmemgrpcod = Convert.ToInt32(dr[1]);
                k.p_grpmemempcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

    }
    public class clsdoc : clscon
    {
        public Int32 savedoc_rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insdoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doctit", SqlDbType.VarChar,100).Value = p.p_doctit;
            cmd.Parameters.Add("@docdsc", SqlDbType.VarChar, 2000).Value = p.p_docdsc;
            cmd.Parameters.Add("@docgrpcod", SqlDbType.Int).Value = p.p_docgrpcod;
            cmd.Parameters.Add("@docdwnfil", SqlDbType.VarChar, 50).Value = p.p_docdwnfil;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upddoc_rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upddoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = p.p_doccod;
            cmd.Parameters.Add("@doctit", SqlDbType.VarChar, 100).Value = p.p_doctit;
            cmd.Parameters.Add("@docdsc", SqlDbType.VarChar, 2000).Value = p.p_docdsc;
            cmd.Parameters.Add("@docgrpcod", SqlDbType.Int).Value = p.p_docgrpcod;
            cmd.Parameters.Add("@docdwnfil", SqlDbType.VarChar, 50).Value = p.p_docdwnfil;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void deldoc_rec(clsdocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("deldoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doccod", SqlDbType.Int).Value = p.p_doccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsdocprp> dispdoc_rec(Int32 grpcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dispdoc", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@grpcod", SqlDbType.Int).Value = grpcod;
            List<clsdocprp> obj = new List<clsdocprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsdocprp k = new clsdocprp();
                k.p_doccod = Convert.ToInt32(dr[0]);
                k.p_doctit = dr[1].ToString();
                k.p_docdsc = dr[2].ToString();
                k.p_docgrpcod = Convert.ToInt32(dr[3]);
                k.p_docdwnfil = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsdocprp> finddoc_rec(Int32 doccod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("finddoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<clsdocprp> obj = new List<clsdocprp>();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                clsdocprp k = new clsdocprp();
                k.p_doccod = Convert.ToInt32(dr[0]);
                k.p_doctit = dr[1].ToString();
                k.p_docdsc = dr[2].ToString();
                k.p_docgrpcod = Convert.ToInt32(dr[3]);
                k.p_docdwnfil = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj; 
        }

    }
}