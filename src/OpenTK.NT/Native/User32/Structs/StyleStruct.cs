﻿using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains the styles for a window.<para/>
    /// Both members can be <see cref="WindowStyles"/> or <see cref="ExtendedWindowStyles"/>.
    /// </summary>
    public struct StyleStruct
    {
        /// <summary>
        /// The previous styles for a window.
        /// </summary>
        public DWORD StyleOld;

        /// <summary>
        /// The new styles for a window.
        /// </summary>
        public DWORD StyleNew;
    }
}
