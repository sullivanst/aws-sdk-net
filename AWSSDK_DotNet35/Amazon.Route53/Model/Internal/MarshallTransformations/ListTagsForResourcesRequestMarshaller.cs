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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTagsForResources Request Marshaller
    /// </summary>       
    public class ListTagsForResourcesRequestMarshaller : IMarshaller<IRequest, ListTagsForResourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTagsForResourcesRequest)input);
        }

        public IRequest Marshall(ListTagsForResourcesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "POST";
            string uriResourcePath = "/2013-04-01/tags/{ResourceType}";
            uriResourcePath = uriResourcePath.Replace("{ResourceType}", publicRequest.IsSetResourceType() ? StringUtils.FromString(publicRequest.ResourceType) : string.Empty);
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("ListTagsForResourcesRequest", "https://route53.amazonaws.com/doc/2013-04-01/");    
                var publicRequestResourceIds = publicRequest.ResourceIds;
                if (publicRequestResourceIds != null && publicRequestResourceIds.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("ResourceIds", "https://route53.amazonaws.com/doc/2013-04-01/");
                    foreach (var publicRequestResourceIdsValue in publicRequestResourceIds) 
                    {
                        xmlWriter.WriteStartElement("ResourceId", "https://route53.amazonaws.com/doc/2013-04-01/");
                        xmlWriter.WriteValue(publicRequestResourceIdsValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        
    }    
}