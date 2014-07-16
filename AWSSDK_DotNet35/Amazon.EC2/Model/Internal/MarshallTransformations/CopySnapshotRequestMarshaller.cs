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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Copy Snapshot Request Marshaller
    /// </summary>       
    public class CopySnapshotRequestMarshaller : IMarshaller<IRequest, CopySnapshotRequest>
    {
        public IRequest Marshall(CopySnapshotRequest copySnapshotRequest)
        {
            IRequest request = new DefaultRequest(copySnapshotRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CopySnapshot");
            request.Parameters.Add("Version", "2014-06-15");
            if (copySnapshotRequest != null && copySnapshotRequest.IsSetSourceRegion())
            {
                request.Parameters.Add("SourceRegion", StringUtils.FromString(copySnapshotRequest.SourceRegion));
            }
            if (copySnapshotRequest != null && copySnapshotRequest.IsSetSourceSnapshotId())
            {
                request.Parameters.Add("SourceSnapshotId", StringUtils.FromString(copySnapshotRequest.SourceSnapshotId));
            }
            if (copySnapshotRequest != null && copySnapshotRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(copySnapshotRequest.Description));
            }
            if (copySnapshotRequest != null && copySnapshotRequest.IsSetDestinationRegion())
            {
                request.Parameters.Add("DestinationRegion", StringUtils.FromString(copySnapshotRequest.DestinationRegion));
            }
            if (copySnapshotRequest != null && copySnapshotRequest.IsSetPresignedUrl())
            {
                request.Parameters.Add("PresignedUrl", StringUtils.FromString(copySnapshotRequest.PresignedUrl));
            }

            return request;
        }
    }
}
