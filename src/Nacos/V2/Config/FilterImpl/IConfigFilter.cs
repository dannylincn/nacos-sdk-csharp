﻿namespace Nacos.V2.Config.FilterImpl
{
    public interface IConfigFilter
    {
        void Init(IFilterConfig filterConfig);

        void DoFilter(IConfigRequest request, IConfigResponse response, IConfigFilterChain filterChain);

        void Deploy();

        int GetOrder();

        string GetFilterName();
    }
}
