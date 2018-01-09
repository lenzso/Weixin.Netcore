﻿namespace Weixin.Netcore.Model.WeixinMessage
{
    /// <summary>
    /// 扫码订阅事件消息
    /// </summary>
    public class ScanSubscribeEvtMessage : ScanEvtMessage
    {
        public ScanSubscribeEvtMessage()
        {
            Event = "Subscribe";
        }
    }
}
