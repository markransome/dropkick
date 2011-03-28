// Copyright 2007-2010 The Apache Software Foundation.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace dropkick.tests.Tasks.Security
{
    using System;
    using dropkick.Tasks.Security.LocalPolicy;
    using NUnit.Framework;

    [TestFixture]
    public class LogOnAsServiceTaskTest
    {
        [Test]
        public void Verify()
        {
            var t = new LogOnAsAServiceTask(Environment.MachineName,"dk_test");
            var r = t.VerifyCanRun();
        }

        [Test][Explicit]
        public void Execute()
        {
            var t = new LogOnAsAServiceTask(Environment.MachineName, "dk_test");
            var r = t.Execute();
        }
    }
}