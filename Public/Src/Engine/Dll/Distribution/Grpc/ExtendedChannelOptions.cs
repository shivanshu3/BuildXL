// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using BuildXL.Utilities.Configuration;
using Grpc.Core;

namespace BuildXL.Engine.Distribution.Grpc
{
    /// <summary>
    /// Channel options to support keepalive feature:
    /// https://fuchsia.googlesource.com/third_party/grpc/%2B/refs/tags/v1.24.3/doc/keepalive.md
    /// </summary>
    internal static class ExtendedChannelOptions
    {
        /// <summary>
        /// This channel argument controls the period (in milliseconds) after
        /// which a keepalive ping is sent on the transport.
        /// </summary>
        public const string KeepAliveTimeMs = "grpc.keepalive_time_ms";

        /// <summary>
        /// This channel argument controls the amount of time (in
        /// milliseconds), the sender of the keepalive ping waits for an
        /// acknowledgement. If it does not receive an acknowledgement within
        /// this time, it will close the connection.
        /// </summary>
        public const string KeepAliveTimeoutMs = "grpc.keepalive_timeout_ms";

        /// <summary>
        /// This channel argument if set to 1 (0 : false; 1 : true), allows
        /// keepalive pings to be sent even if there are no calls in flight.
        /// </summary>
        public const string KeepAlivePermitWithoutCalls = "grpc.keepalive_permit_without_calls";

        /// <summary>
        /// This channel argument if set to 1 (0 : false; 1 : true), allows
        /// keepalive pings to be sent even if there are no calls in flight.
        /// </summary>
        public const string MinTimeBetweenPingsMs = "grpc.http2.min_time_between_pings_ms";

        /// <summary>
        /// This channel argument controls the maximum number of pings that can be 
        /// sent when there is no data/header frame to be sent. GRPC Core will not 
        /// continue sending pings if we run over the limit. Setting it to 0 allows 
        /// sending pings without such a restriction.
        /// </summary>
        public const string MaxPingsWithoutData = "grpc.http2.max_pings_without_data";

        /// <summary>
        /// If there are no data/header frames being received on the transport, this 
        /// channel argument controls the minimum time (in milliseconds) gRPC Core 
        /// will wait between successive pings.
        /// </summary>
        public const string MinSentPingIntervalWithoutDataMs = "grpc.http2.min_sent_ping_interval_without_data_ms";

        /// <summary>
        /// If there are no data/header frames being sent on the transport, this channel
        /// argument on the server side controls the minimum time (in milliseconds) that 
        /// gRPC Core would expect between receiving successive pings. If the time between 
        /// successive pings is less that than this time, then the ping will be considered
        /// a bad ping from the peer. Such a ping counts as a �ping strike�. On the client 
        /// side, this does not have any effect.
        /// </summary>
        public const string MinRecvPingIntervalWithoutDataMs = "grpc.http2.min_recv_ping_interval_without_data_ms";


    }
}