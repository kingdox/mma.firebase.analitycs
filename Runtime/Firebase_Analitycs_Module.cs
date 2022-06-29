#region Access
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using UnityEngine;
using Firebase.Analytics;
#endregion
namespace MMA.Business_Firebase_Analitycs
{
    public static partial class Key
    {
        // public const string _   = KeyData._;
        public static string LogEvent = "Firebase_Analitycs_LogEvent";
    }
    public static partial class Import
    {
        //public const string _ = _;
    }
    public sealed partial class Firebase_Analitycs_Module : Module
    {
        #region References
        //[Header("Applications")]
        //[SerializeField] public ApplicationBase interface_Business_Firebase_Analitycs;
        #endregion
        #region Reactions ( On___ )
        // Contenedor de toda las reacciones del Business_Firebase_Analitycs
        protected override void OnSubscription(bool condition)
        {
            //LogEvent
            Middleware<string>.Subscribe_Publish(condition,name,LogEvent);
            Middleware<(string name, Parameter parameter)>.Subscribe_Publish(condition,name,LogEvent);
            Middleware<(string name, Parameter[] parameter)>.Subscribe_Publish(condition,name,LogEvent);
        }
        #endregion
        #region Methods
        // Contenedor de toda la logica del Business_Firebase_Analitycs
        private void LogEvent(string name){
            FirebaseAnalytics.LogEvent(name);
        }
        private void LogEvent((string name, Parameter parameter) result){
            FirebaseAnalytics.LogEvent(result.name, result.parameter);
        }
        private void LogEvent((string name, Parameter[] parameter) result)
        {
            FirebaseAnalytics.LogEvent(result.name, result.parameter);
        }
        #endregion
        #region Request ( Coroutines )
        // Contenedor de toda la Esperas de corutinas del Business_Firebase_Analitycs
        #endregion
        #region Task ( async )
        // Contenedor de toda la Esperas asincronas del Business_Firebase_Analitycs
        #endregion
    }
}
