// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using Apache.Iggy.Contracts.Http;
using Apache.Iggy.Tests.E2ETests.Fixtures.Models;
using Apache.Iggy.Tests.Utils.Streams;

namespace Apache.Iggy.Tests.E2ETests.Fixtures.Bootstraps;

public class StreamsFixtureBootstrap : IIggyBootstrap
{
    public static readonly StreamRequest StreamRequest = StreamFactory.CreateStreamRequest();
    public static readonly UpdateStreamRequest UpdateStreamRequest = StreamFactory.CreateUpdateStreamRequest();
    public Task BootstrapResourcesAsync(IggyClientModel httpClient, IggyClientModel tcpClient)
    {
        return Task.CompletedTask;
    }
}