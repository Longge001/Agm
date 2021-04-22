﻿using Furion.TaskScheduler;

namespace Dilon.Core.Service
{
    /// <summary>
    /// 任务信息---任务详情
    /// </summary>
    public class JobOutput
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 执行间隔时间（单位秒）
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// Cron表达式
        /// </summary>
        public string Cron { get; set; }

        /// <summary>
        /// 定时器类型
        /// </summary>
        public SpareTimeTypes TimerType { get; set; }

        /// <summary>
        /// 执行次数
        /// </summary>
        public int? RunNumber { get; set; }

        /// <summary>
        /// 请求url
        /// </summary>
        public string RequestUrl { get; set; }

        /// <summary>
        /// 请求参数（Post，Put请求用）
        /// </summary>
        public string RequestParameters { get; set; }

        /// <summary>
        /// Headers(可以包含如：Authorization授权认证)
        /// 格式：{"Authorization":"userpassword.."}
        /// </summary>
        public string Headers { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        /// <example>2</example>
        public RequestTypeEnum RequestType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 定时器状态
        /// </summary>
        public SpareTimeStatus TimerStatus { get; set; } = SpareTimeStatus.Stopped;

        /// <summary>
        /// 异常信息
        /// </summary>
        public string Exception { get; set; }
    }
}
