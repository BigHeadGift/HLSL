﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using ShaderTools.CodeAnalysis;
using VsTextSpan = Microsoft.VisualStudio.TextManager.Interop.TextSpan;

namespace ShaderTools.VisualStudio.LanguageServices.Implementation.Extensions
{
    internal static class VsTextSpanExtensions
    {
        public static bool TryMapSpanFromSecondaryBufferToPrimaryBuffer(this VsTextSpan spanInSecondaryBuffer, Workspace workspace, DocumentId documentId, out VsTextSpan spanInPrimaryBuffer)
        {
            spanInPrimaryBuffer = default(VsTextSpan);
            return false;

            // TODO

            //var visualStudioWorkspace = workspace as VisualStudioWorkspaceImpl;
            //if (visualStudioWorkspace == null)
            //{
            //    return false;
            //}

            //var containedDocument = visualStudioWorkspace.GetHostDocument(documentId) as ContainedDocument;
            //if (containedDocument == null)
            //{
            //    return false;
            //}

            //var bufferCoordinator = containedDocument.ContainedLanguage.BufferCoordinator;

            //var primary = new VsTextSpan[1];
            //var hresult = bufferCoordinator.MapSecondaryToPrimarySpan(spanInSecondaryBuffer, primary);

            //spanInPrimaryBuffer = primary[0];

            //return ErrorHandler.Succeeded(hresult);
        }
    }
}
