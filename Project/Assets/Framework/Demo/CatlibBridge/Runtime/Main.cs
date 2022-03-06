/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System.Collections.Generic;
using CatLib;
using CatLib.Util;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Framework.Demo.CatlibBridge.Runtime.Config;
using Framework.Save.Sqlite;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;

namespace Framework.Demo.CatlibBridge.Runtime
{
    /// <summary>
    /// Main project entrance.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class Main : CatLib.Framework
    {
        protected override void Awake()
        {
            //Json序列化设置
            JsonSettings();

            base.Awake();
        }

        /// <inheritdoc />
        protected override void OnStartCompleted(IApplication application, StartCompletedEventArgs args)
        {
            // Application entry, Your code starts writing here
            // called this function after, use App.Make function to get service
            // ex: App.Make<IYourService>().Debug("hello world");

            Debug.Log("Hello CatLib, Debug Level: " + App.Make<DebugLevel>());
            App.Watch<DebugLevel>(newLevel =>
            {
                Debug.Log("Change debug level: " + newLevel);
            });

            App.Make<ISqlite>().Save("", "");
        }

        /// <inheritdoc />
        protected override IBootstrap[] GetBootstraps()
        {
            return Arr.Merge(base.GetBootstraps(), Bootstraps.GetBoostraps(this));
        }

        #region Json序列化设置

        /// <summary>
        /// Json序列化设置
        /// </summary>
        void JsonSettings()
        {
            //Json序列化设置(需要再Repo进行序列化之前，不然会报Json序列化失败异常)
            JsonConvert.DefaultSettings = () =>
            {
                var setting = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                };

                return setting;
            };
        }

        #endregion

        protected override void Start()
        {
            base.Start();

            ResHotFixTest().Forget();
        }

        async UniTask ResHotFixTest()
        {
            var canvas = GameObject.Find("Canvas");
            var img = await Addressables.LoadAssetAsync<GameObject>("HotImg");

            Object.Instantiate(img, canvas.transform);
        }
    }
}
