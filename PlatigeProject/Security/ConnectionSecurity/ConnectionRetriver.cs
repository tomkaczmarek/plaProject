using DataModel.Utils.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security.Helpers;
using System.IO;


namespace Security.ConnectionSecurity
{
    public class ConnectionRetriver
    {
        private const string FILE_NAME = "dbProfiles.txt";

        public static string FullPath => $@"{Environment.CurrentDirectory}\{FILE_NAME}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public static void SaveConnection(IContext context )
        {
            ConnectionModel model = new ConnectionModel { Server = context.Server, Database = context.Database, Password = EncryptString(context.Password), User = context.User };
            List<ConnectionModel> list = new List<ConnectionModel>();
            if (File.Exists(FullPath))
                list = XmlHelper<List<ConnectionModel>>.DeserializeXmlFromFile(FILE_NAME);
            else
                File.Create(FullPath);

            list.Add(model);
            XmlHelper<List<ConnectionModel>>.SerializeXmlToFile(list, FullPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static IContext GetConnection<T>(string connectionName) where T: IContext, new()
        {
            IContext connection = null;
            List<ConnectionModel> list = new List<ConnectionModel>();
            if (File.Exists(FullPath))
            {
                list = XmlHelper<List<ConnectionModel>>.DeserializeXmlFromFile(FILE_NAME);
                ConnectionModel connectionModel = list.Where(x => x.Server == connectionName).Select(x => x).FirstOrDefault();
                connection = new T() { Server = connectionModel.Server, Database = connectionModel.Database, Password = DescryptString(connectionModel.Password), User = connectionModel.User };           
            }            
            return connection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetListOfConnections()
        {
            List<ConnectionModel> list = new List<ConnectionModel>();
            if (File.Exists(FullPath))
                list = XmlHelper<List<ConnectionModel>>.DeserializeXmlFromFile(FILE_NAME);

            return list.Select(x=>x.Server).Distinct().ToList();
        }

        private static string DescryptString(string text)
        {
            return text;
        }

        private static string  EncryptString(string text)
        {
            return text;
        }
    }
}
