﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using System;

namespace Microsoft.CodeAnalysis.PublicApiAnalyzers
{
    internal partial class PublicApiAnalyzerResources
    {
        private static readonly Type s_resourcesType = typeof(PublicApiAnalyzerResources);

        public static LocalizableResourceString CreateLocalizableResourceString(string nameOfLocalizableResource)
            => new(nameOfLocalizableResource, ResourceManager, s_resourcesType);

        public static LocalizableResourceString CreateLocalizableResourceString(string nameOfLocalizableResource, params string[] formatArguments)
            => new(nameOfLocalizableResource, ResourceManager, s_resourcesType, formatArguments);
    }
}
