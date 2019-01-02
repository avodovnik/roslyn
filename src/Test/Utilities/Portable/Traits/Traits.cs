﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class Traits
    {
        public const string Editor = nameof(Editor);
        public static class Editors
        {
            public const string KeyProcessors = nameof(KeyProcessors);
            public const string KeyProcessorProviders = nameof(KeyProcessorProviders);
            public const string Preview = nameof(Preview);
        }

        public const string Feature = nameof(Feature);
        public static class Features
        {
            public const string AddMissingTokens = nameof(AddMissingTokens);
            public const string AddMissingReference = nameof(AddMissingReference);
            public const string Adornments = nameof(Adornments);
            public const string AsyncLazy = nameof(AsyncLazy);
            public const string AutomaticEndConstructCorrection = nameof(AutomaticEndConstructCorrection);
            public const string AutomaticCompletion = nameof(AutomaticCompletion);
            public const string BlockCommentEditing = nameof(BlockCommentEditing);
            public const string BraceHighlighting = nameof(BraceHighlighting);
            public const string BraceMatching = nameof(BraceMatching);
            public const string Build = nameof(Build);
            public const string CallHierarchy = nameof(CallHierarchy);
            public const string CaseCorrection = nameof(CaseCorrection);
            public const string ChangeSignature = nameof(ChangeSignature);
            public const string Classification = nameof(Classification);
            public const string ClassView = nameof(ClassView);
            public const string CodeActionsAddConstructorParametersFromMembers = "CodeActions.AddConstructorParametersFromMembers";
            public const string CodeActionsAddDocCommentNodes = "CodeActions.AddDocCommentParamNodes";
            public const string CodeActionsAddAwait = "CodeActions.AddAwait";
            public const string CodeActionsAddRequiredParentheses = "CodeActions.AddRequiredParentheses";
            public const string CodeActionsUpgradeProject = "CodeActions.UpgradeProject";
            public const string CodeActionsAddAccessibilityModifiers = "CodeActions.AddAccessibilityModifiers";
            public const string CodeActionsAddAnonymousTypeMemberName = "CodeActions.AddAnonymousTypeMemberName";
            public const string CodeActionsAddBraces = "CodeActions.AddBraces";
            public const string CodeActionsAddFileBanner = "CodeActions.AddFileBanner";
            public const string CodeActionsAddImport = "CodeActions.AddImport";
            public const string CodeActionsAddMissingReference = "CodeActions.AddMissingReference";
            public const string CodeActionsAddNew = "CodeActions.AddNew";
            public const string CodeActionsAddObsoleteAttribute = "CodeActions.AddObsoleteAttribute";
            public const string CodeActionsAddOverload = "CodeActions.AddOverloads";
            public const string CodeActionsAddParameter = "CodeActions.AddParameter";
            public const string CodeActionsAddParenthesesAroundConditionalExpressionInInterpolatedString = "CodeActions.AddParenthesesAroundConditionalExpressionInInterpolatedString";
            public const string CodeActionsAddShadows = "CodeActions.AddShadows";
            public const string CodeActionsAliasAmbiguousType = "CodeActions.AliasAmbiguousType";
            public const string CodeActionsChangeToAsync = "CodeActions.ChangeToAsync";
            public const string CodeActionsChangeToIEnumerable = "CodeActions.ChangeToIEnumerable";
            public const string CodeActionsChangeToYield = "CodeActions.ChangeToYield";
            public const string CodeActionsConvertAnonymousTypeToClass = "CodeActions.ConvertAnonymousTypeToClass";
            public const string CodeActionsConvertAnonymousTypeToTuple = "CodeActions.ConvertAnonymousTypeToTuple";
            public const string CodeActionsConvertNumericLiteral = "CodeActions.ConvertNumericLiteral";
            public const string CodeActionsConvertLocalFunctionToMethod = "CodeActions.ConvertLocalFunctionToMethod";
            public const string CodeActionsConvertToInterpolatedString = "CodeActions.ConvertToInterpolatedString";
            public const string CodeActionsConvertToIterator = "CodeActions.ConvertToIterator";
            public const string CodeActionsConvertForToForEach = "CodeActions.ConvertForToForEach";
            public const string CodeActionsConvertForEachToFor = "CodeActions.ConvertForEachToFor";
            public const string CodeActionsConvertIfToSwitch = "CodeActions.ConvertIfToSwitch";
            public const string CodeActionsConvertTupleToStruct = "CodeActions.ConvertTupleToStruct";
            public const string CodeActionsConvertQueryToForEach = "CodeActions.ConvertQueryToForEach";
            public const string CodeActionsConvertForEachToQuery = "CodeActions.ConvertForEachToQuery";
            public const string CodeActionsCorrectExitContinue = "CodeActions.CorrectExitContinue";
            public const string CodeActionsCorrectFunctionReturnType = "CodeActions.CorrectFunctionReturnType";
            public const string CodeActionsCorrectNextControlVariable = "CodeActions.CorrectNextControlVariable";
            public const string CodeActionsDeclareAsNullable = "CodeActions.DeclareAsNullable";
            public const string CodeActionsGenerateConstructor = "CodeActions.GenerateConstructor";
            public const string CodeActionsGenerateConstructorFromMembers = "CodeActions.GenerateConstructorFromMembers";
            public const string CodeActionsGenerateDefaultConstructors = "CodeActions.GenerateDefaultConstructors";
            public const string CodeActionsGenerateEndConstruct = "CodeActions.GenerateEndConstruct";
            public const string CodeActionsGenerateEnumMember = "CodeActions.GenerateEnumMember";
            public const string CodeActionsGenerateEvent = "CodeActions.GenerateEvent";
            public const string CodeActionsGenerateEqualsAndGetHashCode = "CodeActions.GenerateEqualsAndGetHashCodeFromMembers";
            public const string CodeActionsGenerateLocal = "CodeActions.GenerateLocal";
            public const string CodeActionsGenerateVariable = "CodeActions.GenerateVariable";
            public const string CodeActionsGenerateMethod = "CodeActions.GenerateMethod";
            public const string CodeActionsGenerateOverrides = "CodeActions.GenerateOverrides";
            public const string CodeActionsGenerateType = "CodeActions.GenerateType";
            public const string CodeActionsExtractInterface = "CodeActions.ExtractInterface";
            public const string CodeActionsExtractMethod = "CodeActions.ExtractMethod";
            public const string CodeActionsFixAllOccurrences = "CodeActions.FixAllOccurrences";
            public const string CodeActionsFullyQualify = "CodeActions.FullyQualify";
            public const string CodeActionsImplementAbstractClass = "CodeActions.ImplementAbstractClass";
            public const string CodeActionsImplementInterface = "CodeActions.ImplementInterface";
            public const string CodeActionsInitializeParameter = "CodeActions.InitializeParameter";
            public const string CodeActionsInlineDeclaration = "CodeActions.InlineDeclaration";
            public const string CodeActionsInlineTemporary = "CodeActions.InlineTemporary";
            public const string CodeActionsInlineTypeCheck = "CodeActions.InlineTypeCheck";
            public const string CodeActionsInsertBraces = "CodeActions.InsertBraces";
            public const string CodeActionsInsertMissingCast = "CodeActions.InsertMissingCast";
            public const string CodeActionsInsertMissingTokens = "CodeActions.InsertMissingTokens";
            public const string CodeActionsIntroduceUsingStatement = "CodeActions.IntroduceUsingStatement";
            public const string CodeActionsIntroduceVariable = "CodeActions.IntroduceVariable";
            public const string CodeActionsInvertConditional = "CodeActions.InvertConditional";
            public const string CodeActionsInvertIf = "CodeActions.InvertIf";
            public const string CodeActionsInvertLogical = "CodeActions.InvertLogical";
            public const string CodeActionsInvokeDelegateWithConditionalAccess = "CodeActions.InvokeDelegateWithConditionalAccess";
            public const string CodeActionsLambdaSimplifier = "CodeActions.LambdaSimplifier";
            public const string CodeActionsMakeFieldReadonly = "CodeActions.MakeFieldReadonly";
            public const string CodeActionsMakeMethodAsynchronous = "CodeActions.MakeMethodAsynchronous";
            public const string CodeActionsMakeMethodSynchronous = "CodeActions.MakeMethodSynchronous";
            public const string CodeActionsMoveDeclarationNearReference = "CodeActions.MoveDeclarationNearReference";
            public const string CodeActionsMoveToTopOfFile = "CodeActions.MoveToTopOfFile";
            public const string CodeActionsMoveType = "CodeActions.MoveType";
            public const string CodeActionsOrderModifiers = "CodeActions.OrderModifiers";
            public const string CodeActionsPopulateSwitch = "CodeActions.PopulateSwitch";
            public const string CodeActionsPullMemberUp = "CodeActions.PullMemberUp";
            public const string CodeActionsQualifyMemberAccess = "CodeActions.QualifyMemberAccess";
            public const string CodeActionsReplaceDefaultLiteral = "CodeActions.ReplaceDefaultLiteral";
            public const string CodeActionsReplaceDocCommentTextWithTag = "CodeActions.ReplaceDocCommentTextWithTag";
            public const string CodeActionsReplaceMethodWithProperty = "CodeActions.ReplaceMethodWithProperty";
            public const string CodeActionsReplacePropertyWithMethods = "CodeActions.ReplacePropertyWithMethods";
            public const string CodeActionsRemoveByVal = "CodeActions.RemoveByVal";
            public const string CodeActionsRemoveDocCommentNode = "CodeActions.RemoveDocCommentNode";
            public const string CodeActionsRemoveUnnecessaryCast = "CodeActions.RemoveUnnecessaryCast";
            public const string CodeActionsRemoveUnnecessaryParentheses = "CodeActions.RemoveUnnecessaryParentheses";
            public const string CodeActionsRemoveUnusedValues = "CodeActions.RemoveUnusedValues";
            public const string CodeActionsRemoveUnusedLocalFunction = "CodeActions.RemoveUnusedLocalFunction";
            public const string CodeActionsRemoveUnusedMembers = "CodeActions.RemoveUnusedMembers";
            public const string CodeActionsRemoveUnusedParameters = "CodeActions.RemoveUnusedParameters";
            public const string CodeActionsRemoveUnusedVariable = "CodeActions.RemoveUnusedVariable";
            public const string CodeActionsRemoveUnnecessaryImports = "CodeActions.RemoveUnnecessaryImports";
            public const string CodeActionsRemoveUnreachableCode = "CodeActions.RemoveUnreachableCode";
            public const string CodeActionsResolveConflictMarker = "CodeActions.ResolveConflictMarker";
            public const string CodeActionsSimplifyThisOrMe = "CodeActions.SimplifyThisOrMe";
            public const string CodeActionsSimplifyTypeNames = "CodeActions.SimplifyTypeNames";
            public const string CodeActionsSpellcheck = "CodeActions.Spellcheck";
            public const string CodeActionsSuppression = "CodeActions.Suppression";
            public const string CodeActionsSyncNamespace = "CodeActions.SyncNamespace";
            public const string CodeActionsUseInterpolatedVerbatimString = "CodeActions.UseInterpolatedVerbatimString";
            public const string CodeActionsUseAutoProperty = "CodeActions.UseAutoProperty";
            public const string CodeActionsUseCoalesceExpression = "CodeActions.UseCoalesceExpression";
            public const string CodeActionsUseCollectionInitializer = "CodeActions.UseCollectionInitializer";
            public const string CodeActionsUseCompoundAssignment = "CodeActions.UseCompoundAssignment";
            public const string CodeActionsUseConditionalExpression = "CodeActions.UseConditionalExpression";
            public const string CodeActionsUseDeconstruction = "CodeActions.UseDeconstruction";
            public const string CodeActionsUseDefaultLiteral = "CodeActions.UseDefaultLiteral";
            public const string CodeActionsUseIndexOperator = "CodeActions.UseIndexOperator";
            public const string CodeActionsUseInferredMemberName = "CodeActions.UseInferredMemberName";
            public const string CodeActionsUseExpressionBody = "CodeActions.UseExpressionBody";
            public const string CodeActionsUseImplicitType = "CodeActions.UseImplicitType";
            public const string CodeActionsUseExplicitType = "CodeActions.UseExplicitType";
            public const string CodeActionsUseExplicitTypeForConst = "CodeActions.UseExplicitTypeForConst";
            public const string CodeActionsUseExplicitTupleName = "CodeActions.UseExplicitTupleName";
            public const string CodeActionsUseFrameworkType = "CodeActions.UseFrameworkType";
            public const string CodeActionsUseIsNullCheck = "CodeActions.UseIsNullCheck";
            public const string CodeActionsUseLocalFunction = "CodeActions.UseLocalFunction";
            public const string CodeActionsUseNullPropagation = "CodeActions.UseNullPropagation";
            public const string CodeActionsUseNamedArguments = "CodeActions.UseNamedArguments";
            public const string CodeActionsNameTupleElement = "CodeActions.NameTupleElement";
            public const string CodeActionsUseObjectInitializer = "CodeActions.UseObjectInitializer";
            public const string CodeActionsUseRangeOperator = "CodeActions.UseRangeOperator";
            public const string CodeActionsUseThrowExpression = "CodeActions.UseThrowExpression";
            public const string CodeActionsWrapping = "CodeActions.Wrapping";
            public const string CodeCleanup = nameof(CodeCleanup);
            public const string CodeGeneration = nameof(CodeGeneration);
            public const string CodeGenerationSortDeclarations = "CodeGeneration.SortDeclarations";
            public const string CodeLens = nameof(CodeLens);
            public const string CodeModel = nameof(CodeModel);
            public const string CodeModelEvents = "CodeModel.Events";
            public const string CodeModelMethodXml = "CodeModel.MethodXml";
            public const string CommentSelection = nameof(CommentSelection);
            public const string Completion = nameof(Completion);
            public const string ConvertAutoPropertyToFullProperty = nameof(ConvertAutoPropertyToFullProperty);
            public const string DebuggingBreakpoints = "Debugging.Breakpoints";
            public const string DebuggingDataTips = "Debugging.DataTips";
            public const string DebuggingIntelliSense = "Debugging.IntelliSense";
            public const string DebuggingLocationName = "Debugging.LocationName";
            public const string DebuggingNameResolver = "Debugging.NameResolver";
            public const string DebuggingProximityExpressions = "Debugging.ProximityExpressions";
            public const string Diagnostics = nameof(Diagnostics);
            public const string DocCommentFormatting = nameof(DocCommentFormatting);
            public const string DocumentationComments = nameof(DocumentationComments);
            public const string EditorConfig = nameof(EditorConfig);
            public const string EncapsulateField = nameof(EncapsulateField);
            public const string EndConstructGeneration = nameof(EndConstructGeneration);
            public const string ErrorList = nameof(ErrorList);
            public const string ErrorSquiggles = nameof(ErrorSquiggles);
            public const string EventHookup = nameof(EventHookup);
            public const string Expansion = nameof(Expansion);
            public const string AddAwait = "Refactoring.AddAwait";
            public const string AddMissingImports = "Refactoring.AddMissingImports";
            public const string ExtractInterface = "Refactoring.ExtractInterface";
            public const string ExtractMethod = "Refactoring.ExtractMethod";
            public const string F1Help = nameof(F1Help);
            public const string FindReferences = nameof(FindReferences);
            public const string FixIncorrectTokens = nameof(FixIncorrectTokens);
            public const string FixInterpolatedVerbatimString = nameof(FixInterpolatedVerbatimString);
            public const string Formatting = nameof(Formatting);
            public const string GoToDefinition = nameof(GoToDefinition);
            public const string GoToImplementation = nameof(GoToImplementation);
            public const string GoToAdjacentMember = nameof(GoToAdjacentMember);
            public const string Interactive = nameof(Interactive);
            public const string InteractiveHost = nameof(InteractiveHost);
            public const string KeywordHighlighting = nameof(KeywordHighlighting);
            public const string KeywordRecommending = nameof(KeywordRecommending);
            public const string LineCommit = nameof(LineCommit);
            public const string LineSeparators = nameof(LineSeparators);
            public const string LinkedFileDiffMerging = nameof(LinkedFileDiffMerging);
            public const string MetadataAsSource = nameof(MetadataAsSource);
            public const string MSBuildWorkspace = nameof(MSBuildWorkspace);
            public const string NamingStyle = nameof(NamingStyle);
            public const string NavigableSymbols = nameof(NavigableSymbols);
            public const string NavigateTo = nameof(NavigateTo);
            public const string NavigationBar = nameof(NavigationBar);
            public const string NetCore = nameof(NetCore);
            public const string NormalizeModifiersOrOperators = nameof(NormalizeModifiersOrOperators);
            public const string ObjectBrowser = nameof(ObjectBrowser);
            public const string Options = nameof(Options);
            public const string Organizing = nameof(Organizing);
            public const string Outlining = nameof(Outlining);
            public const string Packaging = nameof(Packaging);
            public const string PasteTracking = nameof(PasteTracking);
            public const string Peek = nameof(Peek);
            public const string Progression = nameof(Progression);
            public const string ProjectSystemShims = nameof(ProjectSystemShims);
            public const string QuickInfo = nameof(QuickInfo);
            public const string ReduceTokens = nameof(ReduceTokens);
            public const string ReferenceHighlighting = nameof(ReferenceHighlighting);
            public const string RemoteHost = nameof(RemoteHost);
            public const string RemoveUnnecessaryLineContinuation = nameof(RemoveUnnecessaryLineContinuation);
            public const string Rename = nameof(Rename);
            public const string RenameTracking = nameof(RenameTracking);
            public const string RQName = nameof(RQName);
            public const string SignatureHelp = nameof(SignatureHelp);
            public const string Simplification = nameof(Simplification);
            public const string SmartIndent = nameof(SmartIndent);
            public const string SmartTokenFormatting = nameof(SmartTokenFormatting);
            public const string Snippets = nameof(Snippets);
            public const string SplitStringLiteral = nameof(SplitStringLiteral);
            public const string SuggestionTags = nameof(SuggestionTags);
            public const string TextStructureNavigator = nameof(TextStructureNavigator);
            public const string TodoComments = nameof(TodoComments);
            public const string TypeInferenceService = nameof(TypeInferenceService);
            public const string Venus = nameof(Venus);
            public const string ValidateFormatString = nameof(ValidateFormatString);
            public const string ValidateRegexString = nameof(ValidateRegexString);
            public const string VsLanguageBlock = nameof(VsLanguageBlock);
            public const string VsNavInfo = nameof(VsNavInfo);
            public const string WinForms = nameof(WinForms);
            public const string Workspace = nameof(Workspace);
            public const string XmlTagCompletion = nameof(XmlTagCompletion);
        }

        public const string Environment = nameof(Environment);
        public static class Environments
        {
            public const string VSProductInstall = nameof(VSProductInstall);
        }
    }
}
