/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobsByPipeline Request Marshaller
    /// </summary>       
    public class ListJobsByPipelineRequestMarshaller : IMarshaller<IRequest, ListJobsByPipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobsByPipelineRequest)input);
        }

        public IRequest Marshall(ListJobsByPipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.HttpMethod = "GET";

            string uriResourcePath = "/2012-09-25/jobsByPipeline/{PipelineId}";
            uriResourcePath = uriResourcePath.Replace("{PipelineId}", publicRequest.IsSetPipelineId() ? StringUtils.FromString(publicRequest.PipelineId) : string.Empty);
            
            if (publicRequest.IsSetAscending())
                request.Parameters.Add("Ascending", StringUtils.FromString(publicRequest.Ascending));
            
            if (publicRequest.IsSetPageToken())
                request.Parameters.Add("PageToken", StringUtils.FromString(publicRequest.PageToken));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }


    }
}