﻿/*
 * This file is part of the Bucket package.
 *
 * (c) Yu Meng Han <menghanyu1994@gmail.com>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://github.com/getbucket/bucket/wiki
 */

using System;

namespace Bucket.Configuration
{
    /// <summary>
    /// Indicates configuration options.
    /// </summary>
    [Flags]
    public enum ConfigOptions
    {
        /// <summary>
        /// Not options.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that the relative path is obtained.
        /// </summary>
        RelativePath = 1,
    }
}
