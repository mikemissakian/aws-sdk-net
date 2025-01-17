/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// configures the CloudWatch Logs to publish for the Elasticsearch domain.
    /// </summary>
    public partial class AwsElasticsearchDomainLogPublishingOptions
    {
        private AwsElasticsearchDomainLogPublishingOptionsLogConfig _auditLogs;
        private AwsElasticsearchDomainLogPublishingOptionsLogConfig _indexSlowLogs;
        private AwsElasticsearchDomainLogPublishingOptionsLogConfig _searchSlowLogs;

        /// <summary>
        /// Gets and sets the property AuditLogs.
        /// </summary>
        public AwsElasticsearchDomainLogPublishingOptionsLogConfig AuditLogs
        {
            get { return this._auditLogs; }
            set { this._auditLogs = value; }
        }

        // Check to see if AuditLogs property is set
        internal bool IsSetAuditLogs()
        {
            return this._auditLogs != null;
        }

        /// <summary>
        /// Gets and sets the property IndexSlowLogs. 
        /// <para>
        /// Configures the Elasticsearch index logs publishing.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainLogPublishingOptionsLogConfig IndexSlowLogs
        {
            get { return this._indexSlowLogs; }
            set { this._indexSlowLogs = value; }
        }

        // Check to see if IndexSlowLogs property is set
        internal bool IsSetIndexSlowLogs()
        {
            return this._indexSlowLogs != null;
        }

        /// <summary>
        /// Gets and sets the property SearchSlowLogs. 
        /// <para>
        /// Configures the Elasticsearch search slow log publishing.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainLogPublishingOptionsLogConfig SearchSlowLogs
        {
            get { return this._searchSlowLogs; }
            set { this._searchSlowLogs = value; }
        }

        // Check to see if SearchSlowLogs property is set
        internal bool IsSetSearchSlowLogs()
        {
            return this._searchSlowLogs != null;
        }

    }
}