/* Maftoul Omar December 2017 */

using System;
using System.Data;
using System.Drawing;
using Oracle.ManagedDataAccess.Client;

namespace worldCupTest2
{
    public class WorldCupDataBase
    {
        private const  string Host = "localhost";//0
        private const string Listner = "1521";//1
        private const string ServerName = "xe";//2
        private const string UserId = "worldcup2";//3
        private const string Password = "worldcup2";//4
        private OracleConnection ConnectionToDataBase;
        private OracleCommand Command;
        private OracleDataReader dataReader;
        private string ConnectionString =
            String.Format
            ("Data Source ={0}:{1}/{2} ;  " +
             "User Id = {3} ; " +
             "Password ={4}  ; ", Host, Listner, ServerName, UserId, Password);


        public void OpenConnection()
        {
             ConnectionToDataBase = new OracleConnection(StringConnection);
            ConnectionToDataBase.Open();
        }

        public void CloseConnection()
        {
            ConnectionToDataBase.Close();
            ConnectionToDataBase.Dispose();
        }

        public string[] selectTeams(string pot, int rank)
        {
            
            string[] confederationAandTeamName = new string[2] ;
            Command = new OracleCommand();
            Command.Connection = ConnectionToDataBase;
            Command.CommandText = 
                String.Format("select team_name,confederation from teams where team_pot='{0}' and rank ={1}",pot,rank);
            Command.CommandType = CommandType.Text;
            dataReader = Command.ExecuteReader();
            dataReader.Read();
             confederationAandTeamName[0]=dataReader.GetString(0);
            confederationAandTeamName[1] = dataReader.GetString(1);
            return confederationAandTeamName;
        }

        public string[] getFlags(string name)
        {

            string[] informations = new string[3];
            Command = new OracleCommand();
            Command.Connection = ConnectionToDataBase;
            Command.CommandText =
                String.Format("select team_name,team_pot,rank from teams where team_name='{0}'", name);
            Command.CommandType = CommandType.Text;
            dataReader = Command.ExecuteReader();
            dataReader.Read();
            informations[0] = dataReader.GetString(0);
            informations[1] = dataReader.GetString(1);
            informations[2] = dataReader.GetInt32(2).ToString();
            return informations;
        }



        public string StringConnection
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }
    }
}