﻿// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.VisualStudio.Threading.Analyzers
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.Diagnostics;

    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class CSharpVSTHRD108AssertThreadRequirementUnconditionally : AbstractVSTHRD108AssertThreadRequirementUnconditionally
    {
        private protected override LanguageUtils LanguageUtils => CSharpUtils.Instance;
    }
}
