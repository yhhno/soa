﻿using ESB.Core.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ESB.ProviderWebService.Handler
{
    /// <summary>
    /// ESB_QUEUE_20 的摘要说明
    /// </summary>
    public class ESB_QUEUE_20 : AshxAdapter
    {
        protected override string DoEsbAction(string esbAction, string request)
        {
            Thread.Sleep(1000 * 100);

            return String.Format("收到参数：{0}={1}。", esbAction, request);
        }
    }
}