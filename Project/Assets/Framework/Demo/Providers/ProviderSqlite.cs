using System.Collections;
using System.Collections.Generic;
using CatLib;
using CatLib.Container;
using Framework.Save.Sqlite;
using UnityEngine;

namespace Framework.Demo.Providers
{
    public class ProviderSqlite : ServiceProvider
    {
        /// <summary>
        /// ע����Ϣ���߷���
        /// </summary>
        public override void Register()
        {
            App.Singleton<ISqlite, SqliteSystem>();
        }
    }
}