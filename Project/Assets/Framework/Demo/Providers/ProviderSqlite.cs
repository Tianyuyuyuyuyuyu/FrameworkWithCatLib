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
        /// 注册消息管线服务
        /// </summary>
        public override void Register()
        {
            App.Singleton<ISqlite, SqliteSystem>();
        }
    }
}