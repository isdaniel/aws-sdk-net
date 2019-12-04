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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EBS
{

    /// <summary>
    /// Constants used for properties of type ChecksumAlgorithm.
    /// </summary>
    public class ChecksumAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant SHA256 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA256 = new ChecksumAlgorithm("SHA256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumAlgorithm FindValue(string value)
        {
            return FindValue<ChecksumAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_BLOCK_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BLOCK_TOKEN = new ValidationExceptionReason("INVALID_BLOCK_TOKEN");
        /// <summary>
        /// Constant INVALID_CUSTOMER_KEY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CUSTOMER_KEY = new ValidationExceptionReason("INVALID_CUSTOMER_KEY");
        /// <summary>
        /// Constant INVALID_PAGE_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAGE_TOKEN = new ValidationExceptionReason("INVALID_PAGE_TOKEN");
        /// <summary>
        /// Constant INVALID_SNAPSHOT_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SNAPSHOT_ID = new ValidationExceptionReason("INVALID_SNAPSHOT_ID");
        /// <summary>
        /// Constant UNRELATED_SNAPSHOTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNRELATED_SNAPSHOTS = new ValidationExceptionReason("UNRELATED_SNAPSHOTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}