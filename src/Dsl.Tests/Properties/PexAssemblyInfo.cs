using Sawczyn.EFDesigner.EFModel;
using System.Text;
using System.IO;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs" company="Michael Sawczyn">Copyright © Michael Sawczyn 2018</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Sawczyn.EFDesigner.EFModel.Dsl")]
[assembly: PexInstrumentAssembly("System.Drawing.Design")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.TextTemplating.15.0")]
[assembly: PexInstrumentAssembly("EnvDTE")]
[assembly: PexInstrumentAssembly("System.ComponentModel.Composition")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.TextTemplating.Modeling.15.0")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.TextTemplating.Interfaces.10.0")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.Modeling.Sdk.15.0")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.Modeling.Sdk.Diagrams.15.0")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("Microsoft.Data.ConnectionUI.Dialog")]
[assembly: PexInstrumentAssembly("GOLD Engine")]
[assembly: PexInstrumentAssembly("System.Data.Entity.Design")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing.Design")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.TextTemplating.15.0")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "EnvDTE")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.ComponentModel.Composition")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.TextTemplating.Modeling.15.0")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.TextTemplating.Interfaces.10.0")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.Modeling.Sdk.15.0")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.Modeling.Sdk.Diagrams.15.0")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Data.ConnectionUI.Dialog")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "GOLD Engine")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data.Entity.Design")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(BinaryReader))]
[assembly: PexInstrumentType(typeof(BinaryReader))]
[assembly: PexInstrumentType(typeof(EncoderReplacementFallback))]
[assembly: PexInstrumentType(typeof(DecoderReplacementFallback))]
[assembly: PexInstrumentType(typeof(Decoder))]
[assembly: PexInstrumentType(typeof(TextReader))]
[assembly: PexInstrumentType("mscorlib", "System.Text.UTF8Encoding+UTF8Decoder")]
[assembly: PexInstrumentType(typeof(DecoderFallback))]
[assembly: PexInstrumentType(typeof(EncoderFallback))]
[assembly: PexInstrumentType(typeof(BinaryReader))]
[assembly: PexInstrumentType(typeof(EncoderReplacementFallback))]
[assembly: PexInstrumentType(typeof(DecoderReplacementFallback))]
[assembly: PexInstrumentType(typeof(Decoder))]
[assembly: PexSuppressStaticFieldStore(typeof(AttributeParser), "<FailMessage>k__BackingField")]
[assembly: PexSuppressStaticFieldStore(typeof(AttributeParser), "_parser")]
[assembly: PexSuppressStaticFieldStore("Sawczyn.EFDesigner.EFModel.Resources", "resourceMan")]

