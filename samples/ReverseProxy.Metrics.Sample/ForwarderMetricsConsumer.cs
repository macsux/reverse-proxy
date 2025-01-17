// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using Yarp.Telemetry.Consumption;

namespace Yarp.Sample
{
    public sealed class ForwarderMetricsConsumer : IForwarderMetricsConsumer
    {
        public void OnForwarderMetrics(ForwarderMetrics oldMetrics, ForwarderMetrics newMetrics)
        {
            var elapsed = newMetrics.Timestamp - oldMetrics.Timestamp;
            var newRequests = newMetrics.RequestsStarted - oldMetrics.RequestsStarted;
            Console.Title = $"Forwarded {newMetrics.RequestsStarted} requests ({newRequests} in the last {(int)elapsed.TotalMilliseconds} ms)";
        }
    }
}
