// Copyright 2007-2008 The Apache Software Foundation.
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
namespace dropkick.FileSystem
{
    using System.Text.RegularExpressions;
    using DeploymentModel;

    public class RemotePathHelper
    {
        public static string Convert(PhysicalServer server, string localpath)
        {
            return Convert(server.Name, localpath);
        }

        public static string Convert(string server, string localpath)
        {
            if (IsUncPath(localpath))
                return localpath;

            var newPath = @"\\{0}\{1}".FormatWith(server,localpath);

            if (localpath.StartsWith("~")) 
                newPath = newPath.Replace(@"~\", "");

            newPath = newPath.Replace(':', '$');

            return newPath;
        }

        public static bool IsUncPath(string path)
        {
            return path.StartsWith(@"\\");
        }


        public static string SwapUncServerFor(string server)
        {
            var bob = new Regex(@"\\\\");
            return server;
        }
    }
}