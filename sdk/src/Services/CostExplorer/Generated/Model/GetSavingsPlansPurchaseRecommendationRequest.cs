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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetSavingsPlansPurchaseRecommendation operation.
    /// Retrieves your request parameters, Savings Plan Recommendations Summary and Details.
    /// </summary>
    public partial class GetSavingsPlansPurchaseRecommendationRequest : AmazonCostExplorerRequest
    {
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private string _nextPageToken;
        private int? _pageSize;
        private PaymentOption _paymentOption;
        private SupportedSavingsPlansType _savingsPlansType;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The lookback period used to generate the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LookbackPeriodInDays LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option used to generate these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The Savings Plans recommendation type requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportedSavingsPlansType SavingsPlansType
        {
            get { return this._savingsPlansType; }
            set { this._savingsPlansType = value; }
        }

        // Check to see if SavingsPlansType property is set
        internal bool IsSetSavingsPlansType()
        {
            return this._savingsPlansType != null;
        }

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The savings plan recommendation term used to generated these recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TermInYears TermInYears
        {
            get { return this._termInYears; }
            set { this._termInYears = value; }
        }

        // Check to see if TermInYears property is set
        internal bool IsSetTermInYears()
        {
            return this._termInYears != null;
        }

    }
}