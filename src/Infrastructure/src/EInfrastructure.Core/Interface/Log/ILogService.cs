using EInfrastructure.Core.Interface.IOC;

namespace EInfrastructure.Core.Interface.Log
{
    /// <summary>
    /// 日志服务
    /// </summary>
    public interface ILogService : IPerRequest
    {
        #region 增加error文件日志

        /// <summary>
        /// 增加error文件日志
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        void Error(string title, object msg = null);


        /// <summary>
        /// 增加error文件日志
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        void Error<T>(T t) where T : class;

        #endregion

        #region 增加debug文件日志

        /// <summary>
        /// 增加debug文件日志
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        void Debug(string title, object msg = null);

        /// <summary>
        /// 增加debug文件日志
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        void Debug<T>(T t) where T : class;

        #endregion

        #region 增加info文件日志

        /// <summary>
        /// 增加info文件日志
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        void Info(string title, object msg = null);

        /// <summary>
        /// 增加info文件日志
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        void Info<T>(T t) where T : class;

        #endregion

        #region 增加warn文件日志

        /// <summary>
        /// 增加warn文件日志
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        void Warn(string title, object msg = null);

        /// <summary>
        /// 增加warn文件日志
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        void Warn<T>(T t) where T : class;

        #endregion

        #region 增加trace文件日志

        /// <summary>
        /// 增加trace文件日志
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        void Trace(string title, object msg = null);

        /// <summary>
        /// 增加trace文件日志
        /// </summary>
        /// <param name="t"></param>
        /// <typeparam name="T"></typeparam>
        void Trace<T>(T t) where T : class;

        #endregion
    }
}