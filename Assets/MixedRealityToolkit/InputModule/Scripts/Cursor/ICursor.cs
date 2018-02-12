﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MixedRealityToolkit.InputModule.InputHandlers;
using MixedRealityToolkit.InputModule.Pointers;
using UnityEngine;

namespace MixedRealityToolkit.InputModule.Cursors
{
    /// <summary>
    /// Cursor Interface for handling input events and setting visibility.
    /// </summary>
    public interface ICursor : IFocusChangedHandler, ISourceStateHandler, IPointerHandler
    {
        /// <summary>
        /// The pointer this cursor is associated with.
        /// </summary>
        IPointer Pointer { get; }

        /// <summary>
        /// Position of the cursor.
        /// </summary>
        Vector3 Position { get; }

        /// <summary>
        /// Rotation of the cursor.
        /// </summary>
        Quaternion Rotation { get; }

        /// <summary>
        /// Local scale of the cursor.
        /// </summary>
        Vector3 LocalScale { get; }

        /// <summary>
        /// Sets the visibility of the cursor.
        /// </summary>
        /// <param name="visible">True if cursor should be visible, false if not.</param>
        void SetVisibility(bool visible);
    }
}