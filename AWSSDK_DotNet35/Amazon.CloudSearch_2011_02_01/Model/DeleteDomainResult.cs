/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// <para>A response message that contains the status of a newly deleted domain, or no status if the domain has already been completely
    /// deleted.</para>
    /// </summary>
    public partial class DeleteDomainResult : AmazonWebServiceResponse
    {
        
        private DomainStatus domainStatus;


        /// <summary>
        /// The current status of the search domain.
        ///  
        /// </summary>
        public DomainStatus DomainStatus
        {
            get { return this.domainStatus; }
            set { this.domainStatus = value; }
        }

        // Check to see if DomainStatus property is set
        internal bool IsSetDomainStatus()
        {
            return this.domainStatus != null;
        }
    }
}