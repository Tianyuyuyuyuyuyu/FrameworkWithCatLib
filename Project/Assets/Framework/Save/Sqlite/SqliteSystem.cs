using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using CatLib;
using System.Data;
// using Mono.Data.SqliteClient;
using Sirenix.Utilities;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using Cysharp.Threading.Tasks;
using System.IO;
using System.Text;

namespace Framework.Save.Sqlite
{
    public class SqliteSystem : ISqlite
    {
        private IDbConnection sqlConnection = null;

        private IDbCommand sqlCommand = null;

        public SqliteSystem()
        {
            InitSQLiteClient();
        }

        void InitSQLiteClient()
        {
            // sqlConnection = new SqliteConnection(dreamSQLiteDB);
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
        }

        public void Save(string Key, string data)
        {
            Debug.LogError("��������");
        }

        public string GetData(string key)
        {
            Debug.LogError("�������");
            return "";
        }

        public void DeleteData(string key)
        {
            Debug.LogError("ɾ������");
        }

        public void CreateNewDatabase(bool isInGame)
        {
            Debug.LogError("�½����ݿ�");
        }

        public void Release()
        {
            Debug.LogError("�ͷ���Դ");
        }
    }
}