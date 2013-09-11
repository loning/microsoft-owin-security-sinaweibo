﻿/*
 *  Copyright 2013 Feifan Tang. All rights reserved.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 * 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * 
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Owin.Security.SinaWeibo.Provider
{
    public class SinaWeiboAccountReturnEndpointContext : ReturnEndpointContext
    {
        public SinaWeiboAccountReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket,
            IDictionary<string, string> errorDetails)
            : base(context, ticket, errorDetails)
        {
        }
    }
}
